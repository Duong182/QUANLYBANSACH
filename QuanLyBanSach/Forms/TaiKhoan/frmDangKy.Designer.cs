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
            this.grpThongTinDangNhap.Location = new System.Drawing.Point(24, 20);
            this.grpThongTinDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinDangNhap.Name = "grpThongTinDangNhap";
            this.grpThongTinDangNhap.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinDangNhap.Size = new System.Drawing.Size(592, 177);
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
            this.grpThongTinCaNhan.Location = new System.Drawing.Point(24, 213);
            this.grpThongTinCaNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinCaNhan.Name = "grpThongTinCaNhan";
            this.grpThongTinCaNhan.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpThongTinCaNhan.Size = new System.Drawing.Size(592, 222);
            this.grpThongTinCaNhan.TabIndex = 1;
            this.grpThongTinCaNhan.TabStop = false;
            this.grpThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 44);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 85);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(168, 40);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(391, 27);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(168, 81);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(391, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.txtNhapLaiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(168, 122);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '*';
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(391, 27);
            this.txtNhapLaiMatKhau.TabIndex = 4;
            this.txtNhapLaiMatKhau.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Location = new System.Drawing.Point(20, 126);
            this.lblNhapLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(135, 17);
            this.lblNhapLai.TabIndex = 5;
            this.lblNhapLai.Text = "Nhập lại mật khẩu";
            this.lblNhapLai.Click += new System.EventHandler(this.lblNhapLai_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 43);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Location = new System.Drawing.Point(168, 39);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(391, 27);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(168, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 27);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 87);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(69, 17);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(168, 85);
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
            this.rdoNu.Location = new System.Drawing.Point(236, 85);
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
            this.lblEmail.Location = new System.Drawing.Point(20, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Location = new System.Drawing.Point(20, 177);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(58, 17);
            this.lblVaiTro.TabIndex = 7;
            this.lblVaiTro.Text = "Vai trò";
            this.lblVaiTro.Click += new System.EventHandler(this.lblVaiTro_Click);
            // 
            // lblGiaTriVaiTro
            // 
            this.lblGiaTriVaiTro.AccessibleDescription = "";
            this.lblGiaTriVaiTro.AutoSize = true;
            this.lblGiaTriVaiTro.Location = new System.Drawing.Point(168, 177);
            this.lblGiaTriVaiTro.Name = "lblGiaTriVaiTro";
            this.lblGiaTriVaiTro.Size = new System.Drawing.Size(125, 17);
            this.lblGiaTriVaiTro.TabIndex = 8;
            this.lblGiaTriVaiTro.Text = "Nhân viên (mặc định)";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.Location = new System.Drawing.Point(394, 457);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(132, 40);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(538, 457);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 40);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmDangKy
            // 
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 522);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grpThongTinCaNhan);
            this.Controls.Add(this.grpThongTinDangNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký tài khoản";
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