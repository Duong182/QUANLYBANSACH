using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanSach.Forms.QuanLySach
{
    internal static class GiaoDienQuanLySach
    {
        public static TableLayoutPanel TaoBoCuc(Form form, string tieuDe, Size kichThuoc, Size toiThieu)
        {
            form.Text = tieuDe;
            form.Font = new Font("Segoe UI", 10);
            form.AutoScaleDimensions = new SizeF(7, 17);
            form.AutoScaleMode = AutoScaleMode.Font;
            form.ClientSize = kichThuoc;
            form.MinimumSize = toiThieu;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowInTaskbar = false;

            var boCuc = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20, 14, 20, 14),
                ColumnCount = 1,
                RowCount = 5
            };
            boCuc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            boCuc.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            boCuc.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            boCuc.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            boCuc.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            boCuc.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            boCuc.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 21, FontStyle.Bold),
                Margin = new Padding(0, 0, 0, 12),
                Text = tieuDe
            }, 0, 0);
            form.Controls.Add(boCuc);
            return boCuc;
        }

        public static TableLayoutPanel TaoThanhTimKiem(string nhan, TextBox tuKhoa, Button tim, Button taiLai)
        {
            var thanh = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 10),
                ColumnCount = 4,
                RowCount = 1
            };
            thanh.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            thanh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            thanh.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            thanh.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            thanh.Controls.Add(new Label
            {
                Text = nhan,
                AutoSize = true,
                Anchor = AnchorStyles.Left,
                Margin = new Padding(0, 0, 10, 0)
            }, 0, 0);
            tuKhoa.AccessibleName = nhan;
            tuKhoa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tuKhoa.Margin = new Padding(0, 0, 8, 0);
            tuKhoa.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    tim.PerformClick();
                }
            };
            thanh.Controls.Add(tuKhoa, 1, 0);
            thanh.Controls.Add(tim, 2, 0);
            thanh.Controls.Add(taiLai, 3, 0);
            return thanh;
        }

        public static DataGridView TaoBang()
        {
            var bang = new DataGridView
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                ReadOnly = true,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            };
            bang.RowTemplate.Height = 32;
            bang.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 5, 8, 5);
            bang.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            return bang;
        }

        public static DataGridViewTextBoxColumn TaoCot(string thuocTinh, string tieuDe, int tyLe, int beRongToiThieu)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = thuocTinh,
                DataPropertyName = thuocTinh,
                HeaderText = tieuDe,
                FillWeight = tyLe,
                MinimumWidth = beRongToiThieu
            };
        }

        public static Button TaoNut(string text)
        {
            return new Button
            {
                Text = text,
                AutoSize = true,
                MinimumSize = new Size(80, 32),
                Padding = new Padding(10, 0, 10, 0),
                Margin = new Padding(0, 0, 8, 0)
            };
        }

        public static TableLayoutPanel TaoNhomNhap(int soCot)
        {
            var nhom = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Fill,
                ColumnCount = soCot,
                Padding = new Padding(12, 8, 4, 10),
                Margin = new Padding(0, 0, 0, 0)
            };
            for (int cot = 0; cot < soCot; cot++)
                nhom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / soCot));

            return nhom;
        }

        public static void ThemTruong(TableLayoutPanel nhom, string nhan, Control truong, int cot, int hang)
        {
            nhom.Controls.Add(new Label
            {
                AutoSize = true,
                Text = nhan,
                Margin = new Padding(0, 0, 8, 3)
            }, cot, hang);
            truong.AccessibleName = nhan;
            truong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            truong.Margin = new Padding(0, 0, 8, 8);
            nhom.Controls.Add(truong, cot, hang + 1);
        }

        public static void ThemNut(TableLayoutPanel nhom, int hang, params Button[] cacNut)
        {
            var thanh = new FlowLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                WrapContents = false,
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 2, 0, 0)
            };
            thanh.Controls.AddRange(cacNut);
            nhom.Controls.Add(thanh, 0, hang);
            nhom.SetColumnSpan(thanh, nhom.ColumnCount);
        }

        public static Label TaoTrangThai()
        {
            return new Label
            {
                AutoSize = true,
                Margin = new Padding(0, 7, 0, 7)
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
