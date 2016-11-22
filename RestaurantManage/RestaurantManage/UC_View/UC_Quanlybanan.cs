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
    public partial class UC_Quanlybanan : UserControl
    {
        RestaurantServices.RestaurantServicesSoapClient sv = new RestaurantServices.RestaurantServicesSoapClient();
        private SearchItem _sitem;
        public UC_Quanlybanan()
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
            this.ShowText();
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
            btnHuy.Enabled = true;
            this.ShowText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text=="0")
            {
                lblThongbao.Text = "Vui lòng chọn bản ghi muốn xóa";
                lblThongbao.Visible = true;
                return;
            }
            if (sv.KhuVuc_Delete(int.Parse(txtID.Text)))
            {
                MessageBox.Show("Xóa thành công!");
                this.HideText();
                this.RefreshForm();
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
            if (txtTenban.Text=="0")
            {
                lblThongbao.Text = "Vui lòng điền tên tên bàn";
                lblThongbao.Visible = true;
                return;
            }
            else
            {
                lblThongbao.Visible = false;
                if (txtID.Text == "0")
                {
                    if (!sv.BanAn_Insert(txtTenban.Text,int.Parse(txtKhuvuc.SelectedValue.ToString()),0,int.Parse(txtSonguoi.Text)))
                        MessageBox.Show("Thêm thất bại.");
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    if (!sv.BanAn_Update(int.Parse(txtID.Text),txtTenban.Text, int.Parse(txtKhuvuc.SelectedValue.ToString()), 0, int.Parse(txtSonguoi.Text)))
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
            var loaimonanid = (int)dgvDS_Banan.SelectedRows[0].Cells["BanAnID"].Value;
            DataTable dt = sv.BanAn_Chitiet(loaimonanid);
            txtID.Text = dt.Rows[0]["BanAnID"].ToString();
            txtTenban.Text = dt.Rows[0]["TenBan"].ToString();
            txtSonguoi.Text = dt.Rows[0]["SoNguoi"].ToString();
            this.Loadkhuvuc();
            txtKhuvuc.SelectedValue = dt.Rows[0]["KhuVucID"].ToString();
        }

        private void dgvDS_Banan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            var loaimonanid = (int)dgvDS_Banan.SelectedRows[0].Cells["BanAnID"].Value;
            DataTable dt = sv.BanAn_Chitiet(loaimonanid);
            txtID.Text = dt.Rows[0]["BanAnID"].ToString();
            txtTenban.Text = dt.Rows[0]["TenBan"].ToString();
            txtSonguoi.Text = dt.Rows[0]["SoNguoi"].ToString();
            this.Loadkhuvuc();
            txtKhuvuc.SelectedValue = dt.Rows[0]["KhuVucID"].ToString();

        }
        #region Hàm hỗ trợ
        private void ShowTimkiem()
        {
            panelTimkiem.Visible = true;
        }
        private void HideTimkiem()
        {
            panelTimkiem.Visible = false;
        }
        private void InitDataBinding()
        {
            Binding bind3 = new Binding("Text", _sitem, "SearchType", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind4 = new Binding("Text", _sitem, "SearchContent", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLoaitimkiem.DataBindings.Add(bind3);
            txtNoidungtimkiem.DataBindings.Add(bind4);
        }
        private void LoadDS()
        {
            dgvDS_Banan.DataSource = sv.DS_BanAn("", "", false);
        }
        private void LoadSearch()
        {
            dgvDS_Timkiem.DataSource = sv.DS_KhuVuc(_sitem.SearchType, _sitem.SearchContent, true);
        }
        private void HideText()
        {
            txtTenban.Enabled = false;
            txtSonguoi.Enabled = false;
            txtKhuvuc.Enabled = false;
        }
        private void ShowText()
        {
            txtTenban.Enabled = true;
            txtSonguoi.Enabled = true;
            txtKhuvuc.Enabled = true;
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
            txtSonguoi.Text = "";
            txtTenban.Text = "";
            this.Loadkhuvuc();
        }
        private void Loadkhuvuc()
        {
            txtKhuvuc.DataSource = sv.DS_KhuVuc("", "", false);
            txtKhuvuc.ValueMember = "KhuVucID";
            txtKhuvuc.DisplayMember = "TenKhuVuc";
            txtKhuvuc.SelectedIndex = 0;
        }
        #endregion
    }
}
