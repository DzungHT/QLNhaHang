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
            _obj = new MonAn();
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
            _obj = new MonAn();
            txtTenmonan.Enabled = true;
            txtMota.Enabled = true;
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
            txtTenmonan.Enabled = true;
            txtMota.Enabled = true;
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
                _obj = new MonAn();
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
            if (_obj.TenMonAn == "")
            {
                lblThongbao.Text = "Vui lòng điền tên món ăn";
                lblThongbao.Visible = true;
                return;
            }
            else
            {
                lblThongbao.Visible = false;
                if (_obj.MonAnID == 0)
                {
                    if (!sv.MonAn_Insert(_obj.TenMonAn,_obj.DonViTinh,_obj.DonGia,_obj.LoaiMonAnID,_obj.SoLuongTon,_obj.TonToiThieu))
                        MessageBox.Show("Thêm thất bại.");
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    if (!sv.MonAn_Update(_obj.MonAnID,_obj.TenMonAn, _obj.DonViTinh, _obj.DonGia, _obj.LoaiMonAnID, _obj.SoLuongTon, _obj.TonToiThieu))
                        MessageBox.Show("Sửa thất bại");
                    MessageBox.Show("Sửa thành công.");
                }
            }
            _obj = new MonAn();
            this.HideText();
            this.HideButtom();
            this.LoadDS();
            this.LoadSearch();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            _obj = new MonAn();
            this.HideText();
            this.HideButtom();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            this.LoadSearch();
        }

        private void dgvDS_Timkiem_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvDS_Monan_SelectionChanged(object sender, EventArgs e)
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
            Binding bind = new Binding("Text", _obj, "MonAnID", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind1 = new Binding("Text", _obj, "TenMonAn", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind2 = new Binding("Text", _obj, "DonViTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind5 = new Binding("Text", _obj, "DonGia", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind6 = new Binding("Text", _obj, "LoaiMonAnID", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind7 = new Binding("Text", _obj, "SoLuongTon", true, DataSourceUpdateMode.OnPropertyChanged);
            txtID.DataBindings.Add(bind);
            txtTenmonan.DataBindings.Add(bind1);
            txtDonvitinh.DataBindings.Add(bind2);
            txtDongia.DataBindings.Add(bind5);
            txtLoaimonan.
            txtSoluongton.DataBindings.Add(bind7);

            Binding bind3 = new Binding("Text", _sitem, "SearchType", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding bind4 = new Binding("Text", _sitem, "SearchContent", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLoaitimkiem.DataBindings.Add(bind3);
            txtNoidungtimkiem.DataBindings.Add(bind4);
        }

        private void LoadDS()
        {
            dgvDS_Monan.DataSource = sv.DS_MonAN("", "", false);
        }
        private void LoadSearch()
        {
            dgvDS_Timkiem.DataSource = sv.DS_MonAN(_sitem.SearchType, _sitem.SearchContent, true);
        }
        private void HideText()
        {
            txtMota.Enabled = false;
            txtTenmonan.Enabled = false;
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
