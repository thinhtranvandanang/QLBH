namespace Super_Market
{
    partial class frmDanhMucNhaCungCap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LstTenNCC = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtDienThoai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDiachi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnCapNhat = new System.Windows.Forms.Button();
            this.BtnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh mục Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên nhà cung cấp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LstTenNCC
            // 
            this.LstTenNCC.BackColor = System.Drawing.SystemColors.Menu;
            this.LstTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LstTenNCC.FormattingEnabled = true;
            this.LstTenNCC.ItemHeight = 20;
            this.LstTenNCC.Location = new System.Drawing.Point(18, 142);
            this.LstTenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LstTenNCC.Name = "LstTenNCC";
            this.LstTenNCC.Size = new System.Drawing.Size(242, 422);
            this.LstTenNCC.TabIndex = 24;
            this.LstTenNCC.SelectedValueChanged += new System.EventHandler(this.LstTenNCC_SelectedValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(250, 106);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 463);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.TxtDienThoai);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.TxtDiachi);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.TxtName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(454, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin Nhà cung cấp";
            // 
            // TxtDienThoai
            // 
            this.TxtDienThoai.Location = new System.Drawing.Point(176, 154);
            this.TxtDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDienThoai.Name = "TxtDienThoai";
            this.TxtDienThoai.Size = new System.Drawing.Size(220, 26);
            this.TxtDienThoai.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 160);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Điện thoại";
            // 
            // TxtDiachi
            // 
            this.TxtDiachi.Location = new System.Drawing.Point(176, 82);
            this.TxtDiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDiachi.Name = "TxtDiachi";
            this.TxtDiachi.Size = new System.Drawing.Size(220, 26);
            this.TxtDiachi.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Đỉa chỉ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(176, 20);
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
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên nhà cung cấp";
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThem.Location = new System.Drawing.Point(111, 582);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(112, 42);
            this.BtnThem.TabIndex = 26;
            this.BtnThem.Text = "&Thêm";
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.SystemColors.Info;
            this.BtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnXoa.Location = new System.Drawing.Point(264, 582);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(112, 42);
            this.BtnXoa.TabIndex = 27;
            this.BtnXoa.Text = "&Xóa";
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnCapNhat
            // 
            this.BtnCapNhat.BackColor = System.Drawing.SystemColors.Info;
            this.BtnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCapNhat.Location = new System.Drawing.Point(412, 582);
            this.BtnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCapNhat.Name = "BtnCapNhat";
            this.BtnCapNhat.Size = new System.Drawing.Size(112, 42);
            this.BtnCapNhat.TabIndex = 28;
            this.BtnCapNhat.Text = "&Cập nhật";
            this.BtnCapNhat.UseVisualStyleBackColor = false;
            this.BtnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // BtnDong
            // 
            this.BtnDong.BackColor = System.Drawing.SystemColors.Info;
            this.BtnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDong.Location = new System.Drawing.Point(564, 582);
            this.BtnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDong.Name = "BtnDong";
            this.BtnDong.Size = new System.Drawing.Size(112, 42);
            this.BtnDong.TabIndex = 29;
            this.BtnDong.Text = "Đ&óng";
            this.BtnDong.UseVisualStyleBackColor = false;
            this.BtnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // frmDanhMucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 668);
            this.Controls.Add(this.BtnDong);
            this.Controls.Add(this.BtnCapNhat);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LstTenNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDanhMucNhaCungCap";
            this.Text = "Danh mục nhà cung cấp";
            this.Load += new System.EventHandler(this.frmDanhMucNhaCungCap_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LstTenNCC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TxtDienThoai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDiachi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnCapNhat;
        private System.Windows.Forms.Button BtnDong;
    }
}