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
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;

namespace QuanLyTiem.UserInterface
{
    public partial class FormLichSuTiemChung : Form
    {
        string strNhan;
        private LichSuTiemBT lichSuTiemBT;
        private DoiTuongTiemBT doiTuongTiemBT;
        
        public FormLichSuTiemChung()
        {
            lichSuTiemBT = new LichSuTiemBT();
            doiTuongTiemBT = new DoiTuongTiemBT();
            InitializeComponent();
            cmbHoTen.DisplayMember = "HoTen";
            cmbHoTen.ValueMember = "SoCCCD";
        }

        public FormLichSuTiemChung(string giatrinhan) : this()
        {
            strNhan = giatrinhan;
        }

        private void LayHoTenDoiTuong()
        {
            cmbHoTen.DataSource = doiTuongTiemBT.TimDoiTuongTiem(int.Parse(strNhan));
            
        }

        private void FormLichSuTiemChung_Load(object sender, EventArgs e)
        {
            
            int soCCCD = int.Parse(strNhan);
            LayHoTenDoiTuong();
            List<LichSuTiemDTO> danhSachLichSuTiemTheoDoiTuong = lichSuTiemBT.LayDanhSachLichSuTiem(soCCCD);
            this.reportViewerLichSuTiem.LocalReport.ReportPath = "D:/QuanLyTiem/QuanLyTiem/Reporting/ReportLichSuTiem.rdlc";
            var reportDataSource = new ReportDataSource("DataSetLichSuTiem", danhSachLichSuTiemTheoDoiTuong);
            this.reportViewerLichSuTiem.LocalReport.DataSources.Clear();
            this.reportViewerLichSuTiem.LocalReport.DataSources.Add(reportDataSource);

            ReportParameter[] reportParameters = new ReportParameter[2];
            reportParameters[0] = new ReportParameter("ReportParameterSoCCCD", strNhan);
            reportParameters[1] = new ReportParameter("ReportParameterHoTen", cmbHoTen.Text);
            this.reportViewerLichSuTiem.LocalReport.SetParameters(reportParameters);
            this.reportViewerLichSuTiem.RefreshReport();
        }
    }
}
