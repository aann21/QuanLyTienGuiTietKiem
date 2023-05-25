namespace CaoLongAn_19607001.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGOAITE")]
    public partial class NGOAITE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGOAITE()
        {
            CHITIETs = new HashSet<CHITIET>();
            TYGIAs = new HashSet<TYGIA>();
        }

        [Key]
        [StringLength(3)]
        public string MaNgoaiTe { get; set; }

        [StringLength(20)]
        public string TenNgoaiTe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET> CHITIETs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TYGIA> TYGIAs { get; set; }
    }
}
