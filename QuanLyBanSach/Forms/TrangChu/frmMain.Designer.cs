namespace QuanLyBanSach.GUI.TrangChu
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.tblThongKe = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblTieuDeDoanhThu = new System.Windows.Forms.Label();
            this.pnlSoLuongKhach = new System.Windows.Forms.Panel();
            this.lblSoLuongKhach = new System.Windows.Forms.Label();
            this.lblTieuDeSoLuongKhach = new System.Windows.Forms.Label();
            this.lblTieuDeTrang = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNguoiDung = new System.Windows.Forms.Panel();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblTieuDeNguoiDung = new System.Windows.Forms.Label();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.tblThongKe.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            this.pnlSoLuongKhach.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.pnlNguoiDung.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.Location = new System.Drawing.Point(24, 0);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(952, 37);
            this.lblDanhSach.TabIndex = 3;
            this.lblDanhSach.Text = "Danh mục sách";
            // 
            // pnlDanhSach
            // 
            this.pnlDanhSach.Controls.Add(this.dgvSach);
            this.pnlDanhSach.Controls.Add(this.lblDanhSach);
            this.pnlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSach.Location = new System.Drawing.Point(0, 266);
            this.pnlDanhSach.Name = "pnlDanhSach";
            this.pnlDanhSach.Padding = new System.Windows.Forms.Padding(24, 0, 24, 22);
            this.pnlDanhSach.Size = new System.Drawing.Size(1000, 384);
            this.pnlDanhSach.TabIndex = 0;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSach.ColumnHeadersHeight = 42;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(24, 37);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 62;
            this.dgvSach.RowTemplate.Height = 37;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(952, 325);
            this.dgvSach.TabIndex = 2;
            // 
            // tblThongKe
            // 
            this.tblThongKe.ColumnCount = 3;
            this.tblThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongKe.Controls.Add(this.pnlDoanhThu, 0, 0);
            this.tblThongKe.Controls.Add(this.pnlSoLuongKhach, 2, 0);
            this.tblThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThongKe.Location = new System.Drawing.Point(24, 0);
            this.tblThongKe.Name = "tblThongKe";
            this.tblThongKe.RowCount = 1;
            this.tblThongKe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblThongKe.Size = new System.Drawing.Size(952, 94);
            this.tblThongKe.TabIndex = 0;
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.lblTieuDeDoanhThu);
            this.pnlDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.pnlDoanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(468, 94);
            this.pnlDoanhThu.TabIndex = 0;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.Location = new System.Drawing.Point(16, 38);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(146, 54);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "0 VND";
            // 
            // lblTieuDeDoanhThu
            // 
            this.lblTieuDeDoanhThu.AutoSize = true;
            this.lblTieuDeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTieuDeDoanhThu.Location = new System.Drawing.Point(18, 14);
            this.lblTieuDeDoanhThu.Name = "lblTieuDeDoanhThu";
            this.lblTieuDeDoanhThu.Size = new System.Drawing.Size(185, 28);
            this.lblTieuDeDoanhThu.TabIndex = 0;
            this.lblTieuDeDoanhThu.Text = "Doanh thu hôm nay";
            // 
            // pnlSoLuongKhach
            // 
            this.pnlSoLuongKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSoLuongKhach.Controls.Add(this.lblSoLuongKhach);
            this.pnlSoLuongKhach.Controls.Add(this.lblTieuDeSoLuongKhach);
            this.pnlSoLuongKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSoLuongKhach.Location = new System.Drawing.Point(484, 0);
            this.pnlSoLuongKhach.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSoLuongKhach.Name = "pnlSoLuongKhach";
            this.pnlSoLuongKhach.Size = new System.Drawing.Size(468, 94);
            this.pnlSoLuongKhach.TabIndex = 1;
            // 
            // lblSoLuongKhach
            // 
            this.lblSoLuongKhach.AutoSize = true;
            this.lblSoLuongKhach.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongKhach.Location = new System.Drawing.Point(16, 38);
            this.lblSoLuongKhach.Name = "lblSoLuongKhach";
            this.lblSoLuongKhach.Size = new System.Drawing.Size(169, 54);
            this.lblSoLuongKhach.TabIndex = 1;
            this.lblSoLuongKhach.Text = "0 người";
            this.lblSoLuongKhach.Click += new System.EventHandler(this.lblSoLuongKhach_Click);
            // 
            // lblTieuDeSoLuongKhach
            // 
            this.lblTieuDeSoLuongKhach.AutoSize = true;
            this.lblTieuDeSoLuongKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTieuDeSoLuongKhach.Location = new System.Drawing.Point(18, 14);
            this.lblTieuDeSoLuongKhach.Name = "lblTieuDeSoLuongKhach";
            this.lblTieuDeSoLuongKhach.Size = new System.Drawing.Size(195, 28);
            this.lblTieuDeSoLuongKhach.TabIndex = 0;
            this.lblTieuDeSoLuongKhach.Text = "Khách hàng hôm nay";
            // 
            // lblTieuDeTrang
            // 
            this.lblTieuDeTrang.AutoSize = true;
            this.lblTieuDeTrang.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeTrang.Location = new System.Drawing.Point(24, 23);
            this.lblTieuDeTrang.Name = "lblTieuDeTrang";
            this.lblTieuDeTrang.Size = new System.Drawing.Size(271, 65);
            this.lblTieuDeTrang.TabIndex = 0;
            this.lblTieuDeTrang.Text = "Tổng quan";
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuSach,
            this.mnuLoaiSach,
            this.mnuTacGia,
            this.mnuThongKe,
            this.mnuQuanLy});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.menuMain.Size = new System.Drawing.Size(1000, 48);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuTaiKhoan.Size = new System.Drawing.Size(114, 34);
            this.mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuThoat.Size = new System.Drawing.Size(180, 34);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuSach.Size = new System.Drawing.Size(73, 34);
            this.mnuSach.Text = "Sách";
            // 
            // mnuLoaiSach
            // 
            this.mnuLoaiSach.Name = "mnuLoaiSach";
            this.mnuLoaiSach.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuLoaiSach.Size = new System.Drawing.Size(100, 34);
            this.mnuLoaiSach.Text = "Thể loại";
            // 
            // mnuTacGia
            // 
            this.mnuTacGia.Name = "mnuTacGia";
            this.mnuTacGia.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuTacGia.Size = new System.Drawing.Size(91, 34);
            this.mnuTacGia.Text = "Tác giả";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuThongKe.Size = new System.Drawing.Size(113, 34);
            this.mnuThongKe.Text = "Thống kê";
            // 
            // pnlNguoiDung
            // 
            this.pnlNguoiDung.Controls.Add(this.lblTieuDeTrang);
            this.pnlNguoiDung.Controls.Add(this.lblNgay);
            this.pnlNguoiDung.Controls.Add(this.lblNguoiDung);
            this.pnlNguoiDung.Controls.Add(this.lblTieuDeNguoiDung);
            this.pnlNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNguoiDung.Location = new System.Drawing.Point(0, 48);
            this.pnlNguoiDung.Name = "pnlNguoiDung";
            this.pnlNguoiDung.Size = new System.Drawing.Size(1000, 107);
            this.pnlNguoiDung.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(26, 70);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(0, 28);
            this.lblNgay.TabIndex = 2;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNguoiDung.AutoEllipsis = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDung.Location = new System.Drawing.Point(694, 60);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(280, 22);
            this.lblNguoiDung.TabIndex = 1;
            this.lblNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTieuDeNguoiDung
            // 
            this.lblTieuDeNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDeNguoiDung.Location = new System.Drawing.Point(694, 35);
            this.lblTieuDeNguoiDung.Name = "lblTieuDeNguoiDung";
            this.lblTieuDeNguoiDung.Size = new System.Drawing.Size(280, 22);
            this.lblTieuDeNguoiDung.TabIndex = 0;
            this.lblTieuDeNguoiDung.Text = "Người dùng";
            this.lblTieuDeNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.Controls.Add(this.tblThongKe);
            this.pnlThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongKe.Location = new System.Drawing.Point(0, 155);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Padding = new System.Windows.Forms.Padding(24, 0, 24, 17);
            this.pnlThongKe.Size = new System.Drawing.Size(1000, 111);
            this.pnlThongKe.TabIndex = 3;
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuKhachHang});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(95, 34);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(270, 36);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(270, 36);
            this.mnuKhachHang.Text = "Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlDanhSach);
            this.Controls.Add(this.pnlThongKe);
            this.Controls.Add(this.pnlNguoiDung);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(870, 530);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnlDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.tblThongKe.ResumeLayout(false);
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlDoanhThu.PerformLayout();
            this.pnlSoLuongKhach.ResumeLayout(false);
            this.pnlSoLuongKhach.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlNguoiDung.ResumeLayout(false);
            this.pnlNguoiDung.PerformLayout();
            this.pnlThongKe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiSach;
        private System.Windows.Forms.ToolStripMenuItem mnuTacGia;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.Panel pnlNguoiDung;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Label lblTieuDeNguoiDung;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel pnlThongKe;
        private System.Windows.Forms.Panel pnlSoLuongKhach;
        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblTieuDeDoanhThu;
        private System.Windows.Forms.Label lblSoLuongKhach;
        private System.Windows.Forms.Label lblTieuDeSoLuongKhach;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTieuDeTrang;
        private System.Windows.Forms.TableLayoutPanel tblThongKe;
        private System.Windows.Forms.Panel pnlDanhSach;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
    }
}
