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
    class DoiTuongTiemBT
    {
        public readonly DoiTuongTiemDT doiTuongTiemDT;
        public DoiTuongTiemBT()
        {
            doiTuongTiemDT = new DoiTuongTiemDT();
        }

        public bool LuuDoiTuongTiem(DoiTuongTiem doiTuongTiem, out string error)
        {
            try
            {
                return doiTuongTiemDT.ThemDoiTuongTiem(doiTuongTiem, out error);
            }
            catch (Exception ex)
            {

                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public bool SuaDoiTuongTiem(DoiTuongTiem doiTuongTiem, out string error)
        {
            try
            {
                return doiTuongTiemDT.SuaDoiTuongTiem(doiTuongTiem, out error);
            }
            catch (Exception ex)
            {

                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public List<DoiTuongTiemDTO> LayDanhSachDoiTuongTiem()
        {
            return doiTuongTiemDT.LayDanhSachDoiTuongTiem();
        }

        public List<DoiTuongTiemDTO> TimDoiTuongTiem(int soCCCD)
        {
            return doiTuongTiemDT.TimDoiTuongTiem(soCCCD);
        }

        public bool XoaDoiTuongTiem(int soCCCD, out string error)
        {
            try
            {

                return doiTuongTiemDT.XoaDoiTuongTiem(soCCCD, out error);

            }
            catch (Exception ex)
            {

                error = ex.Message + "\n" + ex.InnerException;
                return false;
            }
        }

        public DoiTuongTiem LayDoiTuongTiem(int soCCCD)
        {
            return doiTuongTiemDT.LayDoiTuongTiem(soCCCD);
        }
    }
}
