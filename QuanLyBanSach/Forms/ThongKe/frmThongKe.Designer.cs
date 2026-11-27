namespace QuanLyBanSach.Forms.ThongKe
{
    partial class frmThongKe
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
            this.pnlBangThongKe = new System.Windows.Forms.Panel();
            this.lblTieuDeThongKe = new System.Windows.Forms.Label();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.pnlTimKiem.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.pnlBangThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.Controls.Add(this.lblTieuDeThongKe);
            this.pnlTimKiem.Controls.Add(this.btnTimKiem);
            this.pnlTimKiem.Controls.Add(this.dtpDenNgay);
            this.pnlTimKiem.Controls.Add(this.dtpTuNgay);
            this.pnlTimKiem.Controls.Add(this.lblDenNgay);
            this.pnlTimKiem.Controls.Add(this.lblTuNgay);
            this.pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimKiem.Location = new System.Drawing.Point(0, 0);
            this.pnlTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(860, 126);
            this.pnlTimKiem.TabIndex = 0;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(25, 80);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(61, 17);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(274, 80);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(71, 17);
            this.lblDenNgay.TabIndex = 1;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(90, 76);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(152, 25);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(347, 76);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(152, 25);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnTimKiem.Location = new System.Drawing.Point(522, 69);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 37);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Controls.Add(this.btnThoat);
            this.pnlChucNang.Controls.Add(this.btnXuatBaoCao);
            this.pnlChucNang.Controls.Add(this.lblTongTien);
            this.pnlChucNang.Controls.Add(this.lblSoHoaDon);
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 434);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(860, 106);
            this.pnlChucNang.TabIndex = 1;
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Location = new System.Drawing.Point(26, 14);
            this.lblSoHoaDon.Name = "lblSoHoaDon";
            this.lblSoHoaDon.Size = new System.Drawing.Size(103, 17);
            this.lblSoHoaDon.TabIndex = 0;
            this.lblSoHoaDon.Text = "Số hóa đơn: 0";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(235, 14);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(120, 17);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền: 0 VND";
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatBaoCao.Location = new System.Drawing.Point(582, 48);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(148, 37);
            this.btnXuatBaoCao.TabIndex = 2;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(742, 48);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 37);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.RowTemplate.Height = 37;
            this.dgvThongKe.ColumnHeadersHeight = 42;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            headerStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            rowStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            rowStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            rowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvThongKe.DefaultCellStyle = rowStyle;
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(24, 0);
            this.dgvThongKe.MultiSelect = false;
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(812, 308);
            this.dgvThongKe.TabIndex = 2;
            //
            // lblTieuDeThongKe
            //
            this.lblTieuDeThongKe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeThongKe.AutoSize = true;
            this.lblTieuDeThongKe.Text = "Thống kê hóa đơn";
            this.lblTieuDeThongKe.Location = new System.Drawing.Point(24, 18);
            this.lblTieuDeThongKe.Name = "lblTieuDeThongKe";
            //
            // pnlBangThongKe
            //
            this.pnlBangThongKe.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.pnlBangThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBangThongKe.Controls.Add(this.dgvThongKe);
            this.pnlBangThongKe.Name = "pnlBangThongKe";
            // 
            // frmThongKe
            // 
            this.MinimumSize = new System.Drawing.Size(810, 440);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.pnlBangThongKe);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.pnlTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê hóa đơn";
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlBangThongKe.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label lblTieuDeThongKe;
        private System.Windows.Forms.Panel pnlBangThongKe;
    }
}
