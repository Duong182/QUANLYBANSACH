using QuanLyBanSach.DTO;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    public partial class frmTheLoai : Form
    {
        private readonly DieuKhienDanhMucSach dieuKhien;

        public frmTheLoai()
        {
            InitializeComponent();
            dieuKhien = new DieuKhienDanhMucSach(this, DanhMucSach.TheLoai, "thể loại",
                dgvDanhMuc, txtTimKiem, txtTen, lblTrangThai,
                btnTim, btnTaiLai, btnNhapMoi, btnThem, btnSua, btnXoa);
        }

        internal bool DaThayDoi => dieuKhien.DaThayDoi;
    }
}
