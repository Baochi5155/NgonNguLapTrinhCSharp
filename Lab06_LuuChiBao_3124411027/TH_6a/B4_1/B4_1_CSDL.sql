-- 1. Tạo Database TH_6a nếu chưa có và chuyển môi trường làm việc
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TH_6a')
BEGIN
    CREATE DATABASE TH_6a;
END
GO

USE TH_6a;
GO

-- 2. Kiểm tra nếu bảng Lop chưa có thì tạo mới
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Lop')
BEGIN
    CREATE TABLE Lop (
        MaKhoa VARCHAR(10) NOT NULL,
        MaLop VARCHAR(10) PRIMARY KEY,
        TenLop NVARCHAR(50) NOT NULL
    );
END
GO

-- 3. Thêm dữ liệu mẫu ban đầu (chỉ thêm nếu MaLop chưa tồn tại)
IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = 'DTH19')
    INSERT INTO Lop (MaKhoa, MaLop, TenLop) VALUES ('CNTT', 'DTH19', N'Đại học Tin học khóa 19');

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = 'DKT20')
    INSERT INTO Lop (MaKhoa, MaLop, TenLop) VALUES ('KT', 'DKT20', N'Đại học Kế toán khóa 20');

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = 'DCK21')
    INSERT INTO Lop (MaKhoa, MaLop, TenLop) VALUES ('CK', 'DCK21', N'Đại học Cơ khí khóa 21');
GO

-- 4. Xem danh sách lớp
SELECT * FROM Lop;