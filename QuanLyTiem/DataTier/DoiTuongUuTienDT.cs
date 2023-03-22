using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;

namespace QuanLyTiem.DataTier
{
    class DoiTuongUuTienDT
    {
        public string LayDoiTuongUuTien(string maDoiTuong)
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return dbContext.DoiTuongUuTien.Where(s => s.MaDoiTuong == maDoiTuong).FirstOrDefault().TenDoiTuong;
            }
        }

        public List<DoiTuongUuTienDTO> LayDanhSachDoiTuongUuTien()
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return (from kh in dbContext.DoiTuongUuTien
                        select new DoiTuongUuTienDTO()
                        {
                            MaDoiTuong = kh.MaDoiTuong,
                            TenDoiTuong = kh.TenDoiTuong
                        }).ToList();
            }
        }
    }
}
