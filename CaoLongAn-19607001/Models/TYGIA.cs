namespace CaoLongAn_19607001.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TYGIA")]
    public partial class TYGIA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string MaNgoaiTe { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NgayBatDauApDung { get; set; }

        public int? QuyRaVND { get; set; }

        public string GhiChu { get; set; }

        public virtual NGOAITE NGOAITE { get; set; }
    }
}
