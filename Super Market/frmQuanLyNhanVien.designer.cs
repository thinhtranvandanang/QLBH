namespace Super_Market
{
    partial class frmQuanLyNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnDong = new System.Windows.Forms.Button();
            this.ctMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ctMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctMenuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnThemNhanVien = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtDienThoai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDiachi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPickerNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbChucVu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LstHoTen = new System.Windows.Forms.ListBox();
            this.BtnCapNhat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.ctMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDong
            // 
            this.BtnDong.BackColor = System.Drawing.SystemColors.Info;
            this.BtnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDong.Location = new System.Drawing.Point(625, 487);
            this.BtnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDong.Name = "BtnDong";
            this.BtnDong.Size = new System.Drawing.Size(112, 42);
            this.BtnDong.TabIndex = 14;
            this.BtnDong.Text = "Đ&óng";
            this.BtnDong.UseVisualStyleBackColor = false;
            this.BtnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // ctMenu
            // 
            this.ctMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctMenuNew,
            this.ctMenuDelete,
            this.ctMenuQuit});
            this.ctMenu.Name = "ctMenu";
            this.ctMenu.Size = new System.Drawing.Size(135, 94);
            // 
            // ctMenuNew
            // 
            this.ctMenuNew.Name = "ctMenuNew";
            this.ctMenuNew.Size = new System.Drawing.Size(134, 30);
            this.ctMenuNew.Text = "&New";
            // 
            // ctMenuDelete
            // 
            this.ctMenuDelete.Name = "ctMenuDelete";
            this.ctMenuDelete.Size = new System.Drawing.Size(134, 30);
            this.ctMenuDelete.Text = "&Delete";
            // 
            // ctMenuQuit
            // 
            this.ctMenuQuit.Name = "ctMenuQuit";
            this.ctMenuQuit.Size = new System.Drawing.Size(134, 30);
            this.ctMenuQuit.Text = "&Quit";
            // 
            // BtnThemNhanVien
            // 
            this.BtnThemNhanVien.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThemNhanVien.Location = new System.Drawing.Point(186, 487);
            this.BtnThemNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnThemNhanVien.Name = "BtnThemNhanVien";
            this.BtnThemNhanVien.Size = new System.Drawing.Size(112, 42);
            this.BtnThemNhanVien.TabIndex = 15;
            this.BtnThemNhanVien.Text = "&Thêm";
            this.BtnThemNhanVien.UseVisualStyleBackColor = false;
            this.BtnThemNhanVien.Click += new System.EventHandler(this.BtnThemNhanVien_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(256, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 463);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.TxtDienThoai);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.TxtDiachi);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.TxtCMND);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtPickerNgaysinh);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.CbGioiTinh);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.CbChucVu);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TxtPassword);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.TxtUsername);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TxtName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(520, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin cá nhân";
            // 
            // TxtDienThoai
            // 
            this.TxtDienThoai.Location = new System.Drawing.Point(106, 322);
            this.TxtDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDienThoai.Name = "TxtDienThoai";
            this.TxtDienThoai.Size = new System.Drawing.Size(220, 26);
            this.TxtDienThoai.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 328);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Điện thoại";
            // 
            // TxtDiachi
            // 
            this.TxtDiachi.Location = new System.Drawing.Point(106, 278);
            this.TxtDiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDiachi.Name = "TxtDiachi";
            this.TxtDiachi.Size = new System.Drawing.Size(220, 26);
            this.TxtDiachi.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 285);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Đỉa chỉ";
            // 
            // TxtCMND
            // 
            this.TxtCMND.Location = new System.Drawing.Point(106, 237);
            this.TxtCMND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCMND.Name = "TxtCMND";
            this.TxtCMND.Size = new System.Drawing.Size(220, 26);
            this.TxtCMND.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số CMND";
            // 
            // dtPickerNgaysinh
            // 
            this.dtPickerNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerNgaysinh.Location = new System.Drawing.Point(108, 145);
            this.dtPickerNgaysinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPickerNgaysinh.Name = "dtPickerNgaysinh";
            this.dtPickerNgaysinh.Size = new System.Drawing.Size(220, 26);
            this.dtPickerNgaysinh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày sinh";
            // 
            // CbGioiTinh
            // 
            this.CbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGioiTinh.FormattingEnabled = true;
            this.CbGioiTinh.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CbGioiTinh.Location = new System.Drawing.Point(356, 192);
            this.CbGioiTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbGioiTinh.Name = "CbGioiTinh";
            this.CbGioiTinh.Size = new System.Drawing.Size(118, 28);
            this.CbGioiTinh.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Giới tính";
            // 
            // CbChucVu
            // 
            this.CbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbChucVu.FormattingEnabled = true;
            this.CbChucVu.Items.AddRange(new object[] {
            "Quan Ly",
            "Nhan vien"});
            this.CbChucVu.Location = new System.Drawing.Point(106, 192);
            this.CbChucVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbChucVu.Name = "CbChucVu";
            this.CbChucVu.Size = new System.Drawing.Size(130, 28);
            this.CbChucVu.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Chức vụ";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(106, 103);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(220, 26);
            this.TxtPassword.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(108, 62);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(220, 26);
            this.TxtUsername.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(108, 20);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(220, 26);
            this.TxtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Họ và tên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LstHoTen
            // 
            this.LstHoTen.BackColor = System.Drawing.SystemColors.Info;
            this.LstHoTen.FormattingEnabled = true;
            this.LstHoTen.ItemHeight = 20;
            this.LstHoTen.Location = new System.Drawing.Point(13, 50);
            this.LstHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LstHoTen.Name = "LstHoTen";
            this.LstHoTen.Size = new System.Drawing.Size(241, 424);
            this.LstHoTen.TabIndex = 23;
            this.LstHoTen.SelectedValueChanged += new System.EventHandler(this.LstHoTen_SelectedValueChanged);
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.BackColor = System.Drawing.SystemColors.Info;
            this.BtnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCapNhat.Location = new System.Drawing.Point(478, 487);
            this.BtnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.Size = new System.Drawing.Size(112, 42);
            this.BtnCapNhat.TabIndex = 24;
            this.BtnCapNhat.Text = "&Cập nhật";
            this.BtnCapNhat.UseVisualStyleBackColor = false;
            this.BtnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.SystemColors.Info;
            this.BtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnXoa.Location = new System.Drawing.Point(338, 487);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(112, 42);
            this.BtnXoa.TabIndex = 25;
            this.BtnXoa.Text = "&Xóa";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 558);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnCapNhat);
            this.Controls.Add(this.LstHoTen);
            this.Controls.Add(this.BtnThemNhanVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnDong);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quan Ly Nhan vien";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.ctMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnDong;
        private System.Windows.Forms.ContextMenuStrip ctMenu;
        private System.Windows.Forms.ToolStripMenuItem ctMenuNew;
        private System.Windows.Forms.ToolStripMenuItem ctMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem ctMenuQuit;
        private System.Windows.Forms.Button BtnThemNhanVien;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LstHoTen;
        private System.Windows.Forms.Button BtnCapNhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbChucVu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbGioiTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPickerNgaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCMND;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDiachi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDienThoai;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnXoa;
    }
}