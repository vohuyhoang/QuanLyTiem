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
    class DoiTuongUuTienBT
    {
        public readonly DoiTuongUuTienDT doiTuongUuTienDT;
        public DoiTuongUuTienBT()
        {
            doiTuongUuTienDT = new DoiTuongUuTienDT();
        }
        public List<DoiTuongUuTienDTO> LayDanhSachDoiTuongUuTien()
        {
            return doiTuongUuTienDT.LayDanhSachDoiTuongUuTien();
        }
    }
}
