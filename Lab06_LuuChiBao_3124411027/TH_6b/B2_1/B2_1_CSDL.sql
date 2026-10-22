-- Script CSDL chuẩn cho Bài B2_1 (Quản lý Sinh viên) trên Database TH_6b
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TH_6b')
BEGIN
    CREATE DATABASE TH_6b;
END
GO

USE TH_6b;
GO

-- 1. Kiểm tra nếu chưa có bảng Lop thì tạo mới
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Lop')
BEGIN
    CREATE TABLE Lop (
        MaKhoa VARCHAR(10) NOT NULL,
        MaLop VARCHAR(10) PRIMARY KEY,
        TenLop NVARCHAR(50) NOT NULL
    );
END
GO

-- 2. Thêm dữ liệu mẫu vào bảng Lop
IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = '04CDNTH')
    INSERT INTO Lop (MaKhoa, MaLop, TenLop) VALUES ('CNTT', '04CDNTH', N'Cao đẳng Tin học 04');

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = 'DTH19')
    INSERT INTO Lop (MaKhoa, MaLop, TenLop) VALUES ('CNTT', 'DTH19', N'Đại học Tin học 19');
GO

-- 3. Kiểm tra nếu chưa có bảng SinhVien thì tạo mới
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SinhVien')
BEGIN
    CREATE TABLE SinhVien (
        MaLop VARCHAR(10) NOT NULL,
        MaSV VARCHAR(10) PRIMARY KEY,
        HoTen NVARCHAR(50) NOT NULL,
        NgaySinh DATETIME NOT NULL,
        CONSTRAINT FK_SinhVien_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
    );
END
GO

-- 4. Thêm dữ liệu mẫu vào bảng SinhVien
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV01')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV01', N'Nguyễn Văn A', '2001-05-15');

IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV02')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV02', N'Trần Thị B', '2001-08-20');
GO

-- 5. Xem danh sách lớp và sinh viên
SELECT * FROM Lop;
SELECT * FROM SinhVien;