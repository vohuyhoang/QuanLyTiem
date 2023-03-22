namespace QuanLyTiem.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoiTuongUuTien")]
    public partial class DoiTuongUuTien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoiTuongUuTien()
        {
            ChiTietKeHoachTiem = new HashSet<ChiTietKeHoachTiem>();
            DoiTuongTiem = new HashSet<DoiTuongTiem>();
        }

        [Key]
        [StringLength(10)]
        public string MaDoiTuong { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDoiTuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKeHoachTiem> ChiTietKeHoachTiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoiTuongTiem> DoiTuongTiem { get; set; }
    }
}
