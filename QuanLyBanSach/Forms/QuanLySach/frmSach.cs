using QuanLyBanSach.BLL;
using QuanLyBanSach.DTO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    public partial class frmSach : Form
    {
        private static readonly CultureInfo VanHoaVietNam = CultureInfo.GetCultureInfo("vi-VN");
        private readonly SachBLL sachBLL = new SachBLL();
        private string maSachDangChon;

        public frmSach()
        {
            InitializeComponent();
            DonThongTin();
        }

        internal bool DaThayDoi { get; private set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
                GiaoDienQuanLySach.ThucHien(this, TaiDuLieu);
        }

        private void TaiDuLieu()
        {
            DataTable tacGia = sachBLL.LayDanhMuc(DanhMucSach.TacGia, string.Empty);
            DataTable theLoai = sachBLL.LayDanhMuc(DanhMucSach.TheLoai, string.Empty);
            DataTable linhVuc = sachBLL.LayLinhVuc();
            GanDanhMuc(cboTacGia, tacGia);
            GanDanhMuc(cboTheLoai, theLoai);
            GanDanhMuc(cboLinhVuc, linhVuc);
            TaiDanhSach();
        }

        private static void GanDanhMuc(ComboBox combo, DataTable danhMuc)
        {
            combo.ValueMember = "Ma";
            combo.DisplayMember = "Ten";
            combo.DataSource = danhMuc;
        }

        private void TaiDanhSach(string ketQua = "")
        {
            DataTable danhSach = sachBLL.LayDanhSach(txtTimKiem.Text);
            dgvSach.DataSource = danhSach;
            BoChonSach();
            lblTrangThai.Text = $"{ketQua}{danhSach.Rows.Count} sách";
        }

        private void TimSach_Click(object sender, EventArgs e)
        {
            GiaoDienQuanLySach.ThucHien(this, TaiDuLieu);
        }

        private void TaiLai_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            GiaoDienQuanLySach.ThucHien(this, TaiDuLieu);
        }

        private void NhapMoi_Click(object sender, EventArgs e)
        {
            BoChonSach();
            txtMaSach.Focus();
        }

        private void BoChonSach()
        {
            dgvSach.CurrentCell = null;
            dgvSach.ClearSelection();
            DonThongTin();
        }

        private void DonThongTin()
        {
            maSachDangChon = null;
            txtMaSach.Clear();
            txtMaSach.ReadOnly = false;
            txtTenSach.Clear();
            txtGiaBia.Clear();
            cboTacGia.SelectedIndex = -1;
            cboTheLoai.SelectedIndex = -1;
            cboLinhVuc.SelectedIndex = -1;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void ChonSach(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count == 0 || !(dgvSach.SelectedRows[0].DataBoundItem is DataRowView sach))
                return;

            maSachDangChon = (string)sach["MaSach"];
            txtMaSach.Text = maSachDangChon;
            txtMaSach.ReadOnly = true;
            txtTenSach.Text = (string)sach["TenSach"];
            txtGiaBia.Text = ((decimal)sach["GiaBia"]).ToString("0.##", VanHoaVietNam);
            cboTacGia.SelectedValue = sach["MaTacGia"];
            cboTheLoai.SelectedValue = sach["MaLoaiSach"];
            cboLinhVuc.SelectedValue = sach["MaLinhVuc"];
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private SachDTO DocThongTinSach()
        {
            if (!(cboTacGia.SelectedValue is int maTacGia)
                || !(cboTheLoai.SelectedValue is int maTheLoai)
                || !(cboLinhVuc.SelectedValue is int maLinhVuc))
                throw new InvalidOperationException("Vui lòng chọn tác giả, thể loại và lĩnh vực.");

            const NumberStyles kieuGia = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;
            if (!decimal.TryParse(txtGiaBia.Text.Trim(), kieuGia, VanHoaVietNam, out decimal giaBia))
                throw new InvalidOperationException("Vui lòng nhập giá bìa bằng số. Dùng dấu phẩy cho phần thập phân.");

            return new SachDTO
            {
                MaSach = maSachDangChon ?? txtMaSach.Text,
                TenSach = txtTenSach.Text,
                MaTacGia = maTacGia,
                MaLoaiSach = maTheLoai,
                MaLinhVuc = maLinhVuc,
                GiaBia = giaBia
            };
        }

        private void ThemSach_Click(object sender, EventArgs e)
        {
            GiaoDienQuanLySach.ThucHien(this, () =>
            {
                sachBLL.ThemSach(DocThongTinSach());
                CapNhatSauKhiLuu("Đã thêm sách. ");
            });
        }

        private void SuaSach_Click(object sender, EventArgs e)
        {
            GiaoDienQuanLySach.ThucHien(this, () =>
            {
                sachBLL.SuaSach(DocThongTinSach());
                CapNhatSauKhiLuu("Đã lưu thay đổi. ");
            });
        }

        private void XoaSach_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, $"Xóa sách có mã {maSachDangChon}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                != DialogResult.Yes)
                return;

            GiaoDienQuanLySach.ThucHien(this, () =>
            {
                sachBLL.XoaSach(maSachDangChon);
                CapNhatSauKhiLuu("Đã xóa sách. ");
            });
        }

        private void CapNhatSauKhiLuu(string ketQua)
        {
            DaThayDoi = true;
            lblTrangThai.Text = ketQua;
            BoChonSach();
            TaiDanhSach(ketQua);
        }
    }
}
