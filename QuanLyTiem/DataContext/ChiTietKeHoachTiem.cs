namespace QuanLyTiem.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietKeHoachTiem")]
    public partial class ChiTietKeHoachTiem
    {
        [Key]
        public int MaCTKHT { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKHT { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDoiTuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKT { get; set; }

        public virtual DoiTuongUuTien DoiTuongUuTien { get; set; }

        public virtual KeHoachTiem KeHoachTiem { get; set; }
    }
}
