namespace RestaurantManage.UC_View
{
    partial class UC_Quanlyhoadon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrvHoaDon = new System.Windows.Forms.DataGridView();
            this.dgrvChiTiet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvHoaDon
            // 
            this.dgrvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.dgrvHoaDon.Name = "dgrvHoaDon";
            this.dgrvHoaDon.Size = new System.Drawing.Size(662, 215);
            this.dgrvHoaDon.TabIndex = 0;
            this.dgrvHoaDon.SelectionChanged += new System.EventHandler(this.dgrvHoaDon_SelectionChanged);
            // 
            // dgrvChiTiet
            // 
            this.dgrvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvChiTiet.Location = new System.Drawing.Point(3, 301);
            this.dgrvChiTiet.Name = "dgrvChiTiet";
            this.dgrvChiTiet.Size = new System.Drawing.Size(662, 215);
            this.dgrvChiTiet.TabIndex = 1;
            // 
            // UC_Quanlyhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgrvChiTiet);
            this.Controls.Add(this.dgrvHoaDon);
            this.Name = "UC_Quanlyhoadon";
            this.Size = new System.Drawing.Size(850, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvHoaDon;
        private System.Windows.Forms.DataGridView dgrvChiTiet;
    }
}
