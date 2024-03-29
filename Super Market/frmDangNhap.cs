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
        private  static SqlConnection conn;
        public frmDangNhap()
        {
           
            
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString.getConnect());
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
                using (SqlConnection con = new SqlConnection(ConnectionString.getConnect())) // Khai báo kết nối đến CSDL
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
                            int employeeid= (int)rd["EmployeeID"];
                            string employeename = rd["EmployeeName"].ToString();
                            string Title = rd["Title"].ToString();
                            string Sex = rd["Sex"].ToString();
                            string userName = rd["Username"].ToString();
                            Session.set(employeeid, employeename, Title, Sex, userName);

                            if (Title.Contains(HangSo.QuyenQuanLy)) LoadMenuAdmin(); // nếu là quản lý thì load menu quản lys
                            else LoadMenuNhanVien();

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

        public void LoadMenuAdmin()
        {
            foreach (ToolStripDropDownItem item in ((frmMain)MdiParent).MainMenu.Items)  // các menu cấp 1
            {
                item.Enabled = true;
                foreach (ToolStripMenuItem mi in item.DropDownItems)
                    mi.Enabled = true; // các menu cấp 2
            }
        }

        public void LoadMenuNhanVien()
        { // menu nhân viên
          // menu hệ thống
            ((frmMain)MdiParent).đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            ((frmMain)MdiParent).loginToolStripMenuItem.Enabled = true;
            ((frmMain)MdiParent).logoutToolStripMenuItem.Enabled = true;
            // menu Quản lý danh mục
            ((frmMain)MdiParent).MainMenu.Items[1].Enabled = false;
            ((frmMain)MdiParent).loạiHàngHóaToolStripMenuItem.Enabled = false;
            ((frmMain)MdiParent).hàngHóaToolStripMenuItem1.Enabled = false;
            ((frmMain)MdiParent).nhàCungCấpToolStripMenuItem.Enabled = false;
            // menu Bán hàng
            ((frmMain)MdiParent).MainMenu.Items[2].Enabled = true;
            ((frmMain)MdiParent).lậpHóaĐơnBánHàngToolStripMenuItem.Enabled = true;
            // menu thống kê
            ((frmMain)MdiParent).MainMenu.Items[3].Enabled = true;
            ((frmMain)MdiParent).thốngKêHóaĐơnNhậpHàngToolStripMenuItem.Enabled = false;
            ((frmMain)MdiParent).thốngKêHóaĐơnNhậpHàngToolStripMenuItem.Enabled = true;
            ((frmMain)MdiParent).thốngKêHàngTồnToolStripMenuItem.Enabled = true;
            // menu quản lý nhân viên
            ((frmMain)MdiParent).MainMenu.Items[4].Enabled = false;
            ((frmMain)MdiParent).quảnLýNhânViênToolStripMenuItem.Enabled = true;
          
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
      

        
    }
}