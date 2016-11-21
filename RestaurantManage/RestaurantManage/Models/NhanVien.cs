using System;
using System.Collections.Generic;

namespace RestaurantManage.Models
{
   
    public partial class NhanVien
    {
        public NhanVien()
        {
        }

        public int NhanVienID { get; set; }

        public string HoTen { get; set; }

        public string SDT { get; set; }

        public string DiaChi { get; set; }

        public string Email { get; set; }

    }
}
