using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;


namespace QuanLyTiem.DataTier
{
    class KeHoachTiemDT
    {
        public List<KeHoachTiemDTO> LayDanhSachKeHoachTiem()
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return (from keHoach in dbContext.KeHoachTiem
                        select new KeHoachTiemDTO()
                        {
                            MaKHT = keHoach.MaKHT,
                            TenKHT = keHoach.TenKHT
                        }).ToList();
            }
        }
    }
}
