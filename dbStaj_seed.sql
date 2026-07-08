SET NOCOUNT ON;

-- ============================================================
-- PERSONEL (14 yeni kayıt)
-- ============================================================
INSERT INTO Personel (Ad, Soyad, Email, Maas, IseGirisTarihi) VALUES
('Mehmet',  'Aksoy',    'mehmet.aksoy@dbstaj.com',    8500.00, '2022-03-15'),
('Zeynep',  'Demir',    'zeynep.demir@dbstaj.com',    7200.00, '2023-01-10'),
('Hasan',   'Yıldız',   'hasan.yildiz@dbstaj.com',    8500.00, '2021-06-01'),
('Elif',    'Şahin',    'elif.sahin@dbstaj.com',       9000.00, '2020-09-20'),
('Murat',   'Erdoğan',  'murat.erdogan@dbstaj.com',  12000.00, '2019-04-05'),
('Selin',   'Aydın',    'selin.aydin@dbstaj.com',     7200.00, '2023-07-15'),
('Burak',   'Güneş',    'burak.gunes@dbstaj.com',     8500.00, '2022-11-28'),
('Nihan',   'Korkmaz',  'nihan.korkmaz@dbstaj.com',   9500.00, '2021-02-14'),
('Tarık',   'Çetin',    'tarik.cetin@dbstaj.com',     8500.00, '2020-08-30'),
('Gözde',   'Özdemir',  'gozde.ozdemir@dbstaj.com',   8800.00, '2022-05-17'),
('Kemal',   'Arslan',   'kemal.arslan@dbstaj.com',    6500.00, '2023-03-01'),
('Merve',   'Kılıç',    'merve.kilic@dbstaj.com',     7200.00, '2022-09-12'),
('Emre',    'Polat',    'emre.polat@dbstaj.com',      7800.00, '2021-12-20'),
('Yasemin', 'Doğan',    'yasemin.dogan@dbstaj.com',   7500.00, '2023-06-08');

-- ============================================================
-- MUSTERI (30 yeni kayıt)
-- ============================================================
INSERT INTO Musteri (TC, Ad, Soyad, Email, Telefon, Adres, Sehir) VALUES
('30000000001','Ali',      'Kara',       'ali.kara@mail.com',       '05321100001','Kadıköy Mh. No:12',      'İstanbul'),
('30000000002','Fatma',    'Çelik',      'fatma.celik@mail.com',    '05321100002','Çankaya Cd. No:5',       'Ankara'),
('30000000003','Mustafa',  'Aydın',      'mustafa.aydin@mail.com',  '05321100003','Bornova Mh. No:33',      'İzmir'),
('30000000004','Emine',    'Yıldırım',   'emine.yildirim@mail.com', '05321100004','Nilüfer İlçe No:8',      'Bursa'),
('30000000005','İbrahim',  'Öztürk',     'ibrahim.ozturk@mail.com', '05321100005','Muratpaşa Mh. No:17',   'Antalya'),
('30000000006','Hatice',   'Arslan',     'hatice.arslan@mail.com',  '05321100006','Seyhan İlçe No:22',      'Adana'),
('30000000007','Hüseyin',  'Doğan',      'huseyin.dogan@mail.com',  '05321100007','Meram Mh. No:9',         'Konya'),
('30000000008','Ayşegül',  'Kılıç',      'aysegul.kilic@mail.com',  '05321100008','Şahinbey İlçe No:14',   'Gaziantep'),
('30000000009','Mehmet',   'Şahin',      'mehmet.sahin@mail.com',   '05321100009','Ortahisar Mh. No:3',    'Trabzon'),
('30000000010','Zeynep',   'Yılmaz',     'zeynep.yilmaz@mail.com',  '05321100010','Odunpazarı Mh. No:7',   'Eskişehir'),
('30000000011','Ömer',     'Demir',      'omer.demir@mail.com',     '05331100011','Beylikdüzü Mh. No:45',  'İstanbul'),
('30000000012','Merve',    'Güneş',      'merve.gunes@mail.com',    '05331100012','Keçiören Mh. No:18',    'Ankara'),
('30000000013','Cem',      'Erdoğan',    'cem.erdogan@mail.com',    '05331100013','Karşıyaka Mh. No:29',   'İzmir'),
('30000000014','Selma',    'Çetin',      'selma.cetin@mail.com',    '05331100014','Osmangazi İlçe No:6',   'Bursa'),
('30000000015','Tolga',    'Aksoy',      'tolga.aksoy@mail.com',    '05331100015','Kepez İlçe No:11',       'Antalya'),
('30000000016','Derya',    'Polat',      'derya.polat@mail.com',    '05331100016','Çukurova İlçe No:37',   'Adana'),
('30000000017','Serkan',   'Özdemir',    'serkan.ozdemir@mail.com', '05331100017','Selçuklu İlçe No:5',    'Konya'),
('30000000018','Burcu',    'Korkmaz',    'burcu.korkmaz@mail.com',  '05331100018','Nizip İlçe No:20',       'Gaziantep'),
('30000000019','Emre',     'Avcı',       'emre.avci@mail.com',      '05331100019','Akçaabat İlçe No:4',    'Trabzon'),
('30000000020','Gizem',    'Kaplan',     'gizem.kaplan@mail.com',   '05331100020','Tepebaşı İlçe No:13',   'Eskişehir'),
('30000000021','Barış',    'Yıldız',     'baris.yildiz@mail.com',   '05341100021','Üsküdar Mh. No:88',     'İstanbul'),
('30000000022','Elif',     'Öztürk',     'elif.ozturk@mail.com',    '05341100022','Yenimahalle Mh. No:2',  'Ankara'),
('30000000023','Koray',    'Şimşek',     'koray.simsek@mail.com',   '05341100023','Çiğli İlçe No:19',      'İzmir'),
('30000000024','Pınar',    'Karadeniz',  'pinar.karadeniz@mail.com','05341100024','İnegöl İlçe No:25',     'Bursa'),
('30000000025','Mert',     'Güler',      'mert.guler@mail.com',     '05341100025','Alanya İlçe No:44',     'Antalya'),
('30000000026','Simge',    'Bulut',      'simge.bulut@mail.com',    '05341100026','Yüreğir İlçe No:31',    'Adana'),
('30000000027','Okan',     'Tunç',       'okan.tunc@mail.com',      '05341100027','Karatay İlçe No:16',    'Konya'),
('30000000028','Esra',     'Yıldırım',   'esra.yildirim@mail.com',  '05341100028','Oğuzeli İlçe No:10',    'Gaziantep'),
('30000000029','Kaan',     'Çakır',      'kaan.cakir@mail.com',     '05341100029','Araklı İlçe No:7',      'Trabzon'),
('30000000030','Neslihan', 'Bozkurt',    'neslihan.bozkurt@mail.com','05341100030','Eskişehir Merk. No:21','Eskişehir');

-- ============================================================
-- OTOGARLAR (19 terminal, her şehirde 1-3 adet)
-- ============================================================
INSERT INTO Otogarlar (SehirID, OtogarAdi, Adres, Telefon) VALUES
-- İstanbul (SehirID=1)
(1, 'Esenler Otogarı',         'Esenler Mh., Bayrampaşa/İstanbul',         '02122582500'),
(1, 'Harem Otogarı',           'Harem Sahil Yolu, Üsküdar/İstanbul',        '02163338763'),
(1, 'Büyükçekmece Otogarı',    'Kavaklı Mh., Büyükçekmece/İstanbul',       '02128592410'),
-- Ankara (SehirID=2)
(2, 'AŞTİ',                    'Hipodrom Cd. No:1, Altındağ/Ankara',        '03122481700'),
(2, 'Sincan Otogarı',          'İstasyon Mh., Sincan/Ankara',               '03122700380'),
-- İzmir (SehirID=3)
(3, 'İzmir Şehirlerarası Terminali', 'Terminal Cd., Bornova/İzmir',         '02324720000'),
(3, 'Torbalı Otogarı',         'Torbalı İlçe Merkezi, İzmir',               '02324530100'),
-- Bursa (SehirID=4)
(4, 'Bursa Terminali',         'Atatürk Cd. Terminal, Osmangazi/Bursa',     '02242621300'),
(4, 'Mudanya Otogarı',         'Güzelyalı Mh., Mudanya/Bursa',              '02245441200'),
-- Antalya (SehirID=5)
(5, 'Antalya Otogarı',         'Kazım Karabekir Cd., Muratpaşa/Antalya',   '02422214000'),
(5, 'Alanya Otogarı',          'Gazipaşa Cd., Alanya/Antalya',              '02425120325'),
-- Adana (SehirID=6)
(6, 'Adana Şehirlerarası Terminali', 'M. Kemal Mh., Seyhan/Adana',         '03224280000'),
(6, 'Ceyhan Otogarı',          'Terminal Mh., Ceyhan/Adana',                '03224131200'),
-- Konya (SehirID=7)
(7, 'Konya Otogarı',           'Otogar Mh., Meram/Konya',                   '03322350000'),
(7, 'Ereğli Otogarı',          'İstasyon Cd., Ereğli/Konya',                '03323230050'),
-- Gaziantep (SehirID=8)
(8, 'Gaziantep Otogarı',       'Otogar Cd., Şahinbey/Gaziantep',            '03422212000'),
(8, 'Nizip Otogarı',           'Terminal Mh., Nizip/Gaziantep',             '03422312100'),
-- Trabzon (SehirID=9)
(9, 'Trabzon Otogarı',         'Otogar Mh., Ortahisar/Trabzon',             '04623217900'),
-- Eskişehir (SehirID=10)
(10,'Eskişehir Otogarı',       'İstasyon Cd., Odunpazarı/Eskişehir',        '02222308280');

-- ============================================================
-- SehirID → Ana OtogarID eşlemesi (kolaylık için):
--  İstanbul(1)  → 1 (Esenler)
--  Ankara(2)    → 4 (AŞTİ)
--  İzmir(3)     → 6 (İzmir Terminal)
--  Bursa(4)     → 8 (Bursa Terminali)
--  Antalya(5)   → 10 (Antalya Otogarı)
--  Adana(6)     → 12 (Adana Terminal)
--  Konya(7)     → 14 (Konya Otogarı)
--  Gaziantep(8) → 16 (Gaziantep Otogarı)
--  Trabzon(9)   → 18 (Trabzon Otogarı)
--  Eskişehir(10)→ 19 (Eskişehir Otogarı)
-- ============================================================

-- ============================================================
-- SEFERDURAKLAR
-- Sefer 1:  İstanbul → Eskişehir → Ankara (3 durak)
-- ============================================================
INSERT INTO SeferDuraklar VALUES (1, 1, 1, '2026-07-10 09:00');   -- İstanbul kalkış
INSERT INTO SeferDuraklar VALUES (1, 2,10, '2026-07-10 11:30');   -- Eskişehir
INSERT INTO SeferDuraklar VALUES (1, 3, 2, '2026-07-10 13:30');   -- Ankara varış

-- Sefer 2: İstanbul → Bursa → İzmir (3 durak)
INSERT INTO SeferDuraklar VALUES (2, 1, 1, '2026-07-10 10:30');
INSERT INTO SeferDuraklar VALUES (2, 2, 4, '2026-07-10 13:00');
INSERT INTO SeferDuraklar VALUES (2, 3, 3, '2026-07-10 17:30');

-- Sefer 3: İstanbul → Bursa → Konya → Antalya (4 durak)
INSERT INTO SeferDuraklar VALUES (3, 1, 1, '2026-07-10 21:00');
INSERT INTO SeferDuraklar VALUES (3, 2, 4, '2026-07-11 00:00');
INSERT INTO SeferDuraklar VALUES (3, 3, 7, '2026-07-11 05:30');
INSERT INTO SeferDuraklar VALUES (3, 4, 5, '2026-07-11 09:30');

-- Sefer 4: Ankara → Eskişehir → İstanbul (3 durak)
INSERT INTO SeferDuraklar VALUES (4, 1, 2, '2026-07-10 08:00');
INSERT INTO SeferDuraklar VALUES (4, 2,10, '2026-07-10 10:00');
INSERT INTO SeferDuraklar VALUES (4, 3, 1, '2026-07-10 13:00');

-- Sefer 5: Ankara → Konya (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (5, 1, 2, '2026-07-10 12:00');
INSERT INTO SeferDuraklar VALUES (5, 2, 7, '2026-07-10 14:30');

-- Sefer 6: Ankara → Trabzon (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (6, 1, 2, '2026-07-10 20:00');
INSERT INTO SeferDuraklar VALUES (6, 2, 9, '2026-07-11 06:00');

-- Sefer 7: İzmir → Bursa → İstanbul (3 durak)
INSERT INTO SeferDuraklar VALUES (7, 1, 3, '2026-07-10 09:30');
INSERT INTO SeferDuraklar VALUES (7, 2, 4, '2026-07-10 14:00');
INSERT INTO SeferDuraklar VALUES (7, 3, 1, '2026-07-10 17:00');

-- Sefer 8: İzmir → Bursa (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (8, 1, 3, '2026-07-10 14:00');
INSERT INTO SeferDuraklar VALUES (8, 2, 4, '2026-07-10 18:30');

-- Sefer 9: İzmir → Antalya (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (9, 1, 3, '2026-07-10 23:00');
INSERT INTO SeferDuraklar VALUES (9, 2, 5, '2026-07-11 06:00');

-- Sefer 10: Bursa → Eskişehir → Ankara (3 durak)
INSERT INTO SeferDuraklar VALUES (10, 1, 4, '2026-07-11 07:30');
INSERT INTO SeferDuraklar VALUES (10, 2,10, '2026-07-11 09:30');
INSERT INTO SeferDuraklar VALUES (10, 3, 2, '2026-07-11 12:00');

-- Sefer 11: Bursa → İzmir (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (11, 1, 4, '2026-07-11 11:00');
INSERT INTO SeferDuraklar VALUES (11, 2, 3, '2026-07-11 15:30');

-- Sefer 12: Bursa → Eskişehir (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (12, 1, 4, '2026-07-11 16:30');
INSERT INTO SeferDuraklar VALUES (12, 2,10, '2026-07-11 18:30');

-- Sefer 13: Antalya → Konya → Bursa → İstanbul (4 durak)
INSERT INTO SeferDuraklar VALUES (13, 1, 5, '2026-07-11 20:00');
INSERT INTO SeferDuraklar VALUES (13, 2, 7, '2026-07-12 00:30');
INSERT INTO SeferDuraklar VALUES (13, 3, 4, '2026-07-12 05:30');
INSERT INTO SeferDuraklar VALUES (13, 4, 1, '2026-07-12 08:00');

-- Sefer 14: Antalya → Konya (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (14, 1, 5, '2026-07-11 09:00');
INSERT INTO SeferDuraklar VALUES (14, 2, 7, '2026-07-11 13:30');

-- Sefer 15: Antalya → Adana (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (15, 1, 5, '2026-07-11 13:30');
INSERT INTO SeferDuraklar VALUES (15, 2, 6, '2026-07-11 18:00');

-- Sefer 16: Adana → Konya → Ankara (3 durak)
INSERT INTO SeferDuraklar VALUES (16, 1, 6, '2026-07-11 10:00');
INSERT INTO SeferDuraklar VALUES (16, 2, 7, '2026-07-11 14:00');
INSERT INTO SeferDuraklar VALUES (16, 3, 2, '2026-07-11 18:00');

-- Sefer 17: Adana → Gaziantep (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (17, 1, 6, '2026-07-11 15:00');
INSERT INTO SeferDuraklar VALUES (17, 2, 8, '2026-07-11 17:30');

-- Sefer 18: Adana → Konya → Antalya (3 durak)
INSERT INTO SeferDuraklar VALUES (18, 1, 6, '2026-07-11 22:30');
INSERT INTO SeferDuraklar VALUES (18, 2, 7, '2026-07-12 02:00');
INSERT INTO SeferDuraklar VALUES (18, 3, 5, '2026-07-12 06:30');

-- Sefer 19: Konya → Ankara (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (19, 1, 7, '2026-07-12 08:30');
INSERT INTO SeferDuraklar VALUES (19, 2, 2, '2026-07-12 11:00');

-- Sefer 20: Konya → Antalya (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (20, 1, 7, '2026-07-12 12:30');
INSERT INTO SeferDuraklar VALUES (20, 2, 5, '2026-07-12 17:00');

-- Sefer 21: Konya → Bursa → İstanbul (3 durak)
INSERT INTO SeferDuraklar VALUES (21, 1, 7, '2026-07-12 21:30');
INSERT INTO SeferDuraklar VALUES (21, 2, 4, '2026-07-13 02:30');
INSERT INTO SeferDuraklar VALUES (21, 3, 1, '2026-07-13 05:30');

-- Sefer 22: Gaziantep → Adana (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (22, 1, 8, '2026-07-12 09:00');
INSERT INTO SeferDuraklar VALUES (22, 2, 6, '2026-07-12 11:30');

-- Sefer 23: Gaziantep → Adana → Konya → Ankara (4 durak)
INSERT INTO SeferDuraklar VALUES (23, 1, 8, '2026-07-12 14:00');
INSERT INTO SeferDuraklar VALUES (23, 2, 6, '2026-07-12 16:30');
INSERT INTO SeferDuraklar VALUES (23, 3, 7, '2026-07-12 20:30');
INSERT INTO SeferDuraklar VALUES (23, 4, 2, '2026-07-13 00:30');

-- Sefer 24: Gaziantep → Adana → Konya → İstanbul (4 durak)
INSERT INTO SeferDuraklar VALUES (24, 1, 8, '2026-07-12 19:00');
INSERT INTO SeferDuraklar VALUES (24, 2, 6, '2026-07-12 21:30');
INSERT INTO SeferDuraklar VALUES (24, 3, 7, '2026-07-13 02:00');
INSERT INTO SeferDuraklar VALUES (24, 4, 1, '2026-07-13 09:00');

-- Sefer 25: Trabzon → Ankara (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (25, 1, 9, '2026-07-12 08:00');
INSERT INTO SeferDuraklar VALUES (25, 2, 2, '2026-07-12 18:00');

-- Sefer 26: Trabzon → Ankara → İstanbul (3 durak)
INSERT INTO SeferDuraklar VALUES (26, 1, 9, '2026-07-12 17:00');
INSERT INTO SeferDuraklar VALUES (26, 2, 2, '2026-07-13 03:00');
INSERT INTO SeferDuraklar VALUES (26, 3, 1, '2026-07-13 08:00');

-- Sefer 27: Trabzon → Bursa (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (27, 1, 9, '2026-07-12 18:30');
INSERT INTO SeferDuraklar VALUES (27, 2, 4, '2026-07-13 06:00');

-- Sefer 28: Eskişehir → Bursa (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (28, 1,10, '2026-07-12 07:00');
INSERT INTO SeferDuraklar VALUES (28, 2, 4, '2026-07-12 09:00');

-- Sefer 29: Eskişehir → İstanbul (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (29, 1,10, '2026-07-12 10:00');
INSERT INTO SeferDuraklar VALUES (29, 2, 1, '2026-07-12 12:30');

-- Sefer 30: Eskişehir → Ankara (direkt, 2 durak)
INSERT INTO SeferDuraklar VALUES (30, 1,10, '2026-07-12 15:00');
INSERT INTO SeferDuraklar VALUES (30, 2, 2, '2026-07-12 17:00');

-- ============================================================
-- SEFERDURAKOTOGAR
-- GelisSaati NULL = kalkış durağı  |  GidisSaati NULL = varış durağı
-- ============================================================
-- Sefer 1: İstanbul(OtogarID=1) → Eskişehir(19) → Ankara(4)
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(1,  1, 1, NULL,                   '2026-07-10 09:00'),
(1, 19, 2, '2026-07-10 11:30',    '2026-07-10 11:45'),
(1,  4, 3, '2026-07-10 13:30',    NULL);

-- Sefer 2: İstanbul → Bursa → İzmir
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(2,  1, 1, NULL,                   '2026-07-10 10:30'),
(2,  8, 2, '2026-07-10 13:00',    '2026-07-10 13:20'),
(2,  6, 3, '2026-07-10 17:30',    NULL);

-- Sefer 3: İstanbul → Bursa → Konya → Antalya
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(3,  1, 1, NULL,                   '2026-07-10 21:00'),
(3,  8, 2, '2026-07-11 00:00',    '2026-07-11 00:20'),
(3, 14, 3, '2026-07-11 05:30',    '2026-07-11 05:50'),
(3, 10, 4, '2026-07-11 09:30',    NULL);

-- Sefer 4: Ankara → Eskişehir → İstanbul
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(4,  4, 1, NULL,                   '2026-07-10 08:00'),
(4, 19, 2, '2026-07-10 10:00',    '2026-07-10 10:15'),
(4,  1, 3, '2026-07-10 13:00',    NULL);

-- Sefer 5: Ankara → Konya
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(5,  4, 1, NULL,                   '2026-07-10 12:00'),
(5, 14, 2, '2026-07-10 14:30',    NULL);

-- Sefer 6: Ankara → Trabzon
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(6,  4, 1, NULL,                   '2026-07-10 20:00'),
(6, 18, 2, '2026-07-11 06:00',    NULL);

-- Sefer 7: İzmir → Bursa → İstanbul
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(7,  6, 1, NULL,                   '2026-07-10 09:30'),
(7,  8, 2, '2026-07-10 14:00',    '2026-07-10 14:20'),
(7,  1, 3, '2026-07-10 17:00',    NULL);

-- Sefer 8: İzmir → Bursa
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(8,  6, 1, NULL,                   '2026-07-10 14:00'),
(8,  8, 2, '2026-07-10 18:30',    NULL);

-- Sefer 9: İzmir → Antalya
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(9,  6, 1, NULL,                   '2026-07-10 23:00'),
(9, 10, 2, '2026-07-11 06:00',    NULL);

-- Sefer 10: Bursa → Eskişehir → Ankara
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(10,  8, 1, NULL,                  '2026-07-11 07:30'),
(10, 19, 2, '2026-07-11 09:30',   '2026-07-11 09:45'),
(10,  4, 3, '2026-07-11 12:00',   NULL);

-- Sefer 11: Bursa → İzmir
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(11,  8, 1, NULL,                  '2026-07-11 11:00'),
(11,  6, 2, '2026-07-11 15:30',   NULL);

-- Sefer 12: Bursa → Eskişehir
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(12,  8, 1, NULL,                  '2026-07-11 16:30'),
(12, 19, 2, '2026-07-11 18:30',   NULL);

-- Sefer 13: Antalya → Konya → Bursa → İstanbul
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(13, 10, 1, NULL,                  '2026-07-11 20:00'),
(13, 14, 2, '2026-07-12 00:30',   '2026-07-12 00:50'),
(13,  8, 3, '2026-07-12 05:30',   '2026-07-12 05:50'),
(13,  1, 4, '2026-07-12 08:00',   NULL);

-- Sefer 14: Antalya → Konya
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(14, 10, 1, NULL,                  '2026-07-11 09:00'),
(14, 14, 2, '2026-07-11 13:30',   NULL);

-- Sefer 15: Antalya → Adana
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(15, 10, 1, NULL,                  '2026-07-11 13:30'),
(15, 12, 2, '2026-07-11 18:00',   NULL);

-- Sefer 16: Adana → Konya → Ankara
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(16, 12, 1, NULL,                  '2026-07-11 10:00'),
(16, 14, 2, '2026-07-11 14:00',   '2026-07-11 14:20'),
(16,  4, 3, '2026-07-11 18:00',   NULL);

-- Sefer 17: Adana → Gaziantep
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(17, 12, 1, NULL,                  '2026-07-11 15:00'),
(17, 16, 2, '2026-07-11 17:30',   NULL);

-- Sefer 18: Adana → Konya → Antalya
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(18, 12, 1, NULL,                  '2026-07-11 22:30'),
(18, 14, 2, '2026-07-12 02:00',   '2026-07-12 02:20'),
(18, 10, 3, '2026-07-12 06:30',   NULL);

-- Sefer 19: Konya → Ankara
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(19, 14, 1, NULL,                  '2026-07-12 08:30'),
(19,  4, 2, '2026-07-12 11:00',   NULL);

-- Sefer 20: Konya → Antalya
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(20, 14, 1, NULL,                  '2026-07-12 12:30'),
(20, 10, 2, '2026-07-12 17:00',   NULL);

-- Sefer 21: Konya → Bursa → İstanbul
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(21, 14, 1, NULL,                  '2026-07-12 21:30'),
(21,  8, 2, '2026-07-13 02:30',   '2026-07-13 02:50'),
(21,  2, 3, '2026-07-13 05:30',   NULL);   -- Harem Otogarı (İstanbul)

-- Sefer 22: Gaziantep → Adana
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(22, 16, 1, NULL,                  '2026-07-12 09:00'),
(22, 12, 2, '2026-07-12 11:30',   NULL);

-- Sefer 23: Gaziantep → Adana → Konya → Ankara
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(23, 16, 1, NULL,                  '2026-07-12 14:00'),
(23, 13, 2, '2026-07-12 16:30',   '2026-07-12 16:50'),  -- Ceyhan Otogarı
(23, 14, 3, '2026-07-12 20:30',   '2026-07-12 20:50'),
(23,  4, 4, '2026-07-13 00:30',   NULL);

-- Sefer 24: Gaziantep → Adana → Konya → İstanbul
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(24, 17, 1, NULL,                  '2026-07-12 19:00'),  -- Nizip Otogarı
(24, 12, 2, '2026-07-12 21:30',   '2026-07-12 21:50'),
(24, 14, 3, '2026-07-13 02:00',   '2026-07-13 02:20'),
(24,  1, 4, '2026-07-13 09:00',   NULL);

-- Sefer 25: Trabzon → Ankara
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(25, 18, 1, NULL,                  '2026-07-12 08:00'),
(25,  4, 2, '2026-07-12 18:00',   NULL);

-- Sefer 26: Trabzon → Ankara → İstanbul
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(26, 18, 1, NULL,                  '2026-07-12 17:00'),
(26,  5, 2, '2026-07-13 03:00',   '2026-07-13 03:30'),  -- Sincan Otogarı
(26,  1, 3, '2026-07-13 08:00',   NULL);

-- Sefer 27: Trabzon → Bursa
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(27, 18, 1, NULL,                  '2026-07-12 18:30'),
(27,  9, 2, '2026-07-13 06:00',   NULL);  -- Mudanya Otogarı

-- Sefer 28: Eskişehir → Bursa
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(28, 19, 1, NULL,                  '2026-07-12 07:00'),
(28,  8, 2, '2026-07-12 09:00',   NULL);

-- Sefer 29: Eskişehir → İstanbul
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(29, 19, 1, NULL,                  '2026-07-12 10:00'),
(29,  1, 2, '2026-07-12 12:30',   NULL);

-- Sefer 30: Eskişehir → Ankara
INSERT INTO SeferDurakOtogar (SeferID,OtogarID,DurakSira,GelisSaati,GidisSaati) VALUES
(30, 19, 1, NULL,                  '2026-07-12 15:00'),
(30,  4, 2, '2026-07-12 17:00',   NULL);

-- ============================================================
-- BILETLER (~100 bilet)
-- Direkt seferler: BinisDurakSira=1, InisDurakSira=2
-- 3 duraklı: çeşitli kombinasyonlar
-- 4 duraklı: çeşitli kombinasyonlar
-- ============================================================

-- Sefer 1 (İstanbul→Eskişehir→Ankara) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(1,  1,'30000000001',1,3), (1,  2,'30000000002',1,3), (1,  3,'30000000011',1,2),
(1,  4,'30000000012',2,3), (1,  5,'30000000021',1,3), (1,  6,'58241739616',1,3),
(1,  7,'30000000022',1,3), (1,  8,'30000000003',2,3), (1,  9,'30000000013',1,3),
(1, 10,'10293847561',1,2);

-- Sefer 2 (İstanbul→Bursa→İzmir) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(2,  1,'30000000004',1,3), (2,  2,'30000000014',1,2), (2,  3,'30000000024',2,3),
(2,  4,'30000000005',1,3), (2,  5,'30000000015',1,3), (2,  6,'30000000025',1,3),
(2,  7,'30000000006',1,3), (2,  8,'30000000016',2,3), (2, 10,'13421432142',1,3);

-- Sefer 3 (İstanbul→Bursa→Konya→Antalya) - 4 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(3,  1,'30000000007',1,4), (3,  2,'30000000017',1,4), (3,  3,'30000000027',2,4),
(3,  4,'30000000008',3,4), (3,  5,'30000000018',1,3), (3,  6,'30000000028',1,4),
(3,  7,'98473250925',2,3), (3,  8,'30000000009',1,4), (3,  9,'30000000019',1,4),
(3, 11,'30000000029',1,4);

-- Sefer 4 (Ankara→Eskişehir→İstanbul) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(4,  1,'30000000010',1,3), (4,  2,'30000000020',1,2), (4,  3,'30000000030',2,3),
(4,  4,'42352435245',1,3), (4,  5,'30000000001',1,3), (4,  6,'30000000011',1,3);

-- Sefer 5 (Ankara→Konya) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(5,  1,'30000000002',1,2), (5,  2,'30000000012',1,2), (5,  3,'30000000022',1,2),
(5,  4,'30000000003',1,2), (5,  5,'30000000013',1,2), (5,  6,'58241739616',1,2);

-- Sefer 6 (Ankara→Trabzon) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(6,  1,'30000000004',1,2), (6,  2,'30000000014',1,2), (6,  3,'30000000024',1,2),
(6,  4,'30000000005',1,2), (6,  5,'10293847561',1,2);

-- Sefer 7 (İzmir→Bursa→İstanbul) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(7,  1,'30000000015',1,3), (7,  2,'30000000025',1,2), (7,  3,'30000000006',2,3),
(7,  4,'30000000016',1,3), (7,  5,'30000000026',1,3), (7,  6,'13421432142',1,3);

-- Sefer 8 (İzmir→Bursa) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(8,  1,'30000000007',1,2), (8,  2,'30000000017',1,2), (8,  3,'30000000027',1,2),
(8,  4,'98473250925',1,2);

-- Sefer 9 (İzmir→Antalya) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(9,  1,'30000000008',1,2), (9,  2,'30000000018',1,2), (9,  3,'30000000028',1,2),
(9,  4,'30000000009',1,2), (9,  5,'42352435245',1,2);

-- Sefer 10 (Bursa→Eskişehir→Ankara) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(10,  1,'30000000019',1,3), (10,  2,'30000000029',1,2), (10,  3,'30000000010',2,3),
(10,  4,'30000000020',1,3), (10,  5,'30000000030',1,3), (10,  6,'58241739616',1,3);

-- Sefer 11 (Bursa→İzmir) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(11,  1,'30000000001',1,2), (11,  2,'30000000021',1,2), (11,  3,'10293847561',1,2);

-- Sefer 12 (Bursa→Eskişehir) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(12,  1,'30000000002',1,2), (12,  2,'30000000022',1,2), (12,  3,'13421432142',1,2);

-- Sefer 13 (Antalya→Konya→Bursa→İstanbul) - 4 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(13,  1,'30000000003',1,4), (13,  2,'30000000023',1,4), (13,  3,'30000000004',2,4),
(13,  4,'30000000024',3,4), (13,  5,'30000000014',1,3), (13,  6,'30000000034',1,4),
(13,  7,'98473250925',2,3), (13,  8,'30000000005',1,4);

-- Sefer 14 (Antalya→Konya) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(14,  1,'30000000015',1,2), (14,  2,'30000000025',1,2), (14,  3,'42352435245',1,2);

-- Sefer 15 (Antalya→Adana) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(15,  1,'30000000006',1,2), (15,  2,'30000000016',1,2), (15,  3,'30000000026',1,2),
(15,  4,'58241739616',1,2);

-- Sefer 16 (Adana→Konya→Ankara) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(16,  1,'30000000007',1,3), (16,  2,'30000000017',1,2), (16,  3,'30000000027',2,3),
(16,  4,'10293847561',1,3), (16,  5,'30000000008',1,3);

-- Sefer 17 (Adana→Gaziantep) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(17,  1,'30000000018',1,2), (17,  2,'30000000028',1,2), (17,  3,'13421432142',1,2);

-- Sefer 18 (Adana→Konya→Antalya) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(18,  1,'30000000009',1,3), (18,  2,'30000000019',1,3), (18,  3,'30000000029',2,3),
(18,  4,'98473250925',1,3);

-- Sefer 19 (Konya→Ankara) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(19,  1,'30000000010',1,2), (19,  2,'30000000020',1,2), (19,  3,'30000000030',1,2),
(19,  4,'42352435245',1,2);

-- Sefer 20 (Konya→Antalya) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(20,  1,'30000000001',1,2), (20,  2,'30000000011',1,2), (20,  3,'58241739616',1,2);

-- Sefer 21 (Konya→Bursa→İstanbul) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(21,  1,'30000000002',1,3), (21,  2,'30000000012',1,2), (21,  3,'30000000022',2,3),
(21,  4,'10293847561',1,3), (21,  5,'30000000003',1,3);

-- Sefer 22 (Gaziantep→Adana) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(22,  1,'30000000013',1,2), (22,  2,'30000000023',1,2), (22,  3,'13421432142',1,2);

-- Sefer 23 (Gaziantep→Adana→Konya→Ankara) - 4 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(23,  1,'30000000004',1,4), (23,  2,'30000000014',1,4), (23,  3,'30000000024',2,4),
(23,  4,'30000000005',3,4), (23,  5,'98473250925',1,3), (23,  6,'30000000015',2,3);

-- Sefer 24 (Gaziantep→Adana→Konya→İstanbul) - 4 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(24,  1,'30000000025',1,4), (24,  2,'30000000006',1,4), (24,  3,'30000000016',2,4),
(24,  4,'30000000026',3,4), (24,  5,'42352435245',1,3), (24,  6,'30000000007',1,4);

-- Sefer 25 (Trabzon→Ankara) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(25,  1,'30000000017',1,2), (25,  2,'30000000027',1,2), (25,  3,'58241739616',1,2),
(25,  4,'30000000008',1,2);

-- Sefer 26 (Trabzon→Ankara→İstanbul) - 3 durak
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(26,  1,'30000000018',1,3), (26,  2,'30000000028',1,2), (26,  3,'30000000009',2,3),
(26,  4,'13421432142',1,3), (26,  5,'30000000019',1,3);

-- Sefer 27 (Trabzon→Bursa) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(27,  1,'30000000029',1,2), (27,  2,'30000000010',1,2), (27,  3,'10293847561',1,2);

-- Sefer 28 (Eskişehir→Bursa) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(28,  1,'30000000020',1,2), (28,  2,'30000000030',1,2), (28,  3,'98473250925',1,2);

-- Sefer 29 (Eskişehir→İstanbul) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(29,  1,'30000000001',1,2), (29,  2,'30000000021',1,2), (29,  3,'42352435245',1,2),
(29,  4,'30000000011',1,2);

-- Sefer 30 (Eskişehir→Ankara) - direkt
INSERT INTO Biletler (SeferID,KoltukNo,MusteriTC,BinisDurakSira,InisDurakSira) VALUES
(30,  1,'30000000002',1,2), (30,  2,'30000000012',1,2), (30,  3,'30000000022',1,2),
(30,  4,'30000000003',1,2), (30,  5,'58241739616',1,2);
