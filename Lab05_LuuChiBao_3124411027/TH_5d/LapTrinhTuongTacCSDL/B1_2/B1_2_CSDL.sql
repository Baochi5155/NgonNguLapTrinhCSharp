-- 1. Tạo và sử dụng Database local QLKhoaDB
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QLKhoaDB')
BEGIN
    CREATE DATABASE QLKhoaDB;
END
GO

USE QLKhoaDB;
GO

-- 2. Kiểm tra nếu bảng Khoa chưa có thì mới tạo bảng
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Khoa')
BEGIN
    CREATE TABLE Khoa (
        MaKhoa VARCHAR(10) PRIMARY KEY,
        TenKhoa NVARCHAR(50) NOT NULL
    );
END
GO

-- 3. Thêm dữ liệu mẫu
IF NOT EXISTS (SELECT * FROM Khoa WHERE MaKhoa = 'CK')
    INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CK', N'Cơ khí');

IF NOT EXISTS (SELECT * FROM Khoa WHERE MaKhoa = 'CNTT')
    INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CNTT', N'Công nghệ thông tin');

IF NOT EXISTS (SELECT * FROM Khoa WHERE MaKhoa = 'DDT')
    INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('DDT', N'Điện - Điện tử');

IF NOT EXISTS (SELECT * FROM Khoa WHERE MaKhoa = 'NNA')
    INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('NNA', N'Ngôn ngữ Anh');

IF NOT EXISTS (SELECT * FROM Khoa WHERE MaKhoa = 'QTKD')
    INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('QTKD', N'Quản trị kinh doanh');
GO

-- 4. Kiểm tra dữ liệu sau khi thực thi
SELECT * FROM Khoa;