-- Admin Paneli Tabloları
-- Çalıştırmadan önce USE dbStaj; yapıldığından emin olun

USE dbStaj;
GO

-- 1. Kullanicilar
CREATE TABLE Kullanicilar (
    KullaniciID    INT IDENTITY(1,1) PRIMARY KEY,
    KullaniciAdi   NVARCHAR(50)  NOT NULL,
    SifreMd5       CHAR(32)      NOT NULL,
    AdSoyad        NVARCHAR(100) NULL,
    Aktif          BIT           NOT NULL DEFAULT 1,
    OlusturmaTarihi DATETIME     NOT NULL DEFAULT GETDATE(),
    CONSTRAINT UQ_Kullanicilar_KullaniciAdi UNIQUE (KullaniciAdi)
);
GO

-- 2. Yetkiler
CREATE TABLE Yetkiler (
    YetkiID    INT IDENTITY(1,1) PRIMARY KEY,
    YetkiKodu  NVARCHAR(50)  NOT NULL,
    YetkiAdi   NVARCHAR(100) NOT NULL,
    CONSTRAINT UQ_Yetkiler_YetkiKodu UNIQUE (YetkiKodu)
);
GO

-- 3. KullaniciYetkileri
CREATE TABLE KullaniciYetkileri (
    ID          INT IDENTITY(1,1) PRIMARY KEY,
    KullaniciID INT NOT NULL,
    YetkiID     INT NOT NULL,
    CONSTRAINT FK_KullaniciYetkileri_Kullanici FOREIGN KEY (KullaniciID) REFERENCES Kullanicilar(KullaniciID) ON DELETE CASCADE,
    CONSTRAINT FK_KullaniciYetkileri_Yetki     FOREIGN KEY (YetkiID)     REFERENCES Yetkiler(YetkiID)         ON DELETE CASCADE,
    CONSTRAINT UQ_KullaniciYetkileri           UNIQUE (KullaniciID, YetkiID)
);
GO

-- 4. Otobusler
CREATE TABLE Otobusler (
    OtobusID        INT IDENTITY(1,1) PRIMARY KEY,
    Plaka           NVARCHAR(15)  NOT NULL,
    Marka           NVARCHAR(50)  NULL,
    Model           NVARCHAR(50)  NULL,
    KoltukKapasitesi INT          NOT NULL DEFAULT 36,
    FirmaID         INT           NULL,
    CONSTRAINT UQ_Otobusler_Plaka   UNIQUE (Plaka),
    CONSTRAINT FK_Otobusler_Firmalar FOREIGN KEY (FirmaID) REFERENCES Firmalar(FirmaID) ON DELETE SET NULL
);
GO

-- 5. OtobusKaptan
CREATE TABLE OtobusKaptan (
    ID         INT IDENTITY(1,1) PRIMARY KEY,
    OtobusID   INT NOT NULL,
    PersonelID INT NOT NULL,
    CONSTRAINT FK_OtobusKaptan_Otobus   FOREIGN KEY (OtobusID)   REFERENCES Otobusler(OtobusID) ON DELETE CASCADE,
    CONSTRAINT FK_OtobusKaptan_Personel FOREIGN KEY (PersonelID) REFERENCES Personel(Id),
    CONSTRAINT UQ_OtobusKaptan          UNIQUE (OtobusID, PersonelID)
);
GO

-- Seed: Yetkiler
INSERT INTO Yetkiler (YetkiKodu, YetkiAdi) VALUES
('FIRMA',       'Firma Yönetimi'),
('OTOBUS',      'Otobüs Yönetimi'),
('FIRMA_OTOBUS','Firma-Otobüs Eşleme'),
('KAPTAN',      'Kaptan Yönetimi'),
('KULLANICI',   'Kullanıcı Yönetimi'),
('YETKI',       'Yetki Yönetimi');
GO

-- Seed: admin kullanıcısı (şifre: Admin123 → MD5: e64b78fc3bc91bcbc7dc232ba8ec59e0)
INSERT INTO Kullanicilar (KullaniciAdi, SifreMd5, AdSoyad, Aktif)
VALUES ('admin', 'e64b78fc3bc91bcbc7dc232ba8ec59e0', 'Sistem Yöneticisi', 1);
GO

-- Seed: admin kullanıcısına tüm yetkiler
INSERT INTO KullaniciYetkileri (KullaniciID, YetkiID)
SELECT 1, YetkiID FROM Yetkiler;
GO
