using QuanLyBanSach.Forms.ThongKe;
using QuanLyNhaSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanSach.GUI.TrangChu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += frmMain_Load;
            this.KeyDown += frmMain_KeyDown;

            mnuThongKe.Click += mnuThongKe_Click;
            mnuThoat.Click += mnuThoat_Click;

            this.KeyPreview = true;

            dgvSach.BringToFront();
            menuMain.SendToBack();
        }
        private void frmMain_Load(
           object sender, EventArgs e)
        {
            lblNguoiDung.Text =
                PhienDangNhap.Username;

            CauHinhDataGridView();

            TaiDuLieu();
        }

        private void CauHinhDataGridView()
        {
            dgvSach.AutoGenerateColumns = true;

            dgvSach.ReadOnly = true;

            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AllowUserToResizeRows = false;

            dgvSach.RowHeadersVisible = false;

            dgvSach.MultiSelect = false;

            dgvSach.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSach.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvSach.BackgroundColor = Color.White;

            dgvSach.EnableHeadersVisualStyles = false;

            dgvSach.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(230, 235, 242);

            dgvSach.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.Black;

            dgvSach.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvSach.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvSach.AlternatingRowsDefaultCellStyle.BackColor =
                Color.AliceBlue;

            dgvSach.RowTemplate.Height = 32;

            dgvSach.ColumnHeadersHeight = 35;
        }

        private void TaiDuLieu()
        {
            lblNgay.Text = DateTime.Now.ToString(
                "dddd, dd/MM/yyyy",
                new CultureInfo("vi-VN"));

            try
            {
                TaiDanhSachSach();

                TaiThongKeTrongNgay();
            }
            catch (Exception ex)
            {
                dgvSach.DataSource = null;

                lblDoanhThu.Text = "--";
                lblSoLuongKhach.Text = "--";

                MessageBox.Show(
                    "Không thể tải dữ liệu.\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TaiDanhSachSach()
        {
            using (SqlConnection conn =
                KetNoi.TaoKetNoi())
            {
                conn.Open();

                string sql = @"
                    SELECT
                        s.TenSach,
                        tg.TenTacGia,
                        lv.TenLinhVuc,
                        ls.TenLoaiSach,
                        s.GiaBia
                    FROM Sach s
                    INNER JOIN TacGia tg
                        ON s.MaTacGia = tg.MaTacGia
                    INNER JOIN LinhVuc lv
                        ON s.MaLinhVuc = lv.MaLinhVuc
                    INNER JOIN LoaiSach ls
                        ON s.MaLoaiSach = ls.MaLoaiSach
                    ORDER BY s.MaSach";

                using (SqlDataAdapter da =
                    new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvSach.DataSource = dt;
                }
            }

            DinhDangCotSach();
        }

        private void DinhDangCotSach()
        {
            dgvSach.Columns["TenSach"].HeaderText =
                "TÊN SÁCH";

            dgvSach.Columns["TenTacGia"].HeaderText =
                "TÁC GIẢ";

            dgvSach.Columns["TenLinhVuc"].HeaderText =
                "LĨNH VỰC";

            dgvSach.Columns["TenLoaiSach"].HeaderText =
                "LOẠI SÁCH";

            dgvSach.Columns["GiaBia"].HeaderText =
                "GIÁ BÌA";

            dgvSach.Columns["TenSach"].FillWeight = 30;
            dgvSach.Columns["TenTacGia"].FillWeight = 20;
            dgvSach.Columns["TenLinhVuc"].FillWeight = 20;
            dgvSach.Columns["TenLoaiSach"].FillWeight = 18;
            dgvSach.Columns["GiaBia"].FillWeight = 12;

            dgvSach.Columns["GiaBia"]
                .DefaultCellStyle.Format = "N0";

            dgvSach.Columns["GiaBia"]
                .DefaultCellStyle.FormatProvider =
                    new CultureInfo("vi-VN");

            dgvSach.Columns["GiaBia"]
                .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
        }

        private void TaiThongKeTrongNgay()
        {
            DateTime homNay = DateTime.Today;

            DateTime ngayMai = homNay.AddDays(1);

            using (SqlConnection conn =
                KetNoi.TaoKetNoi())
            {
                conn.Open();

                string sql = @"
                    SELECT
                        ISNULL(SUM(TongTien), 0)
                            AS DoanhThu,

                        COUNT(DISTINCT MaKhachHang)
                            AS SoLuongKhach

                    FROM HoaDon

                    WHERE NgayLap >= @TuNgay
                      AND NgayLap < @DenNgay";

                using (SqlCommand cmd =
                    new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(
                        "@TuNgay",
                        SqlDbType.DateTime2
                    ).Value = homNay;

                    cmd.Parameters.Add(
                        "@DenNgay",
                        SqlDbType.DateTime2
                    ).Value = ngayMai;

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal doanhThu =
                                Convert.ToDecimal(
                                    reader["DoanhThu"]);

                            int soLuongKhach =
                                Convert.ToInt32(
                                    reader["SoLuongKhach"]);

                            lblDoanhThu.Text =
                                doanhThu.ToString(
                                    "N0",
                                    new CultureInfo("vi-VN"))
                                + " VND";

                            lblSoLuongKhach.Text =
                                soLuongKhach + " người";
                        }
                    }
                }
            }
        }

        private void frmMain_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                TaiDuLieu();

                e.Handled = true;
            }
        }
        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            using (frmThongKe f = new frmThongKe())
            {
                f.ShowDialog(this);
            }
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void lblSoLuongKhach_Click(object sender, EventArgs e)
        {

        }
    }
}
