using QuanLyBanSach.DTO;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    public partial class frmTacGia : Form
    {
        private readonly DieuKhienDanhMucSach dieuKhien;

        public frmTacGia()
        {
            InitializeComponent();
            dieuKhien = new DieuKhienDanhMucSach(this, DanhMucSach.TacGia, "tác giả",
                dgvDanhMuc, txtTimKiem, txtTen, lblTrangThai,
                btnTim, btnTaiLai, btnNhapMoi, btnThem, btnSua, btnXoa);
        }

        internal bool DaThayDoi => dieuKhien.DaThayDoi;
    }
}
