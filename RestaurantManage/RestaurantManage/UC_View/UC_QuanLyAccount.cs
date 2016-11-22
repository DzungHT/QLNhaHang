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
    public partial class UC_QuanLyAccount : UserControl
    {
        private RestaurantServices.RestaurantServicesSoapClient serv = new RestaurantServices.RestaurantServicesSoapClient();
        private DataTable dtNV;
        private DataTable dtAcc;
        public UC_QuanLyAccount()
        {
            InitializeComponent();
            dtNV= serv.GetAllNhanVien();
            dtAcc = serv.GetAllAccount();
            ShowListAcc();
            cboNhanVien.Items.Clear();
            foreach(DataRow dr in dtNV.Rows)
            {
                cboNhanVien.Items.Add(dr["Hoten"]);
            }
            cboNhanVien.SelectedItem = cboNhanVien.Items[0];
        }
        private void ShowListAcc()
        {
            try
            {
                dgvDS_Nhanvien.DataSource = dtAcc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string HoTen = cboNhanVien.SelectedItem.ToString();
            int NhanVienID = 0;
            foreach(DataRow dr in dtNV.Rows)
            {
                if (HoTen.Equals(dr["HoTen"]))
                {
                    NhanVienID = (int)dr["NhanVienID"];

                }
            }
            foreach (DataRow dr in dtAcc.Rows)
            {
                if (NhanVienID == (int)dr["NhanVienID"])
                {
                    NhanVienID = (int)dr["NhanVienID"];
                    lblThongbao.Text = "Nhân viên đã có tài khoản! Không thể đăng ký!";
                    return;
                }
            }

            int a = serv.InsertAccount(tbUsername.Text, tbPassword.Text, NhanVienID);
            RefreshBoxInfo();
            lblThongbao.Text = "Thêm Account thành công!";
        }

        private void dgvDS_Nhanvien_SelectionChanged(object sender, EventArgs e)
        {
            tbUsername.Text = dgvDS_Nhanvien.CurrentRow.Cells[0].Value.ToString();
            tbPassword.Text = dgvDS_Nhanvien.CurrentRow.Cells[1].Value.ToString();
            //string HoTen = "";
            //foreach (DataRow dr in dtNV.Rows)
            //{
            //    if (dgvDS_Nhanvien.CurrentRow.Cells[2].Value.ToString().Equals(dr["NhanVienID"]))
            //    {
            //        HoTen = dr["HoTen"].ToString();

            //    }
            //}
            //cboNhanVien.SelectedItem = HoTen;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (serv.DeleteAccount(tbUsername.Text.ToString()) == 1)
                {
                    RefreshBoxInfo();
                    lblThongbao.Text = "Delete thanh cong!";
                    ShowListAcc();
                }
                else
                {
                    RefreshBoxInfo();
                    lblThongbao.Text = "Delete that bai!";
                    ShowListAcc();

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
        private void RefreshBoxInfo()
        {
            tbPassword.Text = "";
            tbUsername.Text = "";
            lblThongbao.Text = "";
        }
    }
}
