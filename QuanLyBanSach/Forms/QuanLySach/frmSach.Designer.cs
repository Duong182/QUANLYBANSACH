using QuanLyBanSach.DTO;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    partial class frmSach
    {
        private DataGridView dgvSach;
        private TextBox txtTimKiem;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private TextBox txtGiaBia;
        private ComboBox cboTacGia;
        private ComboBox cboTheLoai;
        private ComboBox cboLinhVuc;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label lblTrangThai;

        private void InitializeComponent()
        {
            SuspendLayout();
            TableLayoutPanel boCuc = GiaoDienQuanLySach.TaoBoCuc(this, "Quản lý sách",
                new Size(1040, 650), new Size(820, 530));

            txtTimKiem = new TextBox { MaxLength = SachDTO.DoDaiTenToiDa, Name = nameof(txtTimKiem) };
            Button btnTim = GiaoDienQuanLySach.TaoNut("Tìm");
            Button btnTaiLai = GiaoDienQuanLySach.TaoNut("Xem tất cả");
            boCuc.Controls.Add(GiaoDienQuanLySach.TaoThanhTimKiem(
                "Tìm sách", txtTimKiem, btnTim, btnTaiLai), 0, 1);

            dgvSach = GiaoDienQuanLySach.TaoBang();
            dgvSach.Name = nameof(dgvSach);
            var cotGiaBia = GiaoDienQuanLySach.TaoCot("GiaBia", "Giá bìa (đ)", 15, 100);
            cotGiaBia.DefaultCellStyle.Format = "#,##0.##";
            cotGiaBia.DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
            cotGiaBia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSach.Columns.AddRange(
                GiaoDienQuanLySach.TaoCot("MaSach", "Mã sách", 11, 80),
                GiaoDienQuanLySach.TaoCot("TenSach", "Tên sách", 27, 145),
                GiaoDienQuanLySach.TaoCot("TenTacGia", "Tác giả", 18, 100),
                GiaoDienQuanLySach.TaoCot("TenLoaiSach", "Thể loại", 14, 85),
                GiaoDienQuanLySach.TaoCot("TenLinhVuc", "Lĩnh vực", 15, 85),
                cotGiaBia);
            boCuc.Controls.Add(dgvSach, 0, 2);

            lblTrangThai = GiaoDienQuanLySach.TaoTrangThai();
            boCuc.Controls.Add(lblTrangThai, 0, 3);

            TableLayoutPanel nhapSach = GiaoDienQuanLySach.TaoNhomNhap(3);
            txtMaSach = new TextBox { MaxLength = SachDTO.DoDaiMaToiDa, Name = nameof(txtMaSach) };
            txtTenSach = new TextBox { MaxLength = SachDTO.DoDaiTenToiDa, Name = nameof(txtTenSach) };
            txtGiaBia = new TextBox { MaxLength = 30, Name = nameof(txtGiaBia) };
            cboTacGia = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Name = nameof(cboTacGia) };
            cboTheLoai = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Name = nameof(cboTheLoai) };
            cboLinhVuc = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Name = nameof(cboLinhVuc) };
            GiaoDienQuanLySach.ThemTruong(nhapSach, "Mã sách", txtMaSach, 0, 0);
            GiaoDienQuanLySach.ThemTruong(nhapSach, "Tên sách", txtTenSach, 1, 0);
            GiaoDienQuanLySach.ThemTruong(nhapSach, "Giá bìa (đ)", txtGiaBia, 2, 0);
            GiaoDienQuanLySach.ThemTruong(nhapSach, "Tác giả", cboTacGia, 0, 2);
            GiaoDienQuanLySach.ThemTruong(nhapSach, "Thể loại", cboTheLoai, 1, 2);
            GiaoDienQuanLySach.ThemTruong(nhapSach, "Lĩnh vực", cboLinhVuc, 2, 2);

            Button btnNhapMoi = GiaoDienQuanLySach.TaoNut("Nhập mới");
            btnThem = GiaoDienQuanLySach.TaoNut("Thêm sách");
            btnSua = GiaoDienQuanLySach.TaoNut("Lưu sửa");
            btnXoa = GiaoDienQuanLySach.TaoNut("Xóa sách");
            GiaoDienQuanLySach.ThemNut(nhapSach, 4, btnNhapMoi, btnThem, btnSua, btnXoa);
            boCuc.Controls.Add(nhapSach, 0, 4);

            btnTim.Click += TimSach_Click;
            btnTaiLai.Click += TaiLai_Click;
            btnNhapMoi.Click += NhapMoi_Click;
            btnThem.Click += ThemSach_Click;
            btnSua.Click += SuaSach_Click;
            btnXoa.Click += XoaSach_Click;
            dgvSach.SelectionChanged += ChonSach;
            ResumeLayout(false);
        }
    }
}
