namespace QuanLyBanSach.GUI.TaiKhoan
{
    partial class frmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpThongTinDangNhap = new System.Windows.Forms.GroupBox();
            this.grpThongTinCaNhan = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblGiaTriVaiTro = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpThongTinDangNhap.SuspendLayout();
            this.grpThongTinCaNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTinDangNhap
            // 
            this.grpThongTinDangNhap.Controls.Add(this.lblNhapLai);
            this.grpThongTinDangNhap.Controls.Add(this.txtNhapLaiMatKhau);
            this.grpThongTinDangNhap.Controls.Add(this.txtPassword);
            this.grpThongTinDangNhap.Controls.Add(this.txtUsername);
            this.grpThongTinDangNhap.Controls.Add(this.lblPassword);
            this.grpThongTinDangNhap.Controls.Add(this.lblUsername);
            this.grpThongTinDangNhap.Location = new System.Drawing.Point(14, 16);
            this.grpThongTinDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinDangNhap.Name = "grpThongTinDangNhap";
            this.grpThongTinDangNhap.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinDangNhap.Size = new System.Drawing.Size(614, 215);
            this.grpThongTinDangNhap.TabIndex = 0;
            this.grpThongTinDangNhap.TabStop = false;
            this.grpThongTinDangNhap.Text = "Thông tin đăng nhập";
            // 
            // grpThongTinCaNhan
            // 
            this.grpThongTinCaNhan.Controls.Add(this.lblGiaTriVaiTro);
            this.grpThongTinCaNhan.Controls.Add(this.lblVaiTro);
            this.grpThongTinCaNhan.Controls.Add(this.lblEmail);
            this.grpThongTinCaNhan.Controls.Add(this.rdoNu);
            this.grpThongTinCaNhan.Controls.Add(this.rdoNam);
            this.grpThongTinCaNhan.Controls.Add(this.lblGioiTinh);
            this.grpThongTinCaNhan.Controls.Add(this.txtEmail);
            this.grpThongTinCaNhan.Controls.Add(this.txtHoTen);
            this.grpThongTinCaNhan.Controls.Add(this.lblHoTen);
            this.grpThongTinCaNhan.Location = new System.Drawing.Point(14, 252);
            this.grpThongTinCaNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinCaNhan.Name = "grpThongTinCaNhan";
            this.grpThongTinCaNhan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinCaNhan.Size = new System.Drawing.Size(614, 215);
            this.grpThongTinCaNhan.TabIndex = 1;
            this.grpThongTinCaNhan.TabStop = false;
            this.grpThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 47);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 86);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "MẬT KHẨU:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(163, 44);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(439, 25);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(163, 83);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(439, 25);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(163, 126);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '*';
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(439, 25);
            this.txtNhapLaiMatKhau.TabIndex = 4;
            this.txtNhapLaiMatKhau.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Location = new System.Drawing.Point(8, 129);
            this.lblNhapLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(135, 17);
            this.lblNhapLai.TabIndex = 5;
            this.lblNhapLai.Text = "NHẬP LẠI MẬT KHẨU:";
            this.lblNhapLai.Click += new System.EventHandler(this.lblNhapLai_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(8, 52);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "HỌ TÊN:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(163, 49);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(439, 25);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(439, 25);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(8, 96);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(69, 17);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "GIỚI TÍNH:";
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(163, 94);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(54, 21);
            this.rdoNam.TabIndex = 4;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(231, 94);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(44, 21);
            this.rdoNu.TabIndex = 5;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            this.rdoNu.CheckedChanged += new System.EventHandler(this.rdoNu_CheckedChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Location = new System.Drawing.Point(8, 180);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(58, 17);
            this.lblVaiTro.TabIndex = 7;
            this.lblVaiTro.Text = "VAI TRÒ:";
            this.lblVaiTro.Click += new System.EventHandler(this.lblVaiTro_Click);
            // 
            // lblGiaTriVaiTro
            // 
            this.lblGiaTriVaiTro.AccessibleDescription = "";
            this.lblGiaTriVaiTro.AutoSize = true;
            this.lblGiaTriVaiTro.ForeColor = System.Drawing.Color.Gray;
            this.lblGiaTriVaiTro.Location = new System.Drawing.Point(160, 180);
            this.lblGiaTriVaiTro.Name = "lblGiaTriVaiTro";
            this.lblGiaTriVaiTro.Size = new System.Drawing.Size(125, 17);
            this.lblGiaTriVaiTro.TabIndex = 8;
            this.lblGiaTriVaiTro.Text = "NhanVien(mặc định)";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(436, 474);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(104, 41);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(546, 474);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 41);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 539);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grpThongTinCaNhan);
            this.Controls.Add(this.grpThongTinDangNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ĐĂNG KÝ";
            this.grpThongTinDangNhap.ResumeLayout(false);
            this.grpThongTinDangNhap.PerformLayout();
            this.grpThongTinCaNhan.ResumeLayout(false);
            this.grpThongTinCaNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinDangNhap;
        private System.Windows.Forms.GroupBox grpThongTinCaNhan;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGiaTriVaiTro;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ErrorProvider err;
    }
}