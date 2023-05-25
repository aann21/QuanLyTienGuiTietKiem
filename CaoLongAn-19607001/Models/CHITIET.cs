namespace CaoLongAn_19607001.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIET")]
    public partial class CHITIET
    {
        public int SoSo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STTLanGiaoDich { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGiaoDich { get; set; }

        public int? SoTienGiaoDich { get; set; }

        [StringLength(5)]
        public string MaLaiSuat { get; set; }

        [StringLength(3)]
        public string MaNgoaiTe { get; set; }

        public virtual LAISUAT LAISUAT { get; set; }

        public virtual NGOAITE NGOAITE { get; set; }

        public virtual SOTIETKIEM SOTIETKIEM { get; set; }
    }
}
