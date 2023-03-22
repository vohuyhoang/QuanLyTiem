using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiem.BUS;
using QuanLyTiem.DataContext;
using QuanLyTiem.DTO;

namespace QuanLyTiem.UserInterface
{
    public partial class FormQuanLyTiem : Form
    {
        private DoiTuongTiemBT doiTuongTiemBT;
        private LichSuTiemBT lichSuTiemBT;
        public FormQuanLyTiem()
        {
            doiTuongTiemBT = new DoiTuongTiemBT();
            lichSuTiemBT = new LichSuTiemBT();
            InitializeComponent();
        }

        private void FormQuanLyTiem_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            SetGridViewStyle(dgvDanhSachTiemChung);
            SetGridViewStyle(dgvLichSuTiem);
            dgvDanhSachTiemChung.AutoGenerateColumns = false;
            dgvLichSuTiem.AutoGenerateColumns = false;
            TaiDanhSachDoiTuongTiem();
        }

        private void TaiDanhSachDoiTuongTiem()
        {
            dgvDanhSachTiemChung.DataSource = doiTuongTiemBT.LayDanhSachDoiTuongTiem();
        }

        private void SetGridViewStyle(DataGridView dgvDanhSachTiemChung)
        {
            dgvDanhSachTiemChung.DefaultCellStyle.ForeColor = Color.Black;
            dgvDanhSachTiemChung.BorderStyle = BorderStyle.None;
            dgvDanhSachTiemChung.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDanhSachTiemChung.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvDanhSachTiemChung.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSachTiemChung.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDanhSachTiemChung.BackgroundColor = Color.White;
            dgvDanhSachTiemChung.EnableHeadersVisualStyles = false;
            dgvDanhSachTiemChung.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDanhSachTiemChung.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvDanhSachTiemChung.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDanhSachTiemChung.AllowUserToDeleteRows = false;
            dgvDanhSachTiemChung.AllowUserToAddRows = false;
            dgvDanhSachTiemChung.AllowUserToOrderColumns = true;
            dgvDanhSachTiemChung.MultiSelect = false;
            dgvDanhSachTiemChung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvDanhSachTiemChung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            int soCCCD = int.Parse(dgvDanhSachTiemChung.Rows[rowIndex].Cells[0].Value.ToString());
            dgvLichSuTiem.DataSource = lichSuTiemBT.LayDanhSachLichSuTiem(soCCCD);
            dgvDanhSachTiemChung.CurrentRow.Selected = true;
            txtCCCD.Text = dgvDanhSachTiemChung.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtHoten.Text = dgvDanhSachTiemChung.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvDanhSachTiemChung.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
            cmbGioiTinh.SelectedIndex = cmbGioiTinh.FindString(dgvDanhSachTiemChung.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                TaiDanhSachDoiTuongTiem();
                return;
            }
            dgvDanhSachTiemChung.DataSource = doiTuongTiemBT.TimDoiTuongTiem(int.Parse(txtTimKiem.Text));
        }

        private void btnThucHienTiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            FormThucHienTiem formThucHienTiem = new FormThucHienTiem(txtCCCD.Text);
            formThucHienTiem.CapNhatLichSuTiemEvent += FormThucHienTiem_CapNhatLichSuTiemEvent;
            formThucHienTiem.ShowDialog();
        }

        private void FormThucHienTiem_CapNhatLichSuTiemEvent()
        {
            TaiDanhSachDoiTuongTiem();
            TaiDanhSachLichSuTiem();
        }

        private void TaiDanhSachLichSuTiem()
        {
            int soCCCD = int.Parse(txtCCCD.Text);
            dgvLichSuTiem.DataSource = lichSuTiemBT.LayDanhSachLichSuTiem(soCCCD);
        }
    }
}
