namespace RestaurantManage.View
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbTendangnhap = new System.Windows.Forms.TextBox();
            this.tbMatkhau = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // tbTendangnhap
            // 
            this.tbTendangnhap.Location = new System.Drawing.Point(120, 34);
            this.tbTendangnhap.Name = "tbTendangnhap";
            this.tbTendangnhap.Size = new System.Drawing.Size(152, 20);
            this.tbTendangnhap.TabIndex = 1;
            this.tbTendangnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTendangnhap_KeyPress);
            // 
            // tbMatkhau
            // 
            this.tbMatkhau.Location = new System.Drawing.Point(120, 63);
            this.tbMatkhau.Name = "tbMatkhau";
            this.tbMatkhau.PasswordChar = '*';
            this.tbMatkhau.Size = new System.Drawing.Size(152, 20);
            this.tbMatkhau.TabIndex = 2;
            this.tbMatkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatkhau_KeyPress);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDangnhap.Location = new System.Drawing.Point(45, 97);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(71, 34);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(173, 97);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 34);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblThongbao
            // 
            this.lblThongbao.ForeColor = System.Drawing.Color.Red;
            this.lblThongbao.Location = new System.Drawing.Point(15, 9);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(257, 22);
            this.lblThongbao.TabIndex = 4;
            this.lblThongbao.Text = "<thông báo lỗi>";
            this.lblThongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongbao.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.tbMatkhau);
            this.Controls.Add(this.tbTendangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTendangnhap;
        private System.Windows.Forms.TextBox tbMatkhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblThongbao;
    }
}