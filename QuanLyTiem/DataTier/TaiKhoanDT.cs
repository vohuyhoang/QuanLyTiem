using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;

namespace QuanLyTiem.DataTier
{
    class TaiKhoanDT
    {
        public TaiKhoanCanBo LayTaiKhoan(string tenDangNhap, string matKhau)
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return dbContext.TaiKhoanCanBo.Where(s => s.TenDangNhap == tenDangNhap
                && s.MatKhau == matKhau).FirstOrDefault();
            }
        }
    }
}
