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
    public delegate void CapNhatLichSuTiem();
    public partial class FormThucHienTiem : Form
    {
        public event CapNhatLichSuTiem CapNhatLichSuTiemEvent;
        string strNhan;
        private DoiTuongTiemBT doiTuongTiemBT;
        private ThucHienTiemBT thucHienTiemBT;
        private CanBoBT canBoBT;
        private VaccineBT vaccineBT;
        private KeHoachTiemBT keHoachTiemBT;
        public FormThucHienTiem()
        {
            doiTuongTiemBT = new DoiTuongTiemBT();
            thucHienTiemBT = new ThucHienTiemBT();
            keHoachTiemBT = new KeHoachTiemBT();
            vaccineBT = new VaccineBT();
            canBoBT = new CanBoBT();
            InitializeComponent();
        }

        public FormThucHienTiem(string giatrinhan) : this()
        {
            strNhan = giatrinhan;
            tssHoTen.Text = strNhan;
        }

        private void FormThucHienTiem_Load(object sender, EventArgs e)
        {
            
            TaiDanhSachCanBoTiepDon();
            TaiDanhSachCanBoKham();
            TaiDanhSachCanBoTiem();
            TaiDanhSachCanBoTheoDoi();
            TaiDanhSachVaccine();
            TaiDanhSachKeHoachTiem();
            cmbCanBoTiepDon.DisplayMember = "TenCanBo";
            cmbCanBoTiepDon.ValueMember = "MaCanBo";
            cmbCanBoKham.DisplayMember = "TenCanBo";
            cmbCanBoKham.ValueMember = "MaCanBo";
            cmbCanBoTiem.DisplayMember = "TenCanBo";
            cmbCanBoTiem.ValueMember = "MaCanBo";
            cmbCanBoTheoDoi.DisplayMember = "TenCanBo";
            cmbCanBoTheoDoi.ValueMember = "MaCanBo";
            cmbVaccine.DisplayMember = "TenVaccine";
            cmbVaccine.ValueMember = "MaVaccine";
            cmbKeHoachTiem.DisplayMember = "TenKHT";
            cmbKeHoachTiem.ValueMember = "MaKHT";
        }

        private void TaiDanhSachKeHoachTiem()
        {
            cmbKeHoachTiem.DataSource = keHoachTiemBT.LayDanhSachKeHoachTiem();
        }

        private void TaiDanhSachVaccine()
        {
            cmbVaccine.DataSource = vaccineBT.LayDanhSachVaccine();
        }

        private void TaiDanhSachCanBoTheoDoi()
        {
            cmbCanBoTheoDoi.DataSource = canBoBT.LayDanhSachCanBo();
        }

        private void TaiDanhSachCanBoTiem()
        {
            cmbCanBoTiem.DataSource = canBoBT.LayDanhSachCanBo();
        }

        private void TaiDanhSachCanBoKham()
        {
            cmbCanBoKham.DataSource = canBoBT.LayDanhSachCanBo();
        }

        private void TaiDanhSachCanBoTiepDon()
        {
            cmbCanBoTiepDon.DataSource = canBoBT.LayDanhSachCanBo();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbKetQuaKham.Text) || string.IsNullOrEmpty(cmbKetQuaTiem.Text) || string.IsNullOrEmpty(txtSoMui.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!");
                return;
            }
            string error;
            ThucHienTiem thucHienTiem = new ThucHienTiem();
            thucHienTiem.MaCanBo_TiepDon = int.Parse(cmbCanBoTheoDoi.SelectedValue.ToString());
            thucHienTiem.KetQuaTiepDon = cmbKetQuaTiepDon.Text;
            thucHienTiem.MaCanBo_Kham = int.Parse(cmbCanBoKham.SelectedValue.ToString());
            thucHienTiem.KetQuaKham = cmbKetQuaKham.Text;
            thucHienTiem.GhiChuKham = txtGhiChuKham.Text;
            thucHienTiem.MaCanBo_Tiem = int.Parse(cmbCanBoTiem.SelectedValue.ToString());
            thucHienTiem.KetQuaTiem = cmbKetQuaTiem.Text;
            thucHienTiem.MaCanBo_TheoDoi = int.Parse(cmbCanBoTheoDoi.SelectedValue.ToString());
            thucHienTiem.GhiChuTheoDoi = txtGhiChuTheoDoi.Text;

            if (thucHienTiemBT.LuuThucHienTiem(thucHienTiem, out error))
            {
                LichTiemChung lichTiemChung = new LichTiemChung();
                lichTiemChung.SoCCCD = int.Parse(strNhan);
                lichTiemChung.NgayTiem = dtpNgayTiem.Value;
                lichTiemChung.MaVaccine = cmbVaccine.SelectedValue.ToString();
                lichTiemChung.SoMui = int.Parse(txtSoMui.Text);
                lichTiemChung.MaThucHienTiem = thucHienTiem.MaThucHienTiem;
                lichTiemChung.MaKHT = cmbKeHoachTiem.SelectedValue.ToString();
                
                if (!thucHienTiemBT.LuuLichTiemChung(lichTiemChung, out error))
                {
                    MessageBox.Show("Lưu không thành công!\nLỗi: {0}" + error);
                    return;
                }
                MessageBox.Show("Thêm thực hiện tiêm thành công");
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }

        private void FormThucHienTiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatLichSuTiemEvent();
        }
    }
}
