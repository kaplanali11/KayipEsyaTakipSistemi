create database KayipEsyaTakipDB

use KayipEsyaTakipDB

CREATE TABLE KullaniciTBL(
KullaniciID INT PRIMARY KEY IDENTITY(1,1),
Ad NVARCHAR(40) NOT NULL,
Soyad NVARCHAR(40) NOT NULL,
Telefon NVARCHAR(11),
Email NVARCHAR(70))

CREATE TABLE EsyaTBL (
    EsyaID INT PRIMARY KEY IDENTITY(1,1),
    EsyaAdi NVARCHAR(100) NOT NULL,
    KayipTarihi DATE NOT NULL,
    KayipYeri NVARCHAR(100),
    KullaniciID INT NOT NULL,
    FOREIGN KEY (KullaniciID) REFERENCES KullaniciTBL(KullaniciID))

	CREATE TABLE BulunmaBilgisiTBL (
    BulunmaID INT PRIMARY KEY IDENTITY(1,1),
    EsyaID INT NOT NULL,
    BulunmaTarihi DATE,
    BulunduguYer NVARCHAR(100),
    TeslimAlanID INT,
    FOREIGN KEY (EsyaID) REFERENCES EsyaTBL(EsyaID),
    FOREIGN KEY (TeslimAlanID) REFERENCES KullaniciTBL(KullaniciID))

ALTER TABLE KullaniciTBL ALTER COLUMN Telefon varchar(11)

ALTER TABLE BulunmaBilgisiTBL
ALTER COLUMN BulunmaTarihi DATE NOT NULL;

ALTER TABLE BulunmaBilgisiTBL
ALTER COLUMN BulunduguYer NVARCHAR(100) NOT NULL;

ALTER TABLE BulunmaBilgisiTBL
ALTER COLUMN TeslimAlanID INT NOT NULL;

ALTER TABLE KullaniciTBL add Yas TINYINT;

Alter table EsyaTBL add OnemDerecesi TINYINT CHECK (OnemDerecesi IN(1,2,3,4,5))

INSERT INTO KullaniciTBL (Ad, Soyad, Telefon, Email,Yas)
VALUES 
(N'Ahmet', N'Y�lmaz', '05051234567', N'ahmet.yilmaz@gmail.com',45),  
(N'Mehmet', N'Demir', '05052345678', N'mehmet.demir@gmail.com',23),  
(N'Ay�e', N'Kara', '05053456789', N'ayse.kara@gmail.com',61),        
(N'Fatma', N'�elik', '05054567890', N'fatma.celik@gmail.com',19),     
(N'Ali', N'Y�ld�z', '05055678901', N'ali.yildiz@gmail.com',46),       
(N'H�seyin', N'�zt�rk', '05061234567', N'huseyin.ozturk@gmail.com',33),
(N'Murat', N'G�zel', '05062345678', N'murat.guzel@gmail.com',28),     
(N'Zeynep', N'�ak�r', '05063456789', N'zeynep.cakir@gmail.com',37),   
(N'Emre', N'Polat', '05064567890', N'emre.polat@gmail.com',20),       
(N'Selin', N'Duru', '05065678901', N'selin.duru@gmail.com',18),       
(N'Kaan', N'Berk', '05531234567', N'kaan.berk@gmail.com',19),         
(N'Berna', N'Akba�','05532345678', N'berna.akbas@gmail.com',41),    
(N'Cem', N'Bodur', '05533456789', N'cem.bodur@gmail.com',46),         
(N'Ayhan', N'Ayd�n', '05534567890', N'ayhan.aydin@gmail.com',70),    
(N'Emine', N'Yavuz', '05535678901', N'emine.yavuz@gmail.com',55),     
(N'G�khan', N'Kara', '05321234567', N'gokhan.kara@gmail.com',48),     
(N'Feyza', N'Arslan', '05322345678', N'feyza.arslan@gmail.com',24),   
(N'Eda', N'�ahin', '05323456789', N'eda.sahin@gmail.com',32),         
(N'Serkan', N'Korkmaz', '05324567890', N'serkan.korkmaz@gmail.com',43), 
(N'Yusuf', N'G�nay', '05325678901', N'yusuf.gunay@gmail.com',26)  

INSERT INTO EsyaTBL(EsyaAdi, KayipTarihi, KayipYeri, KullaniciID, OnemDerecesi)
VALUES 
(N'Laptop', '2025-05-10', N'�sk�dar', 1, 5),  
(N'C�zdan', '2025-05-12', N'Kad�k�y', 2, 5), 
(N'Telefon', '2025-05-14', N'Be�ikta�', 3, 5), 
(N'Anahtar', '2025-05-13', N'�i�li', 4, 4),   
(N'�anta', '2025-05-11', N'Beyo�lu', 5, 3),   
(N'Defter', '2025-05-16', N'Taksim', 6, 2),    
(N'Bilezik', '2025-05-17', N'Fatih', 7, 4),   
(N'Saat', '2025-05-18', N'Bak�rk�y', 8, 4),   
(N'Y�z�k', '2025-05-19', N'Ba�c�lar', 9, 5),  
(N'G�zl�k', '2025-05-20', N'Levent', 10, 2),  
(N'Kulakl�k', '2025-05-21', N'Sar�yer', 11, 2),
(N'Televizyon', '2025-05-22', N'Kartal', 12, 5), 
(N'Banka Kart�', '2025-05-23', N'Pendik', 13, 4), 
(N'USB Bellek', '2025-05-24', N'Maltepe', 14, 3), 
(N'Bilet', '2025-05-25', N'�sk�dar', 15, 1), 
(N'Kitap', '2025-05-26', N'Kad�k�y', 16, 2), 
(N'Tablet', '2025-05-27', N'�i�li', 17, 4),   
(N'Makyaj Malzemesi', '2025-05-28', N'Beyo�lu', 18, 2), 
(N'Kamera', '2025-05-29', N'Sultanbeyli', 19, 5), 
(N'Powerbank', '2025-05-30', N'K���k�ekmece', 20, 3);

INSERT INTO BulunmaBilgisiTBL (EsyaID, BulunmaTarihi, BulunduguYer, TeslimAlanID)
VALUES 
(1,'2025-05-15', N'Fatih',1),
(2,'2025-05-16', N'�sk�dar',2),
(3,'2025-05-17', N'Kad�k�y',3),
(4,'2025-05-18', N'Be�ikta�',4),
(5,'2025-05-19', N'Levent',5),
(6,'2025-05-20', N'Fatih',6),
(7,'2025-05-21', N'Bak�rk�y',7),
(8,'2025-05-22', N'Ba�c�lar',8),
(9,'2025-05-23', N'Levent',9),
(10,'2025-05-24', N'Fatih',10),
(11,'2025-05-25', N'Sar�yer',11),
(12,'2025-05-26', N'Kartal',12),
(13,'2025-05-27', N'Pendik',13),
(14,'2025-05-28', N'Maltepe',14),
(15,'2025-05-29', N'�sk�dar',15),
(16,'2025-05-30', N'Kad�k�y',16),
(17,'2025-05-31', N'Beyo�lu',17),
(18,'2025-06-01', N'Levent',18),
(19,'2025-06-02', N'Beyo�lu',19),
(20,'2025-06-03', N'Kartal',20);

UPDATE KullaniciTBL SET Telefon='05551234567' WHERE KullaniciID=14
UPDATE EsyaTBL SET EsyaAdi=N'Kaban',KayipYeri=N'Bebek' WHERE EsyaID=8
UPDATE BulunmaBilgisiTBL SET BulunmaTarihi='2025-05-30'WHERE BulunmaID=18

INSERT INTO KullaniciTBL (Ad, Soyad, Telefon, Email)
VALUES (N'Naz�m', N'��rak', '0506467123', 'nazim.cirak@gmail.com')

INSERT INTO EsyaTBL (EsyaAdi, KayipTarihi, KayipYeri, KullaniciID)
VALUES (N'Suluk', '2022-05-04', N'Ey�p',21)

INSERT INTO BulunmaBilgisiTBL (EsyaID, BulunmaTarihi, BulunduguYer, TeslimAlanID)
VALUES (21, '2022-05-06', N'Ey�p',21)


DELETE FROM BulunmaBilgisiTBL
WHERE TeslimAlanID IN (
    SELECT KullaniciID FROM KullaniciTBL WHERE LEN(Telefon) <> 11
)

DELETE FROM EsyaTBL
WHERE KullaniciID IN (
    SELECT KullaniciID FROM KullaniciTBL WHERE LEN(Telefon) <> 11
)

DELETE FROM KullaniciTBL
WHERE LEN(Telefon) <> 11

SELECT * FROM KullaniciTBL
SELECT * FROM EsyaTBL
SELECT * FROM BulunmaBilgisiTBL

