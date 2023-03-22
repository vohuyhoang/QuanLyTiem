
namespace QuanLyTiem.UserInterface
{
    partial class FormLichSuTiemChung
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportViewerLichSuTiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewerLichSuTiem, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reportViewerLichSuTiem
            // 
            this.reportViewerLichSuTiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerLichSuTiem.Location = new System.Drawing.Point(3, 3);
            this.reportViewerLichSuTiem.Name = "reportViewerLichSuTiem";
            this.reportViewerLichSuTiem.ServerReport.BearerToken = null;
            this.reportViewerLichSuTiem.Size = new System.Drawing.Size(705, 356);
            this.reportViewerLichSuTiem.TabIndex = 0;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(15, 3);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(209, 21);
            this.cmbHoTen.TabIndex = 1;
            this.cmbHoTen.Visible = false;
            // 
            // FormLichSuTiemChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(735, 404);
            this.Controls.Add(this.cmbHoTen);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormLichSuTiemChung";
            this.ShowIcon = false;
            this.Text = "Lịch sử tiêm chủng";
            this.Load += new System.EventHandler(this.FormLichSuTiemChung_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerLichSuTiem;
        private System.Windows.Forms.ComboBox cmbHoTen;
    }
}