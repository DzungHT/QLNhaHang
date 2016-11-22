using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManage
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
            UC_View.UC_Quanlyloaimonan uc = new UC_View.UC_Quanlyloaimonan();
            _Content.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
