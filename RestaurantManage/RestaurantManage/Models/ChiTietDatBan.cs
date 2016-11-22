using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManage.Models
{
    public class ChiTietDatBan
    {
        public int DatBanID { get; set; }
        public int MonAnID { get; set; }
        public int SoLuong { get; set; }
        public string TenMonAn { get; set; }
        public int DonGia { get; set; }

        public ChiTietDatBan()
        {

        }

        public ChiTietDatBan(DataRow dr)
        {
            SetValues(dr);
        }

        public void SetValues(DataRow dr)
        {
            this.DatBanID = dr.Table.Columns.Contains("DatBanID") ? dr.Field<int>("DatBanID") : -1;
            this.MonAnID = dr.Table.Columns.Contains("MonAnID") ? dr.Field<int>("MonAnID") : -1;
            this.SoLuong = dr.Table.Columns.Contains("SoLuong") ? dr.Field<int>("SoLuong") : -1;
            this.DonGia = dr.Table.Columns.Contains("DonGia") ? dr.Field<int>("DonGia") : -1;
            this.TenMonAn = dr.Table.Columns.Contains("TenMonAn") ? dr.Field<string>("TenMonAn") : null;
        }
    }
}
