namespace QuanLyTiem.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vaccine")]
    public partial class Vaccine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vaccine()
        {
            LichTiemChung = new HashSet<LichTiemChung>();
        }

        [Key]
        [StringLength(10)]
        public string MaVaccine { get; set; }

        [Required]
        [StringLength(100)]
        public string TenVaccine { get; set; }

        public int SoMuiPhaiTiem { get; set; }

        public int KhoangCachTiem { get; set; }

        public int DoTuoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichTiemChung> LichTiemChung { get; set; }
    }
}
