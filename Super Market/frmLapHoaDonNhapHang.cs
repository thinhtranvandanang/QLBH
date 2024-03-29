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
        private static SqlConnection conn;
        private bool controlKey=false;
        HoaDon hd = new HoaDon();
      
        public frmLapHoaDonNhapHang()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.getConnect());
            cBMaMatHang.DataSource= load_ProductsID();
            
        }
        public ArrayList load_ProductsID()
        {
            ArrayList productsId = new ArrayList();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Select ProductID from Products";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productsId.Add(reader[0].ToString());

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "errors", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                conn.Close();
            }
            return productsId;
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
        {
            String productid = cBMaMatHang.Text;
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "Select ProductID,Name,UnitCalc,sellPrice,totalImport,totalSell From Products where ProductID=" + "'" + productid + "'";
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(txtSoluong.Text) > 0) // productid, productName, quantity, productPrice
                        hd.insert_item_toCart(reader["ProductID"].ToString(), reader["Name"].ToString(), int.Parse(txtSoluong.Text), float.Parse(txtGiaNhap.Text));
                }
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu : " +  ex.ToString()); }
            catch (Exception ex) { MessageBox.Show("Có lỗi sảy ra: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                conn.Close();
            }
        }
        public void insert_Hoadon(DateTime ngayhd,int maNCC,string notes, int employeeId, float total)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnect())) // tạo kết nối
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
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnect())) // tạo kết nối
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

       

        private void BtnXoaMH_Click(object sender, EventArgs e)
        {
            try
            {
                hd.remove_item(dgChiTietMH.CurrentCell.FormattedValue.ToString()); // xóa trong danh sách
                dgChiTietMH.DataSource = hd._Cart;   // hiển thị danh sách mới
                txtTongTien.Text = hd.tong_HoaDon.ToString(); // hiển thị tổng tiền 
                dgChiTietMH.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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

        //tangSLsanPhamDaNhap(cart._ProductId, cart._Quantity)
        private void tangSLsanPhamDaNhap(string _ProductId,int _Quantity)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnect())) // tạo kết nối
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
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "Select max([InOrderID]) id from [InOrders]";
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    result = int.Parse(reader[0].ToString());
                }
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally {
                conn.Close();
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
        }

        private void CbNCCBidinding()
        {
            string strSQL = "SELECT ProviderID,Name FROM Providers";
            using (SqlConnection conn = new SqlConnection(ConnectionString.getConnect()))
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