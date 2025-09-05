CREATE DATABASE ThuongMaiDienTu;
GO

USE ThuongMaiDienTu;
GO

CREATE TABLE DangNhap (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(100) UNIQUE,
    MatKhau NVARCHAR(100)
);
GO

INSERT INTO DangNhap (TenDangNhap, MatKhau) VALUES
(N'admin', '123'),
(N'quanly', '123'),
(N'user', '123');
CREATE TABLE KhachHang (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(255),
    SoDienThoai VARCHAR(10),
    DiaChi NVARCHAR(255),
    NgaySinh DATETIME
);

CREATE TABLE LoaiKhachHang (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiKH NVARCHAR(100)
);

INSERT INTO LoaiKhachHang (TenLoaiKH) VALUES 
(N'Khách vàng'),
(N'Khách bạc'),
(N'Khách đồng');
ALTER TABLE KhachHang ADD LoaiKH INT FOREIGN KEY REFERENCES LoaiKhachHang(Id);
