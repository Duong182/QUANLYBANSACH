using QuanLyBanSach.DAL;
using QuanLyBanSach.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanSach.BLL
{
    internal class SachBLL
    {
        private readonly SachDAL dal = new SachDAL();

        public DataTable LayDanhSach(string tuKhoa)
        {
            return dal.LayDanhSach(tuKhoa.Trim());
        }

        public DataTable LayLinhVuc()
        {
            return dal.LayLinhVuc();
        }

        public DataTable LayDanhMuc(DanhMucSach danhMuc, string tuKhoa)
        {
            return dal.LayDanhMuc(danhMuc, tuKhoa.Trim());
        }

        public void ThemSach(SachDTO sach)
        {
            sach.MaSach = KiemTraDoDai(sach.MaSach, SachDTO.DoDaiMaToiDa, "mã sách");
            KiemTraSach(sach);

            try
            {
                dal.ThemSach(sach);
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                throw new InvalidOperationException("Mã sách đã tồn tại. Vui lòng nhập mã khác.", ex);
            }
            catch (SqlException ex) when (ex.Number == 50001)
            {
                throw new InvalidOperationException("Mã sách chứa ký tự SQL Server không lưu được. Vui lòng dùng mã khác.", ex);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw DanhMucDaThayDoi(ex);
            }
        }

        public void SuaSach(SachDTO sach)
        {
            KiemTraSach(sach);

            try
            {
                if (!dal.SuaSach(sach))
                    throw new InvalidOperationException("Sách đã bị xóa. Vui lòng tải lại danh sách.");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw DanhMucDaThayDoi(ex);
            }
        }

        public void XoaSach(string maSach)
        {
            try
            {
                if (!dal.XoaSach(maSach))
                    throw new InvalidOperationException("Sách đã bị xóa. Vui lòng tải lại danh sách.");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new InvalidOperationException("Không thể xóa sách vì sách đang được dữ liệu khác tham chiếu.", ex);
            }
        }

        public void ThemDanhMuc(DanhMucSach danhMuc, string ten)
        {
            dal.ThemDanhMuc(danhMuc, KiemTraTenDanhMuc(danhMuc, ten));
        }

        public void SuaDanhMuc(DanhMucSach danhMuc, int ma, string ten)
        {
            if (!dal.SuaDanhMuc(danhMuc, ma, KiemTraTenDanhMuc(danhMuc, ten)))
                throw new InvalidOperationException("Mục đã bị xóa. Vui lòng tải lại danh sách.");
        }

        public void XoaDanhMuc(DanhMucSach danhMuc, int ma)
        {
            try
            {
                if (!dal.XoaDanhMuc(danhMuc, ma))
                    throw new InvalidOperationException("Mục đã bị xóa. Vui lòng tải lại danh sách.");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new InvalidOperationException("Không thể xóa mục này vì đang có sách sử dụng.", ex);
            }
        }

        private static void KiemTraSach(SachDTO sach)
        {
            sach.TenSach = KiemTraDoDai(sach.TenSach, SachDTO.DoDaiTenToiDa, "tên sách");

            if (sach.GiaBia < 0 || sach.GiaBia > SachDTO.GiaBiaToiDa || decimal.Round(sach.GiaBia, 2) != sach.GiaBia)
                throw new InvalidOperationException("Giá bìa phải từ 0 đến 9.999.999.999.999.999,99 đồng và có tối đa hai chữ số thập phân.");
        }

        private static string KiemTraTenDanhMuc(DanhMucSach danhMuc, string ten)
        {
            string truong = danhMuc == DanhMucSach.TheLoai ? "tên thể loại" : "tên tác giả";
            return KiemTraDoDai(ten, SachDTO.DoDaiTenDanhMucToiDa, truong);
        }

        private static string KiemTraDoDai(string giaTri, int doDaiToiDa, string truong)
        {
            string ketQua = (giaTri ?? string.Empty).Trim();
            if (ketQua.Length == 0)
                throw new InvalidOperationException("Vui lòng nhập " + truong + ".");

            if (ketQua.Length > doDaiToiDa)
                throw new InvalidOperationException($"Độ dài của {truong} tối đa là {doDaiToiDa} ký tự.");

            return ketQua;
        }

        private static InvalidOperationException DanhMucDaThayDoi(SqlException ex)
        {
            return new InvalidOperationException("Tác giả, thể loại hoặc lĩnh vực đã thay đổi. Vui lòng tải lại danh sách và chọn lại.", ex);
        }
    }
}
