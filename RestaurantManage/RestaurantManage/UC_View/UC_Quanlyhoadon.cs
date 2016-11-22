using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManage.UC_View
{
    public partial class UC_Quanlyhoadon : UserControl
    {
        private RestaurantServices.RestaurantServicesSoapClient serv = new RestaurantServices.RestaurantServicesSoapClient();
        public UC_Quanlyhoadon()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            dgrvHoaDon.DataSource = serv.GetAllHoaDon();
        }

        private void dgrvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int HoaDonID = int.Parse(dgrvHoaDon.CurrentRow.Cells[0].Value.ToString());
                dgrvChiTiet.DataSource = serv.GetChiTietHoaDon(HoaDonID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
