/*
    Khởi tạo cơ sở dữ liệu QuanLyNhaSach cho môi trường phát triển.
    Chạy toàn bộ file trong SQL Server Management Studio.
    Tài khoản ứng dụng để chạy thử là demo_nhanvien, mật khẩu DemoSach123!
    Dữ liệu mẫu chỉ được tạo khi cơ sở dữ liệu chưa có bảng người dùng.
    Hai bảng KhachHang và HoaDon cung cấp dữ liệu cho Tổng quan và Thống kê.
    Bảng LinhVuc cung cấp danh sách lựa chọn trong màn hình Sách.
*/

USE [master];
GO

IF DB_ID(N'QuanLyNhaSach') IS NULL
    EXEC(N'CREATE DATABASE [QuanLyNhaSach] COLLATE SQL_Latin1_General_CP1_CI_AS;');
GO

USE [QuanLyNhaSach];
GO

SET NOCOUNT ON;
SET XACT_ABORT ON;

IF DB_NAME() <> N'QuanLyNhaSach'
    THROW 50010, N'Hãy kết nối tới cơ sở dữ liệu QuanLyNhaSach trước khi khởi tạo.', 1;

IF EXISTS (SELECT 1 FROM sys.tables WHERE is_ms_shipped = 0)
BEGIN
    IF (SELECT COUNT(*) FROM sys.tables
        WHERE schema_id = SCHEMA_ID(N'dbo')
          AND name IN (N'TaiKhoan', N'KhachHang', N'TacGia', N'LinhVuc', N'LoaiSach', N'Sach', N'HoaDon')) = 7
    BEGIN
        PRINT N'QuanLyNhaSach đã có đủ các bảng. Bỏ qua bước khởi tạo.';
        RETURN;
    END;

    THROW 50011, N'Cơ sở dữ liệu đã có bảng nhưng chưa đủ bộ bảng của ứng dụng. Hãy khởi tạo trên cơ sở dữ liệu trống.', 1;
END;

BEGIN TRY
    BEGIN TRANSACTION;

    CREATE TABLE dbo.TaiKhoan
    (
        MaTaiKhoan   int IDENTITY(1, 1) NOT NULL CONSTRAINT PK_TaiKhoan PRIMARY KEY,
        Username     nvarchar(50) COLLATE Latin1_General_100_CI_AS NOT NULL,
        PasswordHash binary(32) NOT NULL,
        HoTen        nvarchar(100) NOT NULL,
        GioiTinh     nvarchar(3) NOT NULL,
        Email        nvarchar(100) NOT NULL,
        VaiTro       nvarchar(20) NOT NULL CONSTRAINT DF_TaiKhoan_VaiTro DEFAULT N'NhanVien',
        CONSTRAINT UQ_TaiKhoan_Username UNIQUE (Username),
        CONSTRAINT CK_TaiKhoan_GioiTinh CHECK (GioiTinh IN (N'Nam', N'Nữ')),
        CONSTRAINT CK_TaiKhoan_VaiTro CHECK (VaiTro IN (N'Admin', N'NhanVien'))
    );

    CREATE TABLE dbo.KhachHang
    (
        MaKhachHang  int IDENTITY(1, 1) NOT NULL CONSTRAINT PK_KhachHang PRIMARY KEY,
        TenKhachHang nvarchar(100) NOT NULL
    );

    CREATE TABLE dbo.TacGia
    (
        MaTacGia  int IDENTITY(1, 1) NOT NULL CONSTRAINT PK_TacGia PRIMARY KEY,
        TenTacGia nvarchar(100) NOT NULL
    );

    CREATE TABLE dbo.LinhVuc
    (
        MaLinhVuc  int IDENTITY(1, 1) NOT NULL CONSTRAINT PK_LinhVuc PRIMARY KEY,
        TenLinhVuc nvarchar(100) NOT NULL
    );

    CREATE TABLE dbo.LoaiSach
    (
        MaLoaiSach  int IDENTITY(1, 1) NOT NULL CONSTRAINT PK_LoaiSach PRIMARY KEY,
        TenLoaiSach nvarchar(100) NOT NULL
    );

    CREATE TABLE dbo.Sach
    (
        MaSach     varchar(20) NOT NULL CONSTRAINT PK_Sach PRIMARY KEY,
        TenSach    nvarchar(200) NOT NULL,
        MaTacGia   int NOT NULL,
        MaLinhVuc  int NOT NULL,
        MaLoaiSach int NOT NULL,
        GiaBia     decimal(18, 2) NOT NULL,
        CONSTRAINT FK_Sach_TacGia FOREIGN KEY (MaTacGia) REFERENCES dbo.TacGia (MaTacGia),
        CONSTRAINT FK_Sach_LinhVuc FOREIGN KEY (MaLinhVuc) REFERENCES dbo.LinhVuc (MaLinhVuc),
        CONSTRAINT FK_Sach_LoaiSach FOREIGN KEY (MaLoaiSach) REFERENCES dbo.LoaiSach (MaLoaiSach),
        CONSTRAINT CK_Sach_GiaBia CHECK (GiaBia >= 0)
    );

    CREATE TABLE dbo.HoaDon
    (
        MaHoaDon    varchar(20) NOT NULL CONSTRAINT PK_HoaDon PRIMARY KEY,
        MaKhachHang int NOT NULL,
        NgayLap     datetime2(7) NOT NULL CONSTRAINT DF_HoaDon_NgayLap DEFAULT SYSDATETIME(),
        TongTien    decimal(18, 2) NOT NULL,
        CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES dbo.KhachHang (MaKhachHang),
        CONSTRAINT CK_HoaDon_TongTien CHECK (TongTien >= 0)
    );

    CREATE INDEX IX_HoaDon_NgayLap ON dbo.HoaDon (NgayLap);

    INSERT INTO dbo.TaiKhoan (Username, PasswordHash, HoTen, GioiTinh, Email)
    VALUES (N'demo_nhanvien', HASHBYTES('SHA2_256', 'DemoSach123!'),
            N'Nhân viên mẫu', N'Nam', N'demo@example.test');

    INSERT INTO dbo.TacGia (TenTacGia)
    VALUES (N'Nguyễn Minh An'), (N'Trần Hoài Nam'), (N'Lê Thanh Vân');

    INSERT INTO dbo.LinhVuc (TenLinhVuc)
    VALUES (N'Công nghệ'), (N'Văn học'), (N'Kinh tế');

    INSERT INTO dbo.LoaiSach (TenLoaiSach)
    VALUES (N'Giáo trình'), (N'Tiểu thuyết'), (N'Kỹ năng');

    INSERT INTO dbo.Sach (MaSach, TenSach, MaTacGia, MaLinhVuc, MaLoaiSach, GiaBia)
    SELECT mau.MaSach, mau.TenSach, tg.MaTacGia, lv.MaLinhVuc, ls.MaLoaiSach, mau.GiaBia
    FROM (VALUES
        ('S001', N'Nhập môn lập trình', N'Nguyễn Minh An', N'Công nghệ', N'Giáo trình', 120000.00),
        ('S002', N'Mùa mưa bên sông', N'Trần Hoài Nam', N'Văn học', N'Tiểu thuyết', 89000.00),
        ('S003', N'Quản lý chi tiêu cá nhân', N'Lê Thanh Vân', N'Kinh tế', N'Kỹ năng', 105000.00),
        ('S004', N'Thực hành cơ sở dữ liệu', N'Nguyễn Minh An', N'Công nghệ', N'Giáo trình', 145000.00)
    ) AS mau (MaSach, TenSach, TenTacGia, TenLinhVuc, TenLoaiSach, GiaBia)
    INNER JOIN dbo.TacGia tg ON tg.TenTacGia = mau.TenTacGia
    INNER JOIN dbo.LinhVuc lv ON lv.TenLinhVuc = mau.TenLinhVuc
    INNER JOIN dbo.LoaiSach ls ON ls.TenLoaiSach = mau.TenLoaiSach;

    INSERT INTO dbo.KhachHang (TenKhachHang)
    VALUES (N'Khách hàng mẫu 01'), (N'Khách hàng mẫu 02');

    INSERT INTO dbo.HoaDon (MaHoaDon, MaKhachHang, TongTien)
    SELECT mau.MaHoaDon, kh.MaKhachHang, mau.TongTien
    FROM (VALUES
        ('HD001', N'Khách hàng mẫu 01', 120000.00),
        ('HD002', N'Khách hàng mẫu 02', 194000.00)
    ) AS mau (MaHoaDon, TenKhachHang, TongTien)
    INNER JOIN dbo.KhachHang kh ON kh.TenKhachHang = mau.TenKhachHang;

    COMMIT TRANSACTION;
    PRINT N'Đã khởi tạo QuanLyNhaSach cùng dữ liệu mẫu.';
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0
        ROLLBACK TRANSACTION;
    THROW;
END CATCH;
GO
