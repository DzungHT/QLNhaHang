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
    public partial class UC_Quanlymonan : UserControl
    {
        RestaurantServices.RestaurantServicesSoapClient sv = new RestaurantServices.RestaurantServicesSoapClient();
        private MonAn _obj;
        private SearchItem _sitem;
        public UC_Quanlymonan()
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
            if (_obj.MonAnID == 0)
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
            if (_obj.MonAnID == 0)
            {
                lblThongbao.Text = "Vui lòng chọn bản ghi muốn xóa";
                lblThongbao.Visible = true;
                return;
            }
            if (sv.MonAn_Delete(_obj.MonAnID))
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
            if (_obj.TenMonAn == "")
            {
                lblThongbao.Text = "Vui lòng điền tên loại món ăn";
                lblThongbao.Visible = true;
                return;
            }
            else
            {
                lblThongbao.Visible = false;
                if (txtID.Text == "0")
                {
                    if (!sv.MonAn_Insert(_obj.TenMonAn, _obj.DonViTinh, _obj.DonGia, int.Parse(txtLoaimonan.SelectedValue.ToString()), 0, "0"))
                        MessageBox.Show("Thêm thất bại.");
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    if (!sv.MonAn_Update(_obj.MonAnID,_obj.TenMonAn, _obj.DonViTinh, _obj.DonGia, int.Parse(txtLoaimonan.SelectedValue.ToString()), 0, "0"))
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
            var monanid = (int)dgvDS_Timkiem.SelectedRows[0].Cells["MonAnID"].Value;
            DataTable dt = sv.MonAn_Chitiet(monanid);
            txtID.Text = dt.Rows[0]["MonAnID"].ToString();
            txtDongia.Text = dt.Rows[0]["DonGia"].ToString();
            txtDonvitinh.Text = dt.Rows[0]["DonViTinh"].ToString();
            txtTenmonan.Text = dt.Rows[0]["TenMonAn"].ToString();
            this.Loadloaimonan();
            txtLoaimonan.SelectedValue = dt.Rows[0]["LoaiMonAnID"].ToString();
        }

        private void dgvDS_Monan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            var loaimonanid = (int)dgvDS_Monan.SelectedRows[0].Cells["MonAnID"].Value;
            DataTable dt = sv.MonAn_Chitiet(loaimonanid);
            txtID.Text = dt.Rows[0]["MonAnID"].ToString();
            txtDongia.Text = dt.Rows[0]["DonGia"].ToString();
            txtDonvitinh.Text = dt.Rows[0]["DonViTinh"].ToString();
            txtTenmonan.Text = dt.Rows[0]["TenMonAn"].ToString();
            this.Loadloaimonan();
            txtLoaimonan.SelectedValue= dt.Rows[0]["LoaiMonAnID"].ToString();

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
            _obj = new MonAn();
            Binding bind = new Binding("Text", _obj, "MonAnID", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind1 = new Binding("Text", _obj, "TenMonAn", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind5 = new Binding("Text", _obj, "DonViTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind6 = new Binding("Text", _obj, "DonGia", true, DataSourceUpdateMode.OnPropertyChanged);
            txtID.DataBindings.Add(bind);
            txtTenmonan.DataBindings.Add(bind1);
            txtDonvitinh.DataBindings.Add(bind5);
            txtDongia.DataBindings.Add(bind6);
            this.Loadloaimonan();
            Binding bind3 = new Binding("Text", _sitem, "SearchType", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind4 = new Binding("Text", _sitem, "SearchContent", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLoaitimkiem.DataBindings.Add(bind3);
            txtNoidungtimkiem.DataBindings.Add(bind4);
        }
        private void LoadDS()
        {
            dgvDS_Monan.DataSource = sv.DS_MonAn("", "", false);
        }
        private void LoadSearch()
        {
            dgvDS_Timkiem.DataSource = sv.DS_MonAn(_sitem.SearchType, _sitem.SearchContent, true);
        }
        private void HideText()
        {
            txtDongia.Enabled = false;
            txtDonvitinh.Enabled = false;
            txtTenmonan.Enabled = false;
            txtLoaimonan.Enabled = false;
        }
        private void ShowText()
        {
            txtDongia.Enabled = true;
            txtDonvitinh.Enabled = true;
            txtTenmonan.Enabled = true;
            txtLoaimonan.Enabled = true;
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
            txtDongia.Text = "";
            txtDonvitinh.Text = "";
            txtTenmonan.Text = "";
            this.Loadloaimonan();
        }
        private void Loadloaimonan()
        {
            txtLoaimonan.DataSource = sv.DS_LoaiMonAN("", "", false);
            txtLoaimonan.ValueMember = "LoaiMonAnID";
            txtLoaimonan.DisplayMember = "TenLoaiMonAn";
            txtLoaimonan.SelectedIndex = 0;
        }
        #endregion


    }
}
