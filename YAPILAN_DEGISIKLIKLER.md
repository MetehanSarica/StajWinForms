# Yapılan Değişiklikler — Admin Paneli Ödev Uygulaması

Tarih: 2026-07-17

---

## 1. Veritabanı — Yeni Tablolar

**Dosya:** `db/adminpanel_tablolar.sql`

Aşağıdaki 5 tablo oluşturuldu ve script `sqlcmd` ile `dbStaj` veritabanına uygulandı.

### Kullanicilar
Admin paneline giriş yapacak kullanıcıları tutar. Personel tablosundan bağımsız.

| Kolon | Tip | Açıklama |
|---|---|---|
| KullaniciID | INT IDENTITY PK | |
| KullaniciAdi | NVARCHAR(50) UNIQUE | |
| SifreMd5 | CHAR(32) | MD5 hash (UTF-8) |
| AdSoyad | NVARCHAR(100) NULL | |
| Aktif | BIT DEFAULT 1 | |
| OlusturmaTarihi | DATETIME DEFAULT GETDATE() | |

### Yetkiler
Sistemdeki yetki kodlarını tanımlar.

| YetkiKodu | YetkiAdi |
|---|---|
| FIRMA | Firma Yönetimi |
| OTOBUS | Otobüs Yönetimi |
| FIRMA_OTOBUS | Firma-Otobüs Eşleme |
| KAPTAN | Kaptan Yönetimi |
| KULLANICI | Kullanıcı Yönetimi |
| YETKI | Yetki Yönetimi |

### KullaniciYetkileri
Kullanıcı–yetki many-to-many bağlantı tablosu.

| Kolon | Tip |
|---|---|
| ID | INT IDENTITY PK |
| KullaniciID | INT FK → Kullanicilar (CASCADE) |
| YetkiID | INT FK → Yetkiler (CASCADE) |

### Otobusler
Otobüs tanımları. FirmaID NULL olabilir (eşlenmemiş otobüs).

| Kolon | Tip |
|---|---|
| OtobusID | INT IDENTITY PK |
| Plaka | NVARCHAR(15) UNIQUE |
| Marka | NVARCHAR(50) NULL |
| Model | NVARCHAR(50) NULL |
| KoltukKapasitesi | INT DEFAULT 36 |
| FirmaID | INT NULL FK → Firmalar (SET NULL) |

### OtobusKaptan
Otobüs–kaptan (personel) many-to-many eşleme tablosu.

| Kolon | Tip |
|---|---|
| ID | INT IDENTITY PK |
| OtobusID | INT FK → Otobusler (CASCADE) |
| PersonelID | INT FK → Personel |

### Seed Verileri
- 6 yetki kaydı
- `admin` kullanıcısı → şifre: **Admin123** → MD5: `e64b78fc3bc91bcbc7dc232ba8ec59e0`
- Admin'e tüm 6 yetki atandı

---

## 2. API — Yeni Dosyalar

### Modeller (`StajWinForms_API/Models/`)

| Dosya | Açıklama |
|---|---|
| `Kullanicilar.cs` | SifreMd5 alanı `[JsonIgnore]` ile gizli |
| `Yetkiler.cs` | |
| `KullaniciYetkileri.cs` | |
| `Otobusler.cs` | Firma navigation property içerir |
| `OtobusKaptan.cs` | Personel navigation property içerir |

### Güncellemeler

**`Models/DbStajContext.cs`**
- 5 yeni DbSet eklendi: `Kullanicilars`, `KullaniciYetkileri`, `Yetkilers`, `Otobuslers`, `OtobusKaptanlar`
- `OnModelCreating` içine 5 yeni entity konfigürasyonu eklendi

**`Models/Firmalar.cs`**
- `Otobuslers` navigation property eklendi (`[JsonIgnore]`)

**`Models/Personel.cs`**
- `OtobusKaptanlar` navigation property eklendi (`[JsonIgnore]`)

### Helper

**`Helpers/Md5Helper.cs`**
```csharp
// System.Security.Cryptography.MD5.HashData kullanır
// Döndürdüğü değer: lowercase hex string (32 karakter)
public static string Hash(string deger)
```

### DTO'lar (`StajWinForms_API/Dtos/`)

| Dosya | İçerik |
|---|---|
| `LoginDto.cs` | `LoginDto` (KullaniciAdi, Sifre), `LoginSonucDto` (id, ad, yetkiKodlari) |
| `KullaniciDto.cs` | `KullaniciGosterDto`, `KullaniciOlusturDto`, `KullaniciGuncelleDto` |
| `OtobusDto.cs` | `OtobusDto` (FirmaAdi dahil), `OtobusOlusturDto`, `OtobusKaptanDto` |

### Controller'lar (`StajWinForms_API/Controllers/`)

| Controller | Endpoint'ler |
|---|---|
| **AuthController** | `POST /api/auth/login` → şifreyi MD5'leyip karşılaştırır, kullanıcı + yetki listesi döner |
| **KullanicilarController** | `GET`, `POST`, `PUT /{id}`, `DELETE /{id}`, `GET /{id}/yetkiler`, `PUT /{id}/yetkiler` |
| **OtobuslerController** | `GET`, `POST`, `PUT /{id}`, `DELETE /{id}`, `PUT /{id}/firma` |
| **OtobusKaptanController** | `GET /{otobusId}`, `POST`, `DELETE /{id}` |
| **FirmalarController** | Mevcut `GET`'e ek olarak `POST`, `PUT /{id}`, `DELETE /{id}` eklendi. Sil: bağlı sefer veya otobüs varsa 400 döner |
| **PersonelController** | Mevcut `GET`'e ek olarak `POST`, `PUT /{id}`, `DELETE /{id}` eklendi. Sil: sefer ataması varsa 400 döner |

---

## 3. WinForms — Yeni ve Değiştirilen Dosyalar

### Program.cs (değiştirildi)

`Main()` → `Main(string[] args)` olarak değiştirildi.

```
Parametre yok  →  SeferSecimMenu (mevcut normal akış)
adminp         →  LoginForm → başarılı giriş → AdminPanelForm
```

### Yeni Dosyalar

#### `Oturum.cs`
Static sınıf. Giriş yapan kullanıcının bilgileri ve yetki kodlarını oturum boyunca tutar.
```csharp
Oturum.KullaniciId
Oturum.KullaniciAdi
Oturum.AdSoyad
Oturum.YetkiKodlari        // List<string>
Oturum.HasYetki("FIRMA")   // true/false
```

#### `LoginForm` (.cs + Designer.cs)
- Kullanıcı adı + şifre (password char `*`)
- Giriş butonuna veya Enter'a basınca `POST /api/auth/login` çağrısı
- Başarılı girişte `Oturum` statik sınıfını doldurur, `DialogResult.OK` döner
- Yanlış şifre / pasif kullanıcı → hata mesajı

#### `AdminPanelForm` (.cs + Designer.cs)
- Giriş yapan kullanıcının adını gösterir
- 7 buton: Firma Yönetimi, Otobüs Yönetimi, Firma–Otobüs Eşleme, Kaptan Yönetimi, Otobüs–Kaptan Eşleme, Kullanıcı Yönetimi, Yetki Atama
- Her buton `Oturum.HasYetki(...)` ile kontrol edilir; yetkisi olmayan kullanıcı için `Visible = false`

#### `FirmaBrowserForm` (.cs + Designer.cs) ⭐ BackgroundWorker
Firma CRUD ekranı. **BackgroundWorker** ödev gereği kullanıldı.

- `bgwVeriYukle`: DoWork → `AppConfig.Http.GetStringAsync(...).GetAwaiter().GetResult()` (BGW thread'inde senkron çağrı), RunWorkerCompleted → grid'e bağlama
- `bgwIslem`: EKLE / GUNCELLE / SIL işlemleri için ayrı BackgroundWorker
- İşlem sırasında tüm butonlar disable edilir
- Sil: firmada sefer/otobüs varsa API 400 döner, hata mesajı gösterilir
- Ekle/Değiştir: `XtraInputBox` ile tek satırlık firma adı girişi

#### `OtobusBrowserForm` (.cs + Designer.cs)
Otobüs CRUD. async/await kullanır (FirmaBrowser'dan farklı olarak ödev sadece Firma'da BGW istedi).

#### `OtobusEditForm` (.cs + Designer.cs)
Otobüs ekle/değiştir dialog formu.
- Plaka, Marka, Model, Koltuk Sayısı (SpinEdit), Firma (standart WinForms ComboBox)

#### `FirmaOtobusEslemeForm` (.cs + Designer.cs)
- Firma seç (ComboBox)
- Sol liste: firmaya atanmış otobüsler
- Sağ liste: atanmamış otobüsler
- **Ata ►** : `PUT /api/otobusler/{id}/firma`
- **◄ Kaldır** : `PUT /api/otobusler/{id}/firma` (null gönderir)

#### `KaptanBrowserForm` (.cs + Designer.cs)
Personel tablosu üzerinden kaptan CRUD. async/await kullanır.

#### `KaptanEditForm` (.cs + Designer.cs)
Kaptan ekle/değiştir dialog.
- Ad, Soyad, E-posta, Maaş (SpinEdit, decimal), İşe Giriş (DateEdit)

#### `KaptanEslemeForm` (.cs + Designer.cs)
- Otobüs seç (ComboBox)
- Sol liste: atanmış kaptanlar (OtobusKaptan tablosu)
- Sağ liste: tüm personel (atanmamışlar)
- Ata / Kaldır

#### `KullaniciYonetimForm` (.cs + Designer.cs)
Kullanıcı CRUD. Kendi hesabını silmeye izin vermez (`Oturum.KullaniciId` kontrolü).

#### `KullaniciEditForm` (.cs + Designer.cs)
- Yeni kayıtta şifre zorunlu
- Güncelleme: şifre alanı boş bırakılırsa mevcut şifre korunur (API `YeniSifre` null alır)
- Aktif CheckEdit

#### `YetkiAtamaForm` (.cs + Designer.cs)
- Sol: kullanıcı listesi (ListBoxControl)
- Sağ: CheckedListBoxControl (6 yetki)
- Kullanıcı seçilince mevcut yetkiler API'den alınır, checkbox'lar güncellenir
- Kaydet: `PUT /api/kullanicilar/{id}/yetkiler`

---

## 4. Teknik Notlar

### BackgroundWorker Kullanımı (FirmaBrowserForm)
Ödev "araştır" diye belirttiği için Firma browser'ında bilinçli olarak kullanıldı. Projenin geri kalanı async/await kullanıyor.

BGW thread'inde `HttpClient` çağrısı:
```csharp
// DoWork içinde — await kullanılamaz, .GetAwaiter().GetResult() ile senkron çekme
var json = AppConfig.Http.GetStringAsync("api/firmalar").GetAwaiter().GetResult();
```

### MD5 Güvenlik Notu
MD5 kriptografik açıdan zayıftır (rainbow table saldırılarına açık). Ödev gerektirdiği için kullanıldı. Gerçek projede `bcrypt` veya `PBKDF2` (salt ile) tercih edilmelidir.

### Şifre Akışı
```
WinForms → API (düz şifre, HTTPS üzerinden)
API → Md5Helper.Hash(sifre) → DB'deki SifreMd5 ile karşılaştırma
Şifre asla DB'den istemciye dönmez (JsonIgnore)
```

### ComboBox Seçimi
DevExpress `ComboBoxEdit.Properties.Items` yalnızca string destekler. Nesne bağlama gereken yerlerde (Firma, Otobüs seçimi) standart `System.Windows.Forms.ComboBox` kullanıldı.

---

## 5. Çalıştırma Talimatları

### SQL Script (tek seferlik)
Script zaten çalıştırıldı. Yeniden çalıştırmak gerekirse:
```
sqlcmd -S "(localdb)\mssqllocaldb" -d dbStaj -i db\adminpanel_tablolar.sql
```
> ⚠️ Yeniden çalıştırma tablo varsa hata verir. `IF NOT EXISTS` eklenebilir.

### Normal Mod (mevcut akış)
```
dotnet run --project StajWinForms
```
veya VS'den F5 (argümansız)

### Admin Panel Modu
```
dotnet run --project StajWinForms -- adminp
```
veya VS'de: **Properties → Debug → Command line arguments → `adminp`**

Giriş: `admin` / `Admin123`

---

## 6. Oluşturulan / Değiştirilen Dosyalar Listesi

```
OLUŞTURULAN:
db/adminpanel_tablolar.sql

StajWinForms_API/Models/Kullanicilar.cs
StajWinForms_API/Models/Yetkiler.cs
StajWinForms_API/Models/KullaniciYetkileri.cs
StajWinForms_API/Models/Otobusler.cs
StajWinForms_API/Models/OtobusKaptan.cs
StajWinForms_API/Helpers/Md5Helper.cs
StajWinForms_API/Dtos/LoginDto.cs
StajWinForms_API/Dtos/KullaniciDto.cs
StajWinForms_API/Dtos/OtobusDto.cs
StajWinForms_API/Controllers/AuthController.cs
StajWinForms_API/Controllers/KullanicilarController.cs
StajWinForms_API/Controllers/OtobuslerController.cs
StajWinForms_API/Controllers/OtobusKaptanController.cs

StajWinForms/Oturum.cs
StajWinForms/LoginForm.cs
StajWinForms/LoginForm.Designer.cs
StajWinForms/AdminPanelForm.cs
StajWinForms/AdminPanelForm.Designer.cs
StajWinForms/FirmaBrowserForm.cs
StajWinForms/FirmaBrowserForm.Designer.cs
StajWinForms/OtobusBrowserForm.cs
StajWinForms/OtobusBrowserForm.Designer.cs
StajWinForms/OtobusEditForm.cs
StajWinForms/OtobusEditForm.Designer.cs
StajWinForms/FirmaOtobusEslemeForm.cs
StajWinForms/FirmaOtobusEslemeForm.Designer.cs
StajWinForms/KaptanBrowserForm.cs
StajWinForms/KaptanBrowserForm.Designer.cs
StajWinForms/KaptanEditForm.cs
StajWinForms/KaptanEditForm.Designer.cs
StajWinForms/KaptanEslemeForm.cs
StajWinForms/KaptanEslemeForm.Designer.cs
StajWinForms/KullaniciYonetimForm.cs
StajWinForms/KullaniciYonetimForm.Designer.cs
StajWinForms/KullaniciEditForm.cs
StajWinForms/KullaniciEditForm.Designer.cs
StajWinForms/YetkiAtamaForm.cs
StajWinForms/YetkiAtamaForm.Designer.cs

DEĞİŞTİRİLEN:
StajWinForms_API/Models/DbStajContext.cs   (5 yeni DbSet + OnModelCreating)
StajWinForms_API/Models/Firmalar.cs        (Otobuslers nav property)
StajWinForms_API/Models/Personel.cs        (OtobusKaptanlar nav property)
StajWinForms_API/Controllers/FirmalarController.cs   (POST/PUT/DELETE eklendi)
StajWinForms_API/Controllers/PersonelController.cs   (POST/PUT/DELETE eklendi)
StajWinForms/Program.cs                    (args parametresi + adminp dalı)
```
