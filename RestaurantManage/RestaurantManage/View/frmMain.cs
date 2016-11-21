using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManage.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UC_View.UC_Quanlynhanvien s = new UC_View.UC_Quanlynhanvien();
            panel1.Controls.Clear();
            panel1.Controls.Add(s);
            s.Dock = DockStyle.Fill;
        }
    }
}
