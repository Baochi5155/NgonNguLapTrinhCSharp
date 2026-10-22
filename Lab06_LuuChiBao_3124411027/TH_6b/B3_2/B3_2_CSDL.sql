USE TH_6b;
GO

-- 1. Sửa cột SoTiet trong bảng MonHoc cho phép NULL (tránh lỗi Msg 515)
IF EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('MonHoc') AND name = 'SoTiet')
BEGIN
    ALTER TABLE MonHoc ALTER COLUMN SoTiet INT NULL;
END
GO

-- 2. Kiểm tra nếu chưa có bảng MonHoc thì tạo mới
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MonHoc')
BEGIN
    CREATE TABLE MonHoc (
        MaMH VARCHAR(10) PRIMARY KEY,
        TenMH NVARCHAR(100) NOT NULL,
        SoTiet INT NULL
    );
END
GO

-- 3. Thêm dữ liệu mẫu Môn học (truyền đầy đủ MaMH, TenMH, SoTiet)
IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMH = '1')
    INSERT INTO MonHoc (MaMH, TenMH, SoTiet) VALUES ('1', N'Toán Cao cấp', 45);

IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMH = '2')
    INSERT INTO MonHoc (MaMH, TenMH, SoTiet) VALUES ('2', N'Mác - Lênin', 30);

IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMH = '3')
    INSERT INTO MonHoc (MaMH, TenMH, SoTiet) VALUES ('3', N'Tin học đại cương', 45);
GO

-- 4. Tạo bảng Lop nếu chưa có
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Lop')
BEGIN
    CREATE TABLE Lop (
        MaLop VARCHAR(10) PRIMARY KEY,
        TenLop NVARCHAR(100) NOT NULL,
        MaKhoa VARCHAR(10) NOT NULL
    );
END
GO

IF NOT EXISTS (SELECT * FROM Lop WHERE MaLop = 'DTH19')
    INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('DTH19', N'Đại học Tin học 19', 'CNTT');
GO

-- 5. Tạo bảng SinhVien nếu chưa có
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

-- Thêm dữ liệu mẫu Sinh viên
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV01')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV01', N'Trần Thanh Tùng', '1993-12-10');

IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV02')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV02', N'Nguyễn Thanh Bình', '1993-02-04');

IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV03')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV03', N'Nguyễn Đạt Nhân', '1992-03-15');

IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV04')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV04', N'Nguyễn Gia Bảo', '1993-05-11');

IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV05')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV05', N'Nguyễn Thanh Lan', '1993-06-12');

IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV06')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV06', N'Lâm Văn Tuấn', '1993-08-03');
GO

-- 6. Tạo bảng Diem nếu chưa có
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Diem')
BEGIN
    CREATE TABLE Diem (
        MaSV VARCHAR(10) NOT NULL,
        MaMH VARCHAR(10) NOT NULL,
        Diem FLOAT NOT NULL,
        PRIMARY KEY (MaSV, MaMH)
    );
END
GO

-- Thêm dữ liệu Điểm
IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV01' AND MaMH = '1')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV01', '1', 4);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV01' AND MaMH = '2')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV01', '2', 7);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV02' AND MaMH = '1')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV02', '1', 6);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV02' AND MaMH = '2')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV02', '2', 3);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV02' AND MaMH = '3')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV02', '3', 5);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV03' AND MaMH = '1')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV03', '1', 9);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV03' AND MaMH = '2')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV03', '2', 10);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV03' AND MaMH = '3')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV03', '3', 9);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV04' AND MaMH = '1')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV04', '1', 3);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV04' AND MaMH = '2')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV04', '2', 6);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV05' AND MaMH = '1')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV05', '1', 5);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV05' AND MaMH = '3')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV05', '3', 7);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV06' AND MaMH = '2')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV06', '2', 8);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV06' AND MaMH = '3')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV06', '3', 8);
GO

-- 7. Kiểm tra lại kết quả
SELECT * FROM MonHoc;
SELECT * FROM SinhVien;
SELECT * FROM Diem;