# StajWinForms — Otobüs Bileti Rezervasyon Sistemi

Bu proje, 3 katmandan oluşan tam bir otobüs bileti satış sistemidir:

| Katman | Proje | Teknoloji | Görev |
|---|---|---|---|
| Masaüstü | `StajWinForms` | WinForms + DevExpress | Gişe personeli arayüzü |
| Backend | `StajWinForms_API` | ASP.NET Core Web API | Veritabanı erişimi ve iş mantığı |
| Web | `StajWeb` | ASP.NET Core Razor Pages | Müşteri web arayüzü |

Hem masaüstü hem web uygulaması veritabanına **doğrudan bağlanmaz**; tüm veri işlemleri API üzerinden yapılır.

```
┌──────────────┐         ┌──────────────┐
│ StajWinForms │ HTTP    │              │  EF Core   ┌───────────┐
│  (Desktop)   ├────────►│ StajWinForms │───────────►│ SQL Server│
└──────────────┘ X-Api-  │     _API     │            │  (dbStaj) │
┌──────────────┐  Key    │  :8081       │            └───────────┘
│   StajWeb    ├────────►│              │
│ (Razor Pages)│         └──────────────┘
└──────────────┘
```

---

## 1. Veritabanı Katmanı (SQL Server + EF Core)

**Bağlantı:** `(localdb)\mssqllocaldb` üzerinde `dbStaj` veritabanı. Connection string `appsettings.json` içinde tutulur.

### Kullanılan Kavram: Entity Framework Core (Database-First)

EF Core, C# sınıfları ile veritabanı tabloları arasında köprü kuran bir **ORM** (Object-Relational Mapper). SQL yazmak yerine LINQ sorguları yazarsın, EF Core bunları SQL'e çevirir.

- **`DbStajContext`** — veritabanının C# temsili. Her tablo bir `DbSet<T>` property'si:
  ```csharp
  public virtual DbSet<Biletler> Biletlers { get; set; }
  ```
- **`OnModelCreating` (Fluent API)** — tablo adları, kolon tipleri, primary key'ler ve foreign key ilişkileri kod ile tanımlanır. Örn: `MusteriTC` kolonu 11 karakter sabit uzunlukta.
- **Navigation Property** — ilişkili tablolara property üzerinden erişim:
  ```csharp
  b.Sefer.KalkisSehir.SehirAdi   // Bilet → Sefer → Şehir (JOIN otomatik)
  ```

### Tablolar

| Tablo | İçerik |
|---|---|
| `Sehirler` | Şehir adı + plaka kodu (unique) |
| `Firmalar` | Otobüs firmaları |
| `Seferler` | Kalkış/varış şehri, zaman, fiyat, koltuk kapasitesi |
| `Musteri` | TC (unique), ad, soyad, iletişim, cinsiyet |
| `Biletler` | Sefer + koltuk no + müşteri TC + biniş/iniş durak sırası |
| `SeferDuraklar` | Seferin ara durakları (composite PK: SeferId + DurakSira) |
| `Otogarlar` / `SeferDurakOtogar` | Durakların otogar detayları |

---

## 2. StajWinForms_API (Backend)

### Kullanılan Kavram: ASP.NET Core Web API + REST

Her controller bir kaynağı (resource) temsil eder ve HTTP metodlarıyla çalışır:

```csharp
[ApiController]
[Route("api/[controller]")]      // → /api/biletler
public class BiletlerController : ControllerBase
```

### Kullanılan Kavram: Dependency Injection (DI)

`Program.cs`'de servis kaydedilir, controller constructor'ında otomatik gelir:

```csharp
builder.Services.AddDbContext<DbStajContext>(...);   // kayıt

public BiletlerController(DbStajContext context)      // enjeksiyon
{
    _context = context;
}
```

Böylece controller kendi bağımlılığını üretmez — test edilebilirlik ve gevşek bağlılık sağlanır.

### Kullanılan Kavram: DTO (Data Transfer Object)

Entity'ler (DB modelleri) doğrudan dışarı verilmez; API'nin dışarıya açtığı şekil DTO'larla tanımlanır:

- `SeferDetayDto` — sefer + firma adı + şehir adları + boş koltuk sayısı (hesaplanmış alan)
- `BiletDto` — bilet + müşteri ad soyad + sefer bilgileri (JOIN edilmiş düz veri)
- `SatinAlDto` — müşteri bilgileri + koltuk + güzergah (satın alma isteği)
- `CreateBiletDto` — mevcut müşteriye bilet kesme isteği

**Neden?** Entity'de navigation property'ler var; JSON'a çevrilirken döngüsel referans oluşur ve gereksiz/gizli veri sızar. DTO sadece gereken alanları taşır.

### Kullanılan Kavram: LINQ Projection (`Select`)

```csharp
var list = await _context.Seferlers
    .Select(s => new SeferDetayDto {
        FirmaAdi = s.Firma.FirmaAdi,
        BosKoltuk = s.KoltukKapasitesi - s.Biletlers.Count(),
        ...
    })
    .ToListAsync();
```

`Select` içindeki ifade SQL'e çevrilir — JOIN'ler ve COUNT veritabanında çalışır, sadece gereken kolonlar çekilir.

### Kullanılan Kavram: API Key Middleware

`Program.cs` içinde özel bir middleware, `/api` ile başlayan tüm isteklerde `X-Api-Key` header'ını kontrol eder:

```csharp
app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/api"))
    {
        if (!context.Request.Headers.TryGetValue("X-Api-Key", out var gelenKey)
            || gelenKey != apiKey)
        {
            context.Response.StatusCode = 401;   // Unauthorized
            return;                              // pipeline'ı kes
        }
    }
    await next();                                // sonraki adıma geç
});
```

**Middleware** = her HTTP isteğinin geçtiği zincirin bir halkası. Anahtar yanlışsa istek controller'a hiç ulaşmaz.

### Kullanılan Kavram: Transaction + Serializable Isolation

Bilet satın almada kritik senaryo: iki kişi aynı anda aynı koltuğu almaya çalışırsa?

```csharp
await using var transaction = await _context.Database
    .BeginTransactionAsync(System.Data.IsolationLevel.Serializable);
```

- **Transaction:** doluluk kontrolü + müşteri ekleme + bilet ekleme ya hep ya hiç çalışır.
- **Serializable:** en katı izolasyon seviyesi — kontrol ile insert arasına başka bir satış giremez. İkinci istek bekler, sonra `Conflict (409)` alır.
- Hata olursa `RollbackAsync()` ile her şey geri alınır.

### Kullanılan Kavram: Güzergah Bazlı Koltuk Doluluğu (Aralık Çakışması)

Bir koltuk tüm seferde değil, **belirli duraklar arasında** dolu olabilir. İki aralığın çakışma kontrolü:

```csharp
b.BinisDurakSira < dto.InisDurakSira &&
b.InisDurakSira  > dto.BinisDurakSira
```

Örnek: Mevcut bilet 1→3 duraklar arası. Yeni istek 3→5 ise çakışma yok (koltuk satılır); 2→4 ise çakışır (`409 Conflict`).

### Kullanılan Kavram: HTTP Durum Kodları

| Kod | Metod | Anlamı |
|---|---|---|
| `200 Ok` | `Ok(...)` | Başarılı |
| `400 BadRequest` | `BadRequest(...)` | Geçersiz istek (müşteri/sefer yok) |
| `401 Unauthorized` | middleware | API anahtarı hatalı |
| `404 NotFound` | `NotFound(...)` | Kayıt bulunamadı |
| `409 Conflict` | `Conflict(...)` | Koltuk dolu |
| `500` | `StatusCode(500, ...)` | Sunucu hatası |

### Kullanılan Kavram: OpenAPI + Scalar

```csharp
builder.Services.AddOpenApi();
app.MapScalarApiReference();   // geliştirme ortamında API dokümantasyon arayüzü
```

Scalar, Swagger benzeri interaktif API test/dokümantasyon sayfası sunar.

### API Endpoint Özeti

| Metod | URL | İş |
|---|---|---|
| GET | `/api/seferdetay` | Tüm seferler (detaylı) |
| GET | `/api/seferdetay/{id}` | Tek sefer + durak listesi |
| GET | `/api/seferler` | Ham sefer listesi (ID bazlı) |
| GET | `/api/sehirler` | Şehir listesi |
| GET | `/api/seferduraklar/{seferId}` | Seferin durakları (sıralı) |
| GET | `/api/biletler` | Tüm biletler |
| GET | `/api/biletler/{seferId}` | Seferin biletleri |
| GET | `/api/biletler/musteri/{tc}` | Müşterinin biletleri |
| POST | `/api/biletler` | Kayıtlı müşteriye bilet |
| POST | `/api/biletler/satinal` | Müşteri kaydı + bilet (transaction) |
| DELETE | `/api/biletler/{biletId}` | Bilet iptali |

---

## 3. StajWinForms (Masaüstü Uygulama)

### Kullanılan Kavram: DevExpress WinForms

Standart WinForms kontrolleri yerine DevExpress bileşenleri kullanılmış:

- `XtraForm` — tema destekli form taban sınıfı
- `SimpleButton`, `LabelControl`, `TextEdit`, `LookUpEdit`, `GridControl`, `PictureEdit`
- Tema: `Office 2019 Colorful` (`UserLookAndFeel.Default.SetSkinStyle`)

### Kullanılan Kavram: Merkezi Konfigürasyon + Tek HttpClient

`Program.cs` içindeki `AppConfig` sınıfı:

```csharp
private static readonly Lazy<HttpClient> _http = new(() =>
{
    var client = new HttpClient { BaseAddress = new Uri(ApiBaseUrl) };
    client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);
    return client;
});
public static HttpClient Http => _http.Value;
```

- **`Lazy<T>`** — nesne ilk erişimde bir kez oluşturulur (lazy initialization).
- **Tek `HttpClient`** — her istekte yeni client açmak socket tükenmesine yol açar; singleton pattern bunu önler.
- **`ConfigurationBuilder`** — `appsettings.json`'dan `ApiBaseUrl` ve `ApiKey` okunur (WinForms'ta varsayılan olmayan bir yapı, elle eklenmiş).

### Form Akışı

```
SeferSecimMenu (şehir + tarih seç)
   └─► AnaMenu (sefer listesi — GridControl)
         ├─► SeferDetay (salt okunur detay + duraklar)
         └─► SecimEkrani (koltuk haritası + biniş/iniş durağı)
               └─► CokluMusteriKaydi (seçilen her koltuk için form)
                     └─► MusteriKaydiControl × N (UserControl)
   AnaMenu ├─► BiletSorgula (TC ile listeleme)
           └─► BiletIptal (TC ile listele + seçileni sil)
```

### Kullanılan Kavram: UserControl ile Yeniden Kullanılabilir Form Parçası

`MusteriKaydiControl` bir `XtraUserControl` — müşteri bilgi alanlarını (TC, ad, soyad, ...) tek pakette toplar. `CokluMusteriKaydi` formu, seçilen **her koltuk için bu kontrolden bir tane** oluşturup kaydırılabilir panele dizer:

```csharp
foreach (var koltukNo in koltuklar)
{
    var control = new MusteriKaydiControl(seferId, koltukNo, binisSira, inisSira);
    control.Location = new Point(10, yOffset);
    panel.Controls.Add(control);
    yOffset += control.Height + 10;
}
```

Böylece 3 koltuk seçilirse 3 ayrı pencere yerine **tek pencerede 3 form bölümü** açılır. Her kontrol kendi `Dogrula()` (validasyon) ve `GetModel()` (veri toplama) metodunu sunar.

### Kullanılan Kavram: Dinamik Kontrol Bulma (LINQ + Reflection benzeri yaklaşım)

`SecimEkrani`, 36 koltuk butonunu tek tek elle numaralandırmak yerine ekran koordinatına göre sıralayıp numara verir:

```csharp
var siraliButonlar = this.Controls.OfType<SimpleButton>()
    .Where(btn => btn.Name != "btnKoltukSec")
    .OrderBy(btn => btn.Location.X)
    .ThenBy(btn => btn.Location.Y)
    .ToList();
```

Ayrıca tüm koltuk butonlarına **tek ortak event handler** bağlanır (`KoltukButonu_Click`) — 36 ayrı metod yerine `sender` üzerinden hangi buton olduğu anlaşılır.

### Kullanılan Kavram: Çoklu Koltuk Seçimi (Toggle Pattern)

```csharp
if (_secilenKoltuklar.Contains(no))
{
    _secilenKoltuklar.Remove(no);          // seçimi kaldır → yeşil
    KoltukRenkAyarla(btn, Color.LightGreen, false);
}
else
{
    _secilenKoltuklar.Add(no);             // seç → sarı
    KoltukRenkAyarla(btn, Color.Yellow, false);
}
```

Renk kodu: **yeşil** = boş, **mavi** = erkek dolu, **pembe** = kadın dolu, **sarı** = seçili.

### Kullanılan Kavram: async/await ile UI Kilitlenmesini Önleme

Tüm API çağrıları `async` — `await _http.GetStringAsync(...)` sırasında UI donmaz. Event handler'lar `async void`, iç metodlar `async Task` olarak tanımlı.

### Kullanılan Kavram: Regex ile Girdi Filtreleme

TC ve telefon alanlarına sadece rakam girilebilir:

```csharp
if (Regex.IsMatch(txtboxTC.Text, "[^0-9]"))
    txtboxTC.Text = Regex.Replace(txtboxTC.Text, "[^0-9]", "");
```

`[^0-9]` = rakam olmayan karakter. Yapıştırma dahil her değişiklikte temizlenir; imleç pozisyonu `MaskBoxSelectionStart` ile korunur.

### Validasyon Kuralları (Dogrula)

1. Tüm alanlar dolu olmalı
2. TC: tam 11 hane, `0` ile başlayamaz
3. Telefon: `0` ile başlamalı (11 hane, MaxLength ile sınırlı)

### Kullanılan Kavram: QuestPDF ile PDF Bilet

`MusteriKaydi` formu satış sonrası **fluent API** ile PDF bilet üretir:

```csharp
Document.Create(doc => {
    doc.Page(page => {
        page.Size(PageSizes.A5.Landscape());
        page.Header()...    // "OTOBÜS BİLETİ" başlığı
        page.Content()...   // yolcu bilgileri tablosu
        page.Footer()...    // sefer no + tarih
    });
}).GeneratePdf(dosyaYolu);
Process.Start(new ProcessStartInfo(dosyaYolu) { UseShellExecute = true });
```

PDF, temp klasörüne yazılır ve varsayılan PDF görüntüleyici ile otomatik açılır. (Lisans: `LicenseType.Community` — ücretsiz kullanım.)

### Kullanılan Kavram: Form İletişimi (Constructor Injection + FormClosed Event)

Formlar arası veri **constructor parametresiyle** taşınır:

```csharp
var form = new CokluMusteriKaydi(_secilenKoltuklar, _seferID, binisSira, inisSira);
form.FormClosed += async (s, args) => await KoltuklariRenklendir();  // dönünce yenile
form.Show();
```

Satış tamamlanınca koltuk haritası otomatik güncellenir.

---

## 4. StajWeb (Web Uygulaması)

### Kullanılan Kavram: Razor Pages

MVC'nin sayfa odaklı alternatifi. Her sayfa iki dosyadan oluşur:

- **`.cshtml`** — Razor görünümü (HTML + C#)
- **`.cshtml.cs`** — PageModel (code-behind): `OnGet()`, `OnPostAsync()` handler'ları

```
@page "{id:int}"        ← route tanımı + kısıt (id sayı olmalı)
@model SeferDetayModel  ← bu sayfanın PageModel'i
```

### Sayfa Akışı

```
Index (şehir + tarih ara)
  └─► Seferler?kalkisId=X&varisId=Y&tarih=Z (kart listesi)
        └─► SeferDetay/{id} (koltuk haritası, JS multiselect)
              └─► Satinal?seferId=X&koltuklar=1,5,9 (koltuk başına form)
                    └─► POST → API → Index'e yönlendir
Navbar ─► BiletSorgula (TC ile listele)
            └─► BiletIptal?biletId=N (onay ekranı → DELETE)
```

### Kullanılan Kavram: IHttpClientFactory (Named Client)

WinForms'taki elle singleton yerine, ASP.NET Core'un fabrika deseni:

```csharp
// Program.cs — bir kez tanımla
builder.Services.AddHttpClient("API", client =>
{
    client.BaseAddress = new Uri("http://localhost:8081/");
    client.DefaultRequestHeaders.Add("X-Api-Key", "staj-2026-gizli-anahtar");
});

// PageModel — DI ile al, isimle üret
var client = _clientFactory.CreateClient("API");
Sefer = await client.GetFromJsonAsync<SeferDetay>($"/api/seferdetay/{Id}");
```

Factory, socket ömrünü ve DNS yenilemeyi kendisi yönetir.

### Kullanılan Kavram: Model Binding

Form ve query string verileri otomatik olarak C# property'lerine bağlanır:

```csharp
[BindProperty(SupportsGet = true)] public int SeferId { get; set; }
```

- `[BindProperty]` — POST verisini bağlar
- `SupportsGet = true` — query string'den de bağlar (`?seferId=5`)
- Route parametresi: `@page "{id:int}"` → `public int Id` otomatik dolar

### Kullanılan Kavram: Indexed Model Binding (Liste Bağlama)

Çoklu yolcu formunun anahtarı — input isimleri dizi indeksiyle yazılır:

```html
<input name="Yolcular[0].MusteriTc" />
<input name="Yolcular[1].MusteriTc" />
```

Razor'da döngüyle üretilir:

```cshtml
@for (int i = 0; i < Model.KoltukList.Count; i++)
{
    <input name="Yolcular[@i].MusteriTc" ... />
}
```

POST geldiğinde ASP.NET Core bunları otomatik `List<YolcuDto> Yolcular`'a doldurur. PageModel'de her yolcu için ayrı API isteği atılır:

```csharp
for (int i = 0; i < KoltukList.Count; i++)
{
    var yolcu = Yolcular[i];
    var response = await client.PostAsJsonAsync("/api/biletler/satinal", new { SeferId, KoltukNo = KoltukList[i], yolcu.MusteriTc, ... });
    if (response.StatusCode == HttpStatusCode.Conflict) return Page();
}
return RedirectToPage("/Index");
```

### Kullanılan Kavram: SelectList ile Dropdown Doldurma

```csharp
SehirListesi = new SelectList(Sehirler, "SehirId", "SehirAdi");
```
```html
<select name="kalkisId" asp-items="Model.SehirListesi">
```

`asp-items` (tag helper), listeyi `<option value="SehirId">SehirAdi</option>` olarak üretir.

### Kullanılan Kavram: JavaScript Multiselect (Koltuk Seçimi)

Web'de koltuk seçimi tarayıcıda tutulur, sayfa yenilenmez:

```javascript
const secilenKoltuklar = [];

function koltukSec(btn, koltukNo) {
    const idx = secilenKoltuklar.indexOf(koltukNo);
    if (idx == -1) {
        secilenKoltuklar.push(koltukNo);      // seç → sarı
        btn.style.background = '#ffc107';
    } else {
        secilenKoltuklar.splice(idx, 1);      // kaldır → yeşil
        btn.style.background = '#28a745';
    }
}

function devamEt() {
    window.location = '/Satinal?seferId=@Model.Id&koltuklar=' + secilenKoltuklar.join(',');
}
```

Seçimler `koltuklar=1,5,9` şeklinde query string ile taşınır; Satinal sayfası `Split(',')` ile geri parse eder.

### Kullanılan Kavram: Razor'da Sunucu Taraflı Koltuk Haritası

36 koltuk (9 sütun × 4 sıra, ortada koridor) döngüyle çizilir; dolu koltuklar cinsiyete göre renklendirilip `disabled` yapılır:

```cshtml
var alinmisKoltuklar = Model.Biletler.ToDictionary(b => b.KoltukNo, b => b.Cinsiyet);
...
int koltukNo = c * 4 + r + 1;   // sütun bazlı numaralama
if (cinsiyet == "E") { <button class="seat male" disabled>@koltukNo</button> }
else if (cinsiyet == "K") { <button class="seat female" disabled>@koltukNo</button> }
else { <button class="seat available" onclick="koltukSec(this, @koltukNo)">@koltukNo</button> }
```

Otobüs gövdesi, şoför koltuğu ve direksiyon tamamen **CSS flexbox** ile çizilmiştir (resim yok).

### Kullanılan Kavram: Bootstrap 5

Tasarım hazır Bootstrap sınıflarıyla yapıldı:

- `card`, `card-body`, `shadow` — kart görünümü (arama kutusu, sefer listesi, yolcu formları)
- `form-control`, `form-select`, `input-group` — form elemanları
- `btn btn-primary / btn-danger` — butonlar
- `d-flex`, `justify-content-between`, `row g-3`, `col-md-6` — grid/flex yerleşim
- `table table-bordered table-hover` — bilet tablosu
- `alert alert-warning` — "sefer bulunamadı" mesajı

### Kullanılan Kavram: PRG Deseni (Post/Redirect/Get)

Satın alma ve iptal işlemlerinden sonra `RedirectToPage(...)` çağrılır — böylece kullanıcı F5'e basınca form tekrar POST edilmez (çift bilet kesilmez).

---

## 5. Ortak Desenler ve Güvenlik

| Konu | Uygulama |
|---|---|
| **API Anahtarı** | Her iki istemci de `X-Api-Key: staj-2026-gizli-anahtar` header'ı gönderir; API middleware'de doğrular |
| **Config dışsallaştırma** | URL ve anahtar kod içinde değil `appsettings.json`'da (WinForms tarafında) |
| **Aynı validasyon iki yerde** | TC/telefon kuralları hem WinForms (`Dogrula`) hem web (`required`, `maxlength`) tarafında |
| **Conflict yönetimi** | API `409` döner; WinForms MessageBox gösterir, web sayfada kalır |
| **Türkçe UI** | Tüm kullanıcı mesajları Türkçe |

---

## 6. Kullanılan Paketler

### StajWinForms_API
| Paket | Amaç |
|---|---|
| `Microsoft.EntityFrameworkCore.SqlServer` | SQL Server ORM |
| `Microsoft.EntityFrameworkCore.Tools/Design` | Scaffold/migration araçları |
| `Microsoft.AspNetCore.OpenApi` | OpenAPI şema üretimi |
| `Scalar.AspNetCore` | API dokümantasyon arayüzü |

### StajWinForms
| Paket | Amaç |
|---|---|
| `DevExpress.Win.*` (26.1.3) | UI bileşenleri (Grid, Navigation, Editors) |
| `QuestPDF` | PDF bilet üretimi |
| `Microsoft.Extensions.Configuration` | appsettings.json okuma |

### StajWeb
Ek paket yok — yalnızca ASP.NET Core'un yerleşik özellikleri (Razor Pages, HttpClientFactory) + Bootstrap/jQuery (statik dosya).

---

## 7. Çalıştırma

1. **API:** `StajWinForms_API` projesini başlat → `http://localhost:8081`
   (LocalDB'de `dbStaj` veritabanı hazır olmalı)
2. **Masaüstü:** `StajWinForms` projesini başlat
3. **Web:** `StajWeb` projesini başlat → tarayıcıda aç

> Not: API anahtarı veya port değişirse `StajWinForms/appsettings.json` ve `StajWeb/Program.cs` güncellenmelidir.
