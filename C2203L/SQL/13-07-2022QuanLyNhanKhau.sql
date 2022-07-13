CREATE DATABASE QuanLyNhanKhau;
USE QuanLyNhanKhau;
CREATE TABLE QuanHuyen(
	MaQH INT IDENTITY(1,1) NOT NULL,
	TenQH NVARCHAR(100)
);
CREATE TABLE DuongPho(
	DuongID INT NOT NULL,
	MaQH INT NOT NULL,
	TenDuong NVARCHAR(MAX) NOT NULL,
	NgayDuyetTen DATETIME NOT NULL
);
CREATE TABLE NhaTrenPho(
	NhaID INT NOT NULL,
	DuongID INT NOT NULL,--N NhaTrenPho - 1 DuongPho
	ChuHo NVARCHAR(50) NULL,
	DienTich MONEY NULL
);
CREATE CLUSTERED INDEX CI_NhaTrenPho_NhaID   
ON NhaTrenPho(NhaID);

CREATE UNIQUE NONCLUSTERED INDEX UI_QuanHuyen_TenQH  
ON QuanHuyen(TenQH );

ALTER TABLE NhaTrenPho
ADD SoNhanKhau INT;

ALTER TABLE QuanHuyen 
ADD CONSTRAINT PK_QuanHuyen 
PRIMARY KEY(MaQH); 

ALTER TABLE DuongPho 
ADD CONSTRAINT PK_DuongPho 
PRIMARY KEY(DuongID); 

ALTER TABLE NhaTrenPho 
ADD CONSTRAINT PK_NhaTrenPho 
PRIMARY KEY(NhaID); 

ALTER TABLE DuongPho
DROP CONSTRAINT CK_DuongPho_NgayDuyetTen;


ALTER TABLE NhaTrenPho
ADD CONSTRAINT FK_NhaTrenPho_DuongPho
FOREIGN KEY (DuongID) REFERENCES DuongPho(DuongID); 

ALTER TABLE DuongPho
ADD CONSTRAINT FK_DuongPho_QuanHuyen
FOREIGN KEY (MaQH) REFERENCES QuanHuyen(MaQH); 


ALTER TABLE DuongPho
ADD CONSTRAINT CK_DuongPho_NgayDuyetTen 
CHECK (NgayDuyetTen >= '1945-09-02' OR NgayDuyetTen <= getdate()); 

INSERT INTO QuanHuyen(TenQH) VALUES
(N'Ba Đình'),
(N'Hoàng Mai');

INSERT INTO DuongPho(DuongId,MaQH,TenDuong,NgayDuyetTen) VALUES
(1,1,N'ĐộiCấn','1946-10-19'),
(2,1,N'VạnPhúc','1998-12-30'),
(3,2,N'GiảiTỏa','1975-09-21');
SELECT * FROM DuongPho;

INSERT INTO NhaTrenPho(NhaID,DuongID,ChuHo,DienTich,SoNhanKhau) VALUES
(1,1,N'Hà Khánh Toàn',100,4),
(2,1,N'Lê Hồng Hải',20,12),
(3,2,N'Trần Khánh',40,1);
SELECT * FROM NhaTrenPho;

UPDATE DuongPho 
SET TenDuong=N'Giải Phóng'
WHERE TenDuong = N'GiảiTỏa';

SELECT * FROM DuongPho 
WHERE TenDuong = N'GiảiTỏa';

