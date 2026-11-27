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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.pnlDanhSach = new System.Windows.Forms.Panel();
            this.tblThongKe = new System.Windows.Forms.TableLayoutPanel();
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.pnlSoLuongKhach = new System.Windows.Forms.Panel();
            this.lblSoLuongKhach = new System.Windows.Forms.Label();
            this.lblTieuDeSoLuongKhach = new System.Windows.Forms.Label();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblTieuDeDoanhThu = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.pnlNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.pnlThongKe.SuspendLayout();
            this.tblThongKe.SuspendLayout();
            this.pnlDanhSach.SuspendLayout();
            this.pnlSoLuongKhach.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuSach,
            this.mnuLoaiSach,
            this.mnuTacGia,
            this.mnuThongKe});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(17, 7, 17, 7);
            this.menuMain.Size = new System.Drawing.Size(1000, 39);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuTaiKhoan.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(81, 19);
            this.mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(113, 22);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuSach
            // 
            this.mnuSach.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(50, 19);
            this.mnuSach.Text = "Sách";
            // 
            // mnuLoaiSach
            // 
            this.mnuLoaiSach.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuLoaiSach.Name = "mnuLoaiSach";
            this.mnuLoaiSach.Size = new System.Drawing.Size(79, 19);
            this.mnuLoaiSach.Text = "Thể loại";
            // 
            // mnuTacGia
            // 
            this.mnuTacGia.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuTacGia.Name = "mnuTacGia";
            this.mnuTacGia.Size = new System.Drawing.Size(63, 19);
            this.mnuTacGia.Text = "Tác giả";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(77, 19);
            this.mnuThongKe.Text = "Thống kê";
            // 
            // pnlNguoiDung
            // 
            this.pnlNguoiDung.Controls.Add(this.lblTieuDeTrang);
            this.pnlNguoiDung.Controls.Add(this.lblNgay);
            this.pnlNguoiDung.Controls.Add(this.lblNguoiDung);
            this.pnlNguoiDung.Controls.Add(this.lblTieuDeNguoiDung);
            this.pnlNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNguoiDung.Location = new System.Drawing.Point(0, 39);
            this.pnlNguoiDung.Name = "pnlNguoiDung";
            this.pnlNguoiDung.Size = new System.Drawing.Size(1000, 107);
            this.pnlNguoiDung.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(26, 70);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(72, 17);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNguoiDung.AutoEllipsis = true;
            this.lblNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNguoiDung.AutoSize = false;
            this.lblNguoiDung.Location = new System.Drawing.Point(694, 60);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(280, 22);
            this.lblNguoiDung.TabIndex = 1;
            this.lblNguoiDung.Text = "";
            // 
            // lblTieuDeNguoiDung
            // 
            this.lblTieuDeNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTieuDeNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDeNguoiDung.AutoSize = false;
            this.lblTieuDeNguoiDung.Location = new System.Drawing.Point(694, 35);
            this.lblTieuDeNguoiDung.Name = "lblTieuDeNguoiDung";
            this.lblTieuDeNguoiDung.Size = new System.Drawing.Size(280, 22);
            this.lblTieuDeNguoiDung.TabIndex = 0;
            this.lblTieuDeNguoiDung.Text = "Người dùng";
            // 
            // dgvSach
            // 
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.RowTemplate.Height = 37;
            this.dgvSach.ColumnHeadersHeight = 42;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            rowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSach.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvSach.DefaultCellStyle = rowStyle;
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(24, 37);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.Size = new System.Drawing.Size(952, 334);
            this.dgvSach.TabIndex = 2;
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.Padding = new System.Windows.Forms.Padding(24, 0, 24, 17);
            this.pnlThongKe.Controls.Add(this.tblThongKe);
            this.pnlThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongKe.Location = new System.Drawing.Point(0, 146);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(1000, 111);
            this.pnlThongKe.TabIndex = 3;
            // 
            // pnlSoLuongKhach
            // 
            this.pnlSoLuongKhach.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSoLuongKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSoLuongKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSoLuongKhach.Controls.Add(this.lblSoLuongKhach);
            this.pnlSoLuongKhach.Controls.Add(this.lblTieuDeSoLuongKhach);
            this.pnlSoLuongKhach.Location = new System.Drawing.Point(362, 10);
            this.pnlSoLuongKhach.Name = "pnlSoLuongKhach";
            this.pnlSoLuongKhach.Size = new System.Drawing.Size(468, 94);
            this.pnlSoLuongKhach.TabIndex = 1;
            // 
            // lblSoLuongKhach
            // 
            this.lblSoLuongKhach.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongKhach.AutoSize = true;
            this.lblSoLuongKhach.Location = new System.Drawing.Point(16, 38);
            this.lblSoLuongKhach.Name = "lblSoLuongKhach";
            this.lblSoLuongKhach.Size = new System.Drawing.Size(53, 17);
            this.lblSoLuongKhach.TabIndex = 1;
            this.lblSoLuongKhach.Text = "0 người";
            this.lblSoLuongKhach.Click += new System.EventHandler(this.lblSoLuongKhach_Click);
            // 
            // lblTieuDeSoLuongKhach
            // 
            this.lblTieuDeSoLuongKhach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblTieuDeSoLuongKhach.AutoSize = true;
            this.lblTieuDeSoLuongKhach.Location = new System.Drawing.Point(18, 14);
            this.lblTieuDeSoLuongKhach.Name = "lblTieuDeSoLuongKhach";
            this.lblTieuDeSoLuongKhach.Size = new System.Drawing.Size(119, 17);
            this.lblTieuDeSoLuongKhach.TabIndex = 0;
            this.lblTieuDeSoLuongKhach.Text = "Khách hàng hôm nay";
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.lblTieuDeDoanhThu);
            this.pnlDoanhThu.Location = new System.Drawing.Point(12, 10);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(468, 94);
            this.pnlDoanhThu.TabIndex = 0;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(16, 38);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(42, 17);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "0 VND";
            // 
            // lblTieuDeDoanhThu
            // 
            this.lblTieuDeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblTieuDeDoanhThu.AutoSize = true;
            this.lblTieuDeDoanhThu.Location = new System.Drawing.Point(18, 14);
            this.lblTieuDeDoanhThu.Name = "lblTieuDeDoanhThu";
            this.lblTieuDeDoanhThu.Size = new System.Drawing.Size(168, 17);
            this.lblTieuDeDoanhThu.TabIndex = 0;
            this.lblTieuDeDoanhThu.Text = "Doanh thu hôm nay";
            //
            // lblTieuDeTrang
            //
            this.lblTieuDeTrang.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeTrang.AutoSize = true;
            this.lblTieuDeTrang.Location = new System.Drawing.Point(24, 23);
            this.lblTieuDeTrang.Text = "Tổng quan";
            this.lblTieuDeTrang.Name = "lblTieuDeTrang";
            //
            // tblThongKe
            //
            this.tblThongKe.Size = new System.Drawing.Size(952, 94);
            this.tblThongKe.TabStop = false;
            this.tblThongKe.RowCount = 1;
            this.tblThongKe.ColumnCount = 3;
            this.tblThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblThongKe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongKe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblThongKe.Controls.Add(this.pnlDoanhThu, 0, 0);
            this.tblThongKe.Controls.Add(this.pnlSoLuongKhach, 2, 0);
            this.tblThongKe.Name = "tblThongKe";
            //
            // pnlDanhSach
            //
            this.pnlDanhSach.Padding = new System.Windows.Forms.Padding(24, 0, 24, 22);
            this.pnlDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSach.Controls.Add(this.dgvSach);
            this.pnlDanhSach.Controls.Add(this.lblDanhSach);
            this.pnlDanhSach.Name = "pnlDanhSach";
            //
            // lblDanhSach
            //
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDanhSach.Text = "Danh mục sách";
            this.lblDanhSach.Height = 37;
            this.lblDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSach.Name = "lblDanhSach";
            // 
            // frmMain
            // 
            this.MinimumSize = new System.Drawing.Size(870, 530);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlDanhSach);
            this.Controls.Add(this.pnlThongKe);
            this.Controls.Add(this.pnlNguoiDung);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlNguoiDung.ResumeLayout(false);
            this.pnlNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.pnlThongKe.ResumeLayout(false);
            this.tblThongKe.ResumeLayout(false);
            this.pnlDanhSach.ResumeLayout(false);
            this.pnlSoLuongKhach.ResumeLayout(false);
            this.pnlSoLuongKhach.PerformLayout();
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlDoanhThu.PerformLayout();
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
    }
}
