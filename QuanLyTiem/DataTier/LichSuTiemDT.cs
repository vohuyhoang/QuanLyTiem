using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;

namespace QuanLyTiem.DataTier
{
    class LichSuTiemDT
    {
        public List<LichSuTiemDTO> LayDanhSachLichSuTiem(int soCCCD)
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return (from doiTuong in dbContext.LichTiemChung
                        where doiTuong.SoCCCD == soCCCD
                        select new LichSuTiemDTO()
                        {
                            SoCCCD = doiTuong.SoCCCD,
                            MaTiem = doiTuong.MaTiem,
                            TenVaccine = doiTuong.Vaccine.TenVaccine,
                            KetQuaTiem = doiTuong.ThucHienTiem.KetQuaTiem,
                            DonViTiem = doiTuong.KeHoachTiem.TenDonViTiem,
                            SoMui = doiTuong.SoMui,
                            NgayTiem = doiTuong.NgayTiem
                        }).ToList();
            }
        }
    }
}
