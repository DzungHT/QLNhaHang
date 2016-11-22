using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManage.Models
{
    public class DatBan
    {
        public int DatBanID { get; set; }
        public int BanAnID { get; set; }
        public DateTime NgayDatBan { get; set; }

        public DatBan()
        {

        }

        public DatBan(DataRow dr)
        {
            SetValues(dr);
        }

        public void SetValues(DataRow dr)
        {
            this.DatBanID = dr.Table.Columns.Contains("DatBanID") ? dr.Field<int>("DatBanID") : -1;
            this.BanAnID = dr.Table.Columns.Contains("BanAnID") ? dr.Field<int>("BanAnID") : -1;
            this.NgayDatBan = dr.Table.Columns.Contains("NgayDatBan") ? dr.Field<DateTime>("NgayDatBan") : new DateTime();
        }
    }
}
