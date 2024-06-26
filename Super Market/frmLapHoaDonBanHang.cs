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
    public partial class frmLapHoaDonBanHang : Form
    {
       // private static SqlConnection conn;
        private bool controlKey=false;
        HoaDon hd = new HoaDon();
        int idNhanVien = Session._EmployeeId  ; // nhân viên thực hiện bán hàng
        DateTime ngayban = DateTime.Now; // ngày hiện tại bán hàng

        public frmLapHoaDonBanHang()
        {
            InitializeComponent();
           
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

        private void BtnThemMatHang_Click(object sender, EventArgs e)
        {
            themSPvaoHoadon();
            dgChiTietMH.DataSource = null; // xóa dữ liệu cũ
            dgChiTietMH.Refresh();
            dgChiTietMH.DataSource = hd._Cart; // nạp nguồn dữ liệu mới
            dgChiTietMH.Refresh();
            txtTongTien.Text = hd.tong_HoaDon.ToString("N2");
        }

        public void themSPvaoHoadon()
        { // khi thêm 1 sản phẩm, ta thêm vào danh sách, chứ không thêm vào csdl
            //*** chưa kiểm tra dữ liệu vào
            if (string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Nhập số lượng bán");
                return;
            }



            string maSpThem = cBMaMatHang.SelectedValue.ToString(); // lấy mã sản phẩm sẽ thêm vào chi tiết hóa đơn
                                                                    //int SoLuongThem = int.Parse(txtSoluong.Text); // số lượng sẽ thêm
            int SoLuongThem;
            bool isNumber = int.TryParse(txtSoluong.Text, out SoLuongThem);
            if (SoLuongThem <= 0) { MessageBox.Show("Số lượng phải lớn hơn 0"); return; }
            // bỏ qua đoạn code kiểm tra có đủ tồn hay không
            // vì bán tại cửa hàng, khách đến chọn áo quần, mang ra quầy ,nên đã đủ tồn thực tế
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = "Select * From Products where ProductID=@masp";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@masp", maSpThem);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string maSp = rd["productid"].ToString();
                            string tenSp = rd["Name"].ToString();
                            string dvt = rd["UnitCalc"].ToString();
                            float giaban = Convert.ToSingle(rd["sellPrice"].ToString());
                            // nếu giá bán =0 thì chưa thiết lập giá bán, nên không cho thêm vào đơn hàng bán
                            if (giaban == 0)
                            {
                                MessageBox.Show("Sản phẩm " + cBMaMatHang.Text + " chưa có giá bán");
                                return;
                            }
                            hd.insert_item_toCart(maSpThem, tenSp,SoLuongThem, giaban);
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

        public void insert_Hoadon(int idNhanVien, DateTime ngayhd, float total)
        { // thêm thông tin vào hóa đơn nhập - phía 1
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = "INSERT INTO SellOrders(SellDate,Total,EmployeeID)  VALUES(@ngayban,@Tongtien,@manv)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@manv", idNhanVien);
                    cmd.Parameters.AddWithValue("@Tongtien", total);
                    SqlParameter param3 = new SqlParameter(); param3.ParameterName = "@ngayban"; param3.SqlDbType = SqlDbType.DateTime; param3.Value = ngayhd; cmd.Parameters.Add(param3);
                    cmd.ExecuteNonQuery(); // Thi hành SQL 
                    cmd.Dispose();
                    MessageBox.Show("Đã lưu thông tin");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void insert_HoadonChitiet(int mahd, string masp, float giaban, int soluong)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = "insert into SellOrderDetail(SellOrderID,ProductID,productPrice,Quantity) VALUES(@mahd, @masp, @giaban, @soluong)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@mahd", mahd);
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.AddWithValue("@giaban", giaban); // đơn giá bán
                    cmd.Parameters.AddWithValue("@soluong", soluong);
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
            txtSoluong.Text = "";
            if (hd._Cart.Count > 0) hd._Cart.Clear();  // làm rỗng danh sách
            txtTongTien.Text = hd.tong_HoaDon.ToString();
            dgChiTietMH.DataSource = hd._Cart;
            dgChiTietMH.Refresh();
        }

        private void BtnInHoaDon_Click(object sender, EventArgs e)
        {
            if (hd._Cart.Count == 0)
            {
                MessageBox.Show("Chi tiết đơn hàng chưa có");
                return;
            }

            float total = hd.tong_HoaDon;
            insert_Hoadon(idNhanVien, ngayban,total);
            foreach(Cart cart in hd._Cart)
            {
                insert_HoadonChitiet(select_orderid(), cart._ProductId, cart._ProductPrice, cart._Quantity);
                tangSLsanPhamDaBan(cart._ProductId, cart._Quantity);// tăng số lượng sản phẩm đã bán trong tbl sản phẩm
            }
            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
            }
            txtTongTien.Text = hd.tong_HoaDon.ToString();
            dgChiTietMH.DataSource = hd._Cart;
            dgChiTietMH.Refresh(); 
        }

        private void tangSLsanPhamDaBan(string _ProductId,int _Quantity)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = " update Products " +
                                   " set   totalSell = totalSell + @slBan" +
                                   " where ProductID=@ProductID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ProductID", _ProductId);
                    cmd.Parameters.AddWithValue("@slBan", _Quantity);
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
                    string query = "Select max(SellOrderID) from SellOrders";
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
                    string stt = dgChiTietMH.CurrentCell.FormattedValue.ToString();
                    hd.remove_item(stt);
                    dgChiTietMH.DataSource = hd._Cart;
                    txtTongTien.Text = hd.tong_HoaDon.ToString();
                    dgChiTietMH.Refresh();

                }catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void frmLapHoaDonBanHang_Load(object sender, EventArgs e)
        {
         
            CbSanPhamBinding();
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void writeToFile()
        {
            String today = DateTime.Today.ToShortDateString();
            int rows = dgChiTietMH.Rows.Count;
            using (FileStream stream = new FileStream("donhang.txt", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(clsCacBienChung.tenDonVi);
                    writer.WriteLine(today);
                    writer.WriteLine("Hóa đơn thanh toán");
                    writer.WriteLine("");
                    for (int i = 0; i < rows; i++)
                    {
                        String productname = dgChiTietMH.Rows[i].Cells[1].FormattedValue.ToString();
                        String soluong = dgChiTietMH.Rows[i].Cells[2].FormattedValue.ToString();
                        String gia = dgChiTietMH.Rows[i].Cells[3].FormattedValue.ToString();
                        String tong = dgChiTietMH.Rows[i].Cells[4].FormattedValue.ToString();
                        writer.WriteLine(productname + " " + soluong + " " + gia + " " + tong);
                    }
                    writer.WriteLine("Tổng tiền:"+hd.tong_HoaDon.ToString());
                    writer.WriteLine("Cảm ơn quý khách đã mua hàng tại siêu thị của chúng tôi");
                    writer.WriteLine("Nhân viên:"+ Session._EmployeeName);
                    writer.Close();
                }
                stream.Close();
            }
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

    }
}