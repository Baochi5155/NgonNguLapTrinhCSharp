-- 1. Tạo Database TH_6b nếu chưa có và chuyển môi trường làm việc
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TH_6b')
BEGIN
    CREATE DATABASE TH_6b;
END
GO

USE TH_6b;
GO

-- 2. Kiểm tra nếu chưa có bảng SinhVien thì tạo mới
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

-- 3. Kiểm tra nếu chưa có bảng MonHoc thì tạo mới
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MonHoc')
BEGIN
    CREATE TABLE MonHoc (
        MaMH VARCHAR(10) PRIMARY KEY,
        TenMH NVARCHAR(50) NOT NULL,
        SoTiet INT NOT NULL
    );
END
GO

-- 4. Kiểm tra nếu chưa có bảng Diem thì tạo mới (Khóa chính phức hợp MaSV, MaMH)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Diem')
BEGIN
    CREATE TABLE Diem (
        MaSV VARCHAR(10) NOT NULL,
        MaMH VARCHAR(10) NOT NULL,
        Diem FLOAT NOT NULL,
        PRIMARY KEY (MaSV, MaMH),
        CONSTRAINT FK_Diem_SinhVien FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
        CONSTRAINT FK_Diem_MonHoc FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMH)
    );
END
GO

-- 5. Thêm dữ liệu mẫu vào bảng SinhVien và MonHoc
IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV01')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV01', N'Nguyễn Văn A', '2001-05-15');

IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV = 'SV02')
    INSERT INTO SinhVien (MaLop, MaSV, HoTen, NgaySinh) VALUES ('DTH19', 'SV02', N'Trần Thị B', '2001-08-20');

IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMH = 'CSDL')
    INSERT INTO MonHoc (MaMH, TenMH, SoTiet) VALUES ('CSDL', N'Cơ sở dữ liệu', 45);

IF NOT EXISTS (SELECT * FROM MonHoc WHERE MaMH = 'THVP')
    INSERT INTO MonHoc (MaMH, TenMH, SoTiet) VALUES ('THVP', N'Tin học văn phòng', 30);
GO

-- 6. Thêm dữ liệu mẫu ban đầu vào bảng Diem
IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV01' AND MaMH = 'CSDL')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV01', 'CSDL', 8.5);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV02' AND MaMH = 'CSDL')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV02', 'CSDL', 9.0);
GO

-- 7. Xem bảng điểm
SELECT * FROM Diem;