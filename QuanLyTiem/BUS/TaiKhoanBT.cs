using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;
using QuanLyTiem.DataTier;
using QuanLyTiem.Libs;

namespace QuanLyTiem.BUS
{
    class TaiKhoanBT
    {
        private readonly TaiKhoanDT taiKhoanDT;
        public TaiKhoanBT()
        {
            taiKhoanDT = new TaiKhoanDT();
        }
        public TaiKhoanCanBo LayTaiKhoan(string tenDangNhap, string matKhau)
        {
            //matKhau = Helpers.MaHoaMatKhauMD5(matKhau);
            return taiKhoanDT.LayTaiKhoan(tenDangNhap, matKhau);
        }
    }
}
