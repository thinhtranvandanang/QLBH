namespace Super_Market
{
    partial class frmQuanLyChungLoaiHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnThemChungLoai = new System.Windows.Forms.Button();
            this.TxtChungLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCapNhatChungLoai = new System.Windows.Forms.Button();
            this.BtnSuaChungLoai = new System.Windows.Forms.Button();
            this.LstProductTypes = new System.Windows.Forms.ListBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnXoaChungLoai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnThemChungLoai);
            this.groupBox1.Controls.Add(this.TxtChungLoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnThemChungLoai
            // 
            this.BtnThemChungLoai.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThemChungLoai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThemChungLoai.Location = new System.Drawing.Point(291, 23);
            this.BtnThemChungLoai.Name = "BtnThemChungLoai";
            this.BtnThemChungLoai.Size = new System.Drawing.Size(75, 23);
            this.BtnThemChungLoai.TabIndex = 2;
            this.BtnThemChungLoai.Text = "&Thêm";
            this.BtnThemChungLoai.UseVisualStyleBackColor = false;
            this.BtnThemChungLoai.Click += new System.EventHandler(this.BtnThemChungLoai_Click);
            // 
            // TxtChungLoai
            // 
            this.TxtChungLoai.Location = new System.Drawing.Point(95, 25);
            this.TxtChungLoai.Name = "TxtChungLoai";
            this.TxtChungLoai.Size = new System.Drawing.Size(173, 20);
            this.TxtChungLoai.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chủng loại";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnCapNhatChungLoai);
            this.groupBox2.Controls.Add(this.BtnSuaChungLoai);
            this.groupBox2.Controls.Add(this.LstProductTypes);
            this.groupBox2.Controls.Add(this.BtnThoat);
            this.groupBox2.Controls.Add(this.BtnXoaChungLoai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 229);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // BtnCapNhatChungLoai
            // 
            this.BtnCapNhatChungLoai.BackColor = System.Drawing.SystemColors.Info;
            this.BtnCapNhatChungLoai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCapNhatChungLoai.Location = new System.Drawing.Point(312, 19);
            this.BtnCapNhatChungLoai.Name = "BtnCapNhatChungLoai";
            this.BtnCapNhatChungLoai.Size = new System.Drawing.Size(75, 23);
            this.BtnCapNhatChungLoai.TabIndex = 10;
            this.BtnCapNhatChungLoai.Text = "&Cập nhật";
            this.BtnCapNhatChungLoai.UseVisualStyleBackColor = false;
            this.BtnCapNhatChungLoai.Click += new System.EventHandler(this.BtnCapNhatChungLoai_Click_1);
            // 
            // BtnSuaChungLoai
            // 
            this.BtnSuaChungLoai.Location = new System.Drawing.Point(312, 19);
            this.BtnSuaChungLoai.Name = "BtnSuaChungLoai";
            this.BtnSuaChungLoai.Size = new System.Drawing.Size(75, 23);
            this.BtnSuaChungLoai.TabIndex = 9;
            this.BtnSuaChungLoai.Text = "&Sửa";
            this.BtnSuaChungLoai.UseVisualStyleBackColor = true;
            this.BtnSuaChungLoai.Click += new System.EventHandler(this.BtnSuaChungLoai_Click);
            // 
            // LstProductTypes
            // 
            this.LstProductTypes.BackColor = System.Drawing.SystemColors.Info;
            this.LstProductTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstProductTypes.FormattingEnabled = true;
            this.LstProductTypes.ItemHeight = 16;
            this.LstProductTypes.Location = new System.Drawing.Point(0, 34);
            this.LstProductTypes.Name = "LstProductTypes";
            this.LstProductTypes.Size = new System.Drawing.Size(296, 180);
            this.LstProductTypes.TabIndex = 8;
            // 
            // BtnThoat
            // 
            this.BtnThoat.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThoat.Location = new System.Drawing.Point(312, 142);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 7;
            this.BtnThoat.Text = "&Thoát";
            this.BtnThoat.UseVisualStyleBackColor = false;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnXoaChungLoai
            // 
            this.BtnXoaChungLoai.BackColor = System.Drawing.SystemColors.Info;
            this.BtnXoaChungLoai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnXoaChungLoai.Location = new System.Drawing.Point(312, 73);
            this.BtnXoaChungLoai.Name = "BtnXoaChungLoai";
            this.BtnXoaChungLoai.Size = new System.Drawing.Size(75, 23);
            this.BtnXoaChungLoai.TabIndex = 6;
            this.BtnXoaChungLoai.Text = "&Xóa";
            this.BtnXoaChungLoai.UseVisualStyleBackColor = false;
            this.BtnXoaChungLoai.Click += new System.EventHandler(this.BtnXoaChungLoai_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chủng loại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản lý Chủng loại hàng";
            // 
            // frmQuanLyChungLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::Super_Market.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyChungLoaiHang";
            this.Text = "Quản ly chủng loại hàng";
            this.Load += new System.EventHandler(this.frmTypes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnThemChungLoai;
        private System.Windows.Forms.TextBox TxtChungLoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnXoaChungLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSuaChungLoai;
        private System.Windows.Forms.Button BtnCapNhatChungLoai;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ListBox LstProductTypes;
    }
}