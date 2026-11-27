using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    internal static class GiaoDienQuanLySach
    {
        public static void GanTimKiemBangEnter(TextBox tuKhoa, Button tim)
        {
            tuKhoa.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    tim.PerformClick();
                }
            };
        }

        public static void ThucHien(Form form, Action thaoTac)
        {
            try
            {
                thaoTac();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(form, ex.Message, form.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(form, "Không thể truy cập dữ liệu SQL Server.\n" + ex.Message,
                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
