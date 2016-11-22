using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManage.RestaurantServices;
using RestaurantManage.Models;

namespace RestaurantManage.UC_View
{
    public partial class UC_BanHang : UserControl
    {
        List<BanAn> _lstBanAn;
        List<MonAn> _lstMonAn;
        List<ChiTietDatBan> _lstChiTiet;
        BanAn _SelectedBanAn;
        MonAn _SelectedMonAn;
        DatBan _CurrDatBan;
        int _TongTien;

        public int NhanVienID { get; set; }

        public UC_BanHang()
        {
            InitializeComponent();
            _lstBanAn = new List<BanAn>();
            _lstMonAn = new List<MonAn>();
            _SelectedMonAn = new MonAn();
            _SelectedBanAn = new BanAn();
            _CurrDatBan = new DatBan();
        }

        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            RestaurantServicesSoapClient serv = new RestaurantServicesSoapClient();
            var dtBanAn = serv.Lay_BanAn(-1, -1);
            var dtKhuVuc = serv.Lay_KhuVuc();
            var dtTrangThaiBanAn = serv.Lay_TrangThaiBanAn();
            var dtLoaiMonAn = serv.Lay_LoaiMonAn();
            LoadBanAn(dtBanAn);
            LoadKhuVuc(dtKhuVuc);
            LoadTrangThaiBanAn(dtTrangThaiBanAn);
            LoadLoaiMonAn(dtLoaiMonAn);
            this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_cboTrangThaiBanAn_SelectedIndexChanged);
            this.cboTrangThaiBanAn.SelectedIndexChanged += new System.EventHandler(this.cboKhuVuc_cboTrangThaiBanAn_SelectedIndexChanged);
            this.cboLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cboLoaiMonAn_SelectedIndexChanged);

            // Load grdMonAn
            var dtMonAn = serv.Lay_MonAn(-1);
            grdMonAn.AutoGenerateColumns = false;
            grdMonAn.DataSource = dtMonAn;
            foreach (DataRow dr in dtMonAn.Rows)
            {
                _lstMonAn.Add(new MonAn(dr));
            }

            this.Cursor = Cursors.Default;
        }

        private void LoadBanAn(DataTable dt)
        {
            listViewBanAn.Items.Clear();
            _lstBanAn.Clear();
            BanAn ba;
            foreach (DataRow dr in dt.Rows)
            {
                ba = new BanAn(dr);
                _lstBanAn.Add(ba);
                ListViewItem item = new ListViewItem();
                item.Text = ba.TenBan + " (" + ba.TenTrangThai + ")";
                item.Name = ba.BanAnID.ToString();
                item.ImageIndex = ba.TrangThaiID == 0 ? 0 : 1;
                item.ForeColor = ba.TrangThaiID == 0 ? Color.Black : Color.Red;
                listViewBanAn.Items.Add(item);
            }

        }
        private void LoadKhuVuc(DataTable dt)
        {
            cboKhuVuc.DataSource = dt;
            cboKhuVuc.ValueMember = "KhuVucID";
            cboKhuVuc.DisplayMember = "TenKhuVuc";
        }
        private void LoadTrangThaiBanAn(DataTable dt)
        {
            cboTrangThaiBanAn.DataSource = dt;
            cboTrangThaiBanAn.ValueMember = "TrangThaiID";
            cboTrangThaiBanAn.DisplayMember = "TenTrangThai";
        }
        private void LoadLoaiMonAn(DataTable dt)
        {
            cboLoaiMonAn.DataSource = dt;
            cboLoaiMonAn.ValueMember = "LoaiMonAnID";
            cboLoaiMonAn.DisplayMember = "TenLoaiMonAn";
        }
        private void cboKhuVuc_cboTrangThaiBanAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantServicesSoapClient serv = new RestaurantServicesSoapClient();
            var dtBanAn = serv.Lay_BanAn((int)cboKhuVuc.SelectedValue, (int)cboTrangThaiBanAn.SelectedValue);
            LoadBanAn(dtBanAn);
        }

        private void cboLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurantServicesSoapClient serv = new RestaurantServicesSoapClient();
            var dtMonAn = serv.Lay_MonAn((int)cboLoaiMonAn.SelectedValue);
            grdMonAn.DataSource = dtMonAn;
        }

        private void grdMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var monAnID = (int)grdMonAn.SelectedRows[0].Cells[0].Value;
            this._SelectedMonAn = _lstMonAn.Find(x => x.MonAnID == monAnID);
            lblTenMonAn.Text = _SelectedMonAn.TenMonAn;
            lblDonViTinh.Text = _SelectedMonAn.DonViTinh;
            lblDonGia.Text = _SelectedMonAn.DonGia.ToString("#,#") + " VND";
            numSoLuong.Value = 1;
        }

        private void listViewBanAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewMonAnDaGoi.Items.Clear();
            lblTongTien.Text = lblTongTien.Tag.ToString();
            lblTenBan.Text = lblTenBan.Tag.ToString();
            lblTenKhuVuc.Text = lblTenKhuVuc.Tag.ToString();
            lblThoiGianDatBan.Text = lblThoiGianDatBan.Tag.ToString();
            _SelectedBanAn = null;
            _CurrDatBan = null;
            if (listViewBanAn.SelectedItems.Count > 0)
            {
                var banAnID = int.Parse(listViewBanAn.SelectedItems[0].Name);
                this._SelectedBanAn = _lstBanAn.Find(x => x.BanAnID == banAnID);
                lblTenBan.Text = _SelectedBanAn.TenBan;
                lblTenKhuVuc.Text = _SelectedBanAn.TenKhuVuc;
                if (this._SelectedBanAn.TrangThaiID == 1)
                {
                    RestaurantServicesSoapClient serv = new RestaurantServicesSoapClient();
                    var ds = serv.Lay_DanhSachDatBan(banAnID);
                    _CurrDatBan = new DatBan(ds.Tables[0].Rows[0]);
                    lblThoiGianDatBan.Text = _CurrDatBan.NgayDatBan.ToString();
                    _lstChiTiet = new List<ChiTietDatBan>();
                    foreach (DataRow dr in ds.Tables[1].Rows)
                    {
                        var ct = new ChiTietDatBan(dr);
                        _lstChiTiet.Add(ct);
                        ListViewItem item = new ListViewItem();
                        item.Text = ct.TenMonAn;
                        item.SubItems.Add(ct.DonGia.ToString("#,#"));
                        item.SubItems.Add(ct.SoLuong.ToString());
                        item.SubItems.Add((ct.SoLuong * ct.DonGia).ToString("#,#"));
                        listViewMonAnDaGoi.Items.Add(item);
                    }
                    _TongTien = 0;
                    _lstChiTiet.ForEach(x =>
                    {
                        _TongTien += x.DonGia * x.SoLuong;
                    });
                    _TongTien *= 1000;
                    lblTongTien.Text = _TongTien.ToString("#,#");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_SelectedBanAn == null)
            {
                MessageBox.Show("Chưa chọn bàn!");
                return;
            }
            if(_SelectedMonAn == null)
            {
                MessageBox.Show("Chưa chọn món ăn!");
                return;
            }
            RestaurantServicesSoapClient serv = new RestaurantServicesSoapClient();
            var dt = serv.GoiMon(_SelectedBanAn.BanAnID, _SelectedMonAn.MonAnID, (int)numSoLuong.Value);

            if(dt.Rows[0].Field<int>(0) == -1)
            {
                MessageBox.Show(dt.Rows[0].Field<string>(1),"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gọi món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBanAn(serv.Lay_BanAn((int)cboKhuVuc.SelectedValue, (int)cboTrangThaiBanAn.SelectedValue));
                listViewBanAn.SelectedIndices.Clear();
                var x = listViewBanAn.Items.Find(_SelectedBanAn.BanAnID.ToString(), false);
                listViewBanAn.Items[x[0].Index].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_CurrDatBan == null)
            {
                MessageBox.Show("Chưa chọn bàn hoặc bàn trống!");
                return;
            }
            RestaurantServicesSoapClient serv = new RestaurantServicesSoapClient();
            var dt = serv.ThanhToan(_CurrDatBan.DatBanID, NhanVienID, null);

            if (dt.Rows[0].Field<int>(0) == -1)
            {
                MessageBox.Show(dt.Rows[0].Field<string>(1), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBanAn(serv.Lay_BanAn((int)cboKhuVuc.SelectedValue, (int)cboTrangThaiBanAn.SelectedValue));
                listViewBanAn.SelectedIndices.Clear();
                var x = listViewBanAn.Items.Find(_SelectedBanAn.BanAnID.ToString(), false);
                listViewBanAn.Items[x[0].Index].Selected = true;
            }
        }
    }
}
