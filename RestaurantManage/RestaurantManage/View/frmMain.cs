using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManage.UC_View;

namespace RestaurantManage.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.LoadForm();
            this.VisibleTab();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        #region
        private void LoadForm()
        {
            UC_Header uc_header = new UC_Header();
            UC_Footer uc_footer = new UC_Footer();
            _Header.Controls.Clear();
            _Footer.Controls.Clear();
            _Header.Controls.Add(uc_header);
            _Footer.Controls.Add(uc_footer);
            uc_header.Dock = DockStyle.Fill;
            uc_footer.Dock = DockStyle.Fill;
        }
        private void VisibleTab()
        {
            UC_Quanlynhanvien nv = new UC_Quanlynhanvien();
            _tabQLNhanvien.Controls.Add(nv);
            nv.Dock = DockStyle.Fill;

            _tabMain.TabPages.Clear();
        }
        #endregion
    }
}
