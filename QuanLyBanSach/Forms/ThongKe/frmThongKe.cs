using QuanLyNhaSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyBanSach.Forms.ThongKe
{
    public partial class frmThongKe : Form
    {
        private DataTable duLieuThongKe =
            new DataTable();
        public frmThongKe()
        {
            InitializeComponent();
            this.Load += frmThongKe_Load;

            btnTimKiem.Click += btnTimKiem_Click;

            btnXuatBaoCao.Click +=
                btnXuatBaoCao_Click;

            btnThoat.Click += btnThoat_Click;

            dtpTuNgay.ValueChanged += NgayLoc_ValueChanged;
            dtpDenNgay.ValueChanged += NgayLoc_ValueChanged;

            this.AcceptButton = btnTimKiem;

            dgvThongKe.BringToFront();
        }
        private void frmThongKe_Load(
           object sender, EventArgs e)
        {
            DateTime homNay = DateTime.Today;

            dtpTuNgay.Value = new DateTime(
                homNay.Year, homNay.Month, 1);

            dtpDenNgay.Value = homNay;

            CauHinhDataGridView();

            TimKiemHoaDon();
        }

        private void CauHinhDataGridView()
        {
            dgvThongKe.AutoGenerateColumns = true;

            dgvThongKe.ReadOnly = true;

            dgvThongKe.AllowUserToAddRows = false;

            dgvThongKe.AllowUserToDeleteRows = false;

            dgvThongKe.AllowUserToResizeRows = false;

            dgvThongKe.RowHeadersVisible = false;

            dgvThongKe.MultiSelect = false;

            dgvThongKe.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvThongKe.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvThongKe.BackgroundColor = Color.White;

            dgvThongKe.EnableHeadersVisualStyles = false;

            dgvThongKe.ColumnHeadersDefaultCellStyle
                .BackColor =
                Color.FromArgb(230, 235, 242);

            dgvThongKe.ColumnHeadersDefaultCellStyle
                .Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvThongKe.AlternatingRowsDefaultCellStyle
                .BackColor = Color.AliceBlue;

            dgvThongKe.RowTemplate.Height = 32;

            dgvThongKe.ColumnHeadersHeight = 35;
        }

        private void NgayLoc_ValueChanged(
            object sender, EventArgs e)
        {
            // Phải tìm kiếm lại trước khi xuất báo cáo
            btnXuatBaoCao.Enabled = false;
        }

        private void btnTimKiem_Click(
            object sender, EventArgs e)
        {
            TimKiemHoaDon();
        }

        private void TimKiemHoaDon()
        {
            btnXuatBaoCao.Enabled = false;

            DateTime tuNgay = dtpTuNgay.Value.Date;

            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show(
                    "Từ ngày không được lớn hơn đến ngày.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DateTime ngayKetThuc =
                denNgay.AddDays(1);

            try
            {
                using (SqlConnection conn =
                    KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            hd.MaHoaDon,
                            kh.TenKhachHang,
                            hd.NgayLap,
                            hd.TongTien

                        FROM HoaDon hd

                        INNER JOIN KhachHang kh
                            ON hd.MaKhachHang =
                               kh.MaKhachHang

                        WHERE hd.NgayLap >= @TuNgay
                        AND hd.NgayLap < @DenNgay

                        ORDER BY hd.NgayLap DESC,
                                 hd.MaHoaDon";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(
                            "@TuNgay",
                            SqlDbType.DateTime2
                        ).Value = tuNgay;

                        cmd.Parameters.Add(
                            "@DenNgay",
                            SqlDbType.DateTime2
                        ).Value = ngayKetThuc;

                        using (SqlDataAdapter da =
                            new SqlDataAdapter(cmd))
                        {
                            duLieuThongKe =
                                new DataTable();

                            da.Fill(duLieuThongKe);

                            dgvThongKe.DataSource =
                                duLieuThongKe;
                        }
                    }
                }

                DinhDangCot();

                TinhTongTien();

                btnXuatBaoCao.Enabled =
                    duLieuThongKe.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                dgvThongKe.DataSource = null;

                duLieuThongKe = new DataTable();

                lblSoHoaDon.Text = "Số hóa đơn: --";
                lblTongTien.Text = "Tổng tiền: --";

                MessageBox.Show(
                    "Không thể thống kê dữ liệu.\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DinhDangCot()
        {
            dgvThongKe.Columns["MaHoaDon"].HeaderText =
                "MÃ HÓA ĐƠN";

            dgvThongKe.Columns["TenKhachHang"].HeaderText =
                "TÊN KHÁCH HÀNG";

            dgvThongKe.Columns["NgayLap"].HeaderText =
                "NGÀY LẬP";

            dgvThongKe.Columns["TongTien"].HeaderText =
                "TỔNG TIỀN";

            dgvThongKe.Columns["MaHoaDon"].FillWeight = 20;

            dgvThongKe.Columns["TenKhachHang"].FillWeight = 35;

            dgvThongKe.Columns["NgayLap"].FillWeight = 25;

            dgvThongKe.Columns["TongTien"].FillWeight = 20;

            dgvThongKe.Columns["NgayLap"]
                .DefaultCellStyle.Format =
                "dd/MM/yyyy HH:mm";

            dgvThongKe.Columns["TongTien"]
                .DefaultCellStyle.Format = "N0";

            dgvThongKe.Columns["TongTien"]
                .DefaultCellStyle.FormatProvider =
                new CultureInfo("vi-VN");

            dgvThongKe.Columns["TongTien"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;

            foreach (DataRow row in duLieuThongKe.Rows)
            {
                tongTien += Convert.ToDecimal(
                    row["TongTien"]);
            }

            lblSoHoaDon.Text =
                "Số hóa đơn: " +
                duLieuThongKe.Rows.Count;

            lblTongTien.Text =
                "Tổng tiền: " +
                tongTien.ToString(
                    "N0",
                    new CultureInfo("vi-VN"))
                + " VND";
        }

        private void btnXuatBaoCao_Click(
            object sender, EventArgs e)
        {
            if (!btnXuatBaoCao.Enabled ||
                duLieuThongKe.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu để xuất báo cáo.");

                return;
            }

            using (SaveFileDialog save =
                new SaveFileDialog())
            {
                save.Filter = "CSV File (*.csv)|*.csv";

                save.DefaultExt = "csv";

                save.FileName =
                    "BaoCao_" +
                    DateTime.Now.ToString("yyyyMMdd") +
                    ".csv";

                if (save.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter sw =
                        new StreamWriter(
                            save.FileName,
                            false,
                            new UTF8Encoding(true)))
                    {
                        sw.WriteLine(
                            "Mã hóa đơn,Tên khách hàng," +
                            "Ngày lập,Tổng tiền");

                        foreach (DataRow row
                            in duLieuThongKe.Rows)
                        {
                            string maHoaDon =
                                BaoVeCSV(
                                    row["MaHoaDon"].ToString());

                            string tenKhachHang =
                                BaoVeCSV(
                                    row["TenKhachHang"].ToString());

                            string ngayLap =
                                Convert.ToDateTime(
                                    row["NgayLap"])
                                .ToString("dd/MM/yyyy HH:mm:ss");

                            string tongTien =
                                Convert.ToDecimal(
                                    row["TongTien"])
                                .ToString(
                                    "0.00",
                                    CultureInfo.InvariantCulture);

                            sw.WriteLine(
                                maHoaDon + "," +
                                tenKhachHang + "," +
                                ngayLap + "," +
                                tongTien);
                        }
                    }

                    MessageBox.Show(
                        "Xuất báo cáo thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Xuất báo cáo thất bại.\n" +
                        ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private string BaoVeCSV(string giaTri)
        {
            string kiemTra = giaTri.TrimStart();

            if (kiemTra.Length > 0 &&
                "=+-@".IndexOf(kiemTra[0]) >= 0)
            {
                giaTri = "'" + giaTri;
            }

            return "\"" +
                giaTri.Replace("\"", "\"\"") +
                "\"";
        }

        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
