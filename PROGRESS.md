# DevExpress Geçiş Takibi

## Tamamlananlar

### SeferDetay ✅
- `Form` → `XtraForm`
- 12x `Label` → `LabelControl`
- `Font` → `Appearance.Font` + `Appearance.Options.UseFont = true`
- `AutoSizeMode = LabelAutoSizeMode.None` (fixed size korundu)

### AnaMenu ✅
- `Panel` → `PanelControl` (buton toolbar)
- `DataGridView` → `GridControl` + `GridView`
  - `OptionsBehavior.Editable = false` (editör açılmıyor)
  - `OptionsSelection.EnableAppearanceFocusedCell = false` (sadece satır mavi indicator)
  - `OptionsView.ShowGroupPanel = false`
- Seçili satır erişimi: `SelectedRows[0].Cells[...]` → `GetFocusedRowCellValue(...)`
- Zaten DevExpress olan kontroller: `SimpleButton`, `TextEdit`, `PanelControl`, `XtraForm`

---

### SecimEkrani ✅
- `Form` → `XtraForm`
- 38x `Button` → `SimpleButton`
- `PictureBox` → `PictureEdit` (`Properties.SizeMode` ile)
- `Label` (kod içi) → `LabelControl`
- `ComboBox` (kod içi) → `LookUpEdit`
  - `DropDownStyle` → `Properties.TextEditStyle = DisableTextEditor`
  - `DataSource/DisplayMember/ValueMember` → `Properties.*`
  - `SelectedValue` → `EditValue`
  - Son item seçimi: `EditValue = dtInis.Rows[son]["DurakSira"]`
- `btn.BackColor` → `btn.Appearance.BackColor` + `Appearance.Options.UseBackColor = true`
- `Controls.OfType<Button>()` → `OfType<SimpleButton>()`
- `sender is not Button` → `sender is not SimpleButton`

---

### MusteriKaydi ✅
- `Form` → `XtraForm`
- `Panel` → `PanelControl`
- `Button` → `SimpleButton`
- 7x `Label` → `LabelControl` (AutoSize kaldırıldı, zaten default)
- 7x `TextBox` → `TextEdit` (her biri için `Properties.BeginInit/EndInit`)
- `TextChanged` → `EditValueChanged`
- `txtbox.MaxLength` → `txtbox.Properties.MaxLength`
- `txtbox.SelectionStart` → `txtbox.MaskBox?.SelectionStart`

---

### BiletSorgula ✅
- `Form` → `XtraForm`
- `TextBox` → `TextEdit`, `Button` → `SimpleButton`
- `DataGridView` → `GridControl` + `GridView`

### BiletIptal ✅
- `XtraForm` + `TextEdit` + `SimpleButton` + `GridControl`

### SeferSecimMenu ✅
- `XtraForm` + `ComboBoxEdit` + `SimpleButton`

---

## Bekleyenler

- (yok — DevExpress geçişi tamamlandı)

---

## Son Kontrol Düzeltmeleri (2026-07-10)

- AnaMenu: kullanılmayan `_filtreZaman` alanı ve ölü filtre kodu kaldırıldı
- SeferSecimMenu: bozuk Türkçe karakterler düzeltildi, `.editorconfig` ile UTF-8 BOM zorunlu kılındı
- BiletlerController: `FirmaAdi` null koruması tutarlı hale getirildi (`?? ""`)
- Async event handler'lara eksik try/catch eklendi (API kapalıyken çökme önlendi)
- HttpClient tekilleştirildi: tüm formlar `AppConfig.Http` paylaşılan instance'ını kullanıyor

---

# StajWeb (Web UI) — Razor Pages

## Proje Kurulumu ✅
- Yeni `StajWeb` Razor Pages projesi (net10.0)
- `IHttpClientFactory` named client ("API"): base URL `http://localhost:8081` + `X-Api-Key` header
- Modeller: `Sehirler`, `SeferDetay` (KalkisSehirId/VarisSehirId dahil), `Bilet`
- DTO'lar: `BiletDto`, `YolcuDto`

## Sayfalar ✅
- **Index** — şehir dropdown'ları (`SelectList`) + tarih ile sefer arama
- **Seferler** — kalkış/varış/tarih filtreli sefer listesi
- **SeferDetay/{id}** — CSS ile çizilen otobüs koltuk haritası (36 koltuk, cinsiyete göre renk)
- **Satinal** — koltuk başına yolcu formu, satın alma POST → API
- **BiletSorgula** — TC ile bilet listeleme
- **BiletIptal** — onay ekranı + DELETE

## Web Multiselect (2026-07-13) ✅
- SeferDetay: JS `secilenKoltuklar` dizisi ile çoklu koltuk seçimi (toggle sarı/yeşil)
- Seçimler query string ile taşınıyor: `/Satinal?seferId=X&koltuklar=1,5,9`
- Satinal: `Yolcular[@i].Alan` indexed binding → `List<YolcuDto>` otomatik doluyor
- OnPostAsync: her koltuk için ayrı `/api/biletler/satinal` isteği, Conflict/hata kontrolü

## API Değişiklikleri ✅
- `SeferDetayDto` + `SeferDetayController`: `KalkisSehirId` / `VarisSehirId` alanları eklendi (web'de şehir filtresi için)

---

# WinForms — Çoklu Koltuk Tek Form (2026-07-13) ✅

- `MusteriKaydiControl` (XtraUserControl): müşteri alanları + `Dogrula()` + `GetModel()`
- `CokluMusteriKaydi` (XtraForm): seçilen her koltuk için kontrolü kaydırılabilir panele dizer, "Biletleri Oluştur" ile hepsini sırayla API'ye gönderir
- `SecimEkrani.btnKoltukSec_Click`: koltuk başına ayrı form yerine tek `CokluMusteriKaydi` açıyor; kapanınca koltuk haritası yenileniyor
- `PictureEdit.Properties.ShowMenu = false` (otobüs resminde sağ tık menüsü kapatıldı)

---

# Web Tasarım (2026-07-13) ✅

- **Layout** — Türkçe navbar, marka + Bilet Sorgula linki
- **Index** — hero başlık + ortalanmış arama kartı (Bootstrap `card shadow`)
- **Seferler** — tablo yerine kart listesi (rota, firma, tarih, boş koltuk, fiyat, Seç)
- **SeferDetay** — sefer bilgi kartı + koltuk renk efsanesi (Boş/Erkek/Kadın/Seçili)
- **Satinal** — koltuk başına `card` + `row/col-md-6` grid form
- **BiletSorgula** — `input-group` arama kartı + `table-hover` bilet tablosu
- **BiletIptal** — ortalanmış onay kartı (Evet, İptal Et / Vazgeç)

---

# Dokümantasyon (2026-07-13) ✅

- `PROJE_DOKUMANI.md`: 3 katmanlı mimari, kullanılan tüm kavram ve teknolojilerin açıklamalı dökümü

---

## Sonraki Adımlar

- Web tarafında TC/telefon validasyonunu JS ile güçlendirme (WinForms kurallarıyla birebir)
- Satinal: Conflict durumunda kullanıcıya Türkçe hata mesajı gösterme
- SeferDetay web sayfasında biniş/iniş durağı seçimi (şu an sabit 1→1 gidiyor)
