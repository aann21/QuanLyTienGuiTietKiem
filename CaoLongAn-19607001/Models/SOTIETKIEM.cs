namespace CaoLongAn_19607001.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SOTIETKIEM")]
    public partial class SOTIETKIEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOTIETKIEM()
        {
            CHITIETs = new HashSet<CHITIET>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoSo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLapSo { get; set; }

        [StringLength(40)]
        public string TenKhachHang { get; set; }

        [StringLength(9)]
        public string SoCMND { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET> CHITIETs { get; set; }
    }
}
