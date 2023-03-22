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
    class KeHoachTiemBT
    {
        public readonly KeHoachTiemDT keHoachTiemDT;
        public KeHoachTiemBT()
        {
            keHoachTiemDT = new KeHoachTiemDT();
        }
        public List<KeHoachTiemDTO> LayDanhSachKeHoachTiem()
        {
            return keHoachTiemDT.LayDanhSachKeHoachTiem();
        }
    }
}
