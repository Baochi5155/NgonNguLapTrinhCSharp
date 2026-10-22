-- 1. Tạo Database TH_6a nếu chưa có và chuyển môi trường làm việc
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TH_6a')
BEGIN
    CREATE DATABASE TH_6a;
END
GO

USE TH_6a;
GO

-- 2. Tạo bảng SinhVien nếu chưa tồn tại
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'SinhVien')
BEGIN
    CREATE TABLE SinhVien (
        MaLop VARCHAR(10) NOT NULL,
        MaSV VARCHAR(10) PRIMARY KEY,
        HoTen NVARCHAR(50) NOT NULL,
        NgaySinh DATETIME NOT NULL
    );
END
GO

-- 3. Thêm dữ liệu mẫu ban đầu (chỉ thêm nếu MaSV chưa tồn tại)
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV01')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV01', N'Nguyễn Văn A', '2001-05-15');

IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV02')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV02', N'Trần Thị B', '2001-08-20');
GO

-- 4. Xem danh sách sinh viên
SELECT * FROM SinhVien;