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
    public partial class UC_QuanLyKhachHang : UserControl
    {
        private RestaurantServices.RestaurantServicesSoapClient serv = new RestaurantServices.RestaurantServicesSoapClient();
        public UC_QuanLyKhachHang()
        {
            InitializeComponent();
            ShowListKH();
        }
        private void ShowListKH()
        {
            try
            {
                dgvDS_Nhanvien.DataSource = serv.GetAllKhachHang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RefreshBoxInfo()
        {
            tbSodienthoai.Text = "";
            tbKhachHangID.Text = "";
            tbHoten.Text = "";
            tbDiachi.Text = "";
            lblThongbao.Text = "";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (serv.InsertKhachHang(tbHoten.Text, tbSodienthoai.Text, tbDiachi.Text) == 1)
                {
                    RefreshBoxInfo();
                    lblThongbao.Text = "Insert thanh cong!";
                    ShowListKH();
                }
                else
                {
                    RefreshBoxInfo();
                    lblThongbao.Text = "Insert that bai!";
                    ShowListKH();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvDS_Nhanvien_SelectionChanged(object sender, EventArgs e)
        {
            tbKhachHangID.Text = dgvDS_Nhanvien.CurrentRow.Cells[0].Value.ToString();
            tbHoten.Text = dgvDS_Nhanvien.CurrentRow.Cells[1].Value.ToString();
            tbSodienthoai.Text = dgvDS_Nhanvien.CurrentRow.Cells[2].Value.ToString();
            tbDiachi.Text = dgvDS_Nhanvien.CurrentRow.Cells[3].Value.ToString();


        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int KhachHangID = int.Parse(tbKhachHangID.Text.ToString());
                if (serv.DeleteKhachHang(KhachHangID) == 1)
                {
                    RefreshBoxInfo();
                    lblThongbao.Text = "Delete thanh cong!";
                    ShowListKH();
                }
                else
                {
                    RefreshBoxInfo();
                    lblThongbao.Text = "Delete that bai!";
                    ShowListKH();

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int KhachHangID = int.Parse(tbKhachHangID.Text.ToString());
                if (serv.UpdateKhachHang(KhachHangID, tbHoten.Text, tbSodienthoai.Text, tbDiachi.Text) == 1)
                {
                    RefreshBoxInfo();
                    lblThongbao.Text = "Update thanh cong!";
                    ShowListKH();
                }
                else
                {
                    RefreshBoxInfo();
                    lblThongbao.Text = "Update that bai!";
                    ShowListKH();

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            RefreshBoxInfo();
            lblThongbao.Text = "Hủy thành công!";
        }

        private void dgvDS_Nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
