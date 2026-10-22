-- 1. Tạo Database TH_5d nếu chưa có và chuyển môi trường làm việc
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TH_5d')
BEGIN
    CREATE DATABASE TH_5d;
END
GO

USE TH_5d;
GO

-- 2. Kiểm tra nếu bảng Diem chưa có thì tạo mới
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

-- 3. Thêm dữ liệu mẫu ban đầu (chỉ thêm nếu cặp MaSV + MaMH chưa tồn tại)
IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV01' AND MaMH = 'CSDL')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV01', 'CSDL', 8.5);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV01' AND MaMH = 'CTDL')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV01', 'CTDL', 7.0);

IF NOT EXISTS (SELECT * FROM Diem WHERE MaSV = 'SV02' AND MaMH = 'CSDL')
    INSERT INTO Diem (MaSV, MaMH, Diem) VALUES ('SV02', 'CSDL', 9.0);
GO

-- 4. Xem danh sách điểm
SELECT * FROM Diem;