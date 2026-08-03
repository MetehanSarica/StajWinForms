# StajWinForms — İyileştirme Planı

Otobüs bilet sistemi (WinForms istemci + ASP.NET Core 10 API) için kod incelemesi sonucu hazırlanmış iyileştirme planı.

---

## 1. KRİTİK — Hemen Düzeltilmeli

### 1.1 Telefon doğrulama hatası (BUG)
- **Dosya:** `StajWinForms/MusteriKaydiControl.cs` (satır ~66)
- `MusteriKaydi.cs` telefonu 11 hane kontrol ediyor, `MusteriKaydiControl.cs` ise 10 hane kontrol ediyor ama hata mesajı "11 haneli" diyor.
- **Çözüm:** İki yerde de aynı kural: `telefon.Length == 11 && telefon[0] == '0'`

### 1.2 Gizli bilgiler versiyon kontrolünde
- **Dosyalar:** Her iki projedeki `appsettings.json`
- API anahtarı (`staj-2026-gizli-anahtar`) ve connection string commit edilmiş durumda.
- **Çözüm:** `dotnet user-secrets` kullan veya `appsettings.Local.json` oluşturup `.gitignore`'a ekle. Staj projesi için en azından bu yaklaşımı göstermek artı puan olur.

### 1.3 API anahtarı karşılaştırması timing-safe değil
- **Dosya:** `StajWinForms_API/Program.cs` (satır 32)
- `gelenKey != apiKey` düz string karşılaştırması timing attack'a açık.
- **Çözüm:** `CryptographicOperations.FixedTimeEquals()` kullan.

### 1.4 Müşteri verileri korumasız
- **Dosya:** `StajWinForms_API/Controllers/MusteriController.cs` (satır 21)
- `GetMusteri()` tüm müşterileri (TC, e-posta, adres dahil) filtresiz döndürüyor.
- **Çözüm:** Bu endpoint gerçekten gerekli mi değerlendir; gerekiyorsa DTO ile alan kısıtla, sayfalama ekle.

---

## 2. YÜKSEK — Kısa Vadede

### 2.1 Entity'ler doğrudan döndürülüyor (DTO eksik)
Şu controller'lar EF entity'lerini doğrudan döndürüyor:
- `PersonelController` → `Personel` (maaş bilgisi dahil dışarı açılıyor!)
- `MusteriController` → `Musteri`
- `FirmalarController` → `Firmalar`
- `SehirlerController` → `Sehirler`
- `SeferDuraklarController` → `SeferDuraklar`

**Çözüm:** Her biri için DTO oluştur (`SeferDetayController` ve `BiletlerController`'daki gibi). Özellikle `Personel.Maas` alanının API'den dışarı sızması ciddi sorun.

### 2.2 N+1 / verimsiz sorgular
- **Dosya:** `StajWinForms_API/Controllers/SeferDetayController.cs`
- `BosKoltuk = s.KoltukKapasitesi - s.Biletlers.Count()` — her sefer için ayrı count sorgusu üretebilir.
- **Çözüm:** Sorguların ürettiği SQL'i logla ve kontrol et; gerekirse projection'ı optimize et.

### 2.3 WinForms'ta ortak API servis katmanı yok
Her form kendi HTTP çağrısını, kendi `JsonSerializerOptions`'ını, kendi endpoint string'ini tanımlıyor.

**Çözüm:** Tek bir `ApiService` sınıfı oluştur:
```csharp
public static class ApiService
{
    public static Task<List<SeferDetayModel>> GetSeferDetaylar() => ...;
    public static Task<List<SehirModel>> GetSehirler() => ...;
    // vb.
}
```
- Endpoint string'leri tek yerde toplanır
- `JsonSerializerOptions` tek yerde tanımlanır (5 formda tekrarlanıyor)

### 2.4 Doğrulama mantığı 4 yerde tekrarlanıyor
TC doğrulaması: `MusteriKaydi.cs`, `MusteriKaydiControl.cs`, `BiletSorgula.cs`, `BiletIptal.cs`

**Çözüm:** Statik bir `Dogrulama` yardımcı sınıfı:
```csharp
public static class Dogrulama
{
    public static bool TcGecerliMi(string tc) => tc.Length == 11 && tc[0] != '0' && tc.All(char.IsDigit);
    public static bool TelefonGecerliMi(string tel) => tel.Length == 11 && tel[0] == '0';
}
```

### 2.5 Sunucu tarafı doğrulama yok
API'de hiçbir DTO'da `DataAnnotations` yok. İstemci atlanırsa geçersiz veri (13 haneli TC vb.) veritabanına yazılabilir.

**Çözüm:** DTO'lara attribute ekle:
```csharp
[Required, StringLength(11, MinimumLength = 11)]
[RegularExpression(@"^[1-9]\d{10}$")]
public string Tc { get; set; }
```

### 2.6 Model sınıfları formlar arasında kopyalanmış
`SeferDetayModel` (AnaMenu), `BiletApiModel` (SecimEkrani), `BiletSorgulaModel` (BiletSorgula + BiletIptal), `SehirlerModel` (SeferSecimMenu)...

**Çözüm:** WinForms projesinde `Models/` klasörü altında tek kopya tut, tüm formlar oradan kullansın.

---

## 3. ORTA — Zaman Kaldıkça

### 3.1 Sessiz hata yutma
- `MusteriKaydiControl.cs` şehir yükleme hatasında kullanıcıya bilgi vermiyor / fire-and-forget (`_ = SehirleriYukle()`) hataları kayboluyor.
- **Çözüm:** En azından combobox'a "Yüklenemedi" durumu ekle veya hata olduğunda formu kapat.

### 3.2 Loglama yok
- Hem API hem istemci tarafında hata logu tutulmuyor; tek geri bildirim MessageBox.
- **Çözüm:** API tarafında built-in `ILogger` zaten mevcut — controller'lara enjekte edip hataları logla. İstemcide basit bir dosya logu yeterli.

### 3.3 API'de iş mantığı controller'larda
- `BiletlerController.SatinAlBilet` içinde müşteri oluşturma + koltuk kontrolü + transaction yönetimi hepsi bir arada (~50 satır).
- **Çözüm:** Staj projesi ölçeğinde ağır bir katman gerekmez ama en azından `BiletSatisService` gibi tek bir servis sınıfına taşımak okunabilirliği artırır.

### 3.4 PDF açma UI'ı bloke edebilir
- `MusteriKaydi.cs` satır ~222: `Process.Start()` 
- **Çözüm:** `Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });`

### 3.5 Magic number/renkler
- Koltuk renkleri (`LightBlue`, `LightPink`, `LightGreen`, `Yellow`) SecimEkrani içinde dağınık.
- **Çözüm:** Sınıf başında `const`/`static readonly` alanlar olarak topla, isimlendir (`RenkDoluErkek`, `RenkSecili` vb.).

---

## 4. DÜŞÜK — İsteğe Bağlı

| Konu | Açıklama |
|------|----------|
| Unit test | Doğrulama ve koltuk seçim mantığı için basit xUnit projesi — stajda artı puan |
| Retry mekanizması | HTTP çağrılarına 1-2 tekrar denemesi (Polly veya basit döngü) |
| Rate limiting | API'ye `AddRateLimiter` (built-in, .NET 7+) |
| XML yorumlar | Public API metodlarına `///` özet satırları |
| appsettings.Development.json | Ortam bazlı yapılandırma ayrımı |

---

## Önerilen Uygulama Sırası

1. **Gün 1:** 1.1 telefon bug'ı → 2.4 Dogrulama sınıfı (bug'ı kökten çözer) → 1.3 timing-safe karşılaştırma
2. **Gün 2:** 2.1 DTO'lar (öncelik: Personel — maaş sızıyor) → 2.5 sunucu tarafı doğrulama
3. **Gün 3:** 2.3 ApiService + 2.6 ortak model sınıfları (birlikte yapılmalı)
4. **Gün 4:** 1.2 secrets taşıma → 3.x maddeleri
5. **Kalan zaman:** 4.x maddeleri

---

*Bu plan 2026-07-14 tarihli kod incelemesine dayanmaktadır.*
