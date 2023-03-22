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
    class CanBoBT
    {
        public readonly CanBoDT canBoDT;
        public CanBoBT()
        {
            canBoDT = new CanBoDT();
        }

        public bool LuuCanBo(CanBo canBo, out string error)
        {
            try
            {
                return canBoDT.ThemCanBo(canBo, out error);
            }
            catch (Exception ex)
            {

                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public List<CanBoDTO> LayDanhSachCanBo()
        {
            return canBoDT.LayDanhSachCanBo();
        }
    }
}
