namespace RestaurantManage.View
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._Footer = new System.Windows.Forms.Panel();
            this._Header = new System.Windows.Forms.Panel();
            this._tabMain = new System.Windows.Forms.TabControl();
            this._tabQLNhanvien = new System.Windows.Forms.TabPage();
            this._tabQLLoaimonan = new System.Windows.Forms.TabPage();
            this._tabQLMonan = new System.Windows.Forms.TabPage();
            this._tabQLKhuvuc = new System.Windows.Forms.TabPage();
            this._tabQLBanan = new System.Windows.Forms.TabPage();
            this._tabQLKhachhang = new System.Windows.Forms.TabPage();
            this._tabDatmon = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this._tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._tabMain);
            this.panel1.Controls.Add(this._Footer);
            this.panel1.Controls.Add(this._Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 481);
            this.panel1.TabIndex = 0;
            // 
            // _Footer
            // 
            this._Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Footer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Footer.Location = new System.Drawing.Point(3, 445);
            this._Footer.Name = "_Footer";
            this._Footer.Size = new System.Drawing.Size(816, 35);
            this._Footer.TabIndex = 0;
            // 
            // _Header
            // 
            this._Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Header.Location = new System.Drawing.Point(3, 3);
            this._Header.Name = "_Header";
            this._Header.Size = new System.Drawing.Size(816, 35);
            this._Header.TabIndex = 0;
            // 
            // _tabMain
            // 
            this._tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tabMain.Controls.Add(this._tabQLLoaimonan);
            this._tabMain.Controls.Add(this._tabQLMonan);
            this._tabMain.Controls.Add(this._tabQLKhuvuc);
            this._tabMain.Controls.Add(this._tabQLBanan);
            this._tabMain.Controls.Add(this._tabQLNhanvien);
            this._tabMain.Controls.Add(this._tabQLKhachhang);
            this._tabMain.Controls.Add(this._tabDatmon);
            this._tabMain.Location = new System.Drawing.Point(3, 38);
            this._tabMain.Name = "_tabMain";
            this._tabMain.SelectedIndex = 0;
            this._tabMain.Size = new System.Drawing.Size(816, 405);
            this._tabMain.TabIndex = 0;
            // 
            // _tabQLNhanvien
            // 
            this._tabQLNhanvien.Location = new System.Drawing.Point(4, 22);
            this._tabQLNhanvien.Name = "_tabQLNhanvien";
            this._tabQLNhanvien.Padding = new System.Windows.Forms.Padding(3);
            this._tabQLNhanvien.Size = new System.Drawing.Size(808, 379);
            this._tabQLNhanvien.TabIndex = 0;
            this._tabQLNhanvien.Text = "Quản lý nhân viên";
            this._tabQLNhanvien.UseVisualStyleBackColor = true;
            // 
            // _tabQLLoaimonan
            // 
            this._tabQLLoaimonan.Location = new System.Drawing.Point(4, 22);
            this._tabQLLoaimonan.Name = "_tabQLLoaimonan";
            this._tabQLLoaimonan.Size = new System.Drawing.Size(808, 379);
            this._tabQLLoaimonan.TabIndex = 1;
            this._tabQLLoaimonan.Text = "Quản lý loại món ăn";
            this._tabQLLoaimonan.UseVisualStyleBackColor = true;
            // 
            // _tabQLMonan
            // 
            this._tabQLMonan.Location = new System.Drawing.Point(4, 22);
            this._tabQLMonan.Name = "_tabQLMonan";
            this._tabQLMonan.Size = new System.Drawing.Size(808, 379);
            this._tabQLMonan.TabIndex = 2;
            this._tabQLMonan.Text = "Quản lý món ăn";
            this._tabQLMonan.UseVisualStyleBackColor = true;
            // 
            // _tabQLKhuvuc
            // 
            this._tabQLKhuvuc.Location = new System.Drawing.Point(4, 22);
            this._tabQLKhuvuc.Name = "_tabQLKhuvuc";
            this._tabQLKhuvuc.Size = new System.Drawing.Size(808, 379);
            this._tabQLKhuvuc.TabIndex = 3;
            this._tabQLKhuvuc.Text = "Quản lý khu vực";
            this._tabQLKhuvuc.UseVisualStyleBackColor = true;
            // 
            // _tabQLBanan
            // 
            this._tabQLBanan.Location = new System.Drawing.Point(4, 22);
            this._tabQLBanan.Name = "_tabQLBanan";
            this._tabQLBanan.Size = new System.Drawing.Size(808, 379);
            this._tabQLBanan.TabIndex = 4;
            this._tabQLBanan.Text = "Quản lý bàn ăn";
            this._tabQLBanan.UseVisualStyleBackColor = true;
            // 
            // _tabQLKhachhang
            // 
            this._tabQLKhachhang.Location = new System.Drawing.Point(4, 22);
            this._tabQLKhachhang.Name = "_tabQLKhachhang";
            this._tabQLKhachhang.Size = new System.Drawing.Size(808, 379);
            this._tabQLKhachhang.TabIndex = 5;
            this._tabQLKhachhang.Text = "Quản lý khách hàng";
            this._tabQLKhachhang.UseVisualStyleBackColor = true;
            // 
            // _tabDatmon
            // 
            this._tabDatmon.Location = new System.Drawing.Point(4, 22);
            this._tabDatmon.Name = "_tabDatmon";
            this._tabDatmon.Size = new System.Drawing.Size(808, 379);
            this._tabDatmon.TabIndex = 6;
            this._tabDatmon.Text = "Đặt món";
            this._tabDatmon.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 481);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this._tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel _Header;
        private System.Windows.Forms.Panel _Footer;
        private System.Windows.Forms.TabControl _tabMain;
        private System.Windows.Forms.TabPage _tabQLNhanvien;
        private System.Windows.Forms.TabPage _tabQLLoaimonan;
        private System.Windows.Forms.TabPage _tabQLMonan;
        private System.Windows.Forms.TabPage _tabQLKhuvuc;
        private System.Windows.Forms.TabPage _tabQLBanan;
        private System.Windows.Forms.TabPage _tabQLKhachhang;
        private System.Windows.Forms.TabPage _tabDatmon;
    }
}