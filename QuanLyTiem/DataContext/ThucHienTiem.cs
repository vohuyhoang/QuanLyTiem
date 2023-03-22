namespace QuanLyTiem.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThucHienTiem")]
    public partial class ThucHienTiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThucHienTiem()
        {
            LichTiemChung = new HashSet<LichTiemChung>();
        }

        [Key]
        public int MaThucHienTiem { get; set; }

        public int? MaCanBo_TiepDon { get; set; }

        [StringLength(50)]
        public string KetQuaTiepDon { get; set; }

        public int? MaCanBo_Kham { get; set; }

        [StringLength(50)]
        public string KetQuaKham { get; set; }

        public string GhiChuKham { get; set; }

        public int? MaCanBo_Tiem { get; set; }

        [StringLength(50)]
        public string KetQuaTiem { get; set; }

        public int? MaCanBo_TheoDoi { get; set; }

        [StringLength(50)]
        public string KetQuaTheoDoi { get; set; }

        public string GhiChuTheoDoi { get; set; }

        public virtual CanBo CanBo { get; set; }

        public virtual CanBo CanBo1 { get; set; }

        public virtual CanBo CanBo2 { get; set; }

        public virtual CanBo CanBo3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichTiemChung> LichTiemChung { get; set; }
    }
}
