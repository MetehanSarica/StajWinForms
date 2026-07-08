SET NOCOUNT ON;

-- ============================================================
-- SEHIRLER: 20 new cities (IDs 11-30)
-- ============================================================
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Kocaeli', 41);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Kayseri', 38);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Samsun', 55);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Mersin', 33);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Diyarbakİr', 21);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Denizli', 20);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Malatya', 44);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Sakarya', 54);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Balİkesir', 10);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Manisa', 45);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'MuĞla', 48);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'TekirdaĞ', 59);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Erzurum', 25);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Edirne', 22);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Sivas', 58);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Hatay', 31);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'KahramanmaraŞ', 46);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Van', 65);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'Ordu', 52);
INSERT INTO Sehirler (SehirAdi, PlakaKodu) VALUES (N'NevŞehir', 50);

-- ============================================================
-- FIRMALAR: 10 new companies (IDs 9-18)
-- ============================================================
INSERT INTO Firmalar (FirmaAdi) VALUES (N'Varan Turizm');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'Öz Diyarbakİr Turizm');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'LÜks Karadeniz');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'Has Turizm');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'Akyol Turizm');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'Kontur Turizm');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'DoĞu Koop');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'Sivas Seyahat');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'İstanbul Seyahat');
INSERT INTO Firmalar (FirmaAdi) VALUES (N'Ege Turizm');

-- ============================================================
-- MUSTERI: 50 new customers (TCs 40000000001-40000000050)
-- ============================================================
INSERT INTO Musteri (TC, Ad, Soyad, Email, Telefon, Adres, Sehir) VALUES
('40000000001', N'Ahmet',    N'Yİlmaz',    'ahmet.yilmaz1@mail.com',    '05350000001', N'BeŞiktaŞ Mh. No:1',   N'İstanbul') ('40000000002', N'Mehmet',   N'Kaya',      'mehmet.kaya2@mail.com',     '05350000002', N'KeÇiÖren Mh. No:2',  N'Ankara') ('40000000003', N'Mustafa',  N'Demir',     'mustafa.demir3@mail.com',   '05350000003', N'KarŞİyaka Mh. No:3',  N'İzmir') ('40000000004', N'Ali',      N'Çelik',     'ali.celik4@mail.com',       '05350000004', N'Osmangazi Mh. No:4', N'Bursa') ('40000000005', N'Hasan',    N'Şahin',     'hasan.sahin5@mail.com',     '05350000005', N'Kepez Mh. No:5',    N'Antalya') ('40000000006', N'HÜseyin',  N'DoĞan',     'huseyin.dogan6@mail.com',   '05350000006', N'Seyhan Mh. No:6',   N'Adana') ('40000000007', N'İbrahim',  N'KİlİÇ',     'ibrahim.kilic7@mail.com',   '05350000007', N'Meram Mh. No:7',    N'Konya') ('40000000008', N'Ömer',     N'Arslan',    'omer.arslan8@mail.com',     '05350000008', N'Şahinbey Mh. No:8', N'Gaziantep') ('40000000009', N'Yusuf',    N'ÖztÜrk',   'yusuf.ozturk9@mail.com',    '05350000009', N'Ortahisar Mh. No:9', N'Trabzon') ('40000000010', N'Halil',    N'Aydİn',    'halil.aydin10@mail.com',    '05350000010', N'Odunpazarİ Mh. No:10', N'EskiŞehir') ('40000000011', N'Fatma',    N'Özdemir',  'fatma.ozdemir11@mail.com',  '05360000011', N'Sarİyer Mh. No:11',  N'İstanbul') ('40000000012', N'AyŞe',    N'GÜneŞ',     'ayse.gunes12@mail.com',     '05360000012', N'Çankaya Mh. No:12', N'Ankara') ('40000000013', N'Emine',    N'Çetin',    'emine.cetin13@mail.com',    '05360000013', N'Bornova Mh. No:13',  N'İzmir') ('40000000014', N'Hatice',   N'ErdoĞan',  'hatice.erdogan14@mail.com', '05360000014', N'NilÜfer Mh. No:14', N'Bursa') ('40000000015', N'Zeynep',   N'Yİlmaz',   'zeynep.yilmaz15@mail.com',  '05360000015', N'Alanya Mh. No:15',  N'Antalya') ('40000000016', N'Meryem',   N'Kaya',      'meryem.kaya16@mail.com',    '05360000016', N'Çukurova Mh. No:16', N'Adana') ('40000000017', N'Elif',     N'Demir',     'elif.demir17@mail.com',     '05360000017', N'SelÇuklu Mh. No:17', N'Konya') ('40000000018', N'ŞÜkran',   N'Çelik',    'sÜkran.celik18@mail.com',   '05360000018', N'Nizip Mh. No:18',   N'Gaziantep') ('40000000019', N'GÜneŞ',    N'Şahin',    'gunes.sahin19@mail.com',    '05360000019', N'AkcŞaabat Mh. No:19', N'Trabzon') ('40000000020', N'Pİnar',    N'DoĞan',     'pinar.dogan20@mail.com',    '05360000020', N'TepebaŞİ Mh. No:20', N'EskiŞehir') ('40000000021', N'Ahmet',    N'Arslan',    'ahmet.arslan21@mail.com',   '05370000021', N'KadİkÖy Mh. No:21',  N'İstanbul') ('40000000022', N'Mehmet',   N'Aydİn',   'mehmet.aydin22@mail.com',   '05370000022', N'Etimesgut Mh. No:22', N'Ankara') ('40000000023', N'Mustafa',  N'ÖztÜrk',   'mustafa.ozturk23@mail.com', '05370000023', N'Konak Mh. No:23',    N'İzmir') ('40000000024', N'Ali',      N'GÜneŞ',     'ali.gunes24@mail.com',      '05370000024', N'GÖrÜkle Mh. No:24',   N'Bursa') ('40000000025', N'Hasan',    N'Çetin',    'hasan.cetin25@mail.com',    '05370000025', N'MuratpaŞa Mh. No:25', N'Antalya') ('40000000026', N'HÜseyin',  N'ErdoĞan',  'huseyin.erdogan26@mail.com','05370000026', N'YÜreĞir Mh. No:26', N'Adana') ('40000000027', N'İbrahim',  N'Yİlmaz',   'ibrahim.yilmaz27@mail.com', '05370000027', N'Karatay Mh. No:27',  N'Konya') ('40000000028', N'Ömer',     N'Kaya',      'omer.kaya28@mail.com',      '05370000028', N'OĞuzeli Mh. No:28',  N'Gaziantep') ('40000000029', N'Yusuf',    N'Demir',     'yusuf.demir29@mail.com',    '05370000029', N'Araklİ Mh. No:29',    N'Trabzon') ('40000000030', N'Halil',    N'Çelik',    'halil.celik30@mail.com',    '05370000030', N'Porsuk Mh. No:30',   N'EskiŞehir') ('40000000031', N'Fatma',    N'KİlİÇ',     'fatma.kilic31@mail.com',    '05380000031', N'Izmit Mh. No:31',    N'Kocaeli') ('40000000032', N'AyŞe',    N'Şahin',     'ayse.sahin32@mail.com',     '05380000032', N'Melikgazi Mh. No:32', N'Kayseri') ('40000000033', N'Emine',    N'Arslan',    'emine.arslan33@mail.com',   '05380000033', N'Atakum Mh. No:33',   N'Samsun') ('40000000034', N'Hatice',   N'Aydİn',   'hatice.aydin34@mail.com',   '05380000034', N'Akdeniz Mh. No:34',  N'Mersin') ('40000000035', N'Zeynep',   N'Özdemir',  'zeynep.ozdemir35@mail.com', '05380000035', N'BaĞlar Mh. No:35',   N'Diyarbakİr') ('40000000036', N'Meryem',   N'GÜneŞ',    'meryem.gunes36@mail.com',   '05380000036', N'Pamukkale Mh. No:36', N'Denizli') ('40000000037', N'Elif',     N'ErdoĞan',  'elif.erdogan37@mail.com',   '05380000037', N'Battalgazi Mh. No:37', N'Malatya') ('40000000038', N'ŞÜkran',   N'Yİlmaz',   'sÜkran.yilmaz38@mail.com',  '05380000038', N'Adapazarİ Mh. No:38', N'Sakarya') ('40000000039', N'GÜneŞ',    N'Kaya',      'gunes.kaya39@mail.com',     '05380000039', N'Bandirma Mh. No:39',  N'Balİkesir') ('40000000040', N'Pİnar',    N'Demir',     'pinar.demir40@mail.com',    '05380000040', N'Yunusemre Mh. No:40', N'Manisa') ('40000000041', N'Ahmet',    N'Çelik',    'ahmet.celik41@mail.com',    '05390000041', N'Bodrum Mh. No:41',   N'MuĞla') ('40000000042', N'Mehmet',   N'Şahin',    'mehmet.sahin42@mail.com',   '05390000042', N'Çorlu Mh. No:42',     N'TekirdaĞ') ('40000000043', N'Mustafa',  N'DoĞan',    'mustafa.dogan43@mail.com',  '05390000043', N'Aziziye Mh. No:43',  N'Erzurum') ('40000000044', N'Ali',      N'Arslan',    'ali.arslan44@mail.com',     '05390000044', N'Merkez Mh. No:44',   N'Edirne') ('40000000045', N'Hasan',    N'Aydİn',   'hasan.aydin45@mail.com',    '05390000045', N'Kİzİlirmak Mh. No:45', N'Sivas') ('40000000046', N'HÜseyin',  N'ÖztÜrk',   'huseyin.ozturk46@mail.com', '05390000046', N'Antakya Mh. No:46',  N'Hatay') ('40000000047', N'İbrahim',  N'GÜneŞ',    'ibrahim.gunes47@mail.com',  '05390000047', N'DulkadiroĞlu Mh. No:47', N'KahramanmaraŞ') ('40000000048', N'Ömer',     N'Çetin',    'omer.cetin48@mail.com',     '05390000048', N'Tusba Mh. No:48',    N'Van') ('40000000049', N'Yusuf',    N'ErdoĞan',  'yusuf.erdogan49@mail.com',  '05390000049', N'Altİnordu Mh. No:49', N'Ordu') ('40000000050', N'Halil',    N'KİlİÇ',     'halil.kilic50@mail.com',    '05390000050', N'Merkez Mh. No:50',   N'NevŞehir');

-- ============================================================
-- PERSONEL: 20 new staff (IDs 16-35)
-- ============================================================
INSERT INTO Personel (Ad, Soyad, Email, Maas, IseGirisTarihi) VALUES
(N'Ahmet',     N'Yİlmaz',   'ahmet.yilmaz@dbstaj.com',   9500.00, '2020-03-12') (N'Fatma',     N'Kaya',     'fatma.kaya@dbstaj.com',     8200.00, '2021-06-20') (N'Mustafa',   N'Demir',    'mustafa.demir@dbstaj.com',  7800.00, '2022-01-15') (N'AyŞe',     N'Çelik',    'ayse.celik@dbstaj.com',     8800.00, '2019-09-05') (N'Hasan',     N'Şahin',    'hasan.sahin@dbstaj.com',    7200.00, '2023-04-01') (N'HÜseyin',   N'DoĞan',    'huseyin.dogan@dbstaj.com',  9000.00, '2020-11-18') (N'İbrahim',  N'Arslan',   'ibrahim.arslan@dbstaj.com',10500.00, '2018-07-22') (N'Ömer',     N'Aydİn',   'omer.aydin@dbstaj.com',    11000.00, '2019-02-14') (N'Yusuf',     N'ÖztÜrk',  'yusuf.ozturk@dbstaj.com',  7500.00, '2022-08-30') (N'Halil',     N'Özdemir',  'halil.ozdemir@dbstaj.com',  8500.00, '2021-05-10') (N'Zeynep',    N'GÜneŞ',   'zeynep.gunes2@dbstaj.com',  6800.00, '2023-09-01') (N'Meryem',    N'Çetin',   'meryem.cetin@dbstaj.com',   7000.00, '2022-12-05') (N'Elif',      N'ErdoĞan',  'elif.erdogan@dbstaj.com',  12000.00, '2018-03-20') (N'ŞÜkran',    N'Yİlmaz',  'sÜkran.yilmaz@dbstaj.com',  6500.00, '2024-01-10') (N'GÜneŞ',      N'Kaya',     'gunes.kaya@dbstaj.com',     7200.00, '2023-06-15') (N'Pİnar',      N'Demir',    'pinar.demir@dbstaj.com',    8000.00, '2021-10-28') (N'Selin',     N'Çelik',    'selin.celik@dbstaj.com',    9200.00, '2020-07-03') (N'Burak',     N'Şahin',    'burak.sahin@dbstaj.com',    8700.00, '2019-12-17') (N'Nihan',     N'Arslan',   'nihan.arslan@dbstaj.com',  14000.00, '2018-05-09') (N'Tarİk',     N'Aydİn',   'tarik.aydin@dbstaj.com',   15000.00, '2018-01-22');

-- ============================================================
-- OTOGARLAR: 25 new terminals (IDs 20-44)
-- SehirIDs 11-30 + 2 extra for Istanbul and Ankara
-- ============================================================
INSERT INTO Otogarlar (SehirID, OtogarAdi, Adres, Telefon) VALUES
(11, N'Izmit Otogarİ',          N'Izmit Merkez, Kocaeli',                '02623600100') (11, N'Gebze Otogarİ',          N'Gebze İlÇesi, Kocaeli',              '02623550200') (12, N'Kayseri Otogarİ',        N'Kocasinan Mh., Kayseri',               '03522310100') (13, N'Samsun Otogarİ',         N'Canik Mh., Samsun',                    '03622315000') (14, N'Mersin Otogarİ',         N'Toroslar Mh., Mersin',                 '03243374000') (15, N'Diyarbakİr Otogarİ',   N'Bağlar İlÇesi, Diyarbakİr',    '04122282000') (16, N'Denizli Otogarİ',        N'Pamukkale Mh., Denizli',               '02582621200') (17, N'Malatya Otogarİ',        N'Battalgazi Mh., Malatya',              '04222121800') (18, N'Sakarya Otogarİ',        N'Adapazarİ Mh., Sakarya',            '02642780000') (19, N'Balİkesir Otogarİ',    N'Merkez Mh., Balİkesir',              '02662430000') (20, N'Manisa Otogarİ',         N'Yunusemre Mh., Manisa',                '02362310000') (20, N'Turgutlu Otogarİ',       N'Turgutlu İlÇesi, Manisa',           '02364510200') (21, N'Muğla Otogarİ',         N'Merkez Mh., Muğla',                  '02522141800') (22, N'Tekirdağ Otogarİ',      N'SÜleymanpaŞa Mh., Tekirdağ',       '02822600100') (23, N'Erzurum Otogarİ',        N'Aziziye Mh., Erzurum',                 '04422325000') (24, N'Edirne Otogarİ',         N'Merkez Mh., Edirne',                   '02842210000') (25, N'Sivas Otogarİ',          N'Kİzİlirmak Mh., Sivas',            '03462211500') (26, N'Hatay Otogarİ',          N'Antakya Mh., Hatay',                   '03262140000') (27, N'KahramanmaraŞ Otogarİ', N'Dulkadiroğlu Mh., KahramanmaraŞ', '03442217000') (28, N'Van Otogarİ',            N'TuŞba Mh., Van',                     '04322121000') (29, N'Ordu Otogarİ',           N'Altİnordu Mh., Ordu',               '04522231000') (30, N'NevŞehir Otogarİ',     N'Merkez Mh., NevŞehir',               '03842131500') (30, N'Avanos Otogarİ',         N'Avanos İlÇesi, NevŞehir',          '03842381200') (1,  N'BÜyÜkÇekmece Otogarİ', N'Kavalİ Mh., BÜyÜkÇekmece/İstanbul', '02128592410') (2,  N'Mamak Otogarİ',          N'Mamak İlÇesi, Ankara',             '03124501100');

-- ============================================================
-- SEFERLER: 60 new journeys (IDs 31-90)
-- ============================================================
INSERT INTO Seferler (FirmaID, KalkisSehirID, VarisSehirID, KalkisZamani, KoltukKapasitesi, BosKoltuk, SureDakika, Fiyat) VALUES
(1,  1,  11, '2026-07-15 08:00:00', 45, 38, 90,  150.00),
(2,  1,  18, '2026-07-15 09:00:00', 45, 36, 120, 180.00),
(3,  1,  22, '2026-07-15 10:00:00', 45, 37, 120, 160.00),
(4,  1,  24, '2026-07-15 11:00:00', 45, 35, 180, 220.00),
(5,  2,  12, '2026-07-15 08:00:00', 45, 34, 210, 350.00),
(6,  2,  25, '2026-07-15 09:00:00', 45, 33, 300, 420.00),
(7,  2,  30, '2026-07-15 10:00:00', 45, 36, 180, 320.00),
(8,  2,  17, '2026-07-15 20:00:00', 45, 32, 480, 580.00),
(1,  3,  16, '2026-07-15 08:00:00', 45, 35, 180, 280.00),
(2,  3,  20, '2026-07-15 09:00:00', 45, 38, 60,  120.00),
(3,  3,  21, '2026-07-15 10:00:00', 45, 36, 210, 300.00),
(4,  3,  19, '2026-07-15 11:00:00', 45, 34, 180, 260.00),
(5,  5,  16, '2026-07-15 08:00:00', 45, 33, 210, 320.00),
(6,  5,  21, '2026-07-15 09:00:00', 45, 35, 210, 300.00),
(7,  6,  14, '2026-07-15 08:00:00', 45, 38, 75,  120.00),
(8,  6,  26, '2026-07-15 09:00:00', 45, 37, 90,  160.00),
(1,  6,  27, '2026-07-15 10:00:00', 45, 36, 150, 220.00),
(2,  6,  15, '2026-07-15 20:00:00', 45, 31, 360, 520.00),
(3,  8,  15, '2026-07-15 08:00:00', 45, 34, 210, 330.00),
(4,  8,  17, '2026-07-15 09:00:00', 45, 35, 180, 280.00),
(5,  9,  13, '2026-07-15 08:00:00', 45, 33, 210, 320.00),
(6,  9,  29, '2026-07-15 09:00:00', 45, 37, 90,  160.00),
(7,  9,  23, '2026-07-15 10:00:00', 45, 34, 240, 370.00),
(8,  12, 25, '2026-07-16 08:00:00', 45, 35, 180, 290.00),
(1,  12, 17, '2026-07-16 09:00:00', 45, 33, 240, 380.00),
(2,  12, 30, '2026-07-16 10:00:00', 45, 38, 90,  160.00),
(3,  13, 2,  '2026-07-16 20:00:00', 45, 30, 480, 600.00),
(4,  13, 9,  '2026-07-16 08:00:00', 45, 34, 210, 320.00),
(5,  13, 29, '2026-07-16 09:00:00', 45, 37, 75,  130.00),
(6,  14, 5,  '2026-07-16 08:00:00', 45, 33, 300, 420.00),
(7,  14, 6,  '2026-07-16 09:00:00', 45, 38, 75,  120.00),
(8,  14, 8,  '2026-07-16 20:00:00', 45, 32, 240, 380.00),
(1,  15, 2,  '2026-07-16 19:00:00', 45, 30, 720, 880.00),
(2,  15, 1,  '2026-07-16 18:00:00', 45, 30, 900, 1050.00),
(3,  15, 28, '2026-07-16 08:00:00', 45, 34, 240, 380.00),
(4,  16, 1,  '2026-07-16 20:00:00', 45, 31, 420, 580.00),
(5,  16, 2,  '2026-07-16 21:00:00', 45, 33, 360, 520.00),
(6,  16, 21, '2026-07-16 10:00:00', 45, 36, 150, 240.00),
(7,  17, 2,  '2026-07-16 20:00:00', 45, 31, 480, 620.00),
(8,  17, 1,  '2026-07-16 19:00:00', 45, 30, 660, 820.00),
(9,  17, 25, '2026-07-17 08:00:00', 45, 35, 180, 290.00),
(10, 24, 1,  '2026-07-17 08:00:00', 45, 36, 180, 230.00),
(11, 24, 22, '2026-07-17 09:00:00', 45, 38, 90,  160.00),
(12, 19, 1,  '2026-07-17 08:00:00', 45, 34, 210, 300.00),
(13, 19, 4,  '2026-07-17 09:00:00', 45, 37, 90,  160.00),
(14, 20, 3,  '2026-07-17 08:00:00', 45, 38, 60,  120.00),
(15, 20, 4,  '2026-07-17 09:00:00', 45, 35, 240, 360.00),
(16, 21, 5,  '2026-07-17 08:00:00', 45, 34, 210, 300.00),
(17, 21, 3,  '2026-07-17 09:00:00', 45, 35, 210, 300.00),
(18, 25, 2,  '2026-07-17 20:00:00', 45, 32, 270, 400.00),
(1,  25, 12, '2026-07-17 08:00:00', 45, 35, 180, 290.00),
(2,  26, 6,  '2026-07-17 08:00:00', 45, 37, 90,  160.00),
(3,  26, 8,  '2026-07-17 09:00:00', 45, 36, 180, 270.00),
(4,  27, 6,  '2026-07-17 08:00:00', 45, 37, 120, 200.00),
(5,  27, 8,  '2026-07-17 09:00:00', 45, 38, 90,  160.00),
(6,  28, 2,  '2026-07-17 17:00:00', 45, 30, 780, 980.00),
(7,  28, 15, '2026-07-17 08:00:00', 45, 33, 240, 380.00),
(8,  29, 13, '2026-07-17 08:00:00', 45, 37, 75,  130.00),
(9,  29, 9,  '2026-07-17 09:00:00', 45, 36, 90,  160.00),
(10, 30, 2,  '2026-07-17 20:00:00', 45, 34, 180, 320.00);

-- ============================================================
-- SEFERDURAKLAR: stops for seferler 31-90
-- ============================================================
INSERT INTO SeferDuraklar VALUES (31, 1, 1, '2026-07-15 08:00:00');
INSERT INTO SeferDuraklar VALUES (31, 2, 11,   '2026-07-15 09:30:00');
INSERT INTO SeferDuraklar VALUES (32, 1, 1, '2026-07-15 09:00:00');
INSERT INTO SeferDuraklar VALUES (32, 2, 18,   '2026-07-15 11:00:00');
INSERT INTO SeferDuraklar VALUES (33, 1, 1, '2026-07-15 10:00:00');
INSERT INTO SeferDuraklar VALUES (33, 2, 22,   '2026-07-15 12:00:00');
INSERT INTO SeferDuraklar VALUES (34, 1, 1, '2026-07-15 11:00:00');
INSERT INTO SeferDuraklar VALUES (34, 2, 24,   '2026-07-15 14:00:00');
INSERT INTO SeferDuraklar VALUES (35, 1, 2, '2026-07-15 08:00:00');
INSERT INTO SeferDuraklar VALUES (35, 2, 12,   '2026-07-15 11:30:00');
INSERT INTO SeferDuraklar VALUES (37, 1, 2, '2026-07-15 10:00:00');
INSERT INTO SeferDuraklar VALUES (37, 2, 30,   '2026-07-15 13:00:00');
INSERT INTO SeferDuraklar VALUES (39, 1, 3, '2026-07-15 08:00:00');
INSERT INTO SeferDuraklar VALUES (39, 2, 16,   '2026-07-15 11:00:00');
INSERT INTO SeferDuraklar VALUES (40, 1, 3, '2026-07-15 09:00:00');
INSERT INTO SeferDuraklar VALUES (40, 2, 20,   '2026-07-15 10:00:00');
INSERT INTO SeferDuraklar VALUES (41, 1, 3, '2026-07-15 10:00:00');
INSERT INTO SeferDuraklar VALUES (41, 2, 21,   '2026-07-15 13:30:00');
INSERT INTO SeferDuraklar VALUES (42, 1, 3, '2026-07-15 11:00:00');
INSERT INTO SeferDuraklar VALUES (42, 2, 19,   '2026-07-15 14:00:00');
INSERT INTO SeferDuraklar VALUES (43, 1, 5, '2026-07-15 08:00:00');
INSERT INTO SeferDuraklar VALUES (43, 2, 16,   '2026-07-15 11:30:00');
INSERT INTO SeferDuraklar VALUES (44, 1, 5, '2026-07-15 09:00:00');
INSERT INTO SeferDuraklar VALUES (44, 2, 21,   '2026-07-15 12:30:00');
INSERT INTO SeferDuraklar VALUES (45, 1, 6, '2026-07-15 08:00:00');
INSERT INTO SeferDuraklar VALUES (45, 2, 14,   '2026-07-15 09:15:00');
INSERT INTO SeferDuraklar VALUES (46, 1, 6, '2026-07-15 09:00:00');
INSERT INTO SeferDuraklar VALUES (46, 2, 26,   '2026-07-15 10:30:00');
INSERT INTO SeferDuraklar VALUES (47, 1, 6, '2026-07-15 10:00:00');
INSERT INTO SeferDuraklar VALUES (47, 2, 27,   '2026-07-15 12:30:00');
INSERT INTO SeferDuraklar VALUES (49, 1, 8, '2026-07-15 08:00:00');
INSERT INTO SeferDuraklar VALUES (49, 2, 15,   '2026-07-15 11:30:00');
INSERT INTO SeferDuraklar VALUES (50, 1, 8, '2026-07-15 09:00:00');
INSERT INTO SeferDuraklar VALUES (50, 2, 17,   '2026-07-15 12:00:00');
INSERT INTO SeferDuraklar VALUES (52, 1, 9, '2026-07-15 09:00:00');
INSERT INTO SeferDuraklar VALUES (52, 2, 29,   '2026-07-15 10:30:00');
INSERT INTO SeferDuraklar VALUES (53, 1, 9, '2026-07-15 10:00:00');
INSERT INTO SeferDuraklar VALUES (53, 2, 23,   '2026-07-15 14:00:00');
INSERT INTO SeferDuraklar VALUES (54, 1, 12, '2026-07-16 08:00:00');
INSERT INTO SeferDuraklar VALUES (54, 2, 25,   '2026-07-16 11:00:00');
INSERT INTO SeferDuraklar VALUES (55, 1, 12, '2026-07-16 09:00:00');
INSERT INTO SeferDuraklar VALUES (55, 2, 17,   '2026-07-16 13:00:00');
INSERT INTO SeferDuraklar VALUES (56, 1, 12, '2026-07-16 10:00:00');
INSERT INTO SeferDuraklar VALUES (56, 2, 30,   '2026-07-16 11:30:00');
INSERT INTO SeferDuraklar VALUES (58, 1, 13, '2026-07-16 08:00:00');
INSERT INTO SeferDuraklar VALUES (58, 2, 9,   '2026-07-16 11:30:00');
INSERT INTO SeferDuraklar VALUES (59, 1, 13, '2026-07-16 09:00:00');
INSERT INTO SeferDuraklar VALUES (59, 2, 29,   '2026-07-16 10:15:00');
INSERT INTO SeferDuraklar VALUES (60, 1, 14, '2026-07-16 08:00:00');
INSERT INTO SeferDuraklar VALUES (60, 2, 5,   '2026-07-16 13:00:00');
INSERT INTO SeferDuraklar VALUES (61, 1, 14, '2026-07-16 09:00:00');
INSERT INTO SeferDuraklar VALUES (61, 2, 6,   '2026-07-16 10:15:00');
INSERT INTO SeferDuraklar VALUES (62, 1, 14, '2026-07-16 20:00:00');
INSERT INTO SeferDuraklar VALUES (62, 2, 8,   '2026-07-17 00:00:00');
INSERT INTO SeferDuraklar VALUES (65, 1, 15, '2026-07-16 08:00:00');
INSERT INTO SeferDuraklar VALUES (65, 2, 28,   '2026-07-16 12:00:00');
INSERT INTO SeferDuraklar VALUES (67, 1, 16, '2026-07-16 21:00:00');
INSERT INTO SeferDuraklar VALUES (67, 2, 2,   '2026-07-17 03:00:00');
INSERT INTO SeferDuraklar VALUES (68, 1, 16, '2026-07-16 10:00:00');
INSERT INTO SeferDuraklar VALUES (68, 2, 21,   '2026-07-16 12:30:00');
INSERT INTO SeferDuraklar VALUES (69, 1, 17, '2026-07-16 20:00:00');
INSERT INTO SeferDuraklar VALUES (69, 2, 2,   '2026-07-17 04:00:00');
INSERT INTO SeferDuraklar VALUES (71, 1, 17, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (71, 2, 25,   '2026-07-17 11:00:00');
INSERT INTO SeferDuraklar VALUES (72, 1, 24, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (72, 2, 1,   '2026-07-17 11:00:00');
INSERT INTO SeferDuraklar VALUES (73, 1, 24, '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (73, 2, 22,   '2026-07-17 10:30:00');
INSERT INTO SeferDuraklar VALUES (74, 1, 19, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (74, 2, 1,   '2026-07-17 11:30:00');
INSERT INTO SeferDuraklar VALUES (75, 1, 19, '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (75, 2, 4,   '2026-07-17 10:30:00');
INSERT INTO SeferDuraklar VALUES (76, 1, 20, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (76, 2, 3,   '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (77, 1, 20, '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (77, 2, 4,   '2026-07-17 13:00:00');
INSERT INTO SeferDuraklar VALUES (78, 1, 21, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (78, 2, 5,   '2026-07-17 11:30:00');
INSERT INTO SeferDuraklar VALUES (79, 1, 21, '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (79, 2, 3,   '2026-07-17 12:30:00');
INSERT INTO SeferDuraklar VALUES (81, 1, 25, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (81, 2, 12,   '2026-07-17 11:00:00');
INSERT INTO SeferDuraklar VALUES (82, 1, 26, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (82, 2, 6,   '2026-07-17 09:30:00');
INSERT INTO SeferDuraklar VALUES (83, 1, 26, '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (83, 2, 8,   '2026-07-17 12:00:00');
INSERT INTO SeferDuraklar VALUES (84, 1, 27, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (84, 2, 6,   '2026-07-17 10:00:00');
INSERT INTO SeferDuraklar VALUES (85, 1, 27, '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (85, 2, 8,   '2026-07-17 10:30:00');
INSERT INTO SeferDuraklar VALUES (87, 1, 28, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (87, 2, 15,   '2026-07-17 12:00:00');
INSERT INTO SeferDuraklar VALUES (88, 1, 29, '2026-07-17 08:00:00');
INSERT INTO SeferDuraklar VALUES (88, 2, 13,   '2026-07-17 09:15:00');
INSERT INTO SeferDuraklar VALUES (89, 1, 29, '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (89, 2, 9,   '2026-07-17 10:30:00');
INSERT INTO SeferDuraklar VALUES (90, 1, 30, '2026-07-17 20:00:00');
INSERT INTO SeferDuraklar VALUES (90, 2, 2,   '2026-07-17 23:00:00');

-- Special routes with intermediate stops
INSERT INTO SeferDuraklar VALUES (36, 1, 2,  '2026-07-15 09:00:00');
INSERT INTO SeferDuraklar VALUES (36, 2, 12, '2026-07-15 11:30:00');
INSERT INTO SeferDuraklar VALUES (36, 3, 25, '2026-07-15 14:00:00');
INSERT INTO SeferDuraklar VALUES (38, 1, 2,  '2026-07-15 20:00:00');
INSERT INTO SeferDuraklar VALUES (38, 2, 12, '2026-07-15 23:30:00');
INSERT INTO SeferDuraklar VALUES (38, 3, 17, '2026-07-16 04:00:00');
INSERT INTO SeferDuraklar VALUES (48, 1, 6,  '2026-07-15 20:00:00');
INSERT INTO SeferDuraklar VALUES (48, 2, 8,  '2026-07-15 22:30:00');
INSERT INTO SeferDuraklar VALUES (48, 3, 15, '2026-07-16 02:00:00');
INSERT INTO SeferDuraklar VALUES (51, 1, 9,  '2026-07-15 08:00:00');
INSERT INTO SeferDuraklar VALUES (51, 2, 29, '2026-07-15 10:30:00');
INSERT INTO SeferDuraklar VALUES (51, 3, 13, '2026-07-15 11:30:00');
INSERT INTO SeferDuraklar VALUES (57, 1, 13, '2026-07-16 20:00:00');
INSERT INTO SeferDuraklar VALUES (57, 2, 12, '2026-07-16 23:30:00');
INSERT INTO SeferDuraklar VALUES (57, 3, 2,  '2026-07-17 04:00:00');
INSERT INTO SeferDuraklar VALUES (63, 1, 15, '2026-07-16 19:00:00');
INSERT INTO SeferDuraklar VALUES (63, 2, 17, '2026-07-16 22:00:00');
INSERT INTO SeferDuraklar VALUES (63, 3, 2,  '2026-07-17 07:00:00');
INSERT INTO SeferDuraklar VALUES (64, 1, 15, '2026-07-16 18:00:00');
INSERT INTO SeferDuraklar VALUES (64, 2, 8,  '2026-07-16 20:30:00');
INSERT INTO SeferDuraklar VALUES (64, 3, 6,  '2026-07-16 23:00:00');
INSERT INTO SeferDuraklar VALUES (64, 4, 1,  '2026-07-17 09:00:00');
INSERT INTO SeferDuraklar VALUES (66, 1, 16, '2026-07-16 20:00:00');
INSERT INTO SeferDuraklar VALUES (66, 2, 7,  '2026-07-16 23:00:00');
INSERT INTO SeferDuraklar VALUES (66, 3, 1,  '2026-07-17 03:00:00');
INSERT INTO SeferDuraklar VALUES (70, 1, 17, '2026-07-16 19:00:00');
INSERT INTO SeferDuraklar VALUES (70, 2, 12, '2026-07-16 22:00:00');
INSERT INTO SeferDuraklar VALUES (70, 3, 1,  '2026-07-17 06:00:00');
INSERT INTO SeferDuraklar VALUES (80, 1, 25, '2026-07-17 20:00:00');
INSERT INTO SeferDuraklar VALUES (80, 2, 2,  '2026-07-18 00:30:00');
INSERT INTO SeferDuraklar VALUES (86, 1, 28, '2026-07-17 17:00:00');
INSERT INTO SeferDuraklar VALUES (86, 2, 15, '2026-07-17 21:00:00');
INSERT INTO SeferDuraklar VALUES (86, 3, 2,  '2026-07-18 06:00:00');

-- ============================================================
-- SEFERDURAKOTOGAR: otogar entries for each SeferDuraklar row
-- ============================================================
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (31, 1, 1, NULL, '2026-07-15 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (31, 20, 2, '2026-07-15 09:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (32, 1, 1, NULL, '2026-07-15 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (32, 28, 2, '2026-07-15 11:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (33, 1, 1, NULL, '2026-07-15 10:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (33, 33, 2, '2026-07-15 12:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (34, 1, 1, NULL, '2026-07-15 11:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (34, 35, 2, '2026-07-15 14:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (35, 4, 1, NULL, '2026-07-15 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (35, 22, 2, '2026-07-15 11:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (37, 4, 1, NULL, '2026-07-15 10:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (37, 41, 2, '2026-07-15 13:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (39, 6, 1, NULL, '2026-07-15 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (39, 26, 2, '2026-07-15 11:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (40, 6, 1, NULL, '2026-07-15 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (40, 30, 2, '2026-07-15 10:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (41, 6, 1, NULL, '2026-07-15 10:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (41, 31, 2, '2026-07-15 13:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (42, 6, 1, NULL, '2026-07-15 11:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (42, 29, 2, '2026-07-15 14:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (43, 10, 1, NULL, '2026-07-15 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (43, 26, 2, '2026-07-15 11:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (44, 10, 1, NULL, '2026-07-15 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (44, 31, 2, '2026-07-15 12:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (45, 12, 1, NULL, '2026-07-15 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (45, 24, 2, '2026-07-15 09:15:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (46, 12, 1, NULL, '2026-07-15 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (46, 37, 2, '2026-07-15 10:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (47, 12, 1, NULL, '2026-07-15 10:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (47, 38, 2, '2026-07-15 12:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (49, 16, 1, NULL, '2026-07-15 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (49, 25, 2, '2026-07-15 11:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (50, 16, 1, NULL, '2026-07-15 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (50, 27, 2, '2026-07-15 12:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (52, 18, 1, NULL, '2026-07-15 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (52, 40, 2, '2026-07-15 10:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (53, 18, 1, NULL, '2026-07-15 10:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (53, 34, 2, '2026-07-15 14:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (54, 22, 1, NULL, '2026-07-16 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (54, 36, 2, '2026-07-16 11:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (55, 22, 1, NULL, '2026-07-16 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (55, 27, 2, '2026-07-16 13:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (56, 22, 1, NULL, '2026-07-16 10:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (56, 41, 2, '2026-07-16 11:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (58, 23, 1, NULL, '2026-07-16 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (58, 18, 2, '2026-07-16 11:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (59, 23, 1, NULL, '2026-07-16 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (59, 40, 2, '2026-07-16 10:15:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (60, 24, 1, NULL, '2026-07-16 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (60, 10, 2, '2026-07-16 13:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (61, 24, 1, NULL, '2026-07-16 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (61, 12, 2, '2026-07-16 10:15:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (62, 24, 1, NULL, '2026-07-16 20:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (62, 16, 2, '2026-07-17 00:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (65, 25, 1, NULL, '2026-07-16 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (65, 39, 2, '2026-07-16 12:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (67, 26, 1, NULL, '2026-07-16 21:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (67, 4, 2, '2026-07-17 03:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (68, 26, 1, NULL, '2026-07-16 10:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (68, 31, 2, '2026-07-16 12:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (69, 27, 1, NULL, '2026-07-16 20:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (69, 4, 2, '2026-07-17 04:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (71, 27, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (71, 36, 2, '2026-07-17 11:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (72, 35, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (72, 1, 2, '2026-07-17 11:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (73, 35, 1, NULL, '2026-07-17 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (73, 33, 2, '2026-07-17 10:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (74, 29, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (74, 1, 2, '2026-07-17 11:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (75, 29, 1, NULL, '2026-07-17 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (75, 8, 2, '2026-07-17 10:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (76, 30, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (76, 6, 2, '2026-07-17 09:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (77, 30, 1, NULL, '2026-07-17 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (77, 8, 2, '2026-07-17 13:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (78, 31, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (78, 10, 2, '2026-07-17 11:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (79, 31, 1, NULL, '2026-07-17 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (79, 6, 2, '2026-07-17 12:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (81, 36, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (81, 22, 2, '2026-07-17 11:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (82, 37, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (82, 12, 2, '2026-07-17 09:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (83, 37, 1, NULL, '2026-07-17 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (83, 16, 2, '2026-07-17 12:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (84, 38, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (84, 12, 2, '2026-07-17 10:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (85, 38, 1, NULL, '2026-07-17 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (85, 16, 2, '2026-07-17 10:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (87, 39, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (87, 25, 2, '2026-07-17 12:00:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (88, 40, 1, NULL, '2026-07-17 08:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (88, 23, 2, '2026-07-17 09:15:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (89, 40, 1, NULL, '2026-07-17 09:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (89, 18, 2, '2026-07-17 10:30:00', NULL);
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (90, 41, 1, NULL, '2026-07-17 20:00:00');
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES (90, 4, 2, '2026-07-17 23:00:00', NULL);
