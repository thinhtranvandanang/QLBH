using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace Super_Market
{
    public partial class frmLapHoaDonNhapHang : Form
    {
        private bool controlKey=false;
        HoaDon hd = new HoaDon();
      
        public frmLapHoaDonNhapHang()
        {
            InitializeComponent();
        }

        private void BtnThemMatHang_Click(object sender, EventArgs e)
        {
            themSPvaoHoadon();
            dgChiTietMH.DataSource = null; // xóa dữ liệu cũ
            dgChiTietMH.DataSource = hd._Cart; // nạp nguồn dữ liệu mới
            dgChiTietMH.Refresh();
            txtTongTien.Text = hd.tong_HoaDon.ToString("N2");
        }
        public void themSPvaoHoadon()
        { // khi thêm 1 sản phẩm, ta thêm vào danh sách, chứ không thêm vào csdl
          //*** chưa kiểm tra dữ liệu vào
            string maSpThem = cBMaMatHang.SelectedValue.ToString(); // lấy mã sản phẩm sẽ thêm vào chi tiết hóa đơn
            int SoLuongThem = int.Parse(txtSoluong.Text); // số lượng sẽ thêm
            if (SoLuongThem <= 0) { MessageBox.Show("Số lượng phải lớn hơn 0"); return; }
            float giaNhap = float.Parse(txtGiaNhap.Text);
            if (giaNhap <= 0) { MessageBox.Show("Giá nhập phải lớn hơn 0"); return; }

            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = "Select ProductID,Name,UnitCalc,sellPrice,totalImport,totalSell From Products WHERE(ProductID = @masp)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@masp", maSpThem);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string maSp = rd["ProductID"].ToString();
                            string tenSp = rd["Name"].ToString();
                            hd.insert_item_toCart(maSpThem, tenSp,  SoLuongThem, giaNhap);
                        }
                    }
                    else
                        MessageBox.Show("Sản phẩm có mã này không tồn tại");
                    cmd.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void insert_Hoadon(DateTime ngayhd,int maNCC,string notes, int employeeId, float total)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = "INSERT INTO InOrders (InDate, ProviderID, Notes, EmployeeID, Total) VALUES(@InDate, @ProviderID, @Notes, @EmployeeID, @Total) ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@InDate", ngayhd);
                    cmd.Parameters.AddWithValue("@ProviderID", maNCC);
                    cmd.Parameters.AddWithValue("@Notes", notes);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    cmd.Parameters.AddWithValue("@Total", total);
                    SqlParameter param3 = new SqlParameter();
                    param3.ParameterName = "@NgaySinh";
                    param3.SqlDbType = SqlDbType.DateTime;
                    param3.Value = ngayhd;
                    cmd.Parameters.Add(param3);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Đã lưu thông tin vào CSDL");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void insert_HoadonChitiet(int sellOrderId, String ProductId, int quantity,float ProductPrice)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = "INSERT INTO InOrderDetail(InOrderID, ProductID, Quantity, ProductInPrice) VALUES(@InOrderID, @ProductID, @Quantity, @ProductInPrice)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@InOrderID", sellOrderId);
                    cmd.Parameters.AddWithValue("@ProductID", ProductId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@ProductInPrice", ProductPrice); // đơn giá nhập
                    cmd.ExecuteNonQuery(); // thực hiện lệnh SQL
                    cmd.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

  

        private void BtnHoaDonMoi_Click(object sender, EventArgs e)
        {
            if (hd._Cart.Count > 0) hd._Cart.Clear();  // làm rỗng danh sách
            txtTongTien.Text = hd.tong_HoaDon.ToString();

            txtNote.Clear();
            txtSoluong.Clear();
            txtGiaNhap.Clear();

            dgChiTietMH.DataSource = hd._Cart;
            dgChiTietMH.Refresh();
        }

        private void BtnInHoaDon_Click(object sender, EventArgs e)
        {
            int employeeid = Session._EmployeeId;
            float total = hd.tong_HoaDon;
            insert_Hoadon(dtpInDate.Value, Int32.Parse(CbNCC.SelectedValue.ToString()),txtNote.Text, employeeid, total);

            foreach(Cart cart in hd._Cart)
            {
                insert_HoadonChitiet(select_orderid(), cart._ProductId, cart._Quantity, cart._ProductPrice);
                tangSLsanPhamDaNhap(cart._ProductId, cart._Quantity);// tăng số lượng sản phẩm đã nhập trong tbl sản phẩm
            }
            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
            }
            txtTongTien.Text = hd.tong_HoaDon.ToString();
            dgChiTietMH.DataSource = null;
            dgChiTietMH.Refresh();
            dgChiTietMH.DataSource = hd._Cart;
            dgChiTietMH.Refresh();
        }

        private void tangSLsanPhamDaNhap(string _ProductId,int _Quantity)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = " update Products " +
                                   " set   totalImport = totalImport + @slNhap" +
                                   " where ProductID=@ProductID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ProductID", _ProductId);
                    cmd.Parameters.AddWithValue("@slNhap", _Quantity);
                    cmd.ExecuteNonQuery();  // thực hiện lệnh SQL
                    cmd.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public int select_orderid()
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = "Select max([InOrderID]) id from [InOrders]";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            result = int.Parse(rd[0].ToString());
                        }
                    }
                    cmd.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return result;
        }


        private void cBMaMatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (int)Keys.Escape)
            {
                cBMaMatHang.SelectedIndex = -1;
                cBMaMatHang.Text = "";
                controlKey = true;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                    controlKey = true;
                else
                    controlKey = false;
            }
        }

        private void cBMaMatHang_TextChanged(object sender, EventArgs e)
        {
            if (cBMaMatHang.Text != "" && !controlKey)
            {
                String matchText = cBMaMatHang.Text;
                int result = cBMaMatHang.FindString(matchText);
                if (result != -1)
                {
                    cBMaMatHang.SelectedIndex = result;
                    cBMaMatHang.SelectionStart = matchText.Length;
                    cBMaMatHang.SelectionLength = cBMaMatHang.Text.Length - cBMaMatHang.SelectionStart;
                }
            }
        }

        private void dgChiTietMH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
        private void ctMenuXoa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("ctMenudelete"))
            {
                try
                {
                    hd.remove_item(dgChiTietMH.CurrentCell.FormattedValue.ToString());
                    dgChiTietMH.DataSource = hd._Cart;
                    txtTongTien.Text = hd.tong_HoaDon.ToString();
                    dgChiTietMH.Refresh();

                }catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void frmLapHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            dtpInDate.Value = DateTime.Today;
            dtpInDate.CustomFormat = "dd/MM/yyyy";
            dtpInDate.Format = DateTimePickerFormat.Custom;

            CbNCCBidinding();
            CbSanPhamBinding();
        }

        private void CbSanPhamBinding()
        {
            string strSQL = "SELECT ProductID, Name  FROM Products";
            using (SqlConnection conn = new SqlConnection(ConnectionString.chuoiKetNoi()))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cBMaMatHang.DataSource = dt;
                    cBMaMatHang.DisplayMember = "Name";
                    cBMaMatHang.ValueMember = "ProductID";
                }
            }
        }


        private void CbNCCBidinding()
        {
            string strSQL = "SELECT ProviderID,Name FROM Providers";
            using (SqlConnection conn = new SqlConnection(ConnectionString.chuoiKetNoi()))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    CbNCC.DataSource= dt;
                    CbNCC.DisplayMember = "Name";
                    CbNCC.ValueMember = "ProviderID";

                }
            }

        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            int result;
            try
            {
                if (txtSoluong.Text != "")
                {
                    if (!(int.TryParse(txtSoluong.Text, out result)))
                        txtSoluong.BackColor = Color.Red;
                    else
                        txtSoluong.BackColor = Color.WhiteSmoke;
                }
            }
            catch (Exception ex) { }
        }

        private void ctMenudelete_Click(object sender, EventArgs e)
        {
        }

      
    }
}