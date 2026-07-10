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
