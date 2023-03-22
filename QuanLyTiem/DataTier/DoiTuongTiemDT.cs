using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;

namespace QuanLyTiem.DataTier
{
    class DoiTuongTiemDT
    {
        public bool ThemDoiTuongTiem(DoiTuongTiem doiTuongTiem, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new ModelQuanLyTiem())
                {
                    var timDoiTuong = dbContext.DoiTuongTiem.SingleOrDefault(s => s.SoCCCD == doiTuongTiem.SoCCCD);
                    if (timDoiTuong != null)
                    {
                        error = "Đối tượng này đã tồn tại!";
                        return false;
                    }
                    dbContext.DoiTuongTiem.Add(doiTuongTiem);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public bool SuaDoiTuongTiem(DoiTuongTiem doiTuongTiem, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new ModelQuanLyTiem())
                {
                    var doiTuongTiemUpdate = dbContext.DoiTuongTiem.SingleOrDefault
                        (s => s.SoCCCD == doiTuongTiem.SoCCCD);
                    if (doiTuongTiemUpdate == null)
                    {
                        error = "Đối tượng này không tồn tại!";
                        return false;
                    }
                    doiTuongTiemUpdate.HoTen = doiTuongTiem.HoTen;
                    doiTuongTiemUpdate.DanToc = doiTuongTiem.DanToc;
                    doiTuongTiemUpdate.DiaChi = doiTuongTiem.DiaChi;
                    doiTuongTiemUpdate.MaDoiTuong = doiTuongTiem.MaDoiTuong;
                    doiTuongTiemUpdate.GioiTinh = doiTuongTiem.GioiTinh;
                    doiTuongTiemUpdate.NgaySinh = doiTuongTiem.NgaySinh;
                    doiTuongTiemUpdate.QuocTich = doiTuongTiem.QuocTich;
                    doiTuongTiemUpdate.Phuong = doiTuongTiem.Phuong;
                    doiTuongTiemUpdate.ThanhPho = doiTuongTiem.ThanhPho;
                    doiTuongTiemUpdate.Quan = doiTuongTiem.Quan;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public List<DoiTuongTiemDTO> LayDanhSachDoiTuongTiem()
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return (from doiTuong in dbContext.DoiTuongTiem
                        select new DoiTuongTiemDTO()
                        {
                            SoCCCD = doiTuong.SoCCCD,
                            HoTen = doiTuong.HoTen,
                            GioiTinh = doiTuong.GioiTinh,
                            NgaySinh = doiTuong.NgaySinh,
                            DanToc = doiTuong.DanToc,
                            QuocTich = doiTuong.QuocTich,
                            DiaChi = doiTuong.DiaChi,
                            Phuong = doiTuong.Phuong,
                            ThanhPho = doiTuong.ThanhPho,
                            Quan = doiTuong.Quan,
                            MaDoiTuong = doiTuong.DoiTuongUuTien.TenDoiTuong
                        }).ToList();
            }
        }

        public bool XoaDoiTuongTiem(int soCCCD, out string error)

        {
            error = string.Empty;
            try
            {
                using (var dbContext = new ModelQuanLyTiem())
                {
                    if (dbContext.LichTiemChung.Any(s => s.SoCCCD == soCCCD))
                    {
                        error = "Đối tượng này đã có trong lịch sử tiêm, không thể xóa!";
                        return false;
                    }
                    var doiTuongTiemRemove = dbContext.DoiTuongTiem.SingleOrDefault
                        (s => s.SoCCCD == soCCCD);
                    if (doiTuongTiemRemove == null)
                    {
                        error = "Đối tượng tiêm không tồn tại!";
                        return false;
                    }
                    dbContext.DoiTuongTiem.Remove(doiTuongTiemRemove);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public List<DoiTuongTiemDTO> TimDoiTuongTiem(int soCCCD)
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return (from doiTuong in dbContext.DoiTuongTiem
                        where doiTuong.SoCCCD == soCCCD
                        select new DoiTuongTiemDTO()
                        {
                            SoCCCD = doiTuong.SoCCCD,
                            HoTen = doiTuong.HoTen,
                            GioiTinh = doiTuong.GioiTinh,
                            NgaySinh = doiTuong.NgaySinh,
                            DanToc = doiTuong.DanToc,
                            QuocTich = doiTuong.QuocTich,
                            DiaChi = doiTuong.DiaChi,
                            Phuong = doiTuong.Phuong,
                            ThanhPho = doiTuong.ThanhPho,
                            Quan = doiTuong.Quan,
                            MaDoiTuong = doiTuong.DoiTuongUuTien.TenDoiTuong
                        }).ToList();
            }
        }
        public DoiTuongTiem LayDoiTuongTiem(int soCCCD)
        {
             using (var dbContext = new ModelQuanLyTiem())
             {
                  return dbContext.DoiTuongTiem.Where(s => s.SoCCCD == soCCCD).FirstOrDefault();
             }
        }
    }
}
