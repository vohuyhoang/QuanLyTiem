using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;


namespace QuanLyTiem.DataTier
{
    class VaccineDT
    {
        public List<VaccinceDTO> LayDanhSachVaccine()
        {
            using (var dbContext = new ModelQuanLyTiem())
            {
                return (from vaccince in dbContext.Vaccine
                        select new VaccinceDTO()
                        {
                            MaVaccine = vaccince.MaVaccine,
                            TenVaccine = vaccince.TenVaccine
                        }).ToList();
            }
        }
    }
}
