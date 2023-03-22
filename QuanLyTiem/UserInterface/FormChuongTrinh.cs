using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiem.UserInterface;

namespace QuanLyTiem
{
    public partial class FormChuongTrinh : Form
    {
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void btnDoiTuongTiem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormDoiTuongTiem>().FirstOrDefault();
            if (frm == null)
            {
                FormDoiTuongTiem formDoiTuongTiem = new FormDoiTuongTiem();
                formDoiTuongTiem.MdiParent = this;
                formDoiTuongTiem.StartPosition = FormStartPosition.CenterScreen;
                formDoiTuongTiem.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void menuThemCanBo_Click(object sender, EventArgs e)
        {
            FormThemCanBo formThemCanBo = new FormThemCanBo();
            formThemCanBo.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThucHienTiem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormQuanLyTiem>().FirstOrDefault();
            if (frm == null)
            {
                FormQuanLyTiem formQuanLyTiem = new FormQuanLyTiem();
                formQuanLyTiem.MdiParent = this;
                formQuanLyTiem.StartPosition = FormStartPosition.CenterScreen;
                formQuanLyTiem.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<FormThongKe>().FirstOrDefault();
            if (frm == null)
            {
                FormThongKe formThongKe = new FormThongKe();
                formThongKe.MdiParent = this;
                formThongKe.StartPosition = FormStartPosition.CenterScreen;
                formThongKe.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
