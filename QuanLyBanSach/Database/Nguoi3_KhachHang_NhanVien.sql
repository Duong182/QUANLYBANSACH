/*
    Mở rộng dữ liệu cho module Khách hàng và Nhân viên.
    Chạy QuanLyNhaSach.sql trước khi chạy file này lần đầu.
*/
USE [QuanLyNhaSach];
GO

SET XACT_ABORT ON;

IF DB_NAME() <> N'QuanLyNhaSach'
    THROW 50020, N'Hãy kết nối tới database QuanLyNhaSach để cập nhật.', 1;

IF OBJECT_ID(N'dbo.KhachHang', N'U') IS NULL
   OR COL_LENGTH(N'dbo.KhachHang', N'TenKhachHang') IS NULL
   OR ISNULL(COLUMNPROPERTY(OBJECT_ID(N'dbo.KhachHang'), N'MaKhachHang', 'IsIdentity'), 0) <> 1
    THROW 50021, N'Cần bảng KhachHang từ script khởi tạo chung trước khi cập nhật.', 1;

BEGIN TRY
    BEGIN TRANSACTION;

    IF COL_LENGTH(N'dbo.KhachHang', N'SDT') IS NULL
        ALTER TABLE dbo.KhachHang ADD SDT varchar(15) NULL;

    IF COL_LENGTH(N'dbo.KhachHang', N'DiaChi') IS NULL
        ALTER TABLE dbo.KhachHang ADD DiaChi nvarchar(200) NULL;

    IF COL_LENGTH(N'dbo.KhachHang', N'Email') IS NULL
        ALTER TABLE dbo.KhachHang ADD Email nvarchar(100) NULL;

    IF OBJECT_ID(N'dbo.NhanVien', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.NhanVien
        (
            MaNV   nvarchar(20) NOT NULL CONSTRAINT PK_NhanVien PRIMARY KEY,
            TenNV  nvarchar(100) NOT NULL,
            SDT    varchar(15) NULL,
            DiaChi nvarchar(200) NULL,
            Email  nvarchar(100) NULL,
            ChucVu nvarchar(50) NOT NULL
        );
    END;

    IF (SELECT COUNT(*) FROM sys.columns
        WHERE object_id = OBJECT_ID(N'dbo.NhanVien', N'U')
          AND name IN (N'MaNV', N'TenNV', N'SDT', N'DiaChi', N'Email', N'ChucVu')) <> 6
        THROW 50022, N'Bảng NhanVien hiện có khác cấu trúc của module. Hãy đối chiếu các cột trước khi cập nhật.', 1;

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0
        ROLLBACK TRANSACTION;
    THROW;
END CATCH;
GO
