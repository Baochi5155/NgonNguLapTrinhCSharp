-- Script CSDL chuẩn cho B3_1 trên Database TH_6b (Đã sửa lỗi tràn dữ liệu)
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
        MaLop VARCHAR(10) PRIMARY KEY,
        TenLop NVARCHAR(100) NOT NULL,
        MaKhoa VARCHAR(10) NOT NULL
    );
END
GO

-- 2. Thêm dữ liệu mẫu (Đảm bảo thứ tự cột: MaLop, TenLop, MaKhoa)
IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = '05DHKT2')
    INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('05DHKT2', N'Kế toán ngân hàng khóa 05', 'KT');

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = '05DHTH1')
    INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('05DHTH1', N'Công nghệ phần mềm khóa 05', 'CNTT');

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = '05DHTH2')
    INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('05DHTH2', N'Lập trình mạng khóa 05', 'CNTT');

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = '06DHHH1')
    INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('06DHHH1', N'Hóa phân tích khóa 06', 'HH');

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = '06DHKT1')
    INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('06DHKT1', N'Thuế doanh nghiệp khóa 06', 'KT');

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = '06DHTH1')
    INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('06DHTH1', N'Công nghệ phần mềm khóa 06', 'CNTT');
GO

-- 3. Xem danh sách lớp
SELECT * FROM Lop;