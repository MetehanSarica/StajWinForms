using DevExpress.XtraEditors;
using StajWinForms.Dtos;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms
{
    public partial class YetkiAtamaForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<KullaniciItem> _kullanicilar = new();
        private static readonly Dictionary<string, string> _formAdlari = new()
        {
            ["btnFirmaBrowser"] = "Firma Yönetimi",
            ["btnOtobusBrowser"] = "Otobüs Yönetimi",
            ["btnFirmaOtobusEsle"] = "Firma-Otobüs Eşleme",
            ["btnKaptanBrowser"] = "Kaptan Yönetimi",
            ["btnKaptanEsle"] = "Otobüs-Kaptan Eşleme",
            ["btnSeferOtobusEsle"] = "Sefer-Otobüs Eşleme",
            ["btnKullaniciYonetim"] = "Kullanıcı Yönetimi",
            ["btnYetkiAtama"] = "Yetki Atama"
        };

        public YetkiAtamaForm()
        {
            InitializeComponent();
        }

        private async void YetkiAtamaForm_Load(object sender, EventArgs e)
        {
            await KullanicilariYukle();
            dgvYetkiler.Rows.Clear();
            foreach (var kv in _formAdlari)
                dgvYetkiler.Rows.Add(kv.Value, false, false, false, false, false, false, false);

            var y = Oturum.Yetkiler.FirstOrDefault(x => x.FormAdi == "btnYetkiAtama");
            if (y != null)
                btnKaydet.Visible = y.Kaydet;
        }

        private async Task KullanicilariYukle()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/kullanicilar");
                _kullanicilar = JsonSerializer.Deserialize<List<KullaniciItem>>(json, _jsonOpts) ?? new();
                lstKullanicilar.Items.Clear();
                foreach (var k in _kullanicilar) lstKullanicilar.Items.Add(k);
            }
            catch (Exception ex) { XtraMessageBox.Show("Kullanıcılar yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem is not KullaniciItem k) return;
            lblSeciliKullanici.Text = $"Seçili: {k.KullaniciAdi}";
            try
            {
                var json = await AppConfig.Http.GetStringAsync($"api/kullanicilar/{k.KullaniciId}/yetkiler");
                var mevcutYetkiler = JsonSerializer.Deserialize<List<KullaniciYetkiDto>>(json, _jsonOpts) ?? new();
                var keys = _formAdlari.Keys.ToList();
                for (int i = 0; i < dgvYetkiler.Rows.Count; i++)
                {
                    var dto = mevcutYetkiler.FirstOrDefault(y => y.FormAdi == keys[i]);
                    dgvYetkiler.Rows[i].Cells["colEkle"].Value = dto?.Ekle ?? false;
                    dgvYetkiler.Rows[i].Cells["colSil"].Value = dto?.Sil ?? false;
                    dgvYetkiler.Rows[i].Cells["colDegistir"].Value = dto?.Degistir ?? false;
                    dgvYetkiler.Rows[i].Cells["colIncele"].Value = dto?.Incele ?? false;
                    dgvYetkiler.Rows[i].Cells["colAta"].Value = dto?.Ata ?? false;
                    dgvYetkiler.Rows[i].Cells["colKaldir"].Value = dto?.Kaldir ?? false;
                    dgvYetkiler.Rows[i].Cells["colKaydet"].Value = dto?.Kaydet ?? false;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Yetkiler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem is not KullaniciItem k) return;
            var keys = _formAdlari.Keys.ToList();
            var yetkiler = new List<KullaniciYetkiDto>();
            for (int i = 0; i < dgvYetkiler.Rows.Count; i++)
            {
                yetkiler.Add(new KullaniciYetkiDto
                {
                    FormAdi = keys[i],
                    Ekle = (bool)(dgvYetkiler.Rows[i].Cells["colEkle"].Value ?? false),
                    Sil = (bool)(dgvYetkiler.Rows[i].Cells["colSil"].Value ?? false),
                    Degistir = (bool)(dgvYetkiler.Rows[i].Cells["colDegistir"].Value ?? false),
                    Incele = (bool)(dgvYetkiler.Rows[i].Cells["colIncele"].Value ?? false),
                    Ata = (bool)(dgvYetkiler.Rows[i].Cells["colAta"].Value ?? false),
                    Kaldir = (bool)(dgvYetkiler.Rows[i].Cells["colKaldir"].Value ?? false),
                    Kaydet = (bool)(dgvYetkiler.Rows[i].Cells["colKaydet"].Value ?? false),
                });
            }
            try
            {
                var resp = await AppConfig.Http.PutAsJsonAsync($"api/kullanicilar/{k.KullaniciId}/yetkiler", yetkiler);
                if (resp.IsSuccessStatusCode)
                    XtraMessageBox.Show("Yetkiler kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnKopyala_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem is not KullaniciItem kaynak)
            {
                XtraMessageBox.Show("Önce yetkileri kopyalanacak kullanıcıyı seçin.",
                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var frm = new YetkiKopyalaForm(kaynak.KullaniciId);
            if (frm.ShowDialog(this) != DialogResult.OK) return;

            var isimler = string.Join(", ", frm.HedefKullanicilar.Select(h => h.Adi));
            var onay = XtraMessageBox.Show(
                $"{kaynak.KullaniciAdi} kullanıcısının yetkileri {frm.HedefKullanicilar.Count} kullanıcısına kopyalanacak:\n\n{isimler}\n\nDevam edilsin mi?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            try
            {
                var json = await AppConfig.Http.GetStringAsync($"api/kullanicilar/{kaynak.KullaniciId}/yetkiler");
                var yetkiler = JsonSerializer.Deserialize<List<KullaniciYetkiDto>>(json, _jsonOpts) ?? new();

                var hatalar = new List<string>();
                foreach (var hedef in frm.HedefKullanicilar)
                {
                    var resp = await AppConfig.Http.PutAsJsonAsync(
                        $"api/kullanicilar/{hedef.Id}/yetkiler", yetkiler);
                    if (!resp.IsSuccessStatusCode)
                        hatalar.Add($"{hedef.Adi}: {await resp.Content.ReadAsStringAsync()}");
                }

                if (hatalar.Count == 0)
                    XtraMessageBox.Show($"Yetkiler {frm.HedefKullanicilar.Count} kullanıcıya kopyalandı.",
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Bazı kopyalamalar başarısız:\n" + string.Join("\n", hatalar),
                        "Kısmi Başarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private record KullaniciItem(int KullaniciId, string KullaniciAdi) { public override string ToString() => KullaniciAdi; }
    }
}
