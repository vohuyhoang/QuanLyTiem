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
    class ThucHienTiemBT
    {
        public readonly ThucHienTiemDT thucHienTiemDT;

        public ThucHienTiemBT()
        {
            thucHienTiemDT = new ThucHienTiemDT();
        }

        public bool LuuThucHienTiem(ThucHienTiem thucHienTiem, out string error)
        {
            try
            {
                return thucHienTiemDT.ThemThucHienTien(thucHienTiem, out error);
            }
            catch (Exception ex)
            {

                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public bool LuuLichTiemChung(LichTiemChung lichTiemChung, out string error)
        {
            try
            {
                return thucHienTiemDT.ThemLichTiemChung(lichTiemChung, out error);
            }
            catch (Exception ex)
            {

                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }
    }
}
