
namespace QuanLyTiem.UserInterface
{
    partial class FormThucHienTiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThucHienTiem));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssNgaySinh = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTiepDon = new System.Windows.Forms.TabPage();
            this.cmbKetQuaTiepDon = new System.Windows.Forms.ComboBox();
            this.cmbKeHoachTiem = new System.Windows.Forms.ComboBox();
            this.cmbCanBoTiepDon = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageKhamSangLoc = new System.Windows.Forms.TabPage();
            this.txtGhiChuKham = new System.Windows.Forms.TextBox();
            this.cmbKetQuaKham = new System.Windows.Forms.ComboBox();
            this.cmbCanBoKham = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageThucHienTiem = new System.Windows.Forms.TabPage();
            this.txtSoMui = new System.Windows.Forms.TextBox();
            this.cmbKetQuaTiem = new System.Windows.Forms.ComboBox();
            this.cmbVaccine = new System.Windows.Forms.ComboBox();
            this.cmbCanBoTiem = new System.Windows.Forms.ComboBox();
            this.dtpNgayTiem = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageTheoDoi = new System.Windows.Forms.TabPage();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGhiChuTheoDoi = new System.Windows.Forms.TextBox();
            this.cmbCanBoTheoDoi = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTiepDon.SuspendLayout();
            this.tabPageKhamSangLoc.SuspendLayout();
            this.tabPageThucHienTiem.SuspendLayout();
            this.tabPageTheoDoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssNgaySinh,
            this.tssHoTen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssNgaySinh
            // 
            this.tssNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.tssNgaySinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tssNgaySinh.ForeColor = System.Drawing.Color.White;
            this.tssNgaySinh.Name = "tssNgaySinh";
            this.tssNgaySinh.Size = new System.Drawing.Size(185, 17);
            this.tssNgaySinh.Text = "Thực hiện tiêm cho đối tượng:";
            // 
            // tssHoTen
            // 
            this.tssHoTen.BackColor = System.Drawing.Color.Transparent;
            this.tssHoTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tssHoTen.ForeColor = System.Drawing.Color.White;
            this.tssHoTen.Name = "tssHoTen";
            this.tssHoTen.Size = new System.Drawing.Size(80, 17);
            this.tssHoTen.Text = "<Số CCCD>";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageTiepDon);
            this.tabControl1.Controls.Add(this.tabPageKhamSangLoc);
            this.tabControl1.Controls.Add(this.tabPageThucHienTiem);
            this.tabControl1.Controls.Add(this.tabPageTheoDoi);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 317);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageTiepDon
            // 
            this.tabPageTiepDon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPageTiepDon.Controls.Add(this.cmbKetQuaTiepDon);
            this.tabPageTiepDon.Controls.Add(this.cmbKeHoachTiem);
            this.tabPageTiepDon.Controls.Add(this.cmbCanBoTiepDon);
            this.tabPageTiepDon.Controls.Add(this.dateTimePicker1);
            this.tabPageTiepDon.Controls.Add(this.label3);
            this.tabPageTiepDon.Controls.Add(this.label2);
            this.tabPageTiepDon.Controls.Add(this.label12);
            this.tabPageTiepDon.Controls.Add(this.label1);
            this.tabPageTiepDon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPageTiepDon.Location = new System.Drawing.Point(4, 26);
            this.tabPageTiepDon.Name = "tabPageTiepDon";
            this.tabPageTiepDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTiepDon.Size = new System.Drawing.Size(625, 287);
            this.tabPageTiepDon.TabIndex = 0;
            this.tabPageTiepDon.Text = "Tiếp đón";
            // 
            // cmbKetQuaTiepDon
            // 
            this.cmbKetQuaTiepDon.FormattingEnabled = true;
            this.cmbKetQuaTiepDon.Items.AddRange(new object[] {
            "Chuyển qua khám sàng lọc",
            "Đối tượng không đồng ý tiêm"});
            this.cmbKetQuaTiepDon.Location = new System.Drawing.Point(263, 201);
            this.cmbKetQuaTiepDon.Name = "cmbKetQuaTiepDon";
            this.cmbKetQuaTiepDon.Size = new System.Drawing.Size(286, 25);
            this.cmbKetQuaTiepDon.TabIndex = 7;
            // 
            // cmbKeHoachTiem
            // 
            this.cmbKeHoachTiem.FormattingEnabled = true;
            this.cmbKeHoachTiem.Location = new System.Drawing.Point(263, 51);
            this.cmbKeHoachTiem.Name = "cmbKeHoachTiem";
            this.cmbKeHoachTiem.Size = new System.Drawing.Size(286, 25);
            this.cmbKeHoachTiem.TabIndex = 8;
            // 
            // cmbCanBoTiepDon
            // 
            this.cmbCanBoTiepDon.FormattingEnabled = true;
            this.cmbCanBoTiepDon.Location = new System.Drawing.Point(263, 149);
            this.cmbCanBoTiepDon.Name = "cmbCanBoTiepDon";
            this.cmbCanBoTiepDon.Size = new System.Drawing.Size(286, 25);
            this.cmbCanBoTiepDon.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 25);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chuyển qua bước tiếp theo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cán bộ tiếp đón";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kế hoạch tiêm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày tiếp đón";
            // 
            // tabPageKhamSangLoc
            // 
            this.tabPageKhamSangLoc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPageKhamSangLoc.Controls.Add(this.txtGhiChuKham);
            this.tabPageKhamSangLoc.Controls.Add(this.cmbKetQuaKham);
            this.tabPageKhamSangLoc.Controls.Add(this.cmbCanBoKham);
            this.tabPageKhamSangLoc.Controls.Add(this.label6);
            this.tabPageKhamSangLoc.Controls.Add(this.label4);
            this.tabPageKhamSangLoc.Controls.Add(this.label5);
            this.tabPageKhamSangLoc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPageKhamSangLoc.Location = new System.Drawing.Point(4, 26);
            this.tabPageKhamSangLoc.Name = "tabPageKhamSangLoc";
            this.tabPageKhamSangLoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKhamSangLoc.Size = new System.Drawing.Size(625, 287);
            this.tabPageKhamSangLoc.TabIndex = 1;
            this.tabPageKhamSangLoc.Text = "Khám sàng lọc";
            // 
            // txtGhiChuKham
            // 
            this.txtGhiChuKham.Location = new System.Drawing.Point(239, 110);
            this.txtGhiChuKham.Multiline = true;
            this.txtGhiChuKham.Name = "txtGhiChuKham";
            this.txtGhiChuKham.Size = new System.Drawing.Size(286, 52);
            this.txtGhiChuKham.TabIndex = 15;
            // 
            // cmbKetQuaKham
            // 
            this.cmbKetQuaKham.FormattingEnabled = true;
            this.cmbKetQuaKham.Items.AddRange(new object[] {
            "Đủ điều kiện tiêm",
            "Không đủ yêu cầu tiêm"});
            this.cmbKetQuaKham.Location = new System.Drawing.Point(239, 189);
            this.cmbKetQuaKham.Name = "cmbKetQuaKham";
            this.cmbKetQuaKham.Size = new System.Drawing.Size(286, 25);
            this.cmbKetQuaKham.TabIndex = 13;
            // 
            // cmbCanBoKham
            // 
            this.cmbCanBoKham.FormattingEnabled = true;
            this.cmbCanBoKham.Location = new System.Drawing.Point(239, 59);
            this.cmbCanBoKham.Name = "cmbCanBoKham";
            this.cmbCanBoKham.Size = new System.Drawing.Size(286, 25);
            this.cmbCanBoKham.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ghi chú khám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết luận khám";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cán bộ khám";
            // 
            // tabPageThucHienTiem
            // 
            this.tabPageThucHienTiem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPageThucHienTiem.Controls.Add(this.txtSoMui);
            this.tabPageThucHienTiem.Controls.Add(this.cmbKetQuaTiem);
            this.tabPageThucHienTiem.Controls.Add(this.cmbVaccine);
            this.tabPageThucHienTiem.Controls.Add(this.cmbCanBoTiem);
            this.tabPageThucHienTiem.Controls.Add(this.dtpNgayTiem);
            this.tabPageThucHienTiem.Controls.Add(this.label14);
            this.tabPageThucHienTiem.Controls.Add(this.label7);
            this.tabPageThucHienTiem.Controls.Add(this.label13);
            this.tabPageThucHienTiem.Controls.Add(this.label8);
            this.tabPageThucHienTiem.Controls.Add(this.label9);
            this.tabPageThucHienTiem.Location = new System.Drawing.Point(4, 26);
            this.tabPageThucHienTiem.Name = "tabPageThucHienTiem";
            this.tabPageThucHienTiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThucHienTiem.Size = new System.Drawing.Size(625, 287);
            this.tabPageThucHienTiem.TabIndex = 2;
            this.tabPageThucHienTiem.Text = "Thực hiện tiêm";
            // 
            // txtSoMui
            // 
            this.txtSoMui.Location = new System.Drawing.Point(241, 179);
            this.txtSoMui.Name = "txtSoMui";
            this.txtSoMui.Size = new System.Drawing.Size(77, 25);
            this.txtSoMui.TabIndex = 15;
            // 
            // cmbKetQuaTiem
            // 
            this.cmbKetQuaTiem.FormattingEnabled = true;
            this.cmbKetQuaTiem.Items.AddRange(new object[] {
            "Đã tiêm",
            "Chưa tiêm",
            "Không đủ điều kiện tiêm",
            "Đối tượng không đồng ý tiêm"});
            this.cmbKetQuaTiem.Location = new System.Drawing.Point(241, 229);
            this.cmbKetQuaTiem.Name = "cmbKetQuaTiem";
            this.cmbKetQuaTiem.Size = new System.Drawing.Size(286, 25);
            this.cmbKetQuaTiem.TabIndex = 13;
            // 
            // cmbVaccine
            // 
            this.cmbVaccine.FormattingEnabled = true;
            this.cmbVaccine.Location = new System.Drawing.Point(241, 133);
            this.cmbVaccine.Name = "cmbVaccine";
            this.cmbVaccine.Size = new System.Drawing.Size(286, 25);
            this.cmbVaccine.TabIndex = 14;
            // 
            // cmbCanBoTiem
            // 
            this.cmbCanBoTiem.FormattingEnabled = true;
            this.cmbCanBoTiem.Location = new System.Drawing.Point(241, 84);
            this.cmbCanBoTiem.Name = "cmbCanBoTiem";
            this.cmbCanBoTiem.Size = new System.Drawing.Size(286, 25);
            this.cmbCanBoTiem.TabIndex = 14;
            // 
            // dtpNgayTiem
            // 
            this.dtpNgayTiem.Location = new System.Drawing.Point(241, 34);
            this.dtpNgayTiem.Name = "dtpNgayTiem";
            this.dtpNgayTiem.Size = new System.Drawing.Size(286, 25);
            this.dtpNgayTiem.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Mũi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kết quả tiêm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Loại Vaccxin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cán bộ tiêm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ngày tiêm";
            // 
            // tabPageTheoDoi
            // 
            this.tabPageTheoDoi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPageTheoDoi.Controls.Add(this.btnLuu);
            this.tabPageTheoDoi.Controls.Add(this.txtGhiChuTheoDoi);
            this.tabPageTheoDoi.Controls.Add(this.cmbCanBoTheoDoi);
            this.tabPageTheoDoi.Controls.Add(this.label10);
            this.tabPageTheoDoi.Controls.Add(this.label11);
            this.tabPageTheoDoi.Location = new System.Drawing.Point(4, 26);
            this.tabPageTheoDoi.Name = "tabPageTheoDoi";
            this.tabPageTheoDoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheoDoi.Size = new System.Drawing.Size(625, 287);
            this.tabPageTheoDoi.TabIndex = 3;
            this.tabPageTheoDoi.Text = "Theo dõi sau tiêm";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(450, 229);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGhiChuTheoDoi
            // 
            this.txtGhiChuTheoDoi.Location = new System.Drawing.Point(239, 120);
            this.txtGhiChuTheoDoi.Multiline = true;
            this.txtGhiChuTheoDoi.Name = "txtGhiChuTheoDoi";
            this.txtGhiChuTheoDoi.Size = new System.Drawing.Size(286, 85);
            this.txtGhiChuTheoDoi.TabIndex = 15;
            // 
            // cmbCanBoTheoDoi
            // 
            this.cmbCanBoTheoDoi.FormattingEnabled = true;
            this.cmbCanBoTheoDoi.Location = new System.Drawing.Point(239, 68);
            this.cmbCanBoTheoDoi.Name = "cmbCanBoTheoDoi";
            this.cmbCanBoTheoDoi.Size = new System.Drawing.Size(286, 25);
            this.cmbCanBoTheoDoi.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ghi chú";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cán bộ theo dõi";
            // 
            // FormThucHienTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 342);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "FormThucHienTiem";
            this.ShowIcon = false;
            this.Text = "Thực hiện tiêm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThucHienTiem_FormClosed);
            this.Load += new System.EventHandler(this.FormThucHienTiem_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTiepDon.ResumeLayout(false);
            this.tabPageTiepDon.PerformLayout();
            this.tabPageKhamSangLoc.ResumeLayout(false);
            this.tabPageKhamSangLoc.PerformLayout();
            this.tabPageThucHienTiem.ResumeLayout(false);
            this.tabPageThucHienTiem.PerformLayout();
            this.tabPageTheoDoi.ResumeLayout(false);
            this.tabPageTheoDoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssHoTen;
        private System.Windows.Forms.ToolStripStatusLabel tssNgaySinh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTiepDon;
        private System.Windows.Forms.TabPage tabPageKhamSangLoc;
        private System.Windows.Forms.TabPage tabPageThucHienTiem;
        private System.Windows.Forms.TabPage tabPageTheoDoi;
        private System.Windows.Forms.ComboBox cmbKetQuaTiepDon;
        private System.Windows.Forms.ComboBox cmbCanBoTiepDon;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhiChuKham;
        private System.Windows.Forms.ComboBox cmbKetQuaKham;
        private System.Windows.Forms.ComboBox cmbCanBoKham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKetQuaTiem;
        private System.Windows.Forms.ComboBox cmbCanBoTiem;
        private System.Windows.Forms.DateTimePicker dtpNgayTiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCanBoTheoDoi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoMui;
        private System.Windows.Forms.ComboBox cmbVaccine;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGhiChuTheoDoi;
        private System.Windows.Forms.ComboBox cmbKeHoachTiem;
        private System.Windows.Forms.Label label12;
    }
}