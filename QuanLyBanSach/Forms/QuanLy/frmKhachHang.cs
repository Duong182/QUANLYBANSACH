using QuanLyNhaSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLy
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            HienThiKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }
        private void XoaTrang()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();

            txtMaKH.Focus();
        }
        private bool KiemTraDuLieu()
        {
            // Kiểm tra mã khách hàng
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
                txtMaKH.Focus();
                return false;
            }

            // Kiểm tra tên khách hàng
            if (txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                txtTenKH.Focus();
                return false;
            }

            // Kiểm tra số điện thoại
            string sdt = txtSDT.Text.Trim();

            if (sdt != "" && !Regex.IsMatch(sdt, @"^0\d{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                txtSDT.Focus();
                return false;
            }

            // Kiểm tra Email
            string email = txtEmail.Text.Trim();

            if (email != "" &&
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!");
                txtEmail.Focus();
                return false;
            }

            return true;
        }
        private void HienThiKhachHang()
        {
            lvKhachHang.Items.Clear();

            using (SqlConnection conn = KetNoi.TaoKetNoi())
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM KhachHang";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(
                            reader["MaKH"].ToString()
                        );

                        item.SubItems.Add(reader["TenKH"].ToString());
                        item.SubItems.Add(reader["SDT"].ToString());
                        item.SubItems.Add(reader["DiaChi"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());

                        lvKhachHang.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hiển thị khách hàng: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Kiểm tra dữ liệu nhập
            if (maKH == "" || tenKH == "")
            {
                MessageBox.Show("Vui lòng nhập mã và tên khách hàng!");
                return;
            }

            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = @"INSERT INTO KhachHang
                           (MaKH, TenKH, SDT, DiaChi, Email)
                           VALUES
                           (@MaKH, @TenKH, @SDT, @DiaChi, @Email)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@Email", email);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm khách hàng thành công!");

                // Cập nhật lại ListView
                HienThiKhachHang();

                // Xóa dữ liệu đã nhập
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khách hàng: " + ex.Message);
            }
        }

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(lvKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem item = lvKhachHang.SelectedItems[0];

                txtMaKH.Text = item.SubItems[0].Text;
                txtTenKH.Text = item.SubItems[1].Text;
                txtSDT.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtEmail.Text = item.SubItems[4].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (maKH == "" || tenKH == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng và nhập tên!");
                return;
            }

            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = @"UPDATE KhachHang
                           SET TenKH = @TenKH,
                               SDT = @SDT,
                               DiaChi = @DiaChi,
                               Email = @Email
                           WHERE MaKH = @MaKH";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@Email", email);

                    int ketQua = cmd.ExecuteNonQuery();

                    if (ketQua > 0)
                    {
                        MessageBox.Show("Sửa khách hàng thành công!");
                        HienThiKhachHang();
                        XoaTrang();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa khách hàng: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn khách hàng chưa
            if (lvKhachHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                return;
            }

            // Lấy mã khách hàng được chọn
            string maKH = lvKhachHang.SelectedItems[0].SubItems[0].Text;

            // Hỏi xác nhận trước khi xóa
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa khách hàng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (kq == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = KetNoi.TaoKetNoi())
                    {
                        conn.Open();

                        string sql = "DELETE FROM KhachHang WHERE MaKH = @MaKH";

                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@MaKH", maKH);

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!");

                            HienThiKhachHang();
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng: " + ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // Xóa nội dung các TextBox
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtTimKiem.Clear();

            // Bỏ chọn khách hàng trong ListView
            lvKhachHang.SelectedItems.Clear();

            // Hiển thị lại toàn bộ danh sách
            HienThiKhachHang();

            // Đưa con trỏ về ô mã khách hàng
            txtMaKH.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            lvKhachHang.Items.Clear();

            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = @"SELECT * FROM KhachHang
                           WHERE MaKH LIKE @TuKhoa
                           OR TenKH LIKE @TuKhoa
                           OR SDT LIKE @TuKhoa";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(
                            reader["MaKH"].ToString()
                        );

                        item.SubItems.Add(reader["TenKH"].ToString());
                        item.SubItems.Add(reader["SDT"].ToString());
                        item.SubItems.Add(reader["DiaChi"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());

                        lvKhachHang.Items.Add(item);
                    }

                    reader.Close();

                    if (lvKhachHang.Items.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
        "Bạn có chắc chắn muốn đóng Form không?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
