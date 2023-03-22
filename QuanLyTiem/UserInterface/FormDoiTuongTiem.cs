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
using QuanLyTiem.UserInterface;


namespace QuanLyTiem
{
    public partial class FormDoiTuongTiem : Form
    {
        private DoiTuongUuTienBT doiTuongUuTienBT;
        private DoiTuongTiemBT doiTuongTiemBT;
        public FormDoiTuongTiem()
        {
            InitializeComponent();
            doiTuongUuTienBT = new DoiTuongUuTienBT();
            doiTuongTiemBT = new DoiTuongTiemBT();
            cmbDoiTuong.DisplayMember = "TenDoiTuong";
            cmbDoiTuong.ValueMember = "MaDoiTuong";
            dgvDanhSachDoiTuongTiem.AutoGenerateColumns = false;
            SetGridViewStyle(dgvDanhSachDoiTuongTiem);
        }

        private void SetGridViewStyle(DataGridView dgvDanhSachDoiTuongTiem)
        {
            dgvDanhSachDoiTuongTiem.DefaultCellStyle.ForeColor = Color.Black;
            dgvDanhSachDoiTuongTiem.BorderStyle = BorderStyle.None;
            dgvDanhSachDoiTuongTiem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDanhSachDoiTuongTiem.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvDanhSachDoiTuongTiem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSachDoiTuongTiem.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvDanhSachDoiTuongTiem.BackgroundColor = Color.White;
            dgvDanhSachDoiTuongTiem.EnableHeadersVisualStyles = false;
            dgvDanhSachDoiTuongTiem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDanhSachDoiTuongTiem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvDanhSachDoiTuongTiem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDanhSachDoiTuongTiem.AllowUserToDeleteRows = false;
            dgvDanhSachDoiTuongTiem.AllowUserToAddRows = false;
            dgvDanhSachDoiTuongTiem.AllowUserToOrderColumns = true;
            dgvDanhSachDoiTuongTiem.MultiSelect = false;
            dgvDanhSachDoiTuongTiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FormDoiTuongTiem_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            dtpNgaySinh.Value = DateTime.Now;
            TaiDanhSachDoiTuongUuTien();
            TaiDanhSachDoiTuongTiem();
        }

        private void TaiDanhSachDoiTuongTiem()
        {
            dgvDanhSachDoiTuongTiem.DataSource = doiTuongTiemBT.LayDanhSachDoiTuongTiem();
        }

        private void TaiDanhSachDoiTuongUuTien()
        {
            cmbDoiTuong.DataSource = doiTuongUuTienBT.LayDanhSachDoiTuongUuTien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtHoten.Text) || string.IsNullOrEmpty(cmbGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!");
                return;
            }
            string error;
            DoiTuongTiem doiTuongTiem = new DoiTuongTiem();
            doiTuongTiem.SoCCCD = Int32.Parse(txtCCCD.Text);
            doiTuongTiem.HoTen = txtHoten.Text;
            doiTuongTiem.GioiTinh = cmbGioiTinh.Text;
            doiTuongTiem.NgaySinh = dtpNgaySinh.Value;
            doiTuongTiem.MaDoiTuong = cmbDoiTuong.SelectedValue.ToString();
            doiTuongTiem.ThanhPho = cmbThanhPho.Text;
            doiTuongTiem.Quan = cmbQuan.Text;
            doiTuongTiem.Phuong = cmbPhuong.Text;
            doiTuongTiem.DiaChi = txtDiaChi.Text;
            doiTuongTiem.DanToc = cmbDanToc.Text;
            doiTuongTiem.QuocTich = cmbQuocTich.Text;
            if (doiTuongTiemBT.LuuDoiTuongTiem(doiTuongTiem, out error))
            {
                MessageBox.Show("Thêm đối tượng tiêm thành công");
                TaiDanhSachDoiTuongTiem();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCCCD.Text) || string.IsNullOrEmpty(txtHoten.Text) || string.IsNullOrEmpty(cmbGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!");
                return;
            }
            string error;
            DoiTuongTiem doiTuongTiem = new DoiTuongTiem();
            doiTuongTiem.SoCCCD = Int32.Parse(txtCCCD.Text);
            doiTuongTiem.HoTen = txtHoten.Text;
            doiTuongTiem.GioiTinh = cmbGioiTinh.Text;
            doiTuongTiem.NgaySinh = dtpNgaySinh.Value;
            doiTuongTiem.MaDoiTuong = cmbDoiTuong.SelectedValue.ToString();
            doiTuongTiem.ThanhPho = cmbThanhPho.Text;
            doiTuongTiem.Quan = cmbQuan.Text;
            doiTuongTiem.Phuong = cmbPhuong.Text;
            doiTuongTiem.DiaChi = txtDiaChi.Text;
            doiTuongTiem.DanToc = cmbDanToc.Text;
            doiTuongTiem.QuocTich = cmbQuocTich.Text;
            if (doiTuongTiemBT.SuaDoiTuongTiem(doiTuongTiem, out error))
            {
                MessageBox.Show("Sửa đối tượng tiêm thành công");
                TaiDanhSachDoiTuongTiem();
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            string error;

            if (MessageBox.Show("Bạn có muốn xóa đối tượng tiêm này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (doiTuongTiemBT.XoaDoiTuongTiem(Int32.Parse(txtCCCD.Text), out error))
                {
                    MessageBox.Show("Xóa đối tượng thành công");
                    TaiDanhSachDoiTuongTiem();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                TaiDanhSachDoiTuongTiem();
                return;
            }
            dgvDanhSachDoiTuongTiem.DataSource = doiTuongTiemBT.TimDoiTuongTiem(int.Parse(txtTimKiem.Text));
        }

        private void dgvDanhSachDoiTuongTiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            dgvDanhSachDoiTuongTiem.CurrentRow.Selected = true;
            txtCCCD.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtHoten.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
            cmbGioiTinh.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            cmbDoiTuong.SelectedIndex = cmbDoiTuong.FindString(dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            cmbThanhPho.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            cmbQuan.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            cmbPhuong.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            txtDiaChi.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            cmbDanToc.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            cmbQuocTich.Text = dgvDanhSachDoiTuongTiem.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
        }

        private void btnLichSuTiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            FormLichSuTiemChung formLichSuTiemChung = new FormLichSuTiemChung(txtCCCD.Text);
            formLichSuTiemChung.ShowDialog();
        }

        private void linkLabelLamMoi_Click(object sender, EventArgs e)
        {
            txtCCCD.Text = "";
            txtHoten.Text = "";
            txtDiaChi.Text = "";
            txtGhiChu.Text = "";
            cmbDanToc.Text = "";
            cmbGioiTinh.Text = "";
            cmbPhuong.Text = "";
            cmbQuan.Text = "";
            cmbQuocTich.Text = "";
            cmbThanhPho.Text = "";
        }
    }
}
