﻿using System;
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
    public partial class UC_Quanlyloaimonan : UserControl
    {
        RestaurantServices.RestaurantServicesSoapClient sv = new RestaurantServices.RestaurantServicesSoapClient();
        private LoaiMonAn _lma;
        private SearchItem _sitem;
        public UC_Quanlyloaimonan()
        {
            InitializeComponent();
            _lma = new LoaiMonAn();
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
            _lma = new LoaiMonAn();
            txtTenloai.Enabled = true;
            txtMota.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_lma.LoaiMonAnID == 0)
            {
                lblThongbao.Text = "Vui lòng chọn bản ghi muốn sửa";
                lblThongbao.Visible = true;
                return;
            }
            lblThongbao.Visible = false;
            txtTenloai.Enabled = true;
            txtMota.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_lma.LoaiMonAnID == 0)
            {
                lblThongbao.Text = "Vui lòng chọn bản ghi muốn xóa";
                lblThongbao.Visible = true;
                return;
            }
            if (sv.LoaiMonAn_Delete(_lma.LoaiMonAnID))
            {
                MessageBox.Show("Xóa thành công!");
                _lma = new LoaiMonAn();
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
            if (_lma.TenLoaiMonAN == "")
            {
                lblThongbao.Text = "Vui lòng điền tên loại món ăn";
                lblThongbao.Visible = true;
                return;
            }
            else
            {
                lblThongbao.Visible = false;
                if (_lma.LoaiMonAnID == 0)
                {
                    if (!sv.LoaiMonAn_Insert(_lma.TenLoaiMonAN, _lma.MoTa))
                        MessageBox.Show("Thêm thất bại.");
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    if (!sv.LoaiMonAn_Update(_lma.LoaiMonAnID, _lma.TenLoaiMonAN, _lma.MoTa))
                        MessageBox.Show("Sửa thất bại");
                    MessageBox.Show("Sửa thành công.");
                }
            }
            _lma = new LoaiMonAn();
            this.HideText();
            this.HideButtom();
            this.LoadDS();
            this.LoadSearch();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _lma = new LoaiMonAn();
            this.HideText();
            this.HideButtom();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            this.LoadSearch();
        }

        private void dgvDS_Loaimonan_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvDS_Timkiem_SelectionChanged(object sender, EventArgs e)
        {

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
            Binding bind = new Binding("Text", _lma, "TenLoaiMonAn", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind1 = new Binding("Text", _lma,"LoaiMonAnID", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind2 = new Binding("Text", _lma, "MoTa", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenloai.DataBindings.Add(bind);
            txtID.DataBindings.Add(bind1);
            txtMota.DataBindings.Add(bind2);

            Binding bind3= new Binding("Text", _sitem, "SearchType", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind4 = new Binding("Text", _sitem, "SearchContent", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLoaitimkiem.DataBindings.Add(bind3);
            txtNoidungtimkiem.DataBindings.Add(bind4);
        }

        private void LoadDS()
        {
            dgvDS_Loaimonan.DataSource = sv.DS_LoaiMonAN("", "", false);
        }
        private void LoadSearch()
        {
            dgvDS_Timkiem.DataSource = sv.DS_LoaiMonAN(_sitem.SearchType, _sitem.SearchContent, true);
        }
        private void HideText()
        {
            txtMota.Enabled = false;
            txtTenloai.Enabled = false;
        }
        private void HideButtom()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        #endregion
    }
}
