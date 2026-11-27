using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    partial class frmTheLoai
    {
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBoCuc = new TableLayoutPanel();
            this.lblTieuDe = new Label();
            this.tblTimKiem = new TableLayoutPanel();
            this.lblTimKiem = new Label();
            this.txtTimKiem = new TextBox();
            this.btnTim = new Button();
            this.btnTaiLai = new Button();
            this.dgvDanhMuc = new DataGridView();
            this.lblTrangThai = new Label();
            this.tblNhap = new TableLayoutPanel();
            this.lblTen = new Label();
            this.txtTen = new TextBox();
            this.pnlNut = new FlowLayoutPanel();
            this.btnNhapMoi = new Button();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            DataGridViewCellStyle kieuTieuDe = new DataGridViewCellStyle();
            DataGridViewCellStyle kieuDong = new DataGridViewCellStyle();
            this.tblBoCuc.SuspendLayout();
            this.tblTimKiem.SuspendLayout();
            this.tblNhap.SuspendLayout();
            this.pnlNut.SuspendLayout();
            ((ISupportInitialize)this.dgvDanhMuc).BeginInit();
            this.SuspendLayout();

            // tblBoCuc
            this.tblBoCuc.ColumnCount = 1;
            this.tblBoCuc.RowCount = 5;
            this.tblBoCuc.Dock = DockStyle.Fill;
            this.tblBoCuc.Size = new Size(710, 525);
            this.tblBoCuc.Name = "tblBoCuc";
            this.tblBoCuc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tblBoCuc.RowStyles.Add(new RowStyle());
            this.tblBoCuc.RowStyles.Add(new RowStyle());
            this.tblBoCuc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tblBoCuc.RowStyles.Add(new RowStyle());
            this.tblBoCuc.RowStyles.Add(new RowStyle());
            this.tblBoCuc.Padding = new Padding(20, 14, 20, 14);
            this.tblBoCuc.Controls.Add(this.lblTieuDe, 0, 0);
            this.tblBoCuc.Controls.Add(this.tblTimKiem, 0, 1);
            this.tblBoCuc.Controls.Add(this.dgvDanhMuc, 0, 2);
            this.tblBoCuc.Controls.Add(this.lblTrangThai, 0, 3);
            this.tblBoCuc.Controls.Add(this.tblNhap, 0, 4);
            // lblTieuDe
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            this.lblTieuDe.Margin = new Padding(0, 0, 0, 12);
            this.lblTieuDe.Text = "Quản lý thể loại";
            // tblTimKiem
            this.tblTimKiem.ColumnCount = 4;
            this.tblTimKiem.RowCount = 1;
            this.tblTimKiem.Dock = DockStyle.Fill;
            this.tblTimKiem.Name = "tblTimKiem";
            this.tblTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.tblTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tblTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.tblTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            this.tblTimKiem.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.tblTimKiem.AutoSize = true;
            this.tblTimKiem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tblTimKiem.Margin = new Padding(0, 0, 0, 10);
            this.tblTimKiem.Controls.Add(this.lblTimKiem, 0, 0);
            this.tblTimKiem.Controls.Add(this.txtTimKiem, 1, 0);
            this.tblTimKiem.Controls.Add(this.btnTim, 2, 0);
            this.tblTimKiem.Controls.Add(this.btnTaiLai, 3, 0);
            // lblTimKiem
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Text = "Tìm thể loại";
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Anchor = AnchorStyles.Left;
            this.lblTimKiem.Margin = new Padding(0, 0, 10, 0);
            // txtTimKiem
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.AccessibleName = "Tìm thể loại";
            this.txtTimKiem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtTimKiem.Margin = new Padding(0, 0, 8, 0);
            this.txtTimKiem.MaxLength = 100;
            this.txtTimKiem.TabIndex = 0;
            // dgvDanhMuc
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Dock = DockStyle.Fill;
            this.dgvDanhMuc.Margin = new Padding(0);
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten});
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.RowTemplate.Height = 32;
            this.dgvDanhMuc.TabIndex = 1;
            kieuTieuDe.Padding = new Padding(8, 5, 8, 5);
            kieuDong.Padding = new Padding(8, 0, 8, 0);
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = kieuTieuDe;
            this.dgvDanhMuc.DefaultCellStyle = kieuDong;
            // lblTrangThai
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Margin = new Padding(0, 7, 0, 7);
            // tblNhap
            this.tblNhap.ColumnCount = 1;
            this.tblNhap.RowCount = 3;
            this.tblNhap.AutoSize = true;
            this.tblNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblNhap.Name = "tblNhap";
            this.tblNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tblNhap.RowStyles.Add(new RowStyle());
            this.tblNhap.RowStyles.Add(new RowStyle());
            this.tblNhap.RowStyles.Add(new RowStyle());
            this.tblNhap.Padding = new Padding(12, 8, 4, 10);
            this.tblNhap.Margin = new Padding(0);
            this.tblNhap.Controls.Add(this.lblTen, 0, 0);
            this.tblNhap.Controls.Add(this.txtTen, 0, 1);
            this.tblNhap.Controls.Add(this.pnlNut, 0, 2);
            // lblTen
            this.lblTen.Name = "lblTen";
            this.lblTen.Text = "Tên thể loại";
            this.lblTen.AutoSize = true;
            this.lblTen.Margin = new Padding(0, 0, 8, 3);
            // txtTen
            this.txtTen.Name = "txtTen";
            this.txtTen.AccessibleName = "Tên thể loại";
            this.txtTen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.txtTen.Margin = new Padding(0, 0, 8, 8);
            this.txtTen.TabIndex = 0;
            this.txtTen.MaxLength = 100;
            // pnlNut
            this.pnlNut.Name = "pnlNut";
            this.pnlNut.AutoSize = true;
            this.pnlNut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.pnlNut.WrapContents = false;
            this.pnlNut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNut.Margin = new Padding(0, 2, 0, 0);
            this.pnlNut.TabIndex = 1;
            this.pnlNut.Controls.Add(this.btnNhapMoi);
            this.pnlNut.Controls.Add(this.btnThem);
            this.pnlNut.Controls.Add(this.btnSua);
            this.pnlNut.Controls.Add(this.btnXoa);
            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Text = "Tìm";
            this.btnTim.AutoSize = true;
            this.btnTim.MinimumSize = new Size(80, 32);
            this.btnTim.Padding = new Padding(10, 0, 10, 0);
            this.btnTim.Margin = new Padding(0, 0, 8, 0);
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.TabIndex = 1;
            // btnTaiLai
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Text = "Xem tất cả";
            this.btnTaiLai.AutoSize = true;
            this.btnTaiLai.MinimumSize = new Size(80, 32);
            this.btnTaiLai.Padding = new Padding(10, 0, 10, 0);
            this.btnTaiLai.Margin = new Padding(0, 0, 8, 0);
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.TabIndex = 2;
            // btnNhapMoi
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.AutoSize = true;
            this.btnNhapMoi.MinimumSize = new Size(80, 32);
            this.btnNhapMoi.Padding = new Padding(10, 0, 10, 0);
            this.btnNhapMoi.Margin = new Padding(0, 0, 8, 0);
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.TabIndex = 0;
            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Text = "Thêm";
            this.btnThem.AutoSize = true;
            this.btnThem.MinimumSize = new Size(80, 32);
            this.btnThem.Padding = new Padding(10, 0, 10, 0);
            this.btnThem.Margin = new Padding(0, 0, 8, 0);
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.TabIndex = 1;
            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Text = "Lưu sửa";
            this.btnSua.AutoSize = true;
            this.btnSua.MinimumSize = new Size(80, 32);
            this.btnSua.Padding = new Padding(10, 0, 10, 0);
            this.btnSua.Margin = new Padding(0, 0, 8, 0);
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.TabIndex = 2;
            this.btnSua.Enabled = false;
            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.AutoSize = true;
            this.btnXoa.MinimumSize = new Size(80, 32);
            this.btnXoa.Padding = new Padding(10, 0, 10, 0);
            this.btnXoa.Margin = new Padding(0, 0, 8, 0);
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Enabled = false;
            // Ma
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã";
            this.Ma.Name = "Ma";
            this.Ma.MinimumWidth = 70;
            this.Ma.FillWeight = 20F;
            this.Ma.ReadOnly = true;
            this.Ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ma.Width = 92;
            // Ten
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Thể loại";
            this.Ten.Name = "Ten";
            this.Ten.MinimumWidth = 220;
            this.Ten.FillWeight = 80F;
            this.Ten.ReadOnly = true;
            // frmTheLoai
            this.AutoScaleDimensions = new SizeF(7F, 17F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(710, 525);
            this.MinimumSize = new Size(570, 430);
            this.Font = new Font("Segoe UI", 10F);
            this.Name = "frmTheLoai";
            this.Text = "Quản lý thể loại";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Controls.Add(this.tblBoCuc);
            ((ISupportInitialize)this.dgvDanhMuc).EndInit();
            this.pnlNut.ResumeLayout(false);
            this.pnlNut.PerformLayout();
            this.tblNhap.ResumeLayout(false);
            this.tblNhap.PerformLayout();
            this.tblTimKiem.ResumeLayout(false);
            this.tblTimKiem.PerformLayout();
            this.tblBoCuc.ResumeLayout(false);
            this.tblBoCuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblBoCuc;
        private Label lblTieuDe;
        private TableLayoutPanel tblTimKiem;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTim;
        private Button btnTaiLai;
        private DataGridView dgvDanhMuc;
        private Label lblTrangThai;
        private TableLayoutPanel tblNhap;
        private Label lblTen;
        private TextBox txtTen;
        private FlowLayoutPanel pnlNut;
        private Button btnNhapMoi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    }
}
