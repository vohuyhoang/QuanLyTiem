namespace QuanLyTiem.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichTiemChung")]
    public partial class LichTiemChung
    {
        [Key]
        public int MaTiem { get; set; }

        public DateTime NgayTiem { get; set; }

        public int SoMui { get; set; }

        [Required]
        [StringLength(10)]
        public string MaVaccine { get; set; }

        public int MaThucHienTiem { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKHT { get; set; }

        public int SoCCCD { get; set; }

        public virtual DoiTuongTiem DoiTuongTiem { get; set; }

        public virtual KeHoachTiem KeHoachTiem { get; set; }

        public virtual ThucHienTiem ThucHienTiem { get; set; }

        public virtual Vaccine Vaccine { get; set; }
    }
}
