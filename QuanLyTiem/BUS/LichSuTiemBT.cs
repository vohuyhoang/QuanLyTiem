using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataTier;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;

namespace QuanLyTiem.BUS
{
    class LichSuTiemBT
    {
        public readonly LichSuTiemDT lichSuTiemDT;
        public LichSuTiemBT()
        {
            lichSuTiemDT = new LichSuTiemDT();
        }

        internal List<LichSuTiemDTO> LayDanhSachLichSuTiem(int soCCCD)
        {
            return lichSuTiemDT.LayDanhSachLichSuTiem(soCCCD);
        }
    }
}
