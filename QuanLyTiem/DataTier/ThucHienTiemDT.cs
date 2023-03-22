using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;

namespace QuanLyTiem.DataTier
{
    class ThucHienTiemDT
    {
        public bool ThemThucHienTien(ThucHienTiem thucHienTiem, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new ModelQuanLyTiem())
                {
                    dbContext.ThucHienTiem.Add(thucHienTiem);
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

        public bool ThemLichTiemChung(LichTiemChung lichTiemChung, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new ModelQuanLyTiem())
                {
                    dbContext.LichTiemChung.Add(lichTiemChung);
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
    }
}
