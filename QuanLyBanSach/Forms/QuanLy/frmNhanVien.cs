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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            cboChucVu.Items.Clear();
            cboChucVu.Items.Add("Quản lý");
            cboChucVu.Items.Add("Nhân viên bán hàng");
            cboChucVu.Items.Add("Nhân viên kho");

            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;

            HienThiNhanVien();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }
        private void HienThiNhanVien()
        {
            lvNhanVien.Items.Clear();

            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = "SELECT * FROM dbo.NhanVien";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["MaNV"].ToString());

                        item.SubItems.Add(reader["TenNV"].ToString());
                        item.SubItems.Add(reader["SDT"].ToString());
                        item.SubItems.Add(reader["DiaChi"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["ChucVu"].ToString());

                        lvNhanVien.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị nhân viên: " + ex.Message);
            }
        }
        private void XoaTrang()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            cboChucVu.SelectedIndex = -1;

            txtMaNV.Focus();
        }
        private bool KiemTraDuLieu()
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!");
                txtMaNV.Focus();
                return false;
            }

            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                txtTenNV.Focus();
                return false;
            }

            string sdt = txtSDT.Text.Trim();

            if (sdt != "" && !Regex.IsMatch(sdt, @"^0\d{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                txtSDT.Focus();
                return false;
            }

            string email = txtEmail.Text.Trim();

            if (email != "" && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string chucVu = cboChucVu.Text;

            if (!KiemTraDuLieu())
            {
                return;
            }
            if (cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
                cboChucVu.Focus();
                return;
            }
            if (maNV == "" || tenNV == "")
            {
                MessageBox.Show("Vui lòng nhập mã và tên nhân viên!");
                return;
            }

            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = @"INSERT INTO NhanVien
                           (MaNV, TenNV, SDT, DiaChi, Email, ChucVu)
                           VALUES
                           (@MaNV, @TenNV, @SDT, @DiaChi, @Email, @ChucVu)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@TenNV", tenNV);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm nhân viên thành công!");

                HienThiNhanVien();
                XoaTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message);
            }
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvNhanVien.SelectedItems[0];

                txtMaNV.Text = item.SubItems[0].Text;
                txtTenNV.Text = item.SubItems[1].Text;
                txtSDT.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtEmail.Text = item.SubItems[4].Text;
                cboChucVu.Text = item.SubItems[5].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string chucVu = cboChucVu.Text;

            if (maNV == "" || tenNV == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }
            if (cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!");
                cboChucVu.Focus();
                return;
            }
            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = @"UPDATE NhanVien
                           SET TenNV = @TenNV,
                               SDT = @SDT,
                               DiaChi = @DiaChi,
                               Email = @Email,
                               ChucVu = @ChucVu
                           WHERE MaNV = @MaNV";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@TenNV", tenNV);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                    int ketQua = cmd.ExecuteNonQuery();

                    if (ketQua > 0)
                    {
                        MessageBox.Show("Sửa nhân viên thành công!");
                        HienThiNhanVien();
                        XoaTrang();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa nhân viên: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            string maNV = lvNhanVien.SelectedItems[0].SubItems[0].Text;

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này không?",
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

                        string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaNV", maNV);

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show("Xóa nhân viên thành công!");
                            HienThiNhanVien();
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtTimKiem.Clear();

            cboChucVu.SelectedIndex = -1;

            lvNhanVien.SelectedItems.Clear();

            HienThiNhanVien();

            txtMaNV.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            lvNhanVien.Items.Clear();

            try
            {
                using (SqlConnection conn = KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = @"SELECT * FROM NhanVien
                           WHERE MaNV LIKE @TuKhoa
                           OR TenNV LIKE @TuKhoa";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["MaNV"].ToString());

                        item.SubItems.Add(reader["TenNV"].ToString());
                        item.SubItems.Add(reader["SDT"].ToString());
                        item.SubItems.Add(reader["DiaChi"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["ChucVu"].ToString());

                        lvNhanVien.Items.Add(item);
                    }

                    reader.Close();

                    if (lvNhanVien.Items.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!");
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
