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
    public partial class UC_Quanlykhuvuc : UserControl
    {
        RestaurantServices.RestaurantServicesSoapClient sv = new RestaurantServices.RestaurantServicesSoapClient();
        private SearchItem _sitem;
        public UC_Quanlykhuvuc()
        {
            InitializeComponent();
            _sitem = new SearchItem();
            this.LoadDS();
            InitDataBinding();
        }

        private void btnHientimkiem_Click(object sender, EventArgs e)
        {
            this.ShowTimkiem();
        }

        private void btnAntimkiem_Click(object sender, EventArgs e)
        {
            this.HideTimkiem();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.RefreshForm();
            txtTenKhuVuc.Enabled = true;
            txtMota.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text=="0")
            {
                lblThongbao.Text = "Vui lòng chọn bản ghi muốn sửa";
                lblThongbao.Visible = true;
                return;
            }
            lblThongbao.Visible = false;
            btnLuu.Enabled = true;
            txtTenKhuVuc.Enabled = true;
            txtMota.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "0")
            {
                lblThongbao.Text = "Vui lòng chọn bản ghi muốn xóa";
                lblThongbao.Visible = true;
                return;
            }
            if (sv.KhuVuc_Delete(int.Parse(txtID.Text.ToString())))
            {
                MessageBox.Show("Xóa thành công!");
                this.HideText();
                this.LoadDS();
                this.LoadSearch();
                this.HideButtom();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKhuVuc.Text == "")
            {
                lblThongbao.Text = "Vui lòng điền tên loại món ăn";
                lblThongbao.Visible = true;
                return;
            }
            else
            {
                lblThongbao.Visible = false;
                if (txtID.Text=="0")
                {
                    if (!sv.KhuVuc_Insert(txtTenKhuVuc.Text,txtMota.Text))
                        MessageBox.Show("Thêm thất bại.");
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    if (!sv.KhuVuc_Update(int.Parse(txtID.Text), txtTenKhuVuc.Text, txtMota.Text))
                        MessageBox.Show("Sửa thất bại");
                    MessageBox.Show("Sửa thành công.");
                }
            }
            this.RefreshForm();
            this.HideText();
            this.HideButtom();
            this.LoadDS();
            this.LoadSearch();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.RefreshForm();
            this.HideText();
            this.HideButtom();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            this.LoadSearch();
        }

        private void dgvDS_Timkiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            var loaimonanid = (int)dgvDS_KhuVuc.SelectedRows[0].Cells["KhuVucID"].Value;
            DataTable dt = sv.KhuVuc_Chitiet(loaimonanid);
            txtID.Text = dt.Rows[0]["KhuVucID"].ToString();
            txtTenKhuVuc.Text = dt.Rows[0]["TenKhuVuc"].ToString();
            txtMota.Text = dt.Rows[0]["MoTa"].ToString();
        }

        private void dgvDS_KhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            var loaimonanid = (int)dgvDS_KhuVuc.SelectedRows[0].Cells["KhuVucID"].Value;
            DataTable dt = sv.KhuVuc_Chitiet(loaimonanid);
            txtID.Text = dt.Rows[0]["KhuVucID"].ToString();
            txtTenKhuVuc.Text = dt.Rows[0]["TenKhuVuc"].ToString();
            txtMota.Text = dt.Rows[0]["MoTa"].ToString();
        }
        #region Hàm hỗ trợ
        private void InitDataBinding()
        {
            Binding bind3 = new Binding("Text", _sitem, "SearchType", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind4 = new Binding("Text", _sitem, "SearchContent", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLoaitimkiem.DataBindings.Add(bind3);
            txtNoidungtimkiem.DataBindings.Add(bind4);
        }
        private void ShowTimkiem()
        {
            panelTimkiem.Visible = true;
        }
        private void HideTimkiem()
        {
            panelTimkiem.Visible = false;
        }
        private void LoadDS()
        {
            dgvDS_KhuVuc.DataSource = sv.DS_KhuVuc("", "", false);
        }
        private void LoadSearch()
        {
            dgvDS_Timkiem.DataSource = sv.DS_KhuVuc(_sitem.SearchType, _sitem.SearchContent, true);
        }
        private void HideText()
        {
            txtMota.Enabled = false;
            txtTenKhuVuc.Enabled = false;
        }
        private void HideButtom()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void RefreshForm()
        {
            txtID.Text = "0";
            txtMota.Text = "";
            txtTenKhuVuc.Text = "";
        }
        #endregion
    }
}
