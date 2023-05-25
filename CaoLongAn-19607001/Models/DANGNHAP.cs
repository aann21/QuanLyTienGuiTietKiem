namespace CaoLongAn_19607001.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGNHAP")]
    public partial class DANGNHAP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STT { get; set; }

        public string Taikhoan { get; set; }

        public string Matkhau { get; set; }

        public string Ten { get; set; }

        public string Email { get; set; }
    }
}
