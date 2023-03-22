using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.DTO
{
    class LichSuTiemDTO
    {
        public int MaTiem { get; set; }

        public DateTime NgayTiem { get; set; }

        public int SoMui { get; set; }

        public string TenVaccine { get; set; }

        public string DonViTiem { get; set; }

        public int SoCCCD { get; set; }

        public string KetQuaTiem { get; set; }
    }
}
