using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyTiem.BUS;
using QuanLyTiem.DTO;

namespace QuanLyTiem.UserInterface
{
    public partial class FormThongKeLichTiem : Form
    {
        private LichSuTiemBT lichSuTiemBT;
        private DoiTuongTiemBT doiTuongTiemBT;
        public FormThongKeLichTiem()
        {
            
            lichSuTiemBT = new LichSuTiemBT();
            doiTuongTiemBT = new DoiTuongTiemBT();
            InitializeComponent();
        }

        private void FormThongKeLichTiem_Load(object sender, EventArgs e)
        {

            this.rpvLichSuTiem.RefreshReport();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            cmbHoTen.DataSource = doiTuongTiemBT.TimDoiTuongTiem(int.Parse(txtSoCCCD.Text));
            cmbHoTen.DisplayMember = "HoTen";
            cmbHoTen.ValueMember = "SoCCCD";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int soCCCD = int.Parse(txtSoCCCD.Text);
            List<LichSuTiemDTO> dachSachLichSuTiemTheoDoiTuong = lichSuTiemBT.LayDanhSachLichSuTiem(soCCCD);
            this.rpvLichSuTiem.LocalReport.ReportPath = "../../Reporting/ReportThongKeLichSuTiem.rdlc";
            var report = new ReportDataSource("DataSetThongKeLichSuTiem", dachSachLichSuTiemTheoDoiTuong);
            this.rpvLichSuTiem.LocalReport.DataSources.Clear();
            this.rpvLichSuTiem.LocalReport.DataSources.Add(report);

            ReportParameter[] reportParameters = new ReportParameter[2];
            reportParameters[0] = new ReportParameter("SoCCCD", txtSoCCCD.Text);
            reportParameters[1] = new ReportParameter("HoTen", cmbHoTen.Text);
            this.rpvLichSuTiem.LocalReport.SetParameters(reportParameters);
            this.rpvLichSuTiem.RefreshReport();
        }
    }
}
