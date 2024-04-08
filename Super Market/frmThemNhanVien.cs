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
    public partial class frmThemNhanVien : Form
    {
        private static SqlConnection conn;
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void BtnThemNHanVien_Click(object sender, EventArgs e)
        {
            string tennv, chucVu, gioiTinh, cmnd, diachi, dienthoai, tenLogin, mkLogin;

            tennv = TxtFullName.Text;
            chucVu = CbChucVu.Text;
            cmnd = TxtCMND.Text;
            diachi = TxtDiaChi.Text;
            tenLogin = TxtUsername.Text.Trim();
            mkLogin = TxtPassword.Text;

            gioiTinh = CbGioiTinh.Text;
            dienthoai = TxtDienThoai.Text;

            if ((tennv.Length == 0) || (chucVu.Length == 0) || (cmnd.Length == 0) || (diachi.Length == 0) || (tenLogin.Length == 0) || (mkLogin.Length == 0) || (gioiTinh.Length == 0))
            {
                MessageBox.Show("Cần nhập đủ thông tin");
                return;
            }

            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // Khai báo kết nối đến CSDL
            {
                try
                {
                    con.Open(); // mở kết nối
                    string strSQL = "Insert into Employees(EmployeeName, Title, DateOfBirth, Sex, IDCard, Address, Tel, Username, Password) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", tennv);
                    cmd.Parameters.AddWithValue("@p2", chucVu);
                    cmd.Parameters.AddWithValue("@p3", dtPickerNS.Text);
                    cmd.Parameters.AddWithValue("@p4", CbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@p5", cmnd);
                    cmd.Parameters.AddWithValue("@p6", diachi);
                    cmd.Parameters.AddWithValue("@p7", dienthoai);
                    cmd.Parameters.AddWithValue("@p8", tenLogin);
                    cmd.Parameters.AddWithValue("@p9", mkLogin);
                    cmd.ExecuteNonQuery(); // thực hiện lệnh SQL
                    cmd.Dispose();
                    MessageBox.Show("Đã thêm thông tin");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


       


        private void BtnDong_Click(object sender, EventArgs e)
        {
            if (!((frmMain)MdiParent).checkExitsForm("frmQuanLyNhanVien"))
            {
                frmQuanLyNhanVien frmType = new frmQuanLyNhanVien();
                frmType.MdiParent = ActiveForm;
                frmType.Show();
                this.Close();  // đóng form  
            }
            else ActiveChildForm("frmQuanLyNhanVien");
            this.Close();
        }

   


        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                { frm.Activate(); break; }
            }

        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString.chuoiKetNoi());
        }
    }
}