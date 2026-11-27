namespace QuanLyBanSach.DTO
{
    internal class SachDTO
    {
        public const int DoDaiMaToiDa = 20;
        public const int DoDaiTenToiDa = 200;
        public const int DoDaiTenDanhMucToiDa = 100;
        public const decimal GiaBiaToiDa = 9999999999999999.99m;

        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int MaTacGia { get; set; }
        public int MaLinhVuc { get; set; }
        public int MaLoaiSach { get; set; }
        public decimal GiaBia { get; set; }
    }

    internal enum DanhMucSach
    {
        TheLoai,
        TacGia
    }
}
