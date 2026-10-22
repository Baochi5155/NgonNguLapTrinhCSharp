-- 1. Tạo Database TH_5d nếu chưa có và chuyển môi trường làm việc
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TH_5d')
BEGIN
    CREATE DATABASE TH_5d;
END
GO

USE TH_5d;
GO

-- 2. Kiểm tra nếu bảng MonHoc chưa có thì tạo mới
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MonHoc')
BEGIN
    CREATE TABLE MonHoc (
        MaMH VARCHAR(10) PRIMARY KEY,
        TenMH NVARCHAR(50) NOT NULL
    );
END
GO

-- 3. Thêm dữ liệu mẫu ban đầu (chỉ thêm nếu MaMH chưa tồn tại)
IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMH = 'CSDL')
    INSERT INTO MonHoc (MaMH, TenMH) VALUES ('CSDL', N'Cơ sở dữ liệu');

IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMH = 'LTTTCSDL')
    INSERT INTO MonHoc (MaMH, TenMH) VALUES ('LTTTCSDL', N'Lập trình tương tác CSDL');

IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMH = 'CTDL')
    INSERT INTO MonHoc (MaMH, TenMH) VALUES ('CTDL', N'Cấu trúc dữ liệu');
GO

-- 4. Xem danh sách môn học
SELECT * FROM MonHoc;