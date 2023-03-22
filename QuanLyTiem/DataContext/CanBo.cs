namespace QuanLyTiem.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CanBo")]
    public partial class CanBo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CanBo()
        {
            TaiKhoanCanBo = new HashSet<TaiKhoanCanBo>();
            ThucHienTiem = new HashSet<ThucHienTiem>();
            ThucHienTiem1 = new HashSet<ThucHienTiem>();
            ThucHienTiem2 = new HashSet<ThucHienTiem>();
            ThucHienTiem3 = new HashSet<ThucHienTiem>();
        }

        [Key]
        public int MaCanBo { get; set; }

        [Required]
        [StringLength(200)]
        public string TenCanBo { get; set; }

        [Required]
        [StringLength(100)]
        public string ChucVu { get; set; }

        [Required]
        [StringLength(20)]
        public string SoDTCB { get; set; }

        [Required]
        [StringLength(100)]
        public string DonViCongTac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanCanBo> TaiKhoanCanBo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucHienTiem> ThucHienTiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucHienTiem> ThucHienTiem1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucHienTiem> ThucHienTiem2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucHienTiem> ThucHienTiem3 { get; set; }
    }
}
