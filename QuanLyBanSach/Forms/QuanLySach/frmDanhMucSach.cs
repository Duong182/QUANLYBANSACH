using QuanLyBanSach.BLL;
using QuanLyBanSach.DTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    public class frmDanhMucSach : Form
    {
        private readonly SachBLL sachBLL = new SachBLL();
        private readonly DanhMucSach danhMuc;
        private readonly string tenDanhMuc;
        private readonly DataGridView dgvDanhMuc;
        private readonly TextBox txtTimKiem;
        private readonly TextBox txtTen;
        private readonly Button btnThem;
        private readonly Button btnSua;
        private readonly Button btnXoa;
        private readonly Label lblTrangThai;
        private int? maDangChon;
        private string tenDangChon;

        internal frmDanhMucSach(DanhMucSach danhMuc, string tenDanhMuc, string tieuDe)
        {
            this.danhMuc = danhMuc;
            this.tenDanhMuc = tenDanhMuc;
            SuspendLayout();

            TableLayoutPanel boCuc = GiaoDienQuanLySach.TaoBoCuc(this, "Quản lý " + tenDanhMuc,
                new Size(710, 525), new Size(570, 430));
            txtTimKiem = new TextBox { MaxLength = SachDTO.DoDaiTenDanhMucToiDa, Name = nameof(txtTimKiem) };
            Button btnTim = GiaoDienQuanLySach.TaoNut("Tìm");
            Button btnTaiLai = GiaoDienQuanLySach.TaoNut("Xem tất cả");
            boCuc.Controls.Add(GiaoDienQuanLySach.TaoThanhTimKiem("Tìm " + tenDanhMuc,
                txtTimKiem, btnTim, btnTaiLai), 0, 1);

            dgvDanhMuc = GiaoDienQuanLySach.TaoBang();
            dgvDanhMuc.Name = nameof(dgvDanhMuc);
            var cotMa = GiaoDienQuanLySach.TaoCot("Ma", "Mã", 20, 70);
            cotMa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            cotMa.Width = 92;
            dgvDanhMuc.Columns.AddRange(cotMa,
                GiaoDienQuanLySach.TaoCot("Ten", tieuDe, 80, 220));
            boCuc.Controls.Add(dgvDanhMuc, 0, 2);
            lblTrangThai = GiaoDienQuanLySach.TaoTrangThai();
            boCuc.Controls.Add(lblTrangThai, 0, 3);

            TableLayoutPanel nhap = GiaoDienQuanLySach.TaoNhomNhap(1);
            txtTen = new TextBox { MaxLength = SachDTO.DoDaiTenDanhMucToiDa, Name = nameof(txtTen) };
            GiaoDienQuanLySach.ThemTruong(nhap, "Tên " + tenDanhMuc, txtTen, 0, 0);

            Button btnNhapMoi = GiaoDienQuanLySach.TaoNut("Nhập mới");
            btnThem = GiaoDienQuanLySach.TaoNut("Thêm");
            btnSua = GiaoDienQuanLySach.TaoNut("Lưu sửa");
            btnXoa = GiaoDienQuanLySach.TaoNut("Xóa");
            GiaoDienQuanLySach.ThemNut(nhap, 2, btnNhapMoi, btnThem, btnSua, btnXoa);
            boCuc.Controls.Add(nhap, 0, 4);

            btnTim.Click += (sender, e) => GiaoDienQuanLySach.ThucHien(this, () => TaiDanhSach());
            btnTaiLai.Click += (sender, e) =>
            {
                txtTimKiem.Clear();
                GiaoDienQuanLySach.ThucHien(this, () => TaiDanhSach());
            };
            btnNhapMoi.Click += (sender, e) =>
            {
                BoChonMuc();
                txtTen.Focus();
            };
            btnThem.Click += Them_Click;
            btnSua.Click += Sua_Click;
            btnXoa.Click += Xoa_Click;
            dgvDanhMuc.SelectionChanged += ChonMuc;
            BoChonMuc();
            ResumeLayout(false);
        }

        internal bool DaThayDoi { get; private set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
                GiaoDienQuanLySach.ThucHien(this, () => TaiDanhSach());
        }

        private void TaiDanhSach(string ketQua = "")
        {
            DataTable danhSach = sachBLL.LayDanhMuc(danhMuc, txtTimKiem.Text);
            dgvDanhMuc.DataSource = danhSach;
            BoChonMuc();
            lblTrangThai.Text = $"{ketQua}{danhSach.Rows.Count} {tenDanhMuc}";
        }

        private void BoChonMuc()
        {
            dgvDanhMuc.CurrentCell = null;
            dgvDanhMuc.ClearSelection();
            maDangChon = null;
            tenDangChon = null;
            txtTen.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void ChonMuc(object sender, EventArgs e)
        {
            if (dgvDanhMuc.SelectedRows.Count == 0 || !(dgvDanhMuc.SelectedRows[0].DataBoundItem is DataRowView muc))
                return;

            maDangChon = (int)muc["Ma"];
            tenDangChon = (string)muc["Ten"];
            txtTen.Text = tenDangChon;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            GiaoDienQuanLySach.ThucHien(this, () =>
            {
                sachBLL.ThemDanhMuc(danhMuc, txtTen.Text);
                CapNhatSauKhiLuu("Đã thêm " + tenDanhMuc + ". ");
            });
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            GiaoDienQuanLySach.ThucHien(this, () =>
            {
                sachBLL.SuaDanhMuc(danhMuc, maDangChon.Value, txtTen.Text);
                CapNhatSauKhiLuu("Đã lưu thay đổi. ");
            });
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, $"Xóa {tenDanhMuc} \"{tenDangChon}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                != DialogResult.Yes)
                return;

            GiaoDienQuanLySach.ThucHien(this, () =>
            {
                sachBLL.XoaDanhMuc(danhMuc, maDangChon.Value);
                CapNhatSauKhiLuu("Đã xóa " + tenDanhMuc + ". ");
            });
        }

        private void CapNhatSauKhiLuu(string ketQua)
        {
            DaThayDoi = true;
            lblTrangThai.Text = ketQua;
            BoChonMuc();
            TaiDanhSach(ketQua);
        }
    }
}
