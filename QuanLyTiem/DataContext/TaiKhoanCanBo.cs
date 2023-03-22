namespace QuanLyTiem.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanCanBo")]
    public partial class TaiKhoanCanBo
    {
        [Key]
        [StringLength(20)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(30)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailCanBo { get; set; }

        public int MaCanBo { get; set; }

        public virtual CanBo CanBo { get; set; }
    }
}
