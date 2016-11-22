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
    public partial class UC_Quanlyloaimonan : UserControl
    {
        RestaurantServices.RestaurantServicesSoapClient sv = new RestaurantServices.RestaurantServicesSoapClient();
        private LoaiMonAn _obj;
        private SearchItem _sitem;
        public UC_Quanlyloaimonan()
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
            txtTenloai.Enabled = true;
            txtMota.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_obj.LoaiMonAnID == 0)
            {
                lblThongbao.Text = "Vui lòng chọn bản ghi muốn sửa";
                lblThongbao.Visible = true;
                return;
            }
            lblThongbao.Visible = false;
            btnLuu.Enabled = true;
            txtTenloai.Enabled = true;
            txtMota.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_obj.LoaiMonAnID == 0)
            {
                lblThongbao.Text = "Vui lòng chọn bản ghi muốn xóa";
                lblThongbao.Visible = true;
                return;
            }
            if (sv.LoaiMonAn_Delete(_obj.LoaiMonAnID))
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
            if (_obj.TenLoaiMonAN == "")
            {
                lblThongbao.Text = "Vui lòng điền tên loại món ăn";
                lblThongbao.Visible = true;
                return;
            }
            else
            {
                lblThongbao.Visible = false;
                if (_obj.LoaiMonAnID == 0)
                {
                    if (!sv.LoaiMonAn_Insert(_obj.TenLoaiMonAN, _obj.MoTa))
                        MessageBox.Show("Thêm thất bại.");
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    if (!sv.LoaiMonAn_Update(_obj.LoaiMonAnID, _obj.TenLoaiMonAN, _obj.MoTa))
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
            var loaimonanid = (int)dgvDS_Timkiem.SelectedRows[0].Cells["LoaiMonAnID"].Value;
            DataTable dt = sv.LoaiMonAn_Chitiet(loaimonanid);
            txtID.Text = dt.Rows[0]["LoaiMonAnID"].ToString();
            txtTenloai.Text = dt.Rows[0]["TenLoaiMonAn"].ToString();
            txtMota.Text = dt.Rows[0]["MoTa"].ToString();
        }

        private void dgvDS_Loaimonan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            var loaimonanid = (int)dgvDS_Loaimonan.SelectedRows[0].Cells["LoaiMonAnID"].Value;
            DataTable dt= sv.LoaiMonAn_Chitiet(loaimonanid);
            txtID.Text = dt.Rows[0]["LoaiMonAnID"].ToString();
            txtTenloai.Text= dt.Rows[0]["TenLoaiMonAn"].ToString();
            txtMota.Text= dt.Rows[0]["MoTa"].ToString();
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
            _obj = new LoaiMonAn();
            Binding bind = new Binding("Text", _obj, "TenLoaiMonAn", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind1 = new Binding("Text", _obj,"LoaiMonAnID", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind2 = new Binding("Text", _obj, "MoTa", true, DataSourceUpdateMode.OnPropertyChanged);
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
        private void RefreshForm()
        {
            txtID.Text = "0";
            txtMota.Text = "";
            txtTenloai.Text = "";
        }
        #endregion


    }
}
