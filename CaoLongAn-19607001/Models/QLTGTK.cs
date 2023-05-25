using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CaoLongAn_19607001.Models
{
    public partial class QLTGTK : DbContext
    {
        public QLTGTK()
            : base("name=QLTGTK")
        {
        }

        public virtual DbSet<CHITIET> CHITIETs { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public virtual DbSet<LAISUAT> LAISUATs { get; set; }
        public virtual DbSet<NGOAITE> NGOAITEs { get; set; }
        public virtual DbSet<SOTIETKIEM> SOTIETKIEMs { get; set; }
        public virtual DbSet<TYGIA> TYGIAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIET>()
                .Property(e => e.MaLaiSuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIET>()
                .Property(e => e.MaNgoaiTe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.Taikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.Matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<LAISUAT>()
                .Property(e => e.MaLaiSuat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LAISUAT>()
                .Property(e => e.PhanTramLaiXuat)
                .HasPrecision(5, 0);

            modelBuilder.Entity<NGOAITE>()
                .Property(e => e.MaNgoaiTe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGOAITE>()
                .HasMany(e => e.TYGIAs)
                .WithRequired(e => e.NGOAITE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOTIETKIEM>()
                .Property(e => e.SoCMND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SOTIETKIEM>()
                .HasMany(e => e.CHITIETs)
                .WithRequired(e => e.SOTIETKIEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TYGIA>()
                .Property(e => e.MaNgoaiTe)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
