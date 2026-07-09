SET NOCOUNT ON;

-- ============================================================
-- Biletler tablosuna Cinsiyet sütunu ekleme
-- 'E' = Erkek, 'K' = Kadın
-- NOT: Bu script dbStaj_cinsiyet.sql çalıştırıldıktan sonra
--      çalıştırılmalıdır (Musteri.Cinsiyet dolu olmalı).
-- ============================================================
IF NOT EXISTS (
    SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'Biletler' AND COLUMN_NAME = 'Cinsiyet'
)
BEGIN
    ALTER TABLE Biletler
        ADD Cinsiyet CHAR(1) NULL
        CONSTRAINT CK_Biletler_Cinsiyet CHECK (Cinsiyet IN ('E', 'K'));
END
GO

-- ============================================================
-- Cinsiyet değerlerini Musteri tablosundan doldur
-- ============================================================
UPDATE B
SET    B.Cinsiyet = M.Cinsiyet
FROM   Biletler B
INNER  JOIN Musteri M ON B.MusteriTc = M.TC;

-- Sonucu kontrol et
SELECT B.BiletID, B.SeferId, B.KoltukNo, B.MusteriTc,
       M.Ad, M.Soyad, B.Cinsiyet
FROM   Biletler B
JOIN   Musteri M ON B.MusteriTc = M.TC
ORDER  BY B.BiletID;
