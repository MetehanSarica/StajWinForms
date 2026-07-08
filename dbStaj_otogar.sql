-- ============================================================
-- Otogar ve sefer-durak-otogar tabloları
-- ============================================================

CREATE TABLE Otogarlar (
    OtogarID    INT IDENTITY(1,1) PRIMARY KEY,
    SehirID     INT           NOT NULL,
    OtogarAdi   VARCHAR(100)  NOT NULL,
    Adres       VARCHAR(250)  NULL,
    Telefon     VARCHAR(20)   NULL,
    CONSTRAINT FK__Otogarlar__Sehir FOREIGN KEY (SehirID) REFERENCES Sehirler(SehirID)
);

-- Her seferin hangi otogardan, hangi sırayla geçtiği ve saat bilgileri
CREATE TABLE SeferDurakOtogar (
    ID          INT IDENTITY(1,1) PRIMARY KEY,
    SeferID     INT      NOT NULL,
    OtogarID    INT      NOT NULL,
    DurakSira   INT      NOT NULL,
    GelisSaati  DATETIME NULL,
    GidisSaati  DATETIME NULL,
    CONSTRAINT FK__SeferDurakOtogar__Sefer  FOREIGN KEY (SeferID)  REFERENCES Seferler(SeferID),
    CONSTRAINT FK__SeferDurakOtogar__Otogar FOREIGN KEY (OtogarID) REFERENCES Otogarlar(OtogarID)
);

-- ============================================================
-- Örnek veri
-- ============================================================
INSERT INTO Otogarlar (SehirID, OtogarAdi, Adres, Telefon) VALUES
    ((SELECT SehirID FROM Sehirler WHERE SehirAdi = 'Ankara'),    'Ankara Şehirlerarası Terminal', 'Hipodrom Cd. No:1, Altındağ',  '03124482000'),
    ((SELECT SehirID FROM Sehirler WHERE SehirAdi = 'Eskişehir'), 'Eskişehir Otogarı',             'Otogar Cd., Odunpazarı',       '02222308280'),
    ((SELECT SehirID FROM Sehirler WHERE SehirAdi = 'İzmir'),     'İzmir Şehirlerarası Otobüs Terminali', 'Yeni Garaj, Bornova',   '02324720000');

-- Sefer 1 (Ankara → Eskişehir → İzmir) için otogar durakları
INSERT INTO SeferDurakOtogar (SeferID, OtogarID, DurakSira, GelisSaati, GidisSaati) VALUES
    (1, 1, 1, NULL,                  '2025-08-01 08:00'),  -- Ankara kalkış
    (1, 2, 2, '2025-08-01 10:30',   '2025-08-01 10:45'),  -- Eskişehir transit
    (1, 3, 3, '2025-08-01 15:00',   NULL);                 -- İzmir varış
