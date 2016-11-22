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
    public partial class UC_QuanLyNhanVien : UserControl
    {
        private RestaurantServices.RestaurantServicesSoapClient serv = new RestaurantServices.RestaurantServicesSoapClient();
        public UC_QuanLyNhanVien()
        {
            InitializeComponent();
            try
            {
                dgvDS_Nhanvien.DataSource = serv.GetAllNhanVien();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void RefreshBoxInfo()
        {
            tbSodienthoai.Text = "";
            radNam.Checked = radNu.Checked = false;
            tbNhanVienID.Text = "";
            tbHoten.Text = "";
            tbEmail.Text = "";
            tbDiachi.Text = "";
            lblThongbao.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbSodienthoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDS_Nhanvien_SelectionChanged(object sender, EventArgs e)
        {
            tbNhanVienID.Text = dgvDS_Nhanvien.CurrentRow.Cells[0].Value.ToString();
            tbHoten.Text = dgvDS_Nhanvien.CurrentRow.Cells[1].Value.ToString();
            tbSodienthoai.Text = dgvDS_Nhanvien.CurrentRow.Cells[2].Value.ToString();
            tbDiachi.Text = dgvDS_Nhanvien.CurrentRow.Cells[3].Value.ToString();
            tbEmail.Text = dgvDS_Nhanvien.CurrentRow.Cells[4].Value.ToString();
            bool gt;
            if(bool.TryParse(dgvDS_Nhanvien.CurrentRow.Cells[5].Value.ToString(), out gt))
            {
                if (gt == true)
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lblThongbao.Text = "Xóa thành công!";
            RefreshBoxInfo();
        }
    }
}
