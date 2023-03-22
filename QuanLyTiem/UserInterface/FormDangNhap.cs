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
    public partial class FormDangNhap : Form
    {
        private TaiKhoanBT taiKhoanBT;
        public FormDangNhap()
        {
            InitializeComponent();
            chkHienMatKhau.Enabled = false;
            txtMatKhau.UseSystemPasswordChar = true;
            taiKhoanBT = new TaiKhoanBT();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            TaiKhoanCanBo taiKhoan = taiKhoanBT.LayTaiKhoan(tenDangNhap, matKhau);
            if (taiKhoan != null)
            {
                MessageBox.Show("Đăng nhâp thành công");
                this.Hide();
                FormChuongTrinh formChuongTrinh = new FormChuongTrinh();
                formChuongTrinh.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhâp không thành công");
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            chkHienMatKhau.Enabled = true;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked == true)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                chkHienMatKhau.Checked = false;
                chkHienMatKhau.Enabled = false;
            }
        }
    }
}
