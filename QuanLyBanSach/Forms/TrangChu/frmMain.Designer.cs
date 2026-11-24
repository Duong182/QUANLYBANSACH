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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLinhVuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaXuatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNguoiDung = new System.Windows.Forms.Panel();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblTieuDeNguoiDung = new System.Windows.Forms.Label();
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
            this.pnlSoLuongKhach.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuSach,
            this.mnuLinhVuc,
            this.mnuLoaiSach,
            this.mnuTacGia,
            this.mnuHoaDon,
            this.mniKho,
            this.mnuNhaXuatBan,
            this.mnuThongKe});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuMain.Size = new System.Drawing.Size(699, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(81, 19);
            this.mnuTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(113, 22);
            this.mnuThoat.Text = "THOÁT";
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(50, 19);
            this.mnuSach.Text = "SÁCH";
            // 
            // mnuLinhVuc
            // 
            this.mnuLinhVuc.Name = "mnuLinhVuc";
            this.mnuLinhVuc.Size = new System.Drawing.Size(72, 19);
            this.mnuLinhVuc.Text = "LĨNH VỰC";
            // 
            // mnuLoaiSach
            // 
            this.mnuLoaiSach.Name = "mnuLoaiSach";
            this.mnuLoaiSach.Size = new System.Drawing.Size(79, 19);
            this.mnuLoaiSach.Text = "LOẠI SÁCH";
            // 
            // mnuTacGia
            // 
            this.mnuTacGia.Name = "mnuTacGia";
            this.mnuTacGia.Size = new System.Drawing.Size(63, 19);
            this.mnuTacGia.Text = "TÁC GIẢ";
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(77, 19);
            this.mnuHoaDon.Text = "HÓA ĐƠN ";
            // 
            // mniKho
            // 
            this.mniKho.Name = "mniKho";
            this.mniKho.Size = new System.Drawing.Size(44, 19);
            this.mniKho.Text = "KHO";
            // 
            // mnuNhaXuatBan
            // 
            this.mnuNhaXuatBan.Name = "mnuNhaXuatBan";
            this.mnuNhaXuatBan.Size = new System.Drawing.Size(104, 19);
            this.mnuNhaXuatBan.Text = "NHÀ XUÁT BẢN";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(77, 19);
            this.mnuThongKe.Text = "THỐNG KÊ";
            // 
            // pnlNguoiDung
            // 
            this.pnlNguoiDung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlNguoiDung.Controls.Add(this.lblNgay);
            this.pnlNguoiDung.Controls.Add(this.lblNguoiDung);
            this.pnlNguoiDung.Controls.Add(this.lblTieuDeNguoiDung);
            this.pnlNguoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNguoiDung.Location = new System.Drawing.Point(0, 25);
            this.pnlNguoiDung.Name = "pnlNguoiDung";
            this.pnlNguoiDung.Size = new System.Drawing.Size(699, 45);
            this.pnlNguoiDung.TabIndex = 1;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(37, 15);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(72, 17);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "24/11/2-26";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Location = new System.Drawing.Point(643, 15);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(44, 17);
            this.lblNguoiDung.TabIndex = 1;
            this.lblNguoiDung.Text = "admin";
            // 
            // lblTieuDeNguoiDung
            // 
            this.lblTieuDeNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDeNguoiDung.AutoSize = true;
            this.lblTieuDeNguoiDung.Location = new System.Drawing.Point(544, 15);
            this.lblTieuDeNguoiDung.Name = "lblTieuDeNguoiDung";
            this.lblTieuDeNguoiDung.Size = new System.Drawing.Size(93, 17);
            this.lblTieuDeNguoiDung.TabIndex = 0;
            this.lblTieuDeNguoiDung.Text = "NGƯỜI DÙNG:";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSach.Location = new System.Drawing.Point(0, 70);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.Size = new System.Drawing.Size(699, 363);
            this.dgvSach.TabIndex = 2;
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThongKe.Controls.Add(this.pnlSoLuongKhach);
            this.pnlThongKe.Controls.Add(this.pnlDoanhThu);
            this.pnlThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThongKe.Location = new System.Drawing.Point(0, 361);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(699, 72);
            this.pnlThongKe.TabIndex = 3;
            // 
            // pnlSoLuongKhach
            // 
            this.pnlSoLuongKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSoLuongKhach.Controls.Add(this.lblSoLuongKhach);
            this.pnlSoLuongKhach.Controls.Add(this.lblTieuDeSoLuongKhach);
            this.pnlSoLuongKhach.Location = new System.Drawing.Point(362, 10);
            this.pnlSoLuongKhach.Name = "pnlSoLuongKhach";
            this.pnlSoLuongKhach.Size = new System.Drawing.Size(324, 57);
            this.pnlSoLuongKhach.TabIndex = 1;
            // 
            // lblSoLuongKhach
            // 
            this.lblSoLuongKhach.AutoSize = true;
            this.lblSoLuongKhach.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSoLuongKhach.Location = new System.Drawing.Point(147, 29);
            this.lblSoLuongKhach.Name = "lblSoLuongKhach";
            this.lblSoLuongKhach.Size = new System.Drawing.Size(53, 17);
            this.lblSoLuongKhach.TabIndex = 1;
            this.lblSoLuongKhach.Text = "0 người";
            this.lblSoLuongKhach.Click += new System.EventHandler(this.lblSoLuongKhach_Click);
            // 
            // lblTieuDeSoLuongKhach
            // 
            this.lblTieuDeSoLuongKhach.AutoSize = true;
            this.lblTieuDeSoLuongKhach.ForeColor = System.Drawing.Color.DimGray;
            this.lblTieuDeSoLuongKhach.Location = new System.Drawing.Point(112, 12);
            this.lblTieuDeSoLuongKhach.Name = "lblTieuDeSoLuongKhach";
            this.lblTieuDeSoLuongKhach.Size = new System.Drawing.Size(119, 17);
            this.lblTieuDeSoLuongKhach.TabIndex = 0;
            this.lblTieuDeSoLuongKhach.Text = "SỐ LƯỢNG KHÁCH";
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.lblTieuDeDoanhThu);
            this.pnlDoanhThu.Location = new System.Drawing.Point(12, 10);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(324, 57);
            this.pnlDoanhThu.TabIndex = 0;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDoanhThu.Location = new System.Drawing.Point(113, 29);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(42, 17);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "0VND";
            // 
            // lblTieuDeDoanhThu
            // 
            this.lblTieuDeDoanhThu.AutoSize = true;
            this.lblTieuDeDoanhThu.ForeColor = System.Drawing.Color.DimGray;
            this.lblTieuDeDoanhThu.Location = new System.Drawing.Point(72, 12);
            this.lblTieuDeDoanhThu.Name = "lblTieuDeDoanhThu";
            this.lblTieuDeDoanhThu.Size = new System.Drawing.Size(168, 17);
            this.lblTieuDeDoanhThu.TabIndex = 0;
            this.lblTieuDeDoanhThu.Text = "DOANH THU TRONG NGÀY";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 433);
            this.Controls.Add(this.pnlThongKe);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.pnlNguoiDung);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÀ SÁCH";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlNguoiDung.ResumeLayout(false);
            this.pnlNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.pnlThongKe.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem mnuLinhVuc;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiSach;
        private System.Windows.Forms.ToolStripMenuItem mnuTacGia;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mniKho;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaXuatBan;
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
    }
}