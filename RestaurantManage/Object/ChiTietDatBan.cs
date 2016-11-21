namespace Object
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDatBan")]
    public partial class ChiTietDatBan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DatBanID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MonAnID { get; set; }

        public int? SoLuong { get; set; }

        public virtual DatBan DatBan { get; set; }

        public virtual MonAn MonAn { get; set; }
    }
}
