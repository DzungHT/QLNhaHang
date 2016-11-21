namespace Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonAn")]
    public partial class MonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonAn()
        {
            ChiTietDatBans = new HashSet<ChiTietDatBan>();
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MonanID { get; set; }

        [StringLength(50)]
        public string TenMonAn { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public int? DonGia { get; set; }

        public int? LoaiMonAnID { get; set; }

        public int? SoLuongTon { get; set; }

        [StringLength(10)]
        public string TonToiThieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDatBan> ChiTietDatBans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual LoaiMonAn LoaiMonAn { get; set; }
    }
}
