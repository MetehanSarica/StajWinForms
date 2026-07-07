-- ============================================================
-- Segment bazlı koltuk müsaitliği için yeni tablolar
-- ============================================================

-- Seferin uğradığı her durak, sıralı
CREATE TABLE SeferDuraklar (
    SeferID     INT  NOT NULL,
    DurakSira   INT  NOT NULL,   -- 1 = kalkış, son = varış
    SehirID     INT  NOT NULL,
    GelisSaati  DATETIME NOT NULL,
    PRIMARY KEY (SeferID, DurakSira),
    FOREIGN KEY (SeferID) REFERENCES Seferler(SeferID),
    FOREIGN KEY (SehirID) REFERENCES Sehirler(SehirID)
);

-- Satılan her bilet; yolcunun hangi duraktan binip nerede ineceği
CREATE TABLE Biletler (
    BiletID         INT IDENTITY(1,1) PRIMARY KEY,
    SeferID         INT     NOT NULL,
    KoltukNo        INT     NOT NULL,
    MusteriTC       CHAR(11) NOT NULL,
    BinisDurakSira  INT     NOT NULL,
    InisDurakSira   INT     NOT NULL,
    CONSTRAINT FK_Bilet_Sefer    FOREIGN KEY (SeferID)    REFERENCES Seferler(SeferID),
    CONSTRAINT FK_Bilet_Musteri  FOREIGN KEY (MusteriTC)  REFERENCES Musteri(TC)
);

-- ============================================================
-- Örnek veri (Sefer 1: Ankara → Eskişehir → İzmir)
-- ============================================================
INSERT INTO SeferDuraklar VALUES (1, 1, (SELECT SehirID FROM Sehirler WHERE SehirAdi='Ankara'),    '2025-08-01 08:00');
INSERT INTO SeferDuraklar VALUES (1, 2, (SELECT SehirID FROM Sehirler WHERE SehirAdi='Eskişehir'), '2025-08-01 10:30');
INSERT INTO SeferDuraklar VALUES (1, 3, (SELECT SehirID FROM Sehirler WHERE SehirAdi='İzmir'),     '2025-08-01 15:00');

-- Koltuk 5: Ankara → Eskişehir arası dolu
INSERT INTO Biletler (SeferID, KoltukNo, MusteriTC, BinisDurakSira, InisDurakSira)
VALUES (1, 5, '12345678901', 1, 2);

-- ============================================================
-- KOLTUK MÜSAİTLİK SORGUSU
-- Yolcu @BinisSira'dan @InisSira'ya gitmek istiyor.
-- Çakışan = mevcut yolcu daha önce bindi VE daha sonra inecek.
-- Aşağıdaki sorgu DOLU koltukları döndürür.
-- ============================================================
--
-- DECLARE @SeferID   INT = 1;
-- DECLARE @BinisSira INT = 2;   -- Eskişehir'den binecek
-- DECLARE @InisSira  INT = 3;   -- İzmir'de inecek
--
-- SELECT KoltukNo
-- FROM Biletler
-- WHERE SeferID        = @SeferID
--   AND BinisDurakSira < @InisSira    -- mevcut yolcu istediğimiz varıştan önce bindi
--   AND InisDurakSira  > @BinisSira;  -- mevcut yolcu istediğimiz kalkıştan sonra inecek
--
-- Sonuç boş → koltuk 5 Eskişehir-İzmir segmentinde MÜSAİT
-- (Ankara-Eskişehir arası doluydu ama o segment bitti)
