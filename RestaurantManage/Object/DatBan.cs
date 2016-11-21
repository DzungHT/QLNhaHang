namespace Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatBan")]
    public partial class DatBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatBan()
        {
            ChiTietDatBans = new HashSet<ChiTietDatBan>();
        }

        public int DatBanID { get; set; }

        public int? BanAnID { get; set; }

        public DateTime? NgayDatBan { get; set; }

        public virtual BanAn BanAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDatBan> ChiTietDatBans { get; set; }
    }
}
