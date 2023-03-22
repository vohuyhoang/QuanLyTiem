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
    class VaccineBT
    {
        public readonly VaccineDT vaccineDT;

        public VaccineBT()
        {
            vaccineDT = new VaccineDT();
        }

        public List<VaccinceDTO> LayDanhSachVaccine()
        {
            return vaccineDT.LayDanhSachVaccine();
        }
    }
}
