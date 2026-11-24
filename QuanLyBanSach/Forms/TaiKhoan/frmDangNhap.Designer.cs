namespace QuanLyBanSach
{
    partial class frmDangNhap
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblDemNguoc = new System.Windows.Forms.Label();
            this.lblChuaCoTK = new System.Windows.Forms.Label();
            this.lnkDangKy = new System.Windows.Forms.LinkLabel();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrKhoa = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(210, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(135, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐĂNG NHẬP";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(36, 63);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(36, 128);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "MẬT KHẨU:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(191, 60);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(318, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(191, 128);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(318, 25);
            this.txtPassword.TabIndex = 4;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Location = new System.Drawing.Point(191, 160);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(110, 21);
            this.chkHienMatKhau.TabIndex = 5;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(325, 203);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(103, 30);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(434, 203);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(342, 161);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 17);
            this.lblThongBao.TabIndex = 8;
            this.lblThongBao.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDemNguoc
            // 
            this.lblDemNguoc.AutoSize = true;
            this.lblDemNguoc.ForeColor = System.Drawing.Color.Red;
            this.lblDemNguoc.Location = new System.Drawing.Point(342, 185);
            this.lblDemNguoc.Name = "lblDemNguoc";
            this.lblDemNguoc.Size = new System.Drawing.Size(0, 17);
            this.lblDemNguoc.TabIndex = 9;
            // 
            // lblChuaCoTK
            // 
            this.lblChuaCoTK.AutoSize = true;
            this.lblChuaCoTK.Location = new System.Drawing.Point(175, 246);
            this.lblChuaCoTK.Name = "lblChuaCoTK";
            this.lblChuaCoTK.Size = new System.Drawing.Size(119, 17);
            this.lblChuaCoTK.TabIndex = 10;
            this.lblChuaCoTK.Text = "Chưa có tài khoản?";
            // 
            // lnkDangKy
            // 
            this.lnkDangKy.AutoSize = true;
            this.lnkDangKy.Location = new System.Drawing.Point(300, 246);
            this.lnkDangKy.Name = "lnkDangKy";
            this.lnkDangKy.Size = new System.Drawing.Size(109, 17);
            this.lnkDangKy.TabIndex = 11;
            this.lnkDangKy.TabStop = true;
            this.lnkDangKy.Text = "Đăng kí tài khoản";
            // 
            // err
            // 
            this.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err.ContainerControl = this;
            // 
            // tmrKhoa
            // 
            this.tmrKhoa.Interval = 1000;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 272);
            this.Controls.Add(this.lnkDangKy);
            this.Controls.Add(this.lblChuaCoTK);
            this.Controls.Add(this.lblDemNguoc);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.chkHienMatKhau);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblDemNguoc;
        private System.Windows.Forms.Label lblChuaCoTK;
        private System.Windows.Forms.LinkLabel lnkDangKy;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Timer tmrKhoa;
    }
}

