using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    partial class frmSach
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLinhVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBoCuc = new System.Windows.Forms.TableLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tblTimKiem = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.tblNhap = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblGiaBia = new System.Windows.Forms.Label();
            this.txtGiaBia = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.cboTacGia = new System.Windows.Forms.ComboBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.lblLinhVuc = new System.Windows.Forms.Label();
            this.cboLinhVuc = new System.Windows.Forms.ComboBox();
            this.pnlNut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tblBoCuc.SuspendLayout();
            this.tblTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.tblNhap.SuspendLayout();
            this.pnlNut.SuspendLayout();
            this.SuspendLayout();
            //
            // MaSach
            //
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.FillWeight = 11F;
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.MinimumWidth = 96;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            //
            // TenSach
            //
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.FillWeight = 27F;
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.MinimumWidth = 145;
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            //
            // TenTacGia
            //
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.FillWeight = 18F;
            this.TenTacGia.HeaderText = "Tác giả";
            this.TenTacGia.MinimumWidth = 100;
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            //
            // TenLoaiSach
            //
            this.TenLoaiSach.DataPropertyName = "TenLoaiSach";
            this.TenLoaiSach.FillWeight = 14F;
            this.TenLoaiSach.HeaderText = "Thể loại";
            this.TenLoaiSach.MinimumWidth = 85;
            this.TenLoaiSach.Name = "TenLoaiSach";
            this.TenLoaiSach.ReadOnly = true;
            //
            // TenLinhVuc
            //
            this.TenLinhVuc.DataPropertyName = "TenLinhVuc";
            this.TenLinhVuc.FillWeight = 15F;
            this.TenLinhVuc.HeaderText = "Lĩnh vực";
            this.TenLinhVuc.MinimumWidth = 85;
            this.TenLinhVuc.Name = "TenLinhVuc";
            this.TenLinhVuc.ReadOnly = true;
            //
            // GiaBia
            //
            this.GiaBia.DataPropertyName = "GiaBia";
            this.GiaBia.FillWeight = 15F;
            this.GiaBia.HeaderText = "Giá bìa (đ)";
            this.GiaBia.MinimumWidth = 100;
            this.GiaBia.Name = "GiaBia";
            this.GiaBia.ReadOnly = true;
            //
            // tblBoCuc
            //
            this.tblBoCuc.ColumnCount = 1;
            this.tblBoCuc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBoCuc.Controls.Add(this.lblTieuDe, 0, 0);
            this.tblBoCuc.Controls.Add(this.tblTimKiem, 0, 1);
            this.tblBoCuc.Controls.Add(this.dgvSach, 0, 2);
            this.tblBoCuc.Controls.Add(this.lblTrangThai, 0, 3);
            this.tblBoCuc.Controls.Add(this.tblNhap, 0, 4);
            this.tblBoCuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBoCuc.Location = new System.Drawing.Point(0, 0);
            this.tblBoCuc.Name = "tblBoCuc";
            this.tblBoCuc.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
            this.tblBoCuc.RowCount = 5;
            this.tblBoCuc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBoCuc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBoCuc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBoCuc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBoCuc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBoCuc.Size = new System.Drawing.Size(1040, 650);
            this.tblBoCuc.TabIndex = 0;
            //
            // lblTieuDe
            //
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(20, 14);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(364, 74);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Quản lý sách";
            //
            // tblTimKiem
            //
            this.tblTimKiem.AutoSize = true;
            this.tblTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblTimKiem.ColumnCount = 4;
            this.tblTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblTimKiem.Controls.Add(this.lblTimKiem, 0, 0);
            this.tblTimKiem.Controls.Add(this.txtTimKiem, 1, 0);
            this.tblTimKiem.Controls.Add(this.btnTim, 2, 0);
            this.tblTimKiem.Controls.Add(this.btnTaiLai, 3, 0);
            this.tblTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTimKiem.Location = new System.Drawing.Point(20, 100);
            this.tblTimKiem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tblTimKiem.Name = "tblTimKiem";
            this.tblTimKiem.RowCount = 1;
            this.tblTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTimKiem.Size = new System.Drawing.Size(1000, 47);
            this.tblTimKiem.TabIndex = 1;
            //
            // lblTimKiem
            //
            this.lblTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(0, 5);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(120, 37);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm sách";
            //
            // txtTimKiem
            //
            this.txtTimKiem.AccessibleName = "Tìm sách";
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(130, 2);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.txtTimKiem.MaxLength = 200;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(583, 43);
            this.txtTimKiem.TabIndex = 0;
            //
            // btnTim
            //
            this.btnTim.AutoSize = true;
            this.btnTim.Location = new System.Drawing.Point(721, 0);
            this.btnTim.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnTim.MinimumSize = new System.Drawing.Size(80, 32);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTim.Size = new System.Drawing.Size(91, 47);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.TimSach_Click);
            //
            // btnTaiLai
            //
            this.btnTaiLai.AutoSize = true;
            this.btnTaiLai.Location = new System.Drawing.Point(820, 0);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnTaiLai.MinimumSize = new System.Drawing.Size(80, 32);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTaiLai.Size = new System.Drawing.Size(172, 47);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "Xem tất cả";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.TaiLai_Click);
            //
            // dgvSach
            //
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TenTacGia,
            this.TenLoaiSach,
            this.TenLinhVuc,
            this.GiaBia});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(20, 157);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 82;
            this.dgvSach.RowTemplate.Height = 32;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1000, 189);
            this.dgvSach.TabIndex = 1;
            this.dgvSach.SelectionChanged += new System.EventHandler(this.ChonSach);
            //
            // lblTrangThai
            //
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(20, 353);
            this.lblTrangThai.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(0, 37);
            this.lblTrangThai.TabIndex = 2;
            //
            // tblNhap
            //
            this.tblNhap.AutoSize = true;
            this.tblNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblNhap.ColumnCount = 3;
            this.tblNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblNhap.Controls.Add(this.lblMaSach, 0, 0);
            this.tblNhap.Controls.Add(this.txtMaSach, 0, 1);
            this.tblNhap.Controls.Add(this.lblTenSach, 1, 0);
            this.tblNhap.Controls.Add(this.txtTenSach, 1, 1);
            this.tblNhap.Controls.Add(this.lblGiaBia, 2, 0);
            this.tblNhap.Controls.Add(this.txtGiaBia, 2, 1);
            this.tblNhap.Controls.Add(this.lblTacGia, 0, 2);
            this.tblNhap.Controls.Add(this.cboTacGia, 0, 3);
            this.tblNhap.Controls.Add(this.lblTheLoai, 1, 2);
            this.tblNhap.Controls.Add(this.cboTheLoai, 1, 3);
            this.tblNhap.Controls.Add(this.lblLinhVuc, 2, 2);
            this.tblNhap.Controls.Add(this.cboLinhVuc, 2, 3);
            this.tblNhap.Controls.Add(this.pnlNut, 0, 4);
            this.tblNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblNhap.Location = new System.Drawing.Point(20, 397);
            this.tblNhap.Margin = new System.Windows.Forms.Padding(0);
            this.tblNhap.Name = "tblNhap";
            this.tblNhap.Padding = new System.Windows.Forms.Padding(12, 8, 4, 10);
            this.tblNhap.RowCount = 5;
            this.tblNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNhap.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNhap.Size = new System.Drawing.Size(1000, 239);
            this.tblNhap.TabIndex = 3;
            //
            // lblMaSach
            //
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(12, 8);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(0, 0, 8, 3);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(114, 37);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách";
            //
            // txtMaSach
            //
            this.txtMaSach.AccessibleName = "Mã sách";
            this.txtMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSach.Location = new System.Drawing.Point(12, 48);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.txtMaSach.MaxLength = 20;
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(319, 43);
            this.txtMaSach.TabIndex = 0;
            //
            // lblTenSach
            //
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(339, 8);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(0, 0, 8, 3);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(116, 37);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "Tên sách";
            //
            // txtTenSach
            //
            this.txtTenSach.AccessibleName = "Tên sách";
            this.txtTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSach.Location = new System.Drawing.Point(339, 48);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.txtTenSach.MaxLength = 200;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(319, 43);
            this.txtTenSach.TabIndex = 1;
            //
            // lblGiaBia
            //
            this.lblGiaBia.AutoSize = true;
            this.lblGiaBia.Location = new System.Drawing.Point(666, 8);
            this.lblGiaBia.Margin = new System.Windows.Forms.Padding(0, 0, 8, 3);
            this.lblGiaBia.Name = "lblGiaBia";
            this.lblGiaBia.Size = new System.Drawing.Size(140, 37);
            this.lblGiaBia.TabIndex = 2;
            this.lblGiaBia.Text = "Giá bìa (đ)";
            //
            // txtGiaBia
            //
            this.txtGiaBia.AccessibleName = "Giá bìa (đ)";
            this.txtGiaBia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBia.Location = new System.Drawing.Point(666, 48);
            this.txtGiaBia.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.txtGiaBia.MaxLength = 30;
            this.txtGiaBia.Name = "txtGiaBia";
            this.txtGiaBia.Size = new System.Drawing.Size(322, 43);
            this.txtGiaBia.TabIndex = 2;
            //
            // lblTacGia
            //
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(12, 99);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(0, 0, 8, 3);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(98, 37);
            this.lblTacGia.TabIndex = 3;
            this.lblTacGia.Text = "Tác giả";
            //
            // cboTacGia
            //
            this.cboTacGia.AccessibleName = "Tác giả";
            this.cboTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTacGia.Location = new System.Drawing.Point(12, 139);
            this.cboTacGia.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.cboTacGia.Name = "cboTacGia";
            this.cboTacGia.Size = new System.Drawing.Size(319, 45);
            this.cboTacGia.TabIndex = 3;
            //
            // lblTheLoai
            //
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(339, 99);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(0, 0, 8, 3);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(111, 37);
            this.lblTheLoai.TabIndex = 4;
            this.lblTheLoai.Text = "Thể loại";
            //
            // cboTheLoai
            //
            this.cboTheLoai.AccessibleName = "Thể loại";
            this.cboTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.Location = new System.Drawing.Point(339, 139);
            this.cboTheLoai.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(319, 45);
            this.cboTheLoai.TabIndex = 4;
            //
            // lblLinhVuc
            //
            this.lblLinhVuc.AutoSize = true;
            this.lblLinhVuc.Location = new System.Drawing.Point(666, 99);
            this.lblLinhVuc.Margin = new System.Windows.Forms.Padding(0, 0, 8, 3);
            this.lblLinhVuc.Name = "lblLinhVuc";
            this.lblLinhVuc.Size = new System.Drawing.Size(115, 37);
            this.lblLinhVuc.TabIndex = 5;
            this.lblLinhVuc.Text = "Lĩnh vực";
            //
            // cboLinhVuc
            //
            this.cboLinhVuc.AccessibleName = "Lĩnh vực";
            this.cboLinhVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLinhVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLinhVuc.Location = new System.Drawing.Point(666, 139);
            this.cboLinhVuc.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.cboLinhVuc.Name = "cboLinhVuc";
            this.cboLinhVuc.Size = new System.Drawing.Size(322, 45);
            this.cboLinhVuc.TabIndex = 5;
            //
            // pnlNut
            //
            this.pnlNut.AutoSize = true;
            this.pnlNut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblNhap.SetColumnSpan(this.pnlNut, 3);
            this.pnlNut.Controls.Add(this.btnNhapMoi);
            this.pnlNut.Controls.Add(this.btnThem);
            this.pnlNut.Controls.Add(this.btnSua);
            this.pnlNut.Controls.Add(this.btnXoa);
            this.pnlNut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNut.Location = new System.Drawing.Point(12, 182);
            this.pnlNut.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlNut.Name = "pnlNut";
            this.pnlNut.Size = new System.Drawing.Size(984, 47);
            this.pnlNut.TabIndex = 6;
            this.pnlNut.WrapContents = false;
            //
            // btnNhapMoi
            //
            this.btnNhapMoi.AutoSize = true;
            this.btnNhapMoi.Location = new System.Drawing.Point(0, 0);
            this.btnNhapMoi.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnNhapMoi.MinimumSize = new System.Drawing.Size(80, 32);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNhapMoi.Size = new System.Drawing.Size(165, 47);
            this.btnNhapMoi.TabIndex = 0;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.NhapMoi_Click);
            //
            // btnThem
            //
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(173, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnThem.MinimumSize = new System.Drawing.Size(80, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThem.Size = new System.Drawing.Size(172, 47);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.ThemSach_Click);
            //
            // btnSua
            //
            this.btnSua.AutoSize = true;
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(353, 0);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnSua.MinimumSize = new System.Drawing.Size(80, 32);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSua.Size = new System.Drawing.Size(139, 47);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Lưu sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.SuaSach_Click);
            //
            // btnXoa
            //
            this.btnXoa.AutoSize = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(500, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnXoa.MinimumSize = new System.Drawing.Size(80, 32);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXoa.Size = new System.Drawing.Size(152, 47);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa sách";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.XoaSach_Click);
            //
            // frmSach
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.tblBoCuc);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(820, 530);
            this.Name = "frmSach";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý sách";
            this.tblBoCuc.ResumeLayout(false);
            this.tblBoCuc.PerformLayout();
            this.tblTimKiem.ResumeLayout(false);
            this.tblTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.tblNhap.ResumeLayout(false);
            this.tblNhap.PerformLayout();
            this.pnlNut.ResumeLayout(false);
            this.pnlNut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblBoCuc;
        private Label lblTieuDe;
        private TableLayoutPanel tblTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTim;
        private Button btnTaiLai;
        private DataGridView dgvSach;
        private Label lblTrangThai;
        private TableLayoutPanel tblNhap;
        private Label lblMaSach;
        private TextBox txtMaSach;
        private Label lblTenSach;
        private TextBox txtTenSach;
        private Label lblGiaBia;
        private TextBox txtGiaBia;
        private Label lblTacGia;
        private ComboBox cboTacGia;
        private Label lblTheLoai;
        private ComboBox cboTheLoai;
        private Label lblLinhVuc;
        private ComboBox cboLinhVuc;
        private FlowLayoutPanel pnlNut;
        private Button btnNhapMoi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLinhVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBia;
    }
}
