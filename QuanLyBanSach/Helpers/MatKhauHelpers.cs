using System.Security.Cryptography;
using System.Text;

namespace QuanLyNhaSach
{
    public static class MatKhauHelper
    {
        public static byte[] BamSHA256(string matKhau)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] duLieu =
                    Encoding.UTF8.GetBytes(matKhau);

                return sha256.ComputeHash(duLieu);
            }
        }
    }
}