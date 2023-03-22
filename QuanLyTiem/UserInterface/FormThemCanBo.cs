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

namespace QuanLyTiem
{
    public partial class FormThemCanBo : Form
    {
        private CanBoBT canBoBT;
        
        public FormThemCanBo()
        {
            InitializeComponent();
        }

        private void FormThemCanBo_Load(object sender, EventArgs e)
        {
            canBoBT = new CanBoBT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenCanBo.Text) || string.IsNullOrEmpty(txtSDTCB.Text) || string.IsNullOrEmpty(cmbChucVu.Text) || string.IsNullOrEmpty(txtDonViCongTac.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            string error;
            CanBo canBo = new CanBo();
            canBo.TenCanBo = txtTenCanBo.Text;
            canBo.ChucVu = cmbChucVu.Text;
            canBo.SoDTCB = txtSDTCB.Text;
            canBo.DonViCongTac = txtDonViCongTac.Text;
            if (canBoBT.LuuCanBo(canBo, out error))
            {
                MessageBox.Show("Thêm cán bộ thành công");
                txtTenCanBo.Text = "";
                txtDonViCongTac.Text = "";
                txtSDTCB.Text = "";
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
                return;
            }
        }
    }
}
