namespace QuanLyTiem.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KeHoachTiem")]
    public partial class KeHoachTiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KeHoachTiem()
        {
            ChiTietKeHoachTiem = new HashSet<ChiTietKeHoachTiem>();
            LichTiemChung = new HashSet<LichTiemChung>();
        }

        [Key]
        [StringLength(10)]
        public string MaKHT { get; set; }

        [Required]
        [StringLength(200)]
        public string TenKHT { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDot { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDonViTiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKeHoachTiem> ChiTietKeHoachTiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichTiemChung> LichTiemChung { get; set; }
    }
}
