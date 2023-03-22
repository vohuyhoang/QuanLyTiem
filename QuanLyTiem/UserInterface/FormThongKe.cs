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
    public partial class FormThongKe : Form
    {
        private DoiTuongTiemBT doiTuongTiemBT;
        private LichSuTiemBT lichSuTiemBT;
        public FormThongKe()
        {
            doiTuongTiemBT = new DoiTuongTiemBT();
            lichSuTiemBT = new LichSuTiemBT();
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.reportViewerThongKe.RefreshReport();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            cmbHoTen.Text = "";
            if (string.IsNullOrEmpty(txtSoCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                return;
            }
            cmbHoTen.DataSource = doiTuongTiemBT.TimDoiTuongTiem(int.Parse(txtSoCCCD.Text));
            cmbHoTen.DisplayMember = "HoTen";
            cmbHoTen.ValueMember = "SoCCCD";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoCCCD.Text) || string.IsNullOrEmpty(cmbHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                return;
            }
            int soCCCD = int.Parse(txtSoCCCD.Text);
            List<LichSuTiemDTO> danhSachLichSuTiemTheoDoiTuong = lichSuTiemBT.LayDanhSachLichSuTiem(soCCCD);
            this.reportViewerThongKe.LocalReport.ReportPath = "D:/QuanLyTiem/QuanLyTiem/Reporting/ReportLichSuTiem.rdlc";
            var reportDataSource = new ReportDataSource("DataSetLichSuTiem", danhSachLichSuTiemTheoDoiTuong);
            this.reportViewerThongKe.LocalReport.DataSources.Clear();
            this.reportViewerThongKe.LocalReport.DataSources.Add(reportDataSource);

            ReportParameter[] reportParameters = new ReportParameter[2];
            reportParameters[0] = new ReportParameter("ReportParameterSoCCCD", txtSoCCCD.Text);
            reportParameters[1] = new ReportParameter("ReportParameterHoTen", cmbHoTen.Text);
            this.reportViewerThongKe.LocalReport.SetParameters(reportParameters);
            this.reportViewerThongKe.RefreshReport();
        }
    }
}
