using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManage.Models;

namespace RestaurantManage.UC_View
{
    public partial class UC_Quanlynhanvien : UserControl
    {
        private NhanVien _nv;
        public UC_Quanlynhanvien()
        {
            InitializeComponent();
            _nv = new NhanVien() { NhanVienID = 1, HoTen = "Hoàng Trí Dũng", DiaChi = "ABC", Email = "Email" };
            InitDataBinding();
        }

        public void InitDataBinding()
        {
            Binding bind = new Binding("Text", _nv, "HoTen", true, DataSourceUpdateMode.OnPropertyChanged);
            tbHoten.DataBindings.Add(bind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_nv.HoTen + "|" + tbHoten.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _nv.HoTen = "Hoàng Trí Dũng";
        }
    }
}
