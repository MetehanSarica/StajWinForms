# WinForms Mimari Analiz Raporu

**Proje:** StajWinForms — Otobüs Bileti Satış Sistemi
**Analiz Tarihi:** 10.07.2026
**Kapsam:** `StajWinForms` (WinForms İstemci) + `StajWinForms_API` (ASP.NET Core Web API)

---

## 1. Genel Mimari Bakış

Çözüm iki projeden oluşmaktadır:

| Proje | Teknoloji | Sorumluluk |
|---|---|---|
| `StajWinForms` | .NET 10 (net10.0-windows), DevExpress 26.1, QuestPDF | Sunum katmanı (bilet arama, koltuk seçimi, satın alma, iptal, PDF bilet) |
| `StajWinForms_API` | ASP.NET Core Web API, EF Core 10, SQL Server | Veri erişimi ve iş kuralları (Controller + DTO + Model) |

İstemci, veritabanına doğrudan erişmek yerine `HttpClient` üzerinden REST API tüketmektedir. Bu **doğru bir katmanlama kararıdır** ve projenin en güçlü mimari yönüdür. Form akışı:

```
SeferSecimMenu → AnaMenu (sefer listesi) → SecimEkrani (koltuk) → MusteriKaydi (satın alma + PDF)
                        ↘ SeferDetay / BiletSorgula / BiletIptal
```

Mevcut desen klasik **code-behind (Smart UI)** yaklaşımıdır: tüm iş mantığı, doğrulama, HTTP çağrıları ve UI güncellemeleri form sınıflarının event handler'ları içindedir. Ayrı bir servis/iş katmanı yoktur.

---

## 2. Teknik İnceleme

### 2.1. Asenkron Yapı (async/await, Task)

**Doğru yapılanlar:**
- Tüm HTTP çağrıları `async/await` ile yapılmış; `.Result` / `.Wait()` gibi **deadlock'a yol açacak senkron bloklama hiç yok**. Bu, WinForms projelerinde en sık yapılan hatadan kaçınıldığını gösterir.
- API tarafında tüm EF Core sorguları `ToListAsync`, `SaveChangesAsync` gibi asenkron karşılıklarıyla kullanılmış.
- `SatinAlBilet` endpoint'inde `await using var transaction` ile asenkron transaction yönetimi doğru kurgulanmış.

**Riskli noktalar:**

1. **Korumasız `async void` handler'lar.** `async void` event handler'larda kullanılabilir; ancak içinde yakalanmayan bir exception **uygulamayı çökertir**:
   - `SeferSecimMenu_Load` (SeferSecimMenu.cs:21) — `SehirleriYukle()` try-catch olmadan bekleniyor. API kapalıysa uygulama açılışta çöker.
   - `cmbBinis_EditValueChanged` / `cmbInis_EditValueChanged` (SecimEkrani.cs:62, 81) — `KoltuklariRenklendir()` ağ çağrısı yapıyor, hata yakalanmıyor.
   - `SecimEkrani.cs:206` — `FormClosed += async (s, args) => ...` içindeki `KoltuklariRenklendir()` da korumasız bir **async void lambda**dır.

2. **Fire-and-forget çağrı.** `BiletIptal.cs:66`'da `btnSorgula_Click(sender, e)` doğrudan metot olarak çağrılıyor. Bu bir `async void` olduğu için beklenemez; tamamlanması garanti edilmez ve exception'ı izlenemez. Sorgulama mantığı `private async Task BiletleriYukle()` gibi bir metoda çıkarılıp her iki yerden `await` edilmelidir.

3. **`CancellationToken` yok.** Form kapatıldığında devam eden HTTP çağrıları iptal edilmiyor. Yanıt geldiğinde dispose edilmiş kontrollere erişim (`ObjectDisposedException`) riski vardır.

4. **`HttpClient.Timeout` ayarlanmamış.** Varsayılan 100 sn; API yanıt vermezse UI event handler'ı 100 saniye askıda bekler.

### 2.2. Kaynak Yönetimi, IDisposable ve GDI+ Riskleri

1. **`ShowDialog()` sonrası `Dispose` eksik (GDI+ handle sızıntısı).** WinForms'ta `Show()` ile açılan formlar kapanınca otomatik dispose edilir; ancak **`ShowDialog()` ile açılan formlar edilmez**. Aşağıdaki tüm noktalar her açılışta form + DevExpress kontrollerinin GDI handle'larını sızdırır:
   - `AnaMenu.cs:70-71, 76-77, 84-85, 103-104, 111-112`
   - `SeferSecimMenu.cs:34-38, 43-44`

   Düzeltme kalıbı:
   ```csharp
   using (var secimEkrani = new SecimEkrani(seferID))
       secimEkrani.ShowDialog();
   ```
   Yoğun kullanımda (gişe senaryosu) bu sızıntı zamanla "Error creating window handle" (10.000 GDI nesnesi limiti) hatasına dönüşür.

2. **Statik `HttpClient` kullanımı doğru, ama 6 kez kopyalanmış.** Her form kendi `private static readonly HttpClient _http` alanını tanımlıyor (AnaMenu, SecimEkrani, MusteriKaydi, BiletIptal, BiletSorgula, SeferSecimMenu). Socket tükenmesi yaratmaz (statik oldukları için) fakat DRY ihlalidir ve timeout/header gibi ortak yapılandırmayı imkânsızlaştırır. Tek bir merkezi `ApiClient` sınıfına taşınmalıdır.

3. **Event abonelikleri.** `KoltukButonu_Click` abonelikleri (SecimEkrani.cs:57) form ömrüyle sınırlı olduğundan sızıntı yaratmaz. `MusteriKaydi.FormClosed` lambda'sı (SecimEkrani.cs:206) ebeveyn formu yakalar; ancak çocuk form kapanınca referans koptuğu için kabul edilebilir. Yine de kural olarak uzun ömürlü nesnelere abone olunan handler'lar `FormClosed`/`Dispose` içinde `-=` ile sonlandırılmalıdır — şu an bu disiplin kodda görünmüyor.

4. **PDF üretimi UI thread'inde.** `BiletPdfOlustur()` (MusteriKaydi.cs:140) senkron çalışır; QuestPDF render süresi boyunca UI donar. `await Task.Run(...)` ile arka plana alınmalıdır.

### 2.3. Formlar Arası Veri Transferi ve Bağımlılık Yönetimi

**Olumlu:** Veri aktarımı **constructor injection** ile yapılıyor (`new SecimEkrani(seferID)`, `new MusteriKaydi(seferID, koltukNo, binisSira, inisSira)`), `readonly` alanlarda saklanıyor. Public property üzerinden gevşek aktarım veya global state kullanılmamış — bu temiz bir yaklaşımdır.

**Sorunlar:**

1. **DTO/model sınıfları form dosyalarının içine gömülü ve kopyalanmış.** `SeferDetayModel` (AnaMenu.cs), `BiletApiModel`, `SeferDurakApiModel` (SecimEkrani.cs), `SatinAlModel` (MusteriKaydi.cs), `SehirlerModel` (SeferSecimMenu.cs), `BiletSorgulaModel` (BiletSorgula.cs) hep aynı API sözleşmesinin parçalarıdır. `BiletIptal`, başka bir formun dosyasında tanımlı `BiletSorgulaModel`'e bağımlıdır — **formlar arası gizli bağımlılık**. Tüm modeller ortak bir `Models/` klasörüne (ideali: API ile paylaşılan bir `Shared` class library) taşınmalıdır.

2. **Geri bildirim kanalı olarak `FormClosed` sayacı.** SecimEkrani.cs:199-210'daki `acikFormSayisi` dekremanı kırılgandır: kullanıcı `MusteriKaydi` formunu satın almadan kapatsa da sayaç düşer; satın almanın başarılı olup olmadığı bilinmez. Doğrusu, `MusteriKaydi`'nin `public bool SatinAlindi { get; private set; }` gibi bir sonuç sunması veya bir event yayınlamasıdır.

3. **Çalışma zamanında kontrol adı değiştirme.** `KoltuklariNumaralandir()` (SecimEkrani.cs:44-60) butonların `Name` özelliğini `koltuk1..N` olarak yeniden yazıp koltuk numarasını `btn.Text`'ten `int.Parse` ile geri okuyor. UI metni ile veri modelinin birleştirilmesi kırılgandır; koltuk numarası `btn.Tag`'de tutulmalıdır.

---

## 3. Tespit Edilen Eksiklikler ve Riskler

### 3.1. Kritik — İş Kuralı ve Veri Bütünlüğü

| # | Bulgu | Konum | Etki |
|---|---|---|---|
| K1 | **Çifte satış (race condition):** `SatinAlBilet` endpoint'i koltuğun dolu olup olmadığını **hiç kontrol etmiyor**. İki gişe aynı koltuğu aynı anda satabilir. | BiletlerController.cs:120-163 | Aynı koltuğa iki bilet |
| K2 | **`BosKoltuk` hiç güncellenmiyor:** Bilet satışı/iptali `Seferler.BosKoltuk` değerini değiştirmiyor; listelerdeki boş koltuk sayısı gerçeği yansıtmaz. | BiletlerController.cs | Yanıltıcı veri |
| K3 | **Veritabanı bağlantı dizesi istemcide:** `StajWinForms/appsettings.json` DB connection string içeriyor ve `DbConfig.cs` bunu okuyor — fakat **hiçbir yerde kullanılmıyor** (ölü kod). İstemciye dağıtılan DB kimlik bilgisi güvenlik açığıdır; `DbConfig.cs`, connection string ve kullanılmayan `Microsoft.Data.SqlClient` paketi kaldırılmalıdır. | DbConfig.cs, appsettings.json, csproj | Güvenlik |
| K4 | **API'de kimlik doğrulama yok:** `UseAuthorization` var ama authentication tanımlı değil; tüm endpoint'ler (bilet silme dahil) anonim erişime açık. TC ile bilet sorgulama uç noktası kişisel veri (KVKK) sızdırma riski taşır. | API Program.cs | Güvenlik/KVKK |

### 3.2. Yüksek — Sağlamlık (Robustness)

- **Sessiz yutulan exception:** `SatinAlBilet`'in `catch` bloğu (BiletlerController.cs:158-162) hatayı loglamadan 500 döner. API genelinde `ILogger` kullanımı ve global exception middleware yoktur.
- **HTTP durum kodu kontrolsüz deserializasyon:** `BiletSorgula.cs:28-29` ve `BiletIptal.cs:29-30`'da `GetAsync` sonrası `EnsureSuccessStatusCode()` çağrılmadan `ReadFromJsonAsync` yapılıyor; 404/500 gövdesi JSON parse hatası olarak kullanıcıya "veri işleme hatası" diye yansır.
- **DTO validasyonu yok:** `SatinAlDto` üzerinde `[Required]`, `[StringLength(11)]` gibi hiçbir attribute yok; API, istemci validasyonuna güveniyor. Validasyon **her zaman** sunucuda da yapılmalıdır.
- **Genel `catch (Exception)` ile kaba hata mesajları:** İstemcide `ex.Message` doğrudan kullanıcıya gösteriliyor (AnaMenu.cs:62).
- **HTTPS uyumsuzluğu:** İstemci `http://localhost:8081`'e bağlanırken API `UseHttpsRedirection` kullanıyor; her istek ekstra bir redirect turu yer, POST senaryolarında sürüm/handler davranışına göre kırılganlık yaratır.

### 3.3. Orta — Kod Kalitesi ("Spaghetti" Belirtileri)

- **Kopyala-yapıştır projeksiyonlar:** `BiletlerController`'daki üç GET endpoint'i aynı 14 satırlık `BiletDto` select ifadesini tekrarlıyor. Ortak bir `static Expression<Func<Biletler, BiletDto>>` ile tekilleştirilmelidir.
- **Kopyala-yapıştır TC/telefon maskeleme:** `txtboxTC_TextChanged` regex temizliği üç formda birebir aynı (MusteriKaydi, BiletSorgula, BiletIptal). Ortak bir extension/behavior sınıfına alınmalı; ayrıca `MaxLength` ataması her tuş vuruşunda değil, tasarım zamanında bir kez yapılmalıdır.
- **Zayıf validasyon:** TC için yalnızca uzunluk + ilk hane kontrolü var; standart TC kimlik algoritması (checksum) uygulanmıyor. E-posta formatı hiç doğrulanmıyor. Cinsiyet, `SelectedItem.ToString().Substring(0,1)` ile türetiliyor (MusteriKaydi.cs:87) — combo içeriği değişirse sessizce bozulur.
- **İstemci tarafı filtreleme:** `DoluKoltuklariGetir` (SecimEkrani.cs:164) seferin **tüm** biletlerini indirip bellekte filtreliyor; durak aralığı filtresi API'ye query parametresi olarak taşınmalıdır. Benzer şekilde `AnaMenu` tüm seferleri çekip bellekte filtreliyor.
- **Ölü kod:** `AnaMenu._filtreZaman` hiçbir constructor'da set edilmiyor (her zaman null); `cmbCinsiyet_SelectedIndexChanged` boş; `DbConfig` kullanılmıyor; `using static System.Net.WebRequestMethods` gereksiz.
- **Dosya kodlaması bozuk:** SeferSecimMenu.cs:30'da Türkçe karakterler bozulmuş (`"L�tfen kalk�� ve var�� �ehirlerini se�in."`) — dosya UTF-8 (BOM'lu) olarak kaydedilmelidir.
- **PDF dosya adı kullanıcı girdisinden üretiliyor** (MusteriKaydi.cs:142): Ad alanına girilebilecek geçersiz dosya adı karakterleri `GeneratePdf`'i patlatır; `Path.GetInvalidFileNameChars()` ile temizlenmelidir.
- **Koltuk sıralaması kırılgan:** `OrderBy(X).ThenBy(Y)` piksel konumuna göre numaralandırma, tasarımda buton bir piksel kayarsa koltuk planını bozar.

---

## 4. Geliştirme Fikirleri ve Yol Haritası

### Faz 1 — Hızlı Kazanımlar (mevcut mimariyi bozmadan)

1. `ShowDialog()` çağrılarını `using` bloğuna al (GDI sızıntısı).
2. `SatinAlBilet`'e koltuk doluluk kontrolü + DB'de `(SeferId, KoltukNo, örtüşen durak aralığı)` için kontrol; en azından `UNIQUE(SeferId, KoltukNo)` indeksi.
3. `DbConfig.cs`, istemcideki connection string ve `Microsoft.Data.SqlClient` paketini kaldır.
4. Korumasız `async void` handler'lara try-catch ekle; `btnSorgula_Click` çağrısını `await BiletleriYukle()` olarak yeniden düzenle.
5. API'ye global exception middleware + `ILogger`; DTO'lara DataAnnotations validasyonu.
6. Bozuk kodlamalı dosyayı UTF-8 olarak düzelt.

### Faz 2 — Katmanlaşma

1. **Merkezi `ApiClient` servisi:** Tek `HttpClient`, `Timeout`, ortak JSON ayarları, tiplenmiş metotlar (`Task<List<SeferDto>> GetSeferlerAsync(CancellationToken ct)`). Formlardaki tüm HTTP/JSON kodu buraya taşınır.
2. **Paylaşılan DTO projesi:** `StajWinForms.Shared` class library — API ve istemci aynı sözleşme tiplerini kullanır; 6 kopya model silinir.
3. **DI konteyneri:** `Microsoft.Extensions.Hosting` ile WinForms'ta `IServiceProvider` kurulumu; formlar ve `ApiClient` DI'dan çözülür (test edilebilirlik + `IHttpClientFactory` imkânı).

### Faz 3 — MVP (Model-View-Presenter) Geçişi

Kademeli geçiş önerilir — en karmaşık form olan `SecimEkrani`'ndan başlanarak:

```
ISecimEkraniView (interface)          SecimEkraniPresenter
  KoltukDurumlariniGoster(...)   ◄──   - DuraklariYukleAsync()
  event KoltukSecildi                  - KoltukSecimKurali (binis < inis)
  event DurakDegisti                   - ApiClient'a tek bağımlılık
```

- **View** yalnızca DevExpress kontrollerini yönetir, mantık içermez.
- **Presenter** iş kurallarını (durak sırası, cinsiyet renklendirme, seçim durumu) barındırır ve **UI'sız birim testine** açılır.
- Formlar arası akış için basit bir **Navigator/Coordinator** sınıfı, `new Form().ShowDialog()` dağınıklığını tek noktada toplar.

### Faz 4 — UI/UX ve İleri Konular

- **Yükleme durumu geri bildirimi:** API çağrıları sırasında `WaitForm`/overlay ve butonların devre dışı bırakılması (şu an çift tıklama çifte istek üretebilir).
- **Koltuk planını veriden üretme:** Designer'a elle konmuş butonlar yerine otobüs şablonuna göre dinamik üretim (`TableLayoutPanel`), farklı araç tiplerini destekler.
- **Eşzamanlılık:** EF Core optimistic concurrency (`rowversion`) + satın almada `SERIALIZABLE` yerine koşullu `INSERT ... WHERE NOT EXISTS` deseni.
- **API sürümleme, Serilog, health check, rate limiting** ve TC sorgulama uç noktası için asgari bir API anahtarı/kimlik doğrulama.
- **Birim testleri:** Presenter'lar ve `ApiClient` için xUnit; API için `WebApplicationFactory` ile entegrasyon testleri.

---

## 5. Sonuç

Proje, bir staj çalışması ölçeğinde **doğru temel kararlar** içeriyor: istemci-API ayrımı, tutarlı `async/await` kullanımı, constructor ile veri aktarımı ve EF Core'da projeksiyonlu (Select) sorgular. Öncelikli riskler ise **çifte koltuk satışı (K1)**, **`ShowDialog` kaynak sızıntıları**, **istemcide gemiye alınmış DB bağlantı dizesi (K3)** ve **sunucu tarafı validasyon eksikliği**dir. Faz 1 maddeleri düşük maliyetle uygulanabilir; MVP geçişi ise kod tabanı büyümeden önce yapılırsa en ucuz haliyle gerçekleştirilmiş olur.
