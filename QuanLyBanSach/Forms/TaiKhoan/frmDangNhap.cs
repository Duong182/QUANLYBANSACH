using QuanLyBanSach.GUI.TaiKhoan;
using QuanLyNhaSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class frmDangNhap : Form
    {
        private int soLanSai = 0;

        private DateTime thoiDiemMoKhoa;
        public frmDangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
            this.CancelButton = btnThoat;

            btnDangNhap.Click += btnDangNhap_Click;
            btnThoat.Click += btnThoat_Click;

            chkHienMatKhau.CheckedChanged +=
                chkHienMatKhau_CheckedChanged;

            lnkDangKy.LinkClicked +=
                lnkDangKy_LinkClicked;

            tmrKhoa.Tick += tmrKhoa_Tick;

            txtPassword.PasswordChar = '*';

            lblThongBao.Text = "";
            lblDemNguoc.Text = "";
        }
        private bool KiemTraDuLieu()
        {
            err.Clear();

            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                err.SetError(
                    txtUsername,
                    "Vui lòng nhập tên đăng nhập");

                hopLe = false;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                err.SetError(
                    txtPassword,
                    "Vui lòng nhập mật khẩu");

                hopLe = false;
            }

            return hopLe;
        }
        private void btnDangNhap_Click(
          object sender, EventArgs e)
        {
            if (!btnDangNhap.Enabled)
                return;

            if (!KiemTraDuLieu())
                return;

            string username = txtUsername.Text.Trim();

            string password = txtPassword.Text;

            byte[] passwordHash =
                MatKhauHelper.BamSHA256(password);

            try
            {
                using (SqlConnection conn =
                    KetNoi.TaoKetNoi())
                {
                    conn.Open();

                    string sql = @"
                        SELECT MaTaiKhoan,
                               Username,
                               VaiTro,
                               HoTen
                        FROM TaiKhoan
                        WHERE Username = @u
                        AND PasswordHash = @h";

                    using (SqlCommand cmd =
                        new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(
                            "@u",
                            SqlDbType.NVarChar, 50
                        ).Value = username;

                        cmd.Parameters.Add(
                            "@h",
                            SqlDbType.Binary, 32
                        ).Value = passwordHash;

                        using (SqlDataReader reader =
                            cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PhienDangNhap.MaTaiKhoan =
                                    Convert.ToInt32(reader["MaTaiKhoan"]);

                                PhienDangNhap.Username =
                                    reader["Username"].ToString();

                                PhienDangNhap.HoTen =
                                    reader["HoTen"].ToString();

                                PhienDangNhap.VaiTro =
                                    reader["VaiTro"].ToString();

                                soLanSai = 0;

                                tmrKhoa.Stop();

                                // Thông báo để kiểm tra
                                MessageBox.Show(
                                    "Đăng nhập thành công!",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                this.DialogResult = DialogResult.OK;

                                this.Close();
                            }
                            else
                            {
                                XuLyDangNhapSai();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể đăng nhập.\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void XuLyDangNhapSai()
        {
            soLanSai++;

            lblThongBao.Text =
                "Sai tên đăng nhập hoặc mật khẩu (" +
                soLanSai + "/3)";

            txtPassword.Clear();
            txtPassword.Focus();

            if (soLanSai >= 3)
            {
                btnDangNhap.Enabled = false;

                thoiDiemMoKhoa =
                    DateTime.UtcNow.AddSeconds(30);

                lblDemNguoc.Text =
                    "Thử lại sau 30 giây";

                tmrKhoa.Start();
            }
        }
        private void tmrKhoa_Tick(
            object sender, EventArgs e)
        {
            int giayConLai = (int)Math.Ceiling(
                (thoiDiemMoKhoa - DateTime.UtcNow)
                .TotalSeconds);

            if (giayConLai <= 0)
            {
                tmrKhoa.Stop();

                soLanSai = 0;

                btnDangNhap.Enabled = true;

                lblThongBao.Text = "";
                lblDemNguoc.Text = "";

                txtPassword.Focus();
            }
            else
            {
                lblDemNguoc.Text =
                    "Thử lại sau " + giayConLai + " giây";
            }
        }
        private void chkHienMatKhau_CheckedChanged(
            object sender, EventArgs e)
        {
            txtPassword.PasswordChar =
                chkHienMatKhau.Checked ? '\0' : '*';
        }

        private void lnkDangKy_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmDangKy f = new frmDangKy())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    txtUsername.Text = f.TenDangNhapMoi;

                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {

        }
    }
}
