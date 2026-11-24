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

namespace QuanLyBanSach.GUI.TaiKhoan
{
    public partial class frmDangKy : Form
    {
        public string TenDangNhapMoi
        {
            get;
            private set;
        }
        public frmDangKy()
        {
            InitializeComponent();
            this.AcceptButton = btnDangKy;
            this.CancelButton = btnHuy;

            btnDangKy.Click += btnDangKy_Click;
            btnHuy.Click += btnHuy_Click;

            rdoNam.Checked = true;

            txtPassword.PasswordChar = '*';
            txtNhapLaiMatKhau.PasswordChar = '*';

            lblGiaTriVaiTro.Text =
                "NhanVien (mặc định)";
        }
        private bool KiemTraDuLieu()
        {
            err.Clear();

            bool hopLe = true;

            string username = txtUsername.Text.Trim();

            if (!Regex.IsMatch(
                username,
                @"^[a-zA-Z0-9_]{4,50}$"))
            {
                err.SetError(
                    txtUsername,
                    "Tên đăng nhập từ 4-50 ký tự, " +
                    "chỉ gồm chữ, số và dấu gạch dưới");

                hopLe = false;
            }

            if (txtPassword.Text.Length < 8 ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                err.SetError(
                    txtPassword,
                    "Mật khẩu phải có ít nhất 8 ký tự");

                hopLe = false;
            }

            if (txtPassword.Text !=
                txtNhapLaiMatKhau.Text)
            {
                err.SetError(
                    txtNhapLaiMatKhau,
                    "Mật khẩu không khớp");

                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(
                txtHoTen.Text))
            {
                err.SetError(
                    txtHoTen,
                    "Vui lòng nhập họ tên");

                hopLe = false;
            }

            string email = txtEmail.Text.Trim();

            if (!Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                err.SetError(
                    txtEmail,
                    "Email sai định dạng");

                hopLe = false;
            }

            return hopLe;
        }

        private void btnDangKy_Click(
            object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            string username = txtUsername.Text.Trim();

            byte[] passwordHash =
                MatKhauHelper.BamSHA256(
                    txtPassword.Text);

            string hoTen = txtHoTen.Text.Trim();

            string gioiTinh =
                rdoNam.Checked ? "Nam" : "Nữ";

            string email = txtEmail.Text.Trim();

            try
            {
                using (SqlConnection conn =
                    KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sqlKiemTra = @"
                        SELECT COUNT(*)
                        FROM TaiKhoan
                        WHERE Username = @u";

                    using (SqlCommand cmdKiemTra =
                        new SqlCommand(sqlKiemTra, conn))
                    {
                        cmdKiemTra.Parameters.Add(
                            "@u",
                            SqlDbType.NVarChar, 50
                        ).Value = username;

                        int soLuong = Convert.ToInt32(
                            cmdKiemTra.ExecuteScalar());

                        if (soLuong > 0)
                        {
                            err.SetError(
                                txtUsername,
                                "Tên đăng nhập đã tồn tại");

                            txtUsername.Focus();

                            return;
                        }
                    }

                    string sqlThem = @"
                        INSERT INTO TaiKhoan
                        (
                            Username,
                            PasswordHash,
                            HoTen,
                            GioiTinh,
                            Email,
                            VaiTro
                        )
                        VALUES
                        (
                            @u,
                            @h,
                            @hoten,
                            @gioitinh,
                            @email,
                            N'NhanVien'
                        )";

                    using (SqlCommand cmd =
                        new SqlCommand(sqlThem, conn))
                    {
                        cmd.Parameters.Add(
                            "@u",
                            SqlDbType.NVarChar, 50
                        ).Value = username;

                        cmd.Parameters.Add(
                            "@h",
                            SqlDbType.Binary, 32
                        ).Value = passwordHash;

                        cmd.Parameters.Add(
                            "@hoten",
                            SqlDbType.NVarChar, 100
                        ).Value = hoTen;

                        cmd.Parameters.Add(
                            "@gioitinh",
                            SqlDbType.NVarChar, 3
                        ).Value = gioiTinh;

                        cmd.Parameters.Add(
                            "@email",
                            SqlDbType.NVarChar, 100
                        ).Value = email;

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Đăng ký thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            TenDangNhapMoi = username;

                            this.DialogResult =
                                DialogResult.OK;

                            this.Close();
                        }
                    }
                }
            }
            catch (SqlException ex)
                when (ex.Number == 2601 ||
                      ex.Number == 2627)
            {
                err.SetError(
                    txtUsername,
                    "Tên đăng nhập đã tồn tại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đăng ký thất bại.\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(
            object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNhapLai_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVaiTro_Click(object sender, EventArgs e)
        {

        }
    }
}
