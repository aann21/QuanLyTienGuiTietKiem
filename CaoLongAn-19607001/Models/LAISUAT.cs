namespace CaoLongAn_19607001.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LAISUAT")]
    public partial class LAISUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LAISUAT()
        {
            CHITIETs = new HashSet<CHITIET>();
        }

        [Key]
        [StringLength(5)]
        public string MaLaiSuat { get; set; }

        [StringLength(20)]
        public string KyHan { get; set; }

        public decimal? PhanTramLaiXuat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDauApDung { get; set; }

        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET> CHITIETs { get; set; }
    }
}
