using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;

namespace QuanLyTiem.DataTier
{
    class CanBoDT
    {
        public bool ThemCanBo(CanBo canBo, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new ModelQuanLyTiem())
                {
                    var timCanBo = dbContext.CanBo.SingleOrDefault(s => s.MaCanBo == canBo.MaCanBo);
                    if (timCanBo != null)
                    {
                        error = "Cán bộ này đã tồn tại!";
                        return false;
                    }
                    dbContext.CanBo.Add(canBo);
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

        public List<CanBoDTO> LayDanhSachCanBo()
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return (from canBo in dbContext.CanBo
                        select new CanBoDTO()
                        {
                            MaCanBo = canBo.MaCanBo,
                            TenCanBo = canBo.TenCanBo
                        }).ToList();
            }
        }
    }
}
