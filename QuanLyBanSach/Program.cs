using QuanLyBanSach.GUI.TrangChu;
using System;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            bool dangNhapThanhCong;

            using (frmDangNhap f = new frmDangNhap())
            {
                dangNhapThanhCong =
                    f.ShowDialog() == DialogResult.OK;
            }

            if (dangNhapThanhCong)
            {
                Application.Run(new frmMain());
            }
        }
    }
}