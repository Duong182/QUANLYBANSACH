using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyNhaSach
{
    public static class KetNoi
    {
        private static readonly string chuoiKetNoi =
            ConfigurationManager
            .ConnectionStrings["conn"]
            .ConnectionString;

        public static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(chuoiKetNoi);
        }
    }

}