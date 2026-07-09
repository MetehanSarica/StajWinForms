SET NOCOUNT ON;

-- ============================================================
-- Musteri tablosuna Cinsiyet sütunu ekleme
-- 'E' = Erkek, 'K' = Kadın
-- ============================================================
IF NOT EXISTS (
    SELECT 1 FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_NAME = 'Musteri' AND COLUMN_NAME = 'Cinsiyet'
)
BEGIN
    ALTER TABLE Musteri
        ADD Cinsiyet CHAR(1) NULL
        CONSTRAINT CK_Musteri_Cinsiyet CHECK (Cinsiyet IN ('E', 'K'));
END
GO

-- ============================================================
-- TC 30000000001-030: İlk 30 müşteri (dbStaj_seed.sql)
-- ============================================================
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000001'; -- Ali
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000002'; -- Fatma
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000003'; -- Mustafa
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000004'; -- Emine
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000005'; -- İbrahim
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000006'; -- Hatice
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000007'; -- Hüseyin
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000008'; -- Ayşegül
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000009'; -- Mehmet
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000010'; -- Zeynep
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000011'; -- Ömer
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000012'; -- Merve
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000013'; -- Cem
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000014'; -- Selma
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000015'; -- Tolga
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000016'; -- Derya
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000017'; -- Serkan
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000018'; -- Burcu
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000019'; -- Emre
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000020'; -- Gizem
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000021'; -- Barış
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000022'; -- Elif
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000023'; -- Koray
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000024'; -- Pınar
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000025'; -- Mert
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000026'; -- Simge
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000027'; -- Okan
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000028'; -- Esra
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000029'; -- Kaan
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '30000000030'; -- Neslihan

-- ============================================================
-- TC 40000000001-050: İkinci 50 müşteri (dbStaj_seed2.sql)
-- ============================================================
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000001'; -- Canan
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000002'; -- Furkan
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000003'; -- Hande
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000004'; -- İlker
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000005'; -- Jale
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000006'; -- Kerem
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000007'; -- Leyla
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000008'; -- Musa
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000009'; -- Nazan
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000010'; -- Onur
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000011'; -- Pelin
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000012'; -- Recep
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000013'; -- Seda
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000014'; -- Taner
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000015'; -- Ufuk
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000016'; -- Vildan
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000017'; -- Yasin
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000018'; -- Zehra
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000019'; -- Ahmet
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000020'; -- Beyza
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000021'; -- Can
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000022'; -- Deniz
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000023'; -- Ebru
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000024'; -- Faruk
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000025'; -- Gülşen
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000026'; -- Hakan
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000027'; -- İrem
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000028'; -- Kağan
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000029'; -- Lale
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000030'; -- Mert
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000031'; -- Nur
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000032'; -- Oğuz
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000033'; -- Pınar
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000034'; -- Rüya
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000035'; -- Serhat
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000036'; -- Tuba
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000037'; -- Uğur
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000038'; -- Vesile
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000039'; -- Yağmur
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000040'; -- Zeki
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000041'; -- Alp
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000042'; -- Bahar
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000043'; -- Cengiz
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000044'; -- Didem
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000045'; -- Emre
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000046'; -- Figen
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000047'; -- Gökhan
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000048'; -- Hilal
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '40000000049'; -- İsmet
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '40000000050'; -- Jülide

-- ============================================================
-- Rastgele / isim bilinmeyen TC'ler
-- Biletler tablosunda referans edilen ama seed dosyalarında
-- adı geçmeyen kayıtlar için keyfi atama yapıldı.
-- ============================================================
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '58241739616'; -- Ayşe Yılmaz → Kadın
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '10293847561'; -- isim bilinmiyor → Erkek
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '13421432142'; -- isim bilinmiyor → Kadın
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '98473250925'; -- isim bilinmiyor → Erkek
UPDATE Musteri SET Cinsiyet = 'K' WHERE TC = '42352435245'; -- isim bilinmiyor → Kadın
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '12345678901'; -- test verisi → Erkek
UPDATE Musteri SET Cinsiyet = 'E' WHERE TC = '30000000034'; -- isim bilinmiyor → Erkek

-- NULL kalan varsa (beklenmedik kayıt) varsayılan olarak 'E' ata
UPDATE Musteri SET Cinsiyet = 'E' WHERE Cinsiyet IS NULL;

-- Sonucu kontrol et
SELECT TC, Ad, Soyad, Cinsiyet
FROM   Musteri
ORDER  BY TC;
