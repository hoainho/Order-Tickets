using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDatXe.Models
{
    public partial class DataAccessLayer : DbContext
    {
        public DataAccessLayer()
            : base("name=DataAccessLayer")
        {
        }

        public virtual DbSet<BenXe> BenXes { get; set; }
        public virtual DbSet<ChiTietXe> ChiTietXes { get; set; }
        public virtual DbSet<ChuyenXe> ChuyenXes { get; set; }
        public virtual DbSet<Ghe> Ghes { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiXe> LoaiXes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<VeXe> VeXes { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BenXe>()
                .HasMany(e => e.ChuyenXes)
                .WithRequired(e => e.BenXe)
                .HasForeignKey(e => e.MaBXDi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BenXe>()
                .HasMany(e => e.ChuyenXes1)
                .WithRequired(e => e.BenXe1)
                .HasForeignKey(e => e.MaBXDen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChuyenXe>()
                .Property(e => e.MaCX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChuyenXe>()
                .HasMany(e => e.VeXes)
                .WithRequired(e => e.ChuyenXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ghe>()
                .HasMany(e => e.ChiTietXes)
                .WithRequired(e => e.Ghe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.userName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiXe>()
                .HasMany(e => e.Xes)
                .WithRequired(e => e.LoaiXe)
                .HasForeignKey(e => e.Loai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.userName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.type)
                .IsFixedLength();

            modelBuilder.Entity<VeXe>()
                .Property(e => e.MaVe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VeXe>()
                .Property(e => e.MaCX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VeXe>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.VeXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.ChiTietXes)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Xe>()
                .HasMany(e => e.ChuyenXes)
                .WithRequired(e => e.Xe)
                .WillCascadeOnDelete(false);
        }
    }
}
