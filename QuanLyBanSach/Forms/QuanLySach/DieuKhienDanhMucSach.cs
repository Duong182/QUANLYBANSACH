using QuanLyBanSach.BLL;
using QuanLyBanSach.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    internal sealed class DieuKhienDanhMucSach
    {
        private readonly SachBLL sachBLL = new SachBLL();
        private readonly Form form;
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

        public DieuKhienDanhMucSach(Form form, DanhMucSach danhMuc, string tenDanhMuc,
            DataGridView dgvDanhMuc, TextBox txtTimKiem, TextBox txtTen, Label lblTrangThai,
            Button btnTim, Button btnTaiLai, Button btnNhapMoi, Button btnThem, Button btnSua, Button btnXoa)
        {
            this.form = form;
            this.danhMuc = danhMuc;
            this.tenDanhMuc = tenDanhMuc;
            this.dgvDanhMuc = dgvDanhMuc;
            this.txtTimKiem = txtTimKiem;
            this.txtTen = txtTen;
            this.lblTrangThai = lblTrangThai;
            this.btnThem = btnThem;
            this.btnSua = btnSua;
            this.btnXoa = btnXoa;

            dgvDanhMuc.AutoGenerateColumns = false;
            form.Load += (sender, e) =>
            {
                if (form.Site?.DesignMode != true)
                    TaiDanhSachAnToan();
            };
            GiaoDienQuanLySach.GanTimKiemBangEnter(txtTimKiem, btnTim);
            btnTim.Click += (sender, e) => TaiDanhSachAnToan();
            btnTaiLai.Click += (sender, e) =>
            {
                txtTimKiem.Clear();
                TaiDanhSachAnToan();
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
        }

        public bool DaThayDoi { get; private set; }

        private void TaiDanhSachAnToan()
        {
            GiaoDienQuanLySach.ThucHien(form, () => TaiDanhSach());
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
            GiaoDienQuanLySach.ThucHien(form, () =>
            {
                sachBLL.ThemDanhMuc(danhMuc, txtTen.Text);
                CapNhatSauKhiLuu("Đã thêm " + tenDanhMuc + ". ");
            });
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            GiaoDienQuanLySach.ThucHien(form, () =>
            {
                sachBLL.SuaDanhMuc(danhMuc, maDangChon.Value, txtTen.Text);
                CapNhatSauKhiLuu("Đã lưu thay đổi. ");
            });
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(form, $"Xóa {tenDanhMuc} \"{tenDangChon}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                != DialogResult.Yes)
                return;

            GiaoDienQuanLySach.ThucHien(form, () =>
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
