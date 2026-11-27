using QuanLyNhaSach;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLy
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                HienThiKhachHang();
        }

        private void XoaTrang()
        {
            lvKhachHang.SelectedItems.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtTenKH.Focus();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show(this, "Vui lòng nhập tên khách hàng.");
                txtTenKH.Focus();
                return false;
            }

            string sdt = txtSDT.Text.Trim();
            if (sdt.Length > 0 && !Regex.IsMatch(sdt, @"^0\d{9,10}$"))
            {
                MessageBox.Show(this, "Số điện thoại không hợp lệ.");
                txtSDT.Focus();
                return false;
            }

            string email = txtEmail.Text.Trim();
            if (email.Length > 0 && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show(this, "Email không hợp lệ.");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool HienThiKhachHang(string tuKhoa = "")
        {
            const string sql = @"
                SELECT MaKhachHang, TenKhachHang, SDT, DiaChi, Email
                FROM dbo.KhachHang
                WHERE CONVERT(nvarchar(11), MaKhachHang) LIKE @TuKhoa
                   OR TenKhachHang LIKE @TuKhoa
                   OR SDT LIKE @TuKhoa
                ORDER BY MaKhachHang;";

            lvKhachHang.Items.Clear();

            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 102).Value = "%" + tuKhoa + "%";
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maKhachHang = (int)reader["MaKhachHang"];
                            var item = new ListViewItem(maKhachHang.ToString()) { Tag = maKhachHang };
                            item.SubItems.Add(reader["TenKhachHang"].ToString());
                            item.SubItems.Add(reader["SDT"].ToString());
                            item.SubItems.Add(reader["DiaChi"].ToString());
                            item.SubItems.Add(reader["Email"].ToString());
                            lvKhachHang.Items.Add(item);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể tải danh sách khách hàng.\n" + ex.Message);
                return false;
            }
        }

        private void GanThongTinKhachHang(SqlCommand cmd)
        {
            cmd.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar, 100).Value = txtTenKH.Text.Trim();
            cmd.Parameters.Add("@SDT", SqlDbType.VarChar, 15).Value = txtSDT.Text.Trim();
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = txtDiaChi.Text.Trim();
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = txtEmail.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            const string sql = @"
                INSERT INTO dbo.KhachHang (TenKhachHang, SDT, DiaChi, Email)
                VALUES (@TenKhachHang, @SDT, @DiaChi, @Email);";

            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    GanThongTinKhachHang(cmd);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(this, "Thêm khách hàng thành công.");
                HienThiKhachHang();
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể thêm khách hàng.\n" + ex.Message);
            }
        }

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvKhachHang.SelectedItems[0];
            txtMaKH.Text = item.SubItems[0].Text;
            txtTenKH.Text = item.SubItems[1].Text;
            txtSDT.Text = item.SubItems[2].Text;
            txtDiaChi.Text = item.SubItems[3].Text;
            txtEmail.Text = item.SubItems[4].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Vui lòng chọn khách hàng cần sửa.");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            int maKhachHang = (int)lvKhachHang.SelectedItems[0].Tag;
            const string sql = @"
                UPDATE dbo.KhachHang
                SET TenKhachHang = @TenKhachHang, SDT = @SDT, DiaChi = @DiaChi, Email = @Email
                WHERE MaKhachHang = @MaKhachHang;";

            try
            {
                int soDong;
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = maKhachHang;
                    GanThongTinKhachHang(cmd);
                    conn.Open();
                    soDong = cmd.ExecuteNonQuery();
                }

                MessageBox.Show(this, soDong > 0 ? "Sửa khách hàng thành công." : "Không tìm thấy khách hàng.");
                HienThiKhachHang();
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể sửa khách hàng.\n" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Vui lòng chọn khách hàng cần xóa.");
                return;
            }

            int maKhachHang = (int)lvKhachHang.SelectedItems[0].Tag;
            DialogResult ketQua = MessageBox.Show(this,
                "Bạn có chắc chắn muốn xóa khách hàng này không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (ketQua != DialogResult.Yes)
                return;

            try
            {
                int soDong;
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.KhachHang WHERE MaKhachHang = @MaKhachHang;", conn))
                {
                    cmd.Parameters.Add("@MaKhachHang", SqlDbType.Int).Value = maKhachHang;
                    conn.Open();
                    soDong = cmd.ExecuteNonQuery();
                }

                MessageBox.Show(this, soDong > 0 ? "Xóa khách hàng thành công." : "Không tìm thấy khách hàng.");
                HienThiKhachHang();
                XoaTrang();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(this, "Khách hàng này đã có hóa đơn nên không thể xóa.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể xóa khách hàng.\n" + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            HienThiKhachHang();
            XoaTrang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            if (HienThiKhachHang(txtTimKiem.Text.Trim()) && lvKhachHang.Items.Count == 0)
                MessageBox.Show(this, "Không tìm thấy khách hàng.");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(this, "Bạn có chắc chắn muốn đóng cửa sổ không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
                Close();
        }
    }
}
