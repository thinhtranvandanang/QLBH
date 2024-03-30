using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Super_Market
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Username = (txtUsername.Text).Trim();
                string Password = (txtPassword.Text).Trim();
                using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // Khai báo kết nối đến CSDL
                {
                    try
                    {
                        con.Open(); // mở kết nối
                        string strSQL = "Select * from Employees as Em where Em.Username = @Username AND Em.Password = @Password";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            rd.Read();
                            int employeeid = (int)rd["EmployeeID"];
                            string employeename = rd["EmployeeName"].ToString();
                            string Title = rd["Title"].ToString();
                            string Sex = rd["Sex"].ToString();
                            string userName = rd["Username"].ToString();
                            Session.set(employeeid, employeename, Title, Sex, userName);
                            clsBienDungChung.Quyen = Title; // quyền là nhân viên hay quản lý khi đăng nhập
                            ((frmMain)MdiParent).frmMain_Load(sender, e);
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Kiểm tra lại thông tin người dùng");
                        }
                        cmd.Dispose();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}