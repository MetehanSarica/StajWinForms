using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms
{
    public partial class YetkiAtamaForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<KullaniciItem> _kullanicilar = new();
        private List<YetkiItem> _tumYetkiler = new();

        public YetkiAtamaForm()
        {
            InitializeComponent();
        }

        private async void YetkiAtamaForm_Load(object sender, EventArgs e)
        {
            await KullanicilariYukle();
            await YetkileriYukle();
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

        private async Task YetkileriYukle()
        {
            try
            {
                // Yetkiler API endpoint'i olmasa da statik liste kullanalım
                _tumYetkiler = new List<YetkiItem>
                {
                    new("FIRMA",        "Firma Yönetimi"),
                    new("OTOBUS",       "Otobüs Yönetimi"),
                    new("FIRMA_OTOBUS", "Firma-Otobüs Eşleme"),
                    new("KAPTAN",       "Kaptan Yönetimi"),
                    new("SEFER_OTOBUS", "Sefer-Otobüs Eşleme"),
                    new("KULLANICI",    "Kullanıcı Yönetimi"),
                    new("YETKI",        "Yetki Yönetimi")
                };
                clbYetkiler.Items.Clear();
                foreach (var y in _tumYetkiler) clbYetkiler.Items.Add(y, false);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem is not KullaniciItem k) return;
            lblSeciliKullanici.Text = $"Seçili: {k.KullaniciAdi}";
            try
            {
                var json = await AppConfig.Http.GetStringAsync($"api/kullanicilar/{k.KullaniciId}/yetkiler");
                var mevcutYetkiler = JsonSerializer.Deserialize<List<string>>(json, _jsonOpts) ?? new();
                for (int i = 0; i < clbYetkiler.ItemCount; i++)
                {
                    var yetkiItem = clbYetkiler.GetItemValue(i) as YetkiItem;
                    clbYetkiler.SetItemChecked(i, yetkiItem != null && mevcutYetkiler.Contains(yetkiItem.Kod));
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Yetkiler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lstKullanicilar.SelectedItem is not KullaniciItem k) return;
            var seciliYetkiler = clbYetkiler.CheckedItems
                .Cast<DevExpress.XtraEditors.Controls.CheckedListBoxItem>()
                .Select(i => i.Value as YetkiItem)
                .Where(y => y != null)
                .Select(y => y!.Kod)
                .ToList();
            try
            {
                var resp = await AppConfig.Http.PutAsJsonAsync($"api/kullanicilar/{k.KullaniciId}/yetkiler", seciliYetkiler);
                if (resp.IsSuccessStatusCode)
                    XtraMessageBox.Show("Yetkiler kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private record KullaniciItem(int KullaniciId, string KullaniciAdi) { public override string ToString() => KullaniciAdi; }
        private record YetkiItem(string Kod, string Adi) { public override string ToString() => Adi; }
    }
}
