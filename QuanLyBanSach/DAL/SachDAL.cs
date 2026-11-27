using QuanLyBanSach.DTO;
using QuanLyNhaSach;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanSach.DAL
{
    internal class SachDAL
    {
        public DataTable LayDanhSach(string tuKhoa)
        {
            const string sql = @"
                SELECT s.MaSach, s.TenSach, s.MaTacGia, s.MaLinhVuc, s.MaLoaiSach,
                       tg.TenTacGia, lv.TenLinhVuc, ls.TenLoaiSach, s.GiaBia
                FROM dbo.Sach s
                INNER JOIN dbo.TacGia tg ON s.MaTacGia = tg.MaTacGia
                INNER JOIN dbo.LinhVuc lv ON s.MaLinhVuc = lv.MaLinhVuc
                INNER JOIN dbo.LoaiSach ls ON s.MaLoaiSach = ls.MaLoaiSach
                WHERE @TuKhoa = N''
                   OR CHARINDEX(@TuKhoa, s.MaSach COLLATE Latin1_General_100_CI_AI) > 0
                   OR CHARINDEX(@TuKhoa, s.TenSach COLLATE Latin1_General_100_CI_AI) > 0
                   OR CHARINDEX(@TuKhoa, tg.TenTacGia COLLATE Latin1_General_100_CI_AI) > 0
                   OR CHARINDEX(@TuKhoa, lv.TenLinhVuc COLLATE Latin1_General_100_CI_AI) > 0
                   OR CHARINDEX(@TuKhoa, ls.TenLoaiSach COLLATE Latin1_General_100_CI_AI) > 0
                ORDER BY s.MaSach;";

            return Doc(sql, ThamSoTuKhoa(tuKhoa));
        }

        public DataTable LayLinhVuc()
        {
            return Doc("SELECT MaLinhVuc AS Ma, TenLinhVuc AS Ten FROM dbo.LinhVuc ORDER BY Ten, Ma;");
        }

        public DataTable LayDanhMuc(DanhMucSach danhMuc, string tuKhoa)
        {
            string bang = TenBang(danhMuc);
            string sql = $@"
                SELECT Ma{bang} AS Ma, Ten{bang} AS Ten
                FROM dbo.{bang}
                WHERE @TuKhoa = N''
                   OR CHARINDEX(@TuKhoa, Ten{bang} COLLATE Latin1_General_100_CI_AI) > 0
                ORDER BY Ten, Ma;";

            return Doc(sql, ThamSoTuKhoa(tuKhoa));
        }

        public void ThemSach(SachDTO sach)
        {
            const string sql = @"
                IF CONVERT(nvarchar(20), CONVERT(varchar(20), @MaSach)) COLLATE Latin1_General_100_BIN2
                   <> @MaSach COLLATE Latin1_General_100_BIN2
                    THROW 50001, 'Ma sach khong hop le.', 1;

                INSERT INTO dbo.Sach (MaSach, TenSach, MaTacGia, MaLinhVuc, MaLoaiSach, GiaBia)
                VALUES (@MaSach, @TenSach, @MaTacGia, @MaLinhVuc, @MaLoaiSach, @GiaBia);";

            Ghi(sql, ThamSoSach(sach, SqlDbType.NVarChar));
        }

        public bool SuaSach(SachDTO sach)
        {
            const string sql = @"
                UPDATE dbo.Sach SET TenSach = @TenSach, MaTacGia = @MaTacGia,
                    MaLinhVuc = @MaLinhVuc, MaLoaiSach = @MaLoaiSach, GiaBia = @GiaBia
                WHERE MaSach = @MaSach;";

            return Ghi(sql, ThamSoSach(sach, SqlDbType.VarChar)) > 0;
        }

        public bool XoaSach(string maSach)
        {
            return Ghi("DELETE FROM dbo.Sach WHERE MaSach = @MaSach;",
                new SqlParameter("@MaSach", SqlDbType.VarChar, SachDTO.DoDaiMaToiDa) { Value = maSach }) > 0;
        }

        public void ThemDanhMuc(DanhMucSach danhMuc, string ten)
        {
            string bang = TenBang(danhMuc);
            Ghi($"INSERT INTO dbo.{bang} (Ten{bang}) VALUES (@Ten);", ThamSoTenDanhMuc(ten));
        }

        public bool SuaDanhMuc(DanhMucSach danhMuc, int ma, string ten)
        {
            string bang = TenBang(danhMuc);
            return Ghi($"UPDATE dbo.{bang} SET Ten{bang} = @Ten WHERE Ma{bang} = @Ma;",
                ThamSoTenDanhMuc(ten), new SqlParameter("@Ma", SqlDbType.Int) { Value = ma }) > 0;
        }

        public bool XoaDanhMuc(DanhMucSach danhMuc, int ma)
        {
            string bang = TenBang(danhMuc);
            return Ghi($"DELETE FROM dbo.{bang} WHERE Ma{bang} = @Ma;",
                new SqlParameter("@Ma", SqlDbType.Int) { Value = ma }) > 0;
        }

        private static string TenBang(DanhMucSach danhMuc)
        {
            switch (danhMuc)
            {
                case DanhMucSach.TheLoai:
                    return "LoaiSach";
                case DanhMucSach.TacGia:
                    return "TacGia";
                default:
                    throw new ArgumentOutOfRangeException(nameof(danhMuc));
            }
        }

        private static SqlParameter ThamSoTuKhoa(string tuKhoa)
        {
            return new SqlParameter("@TuKhoa", SqlDbType.NVarChar, SachDTO.DoDaiTenToiDa) { Value = tuKhoa };
        }

        private static SqlParameter[] ThamSoSach(SachDTO sach, SqlDbType kieuMaSach)
        {
            return new[]
            {
                new SqlParameter("@MaSach", kieuMaSach, SachDTO.DoDaiMaToiDa) { Value = sach.MaSach },
                new SqlParameter("@TenSach", SqlDbType.NVarChar, SachDTO.DoDaiTenToiDa) { Value = sach.TenSach },
                new SqlParameter("@MaTacGia", SqlDbType.Int) { Value = sach.MaTacGia },
                new SqlParameter("@MaLinhVuc", SqlDbType.Int) { Value = sach.MaLinhVuc },
                new SqlParameter("@MaLoaiSach", SqlDbType.Int) { Value = sach.MaLoaiSach },
                new SqlParameter("@GiaBia", SqlDbType.Decimal) { Precision = 18, Scale = 2, Value = sach.GiaBia }
            };
        }

        private static SqlParameter ThamSoTenDanhMuc(string ten)
        {
            return new SqlParameter("@Ten", SqlDbType.NVarChar, SachDTO.DoDaiTenDanhMucToiDa) { Value = ten };
        }

        private static DataTable Doc(string sql, params SqlParameter[] thamSo)
        {
            using (SqlConnection ketNoi = KetNoi.TaoKetNoi())
            using (SqlCommand lenh = new SqlCommand(sql, ketNoi))
            using (SqlDataAdapter adapter = new SqlDataAdapter(lenh))
            {
                lenh.Parameters.AddRange(thamSo);
                DataTable bang = new DataTable();
                adapter.Fill(bang);
                return bang;
            }
        }

        private static int Ghi(string sql, params SqlParameter[] thamSo)
        {
            using (SqlConnection ketNoi = KetNoi.TaoKetNoi())
            using (SqlCommand lenh = new SqlCommand(sql, ketNoi))
            {
                lenh.Parameters.AddRange(thamSo);
                ketNoi.Open();
                return lenh.ExecuteNonQuery();
            }
        }
    }
}
