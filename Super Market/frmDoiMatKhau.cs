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
    public partial class frmDoiMatKhau : Form
    {
        private  static SqlConnection conn;
        public frmDoiMatKhau()
        {
           
            
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString.getConnect());
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // kiểm tra phải nhập thông tin trên form
            if (txtCurrPass.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập mật khẩu hiện tại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNewPass1.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập mật khẩu mới", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNewPass2.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập xác thực mật khẩu mới", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // kiểm tra người dùng hiện tại + mật khẩu hiện tại phải đúng
            if (!checkUserNameAndPass(Session._Username, txtCurrPass.Text.Trim()))
            {
                MessageBox.Show("Phải nhập đúng Mật khẩu hiện tại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (txtNewPass1.Text != txtNewPass2.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu phải giống nhau", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // kiểm tra mật khẩu mới và xác nhận 
            setNewPass(Session._Username, txtNewPass1.Text);


        }


        private bool setNewPass(string username, string newpass)
        { // thiết lập mật khẩu mới, sau khi đã kiểm tra ok
            bool kt = false; // giả sử là nhập sai
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnect())) // Khai báo kết nối đến CSDL
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = " update Employees  " +
                                   " set  Password = @Password " +
                                   " where Username= @Username";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Password", newpass);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();  // thực hiện lệnh SQL
                    cmd.Dispose();
                    MessageBox.Show("Đã cập nhập mật khẩu mới");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return kt;
            }
        }

        private bool checkUserNameAndPass(string  username, string pass)
        { // kiểm tra mật khẩu và tài khoản có đúng không
            bool kt = false; // giả sử là nhập sai
            using (SqlConnection con = new SqlConnection(ConnectionString.getConnect())) // Khai báo kết nối đến CSDL
            {
                try
                {
                    con.Open(); // mở kết nối
                    string strSQL = "Select * from Employees as Em where Em.Username = @Username AND Em.Password = @Password";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", pass);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows) kt = true; // nếu tìm thấy
                    cmd.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return kt;
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