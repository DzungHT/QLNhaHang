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
        BanAn _currBa;
        public UC_BanHang()
        {
            InitializeComponent();
            _lstBanAn = new List<BanAn>();
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
                item.Text = ba.TenBan + " ("+ba.TenTrangThai+")";
                item.SubItems.Add(ba.BanAnID.ToString());
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
    }
}
