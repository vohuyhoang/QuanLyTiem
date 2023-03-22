using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyTiem.DataContext
{
    public partial class ModelQuanLyTiem : DbContext
    {
        public ModelQuanLyTiem()
            : base("name=ModelQuanLyTiem")
        {
        }

        public virtual DbSet<CanBo> CanBo { get; set; }
        public virtual DbSet<ChiTietKeHoachTiem> ChiTietKeHoachTiem { get; set; }
        public virtual DbSet<DoiTuongTiem> DoiTuongTiem { get; set; }
        public virtual DbSet<DoiTuongUuTien> DoiTuongUuTien { get; set; }
        public virtual DbSet<KeHoachTiem> KeHoachTiem { get; set; }
        public virtual DbSet<LichTiemChung> LichTiemChung { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoanCanBo> TaiKhoanCanBo { get; set; }
        public virtual DbSet<ThucHienTiem> ThucHienTiem { get; set; }
        public virtual DbSet<Vaccine> Vaccine { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CanBo>()
                .HasMany(e => e.TaiKhoanCanBo)
                .WithRequired(e => e.CanBo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CanBo>()
                .HasMany(e => e.ThucHienTiem)
                .WithOptional(e => e.CanBo)
                .HasForeignKey(e => e.MaCanBo_Kham);

            modelBuilder.Entity<CanBo>()
                .HasMany(e => e.ThucHienTiem1)
                .WithOptional(e => e.CanBo1)
                .HasForeignKey(e => e.MaCanBo_Tiem);

            modelBuilder.Entity<CanBo>()
                .HasMany(e => e.ThucHienTiem2)
                .WithOptional(e => e.CanBo2)
                .HasForeignKey(e => e.MaCanBo_TiepDon);

            modelBuilder.Entity<CanBo>()
                .HasMany(e => e.ThucHienTiem3)
                .WithOptional(e => e.CanBo3)
                .HasForeignKey(e => e.MaCanBo_TheoDoi);

            modelBuilder.Entity<DoiTuongTiem>()
                .HasMany(e => e.LichTiemChung)
                .WithRequired(e => e.DoiTuongTiem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoiTuongUuTien>()
                .HasMany(e => e.ChiTietKeHoachTiem)
                .WithRequired(e => e.DoiTuongUuTien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KeHoachTiem>()
                .HasMany(e => e.ChiTietKeHoachTiem)
                .WithRequired(e => e.KeHoachTiem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KeHoachTiem>()
                .HasMany(e => e.LichTiemChung)
                .WithRequired(e => e.KeHoachTiem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThucHienTiem>()
                .HasMany(e => e.LichTiemChung)
                .WithRequired(e => e.ThucHienTiem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vaccine>()
                .HasMany(e => e.LichTiemChung)
                .WithRequired(e => e.Vaccine)
                .WillCascadeOnDelete(false);
        }
    }
}
