# Pazartesi Ödevleri — Uygulama Planı

Kaynak: `pazartesiyeodevler.txt`

## Görev Özeti

1. Exe komut satırı parametresi ile çalışacak: parametresiz → normal form, `adminp` → admin paneli (login ekranı ile)
2. Kullanıcı giriş ekranı (login)
3. Kullanıcı oluşturma ve güncelleme ekranı
4. Şifreler veritabanında MD5 ile tutulacak
5. Kullanıcılara yetki verme ekranı (ekran bazlı yetki)
6. Firma browser'ı (ekle / sil / değiştir / incele) — **BackgroundWorker** ile
7. Otobüs tanımlama browser'ı (ekle / sil / değiştir / incele)
8. Firma–Otobüs eşleme ekranı
9. Kaptan: hem kaptan tanımlama browser'ı hem otobüs/sefer–kaptan eşleme ekranı

## Alınan Kararlar

- Login kullanıcıları için **ayrı `Kullanicilar` tablosu** (Personel'den bağımsız)
- Firma browser'ında veri işlemleri **BackgroundWorker** ile yapılacak (ödev gereği, öğrenme amaçlı)
- Yetkilendirme **ekran bazlı**: her admin ekranı için görüntüleme yetkisi
- Kaptan için mevcut `Personel` tablosu kullanılacak (Rol = "Kaptan")

## Mevcut Mimari (özet)

- WinForms istemci (`StajWinForms/`) → REST API (`StajWinForms_API/`, ASP.NET Core + EF Core) → SQL Server LocalDB `dbStaj`
- DB **database-first**: yeni tablolar için SQL script + `DbStajContext`/Model güncellemesi gerekir
- Grid ekranları için şablon: `AnaMenu.cs` (DevExpress GridControl + GridView)
- HTTP çağrıları: `AppConfig.Http` (X-Api-Key header)

---

## Aşama 1 — Veritabanı ve API Altyapısı

### 1.1 Yeni tablolar (SQL script: `db/adminpanel_tablolar.sql`)

```sql
Kullanicilar (
    KullaniciID INT IDENTITY PK,
    KullaniciAdi NVARCHAR(50) UNIQUE NOT NULL,
    SifreMd5 CHAR(32) NOT NULL,          -- MD5 hex
    AdSoyad NVARCHAR(100),
    Aktif BIT DEFAULT 1,
    OlusturmaTarihi DATETIME DEFAULT GETDATE()
)

Yetkiler (
    YetkiID INT IDENTITY PK,
    YetkiKodu NVARCHAR(50) UNIQUE NOT NULL,   -- FIRMA, OTOBUS, FIRMA_OTOBUS, KAPTAN, KULLANICI, YETKI
    YetkiAdi NVARCHAR(100)
)

KullaniciYetkileri (
    ID INT IDENTITY PK,
    KullaniciID INT FK -> Kullanicilar,
    YetkiID INT FK -> Yetkiler,
    UNIQUE(KullaniciID, YetkiID)
)

Otobusler (
    OtobusID INT IDENTITY PK,
    Plaka NVARCHAR(15) UNIQUE NOT NULL,
    Marka NVARCHAR(50),
    Model NVARCHAR(50),
    KoltukKapasitesi INT DEFAULT 36,
    FirmaID INT NULL FK -> Firmalar       -- firma-otobüs eşlemesi
)

OtobusKaptan (
    ID INT IDENTITY PK,
    OtobusID INT FK -> Otobusler,
    PersonelID INT FK -> Personel,        -- kaptan
    UNIQUE(OtobusID, PersonelID)
)
```

- Seed: `admin` kullanıcısı (tüm yetkilerle) + 6 yetki kaydı

### 1.2 API tarafı

- Modeller: `Kullanicilar.cs`, `Yetkiler.cs`, `KullaniciYetkileri.cs`, `Otobusler.cs`, `OtobusKaptan.cs`
- `DbStajContext`'e DbSet + OnModelCreating konfigürasyonları
- MD5 yardımcı sınıfı: `Helpers/Md5Helper.cs` (API tarafında hash'leme)
- Yeni controller'lar:
  - `AuthController`: `POST /api/auth/login` → kullanıcı adı + şifre doğrula, kullanıcı + yetki listesi döndür
  - `KullanicilarController`: GET / POST / PUT (şifre değişiminde MD5), yetki atama endpoint'leri (`GET/PUT /api/kullanicilar/{id}/yetkiler`)
  - `OtobuslerController`: tam CRUD + firma eşleme (`PUT /api/otobusler/{id}/firma`)
  - `FirmalarController`: mevcut GET'e ek POST / PUT / DELETE
  - `PersonelController`: kaptan CRUD için genişletme (gerekirse)
  - `OtobusKaptanController`: kaptan–otobüs eşleme CRUD

## Aşama 2 — Parametre ile Başlatma + Login

### 2.1 `Program.cs`

- `Main(string[] args)` olarak değiştir:
  - Parametre yok → mevcut akış: `SeferSecimMenu`
  - `adminp` → `LoginForm` göster; başarılı girişte `AdminPanelForm`
- Test için: Proje > Özellikler > Debug > uygulama argümanı `adminp` (launchSettings)

### 2.2 `LoginForm` (yeni)

- Kullanıcı adı + şifre alanları, Giriş butonu
- Şifre API'ye düz gönderilir, API MD5'leyip karşılaştırır
- Başarılı girişte kullanıcı bilgisi + yetkiler static `Oturum` sınıfında tutulur

## Aşama 3 — Admin Paneli Ana Formu

### 3.1 `AdminPanelForm` (yeni)

- Sol menü / ribbon ile alt ekranlara geçiş (DevExpress)
- Menü öğeleri `Oturum.Yetkiler`'e göre gizlenir/gösterilir
- Alt ekranlar UserControl ya da child form olarak açılır

## Aşama 4 — Kullanıcı Yönetimi

### 4.1 `KullaniciYonetimForm`

- Grid: kullanıcı listesi (AnaMenu şablonu)
- Ekle / Güncelle: kullanıcı adı, ad soyad, şifre (yeni veya değiştir), aktif
- Şifre asla geri okunmaz; sadece yeni şifre yazılırsa güncellenir

### 4.2 `YetkiAtamaForm`

- Kullanıcı seç → yetki listesi CheckedListBox → kaydet (`PUT /api/kullanicilar/{id}/yetkiler`)

## Aşama 5 — Firma Browser'ı (BackgroundWorker)

### 5.1 `FirmaBrowserForm`

- Grid + Ekle / Sil / Değiştir / İncele butonları
- **BackgroundWorker kullanımı** (ödev gereği):
  - `bgwVeriYukle`: `DoWork` içinde API'den senkron veri çekme (`.Result` yerine ayrı senkron çağrı), `ProgressChanged` ile ilerleme, `RunWorkerCompleted` içinde grid'e bağlama
  - Kaydet/sil işlemleri de BackgroundWorker ile; işlem sırasında butonlar disable + progress göstergesi
- Sil: firmaya bağlı sefer/otobüs varsa engelle (API'de kontrol, anlamlı hata mesajı)

## Aşama 6 — Otobüs Browser'ı + Firma–Otobüs Eşleme

### 6.1 `OtobusBrowserForm`

- Grid + Ekle / Sil / Değiştir / İncele (FirmaBrowser ile aynı desen)
- Alanlar: Plaka, Marka, Model, Koltuk Kapasitesi

### 6.2 `FirmaOtobusEslemeForm`

- Firma seç (combo) → firmanın otobüsleri + atanmamış otobüsler iki liste
- Ata / Kaldır butonları (`Otobusler.FirmaID` güncellenir)

## Aşama 7 — Kaptan Ekranları

### 7.1 `KaptanBrowserForm`

- `Personel` tablosu üzerinden kaptan CRUD (Ad, Soyad, Email, Maaş, İşe Giriş)

### 7.2 `KaptanEslemeForm`

- Otobüs seç → kaptan ata/kaldır (`OtobusKaptan` tablosu)

## Aşama 8 — Test ve Bitirme

- `adminp` parametresiyle ve parametresiz başlatma testi
- Login: doğru/yanlış şifre, pasif kullanıcı
- Yetkisi olmayan kullanıcının menüde ekranı görmemesi
- Tüm CRUD ekranlarında ekle/sil/değiştir/incele akışları
- BackgroundWorker sırasında UI'nin donmaması

---

## Uygulama Sırası ve Bağımlılıklar

1. Aşama 1 (DB + API) → her şeyin temeli
2. Aşama 2 (parametre + login) → admin paneline giriş kapısı
3. Aşama 3 (AdminPanelForm iskeleti)
4. Aşama 4 (kullanıcı + yetki) → yetki sistemi çalışır hale gelir
5. Aşama 5 (Firma browser, BackgroundWorker) → CRUD deseni oturur
6. Aşama 6–7 (Otobüs, eşleme, kaptan) → deseni tekrar kullanır
7. Aşama 8 test

## Notlar / Riskler

- **MD5 güvenli değildir** (kırılabilir); ödev gereği kullanılacak ama gerçek projede SHA-256 + salt ya da bcrypt tercih edilmelidir. Hocaya not düşülebilir.
- BackgroundWorker eski bir teknolojidir; projenin geri kalanı async/await kullanıyor. Ödev "araştır" dediği için Firma browser'ında bilinçli olarak kullanılacak.
- DB database-first olduğundan SQL script çalıştırıldıktan sonra modeller elle eklenecek (scaffold yeniden çalıştırılmayacak, mevcut context bozulmasın).
