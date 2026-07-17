using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms
{
    public partial class KaptanEslemeForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<KaptanItem> _tumKaptanlar = new();
        private List<KaptanAtamaItem> _atanmisKaptanlar = new();

        public KaptanEslemeForm()
        {
            InitializeComponent();
        }

        private async void KaptanEslemeForm_Load(object sender, EventArgs e)
        {
            await OtubusleriYukle();
            await TumKaptanlariYukle();
        }

        private async Task OtubusleriYukle()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/otobusler");
                var otobusler = JsonSerializer.Deserialize<List<OtobusItem>>(json, _jsonOpts) ?? new();
                cmbOtobus.Items.Clear();
                cmbOtobus.DisplayMember = "Plaka";
                foreach (var o in otobusler) cmbOtobus.Items.Add(o);
                if (cmbOtobus.Items.Count > 0) cmbOtobus.SelectedIndex = 0;
            }
            catch (Exception ex) { XtraMessageBox.Show("Otobüsler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task TumKaptanlariYukle()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/personel");
                _tumKaptanlar = JsonSerializer.Deserialize<List<KaptanItem>>(json, _jsonOpts) ?? new();
            }
            catch (Exception ex) { XtraMessageBox.Show("Personel yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e) => await AtanmislariYukle();

        private async Task AtanmislariYukle()
        {
            var otobus = cmbOtobus.SelectedItem as OtobusItem;
            if (otobus == null) return;
            try
            {
                var json = await AppConfig.Http.GetStringAsync($"api/otobuskaptan/{otobus.OtobusId}");
                _atanmisKaptanlar = JsonSerializer.Deserialize<List<KaptanAtamaItem>>(json, _jsonOpts) ?? new();
                ListeleriGuncelle();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ListeleriGuncelle()
        {
            var atanmisIds = _atanmisKaptanlar.Select(k => k.PersonelId).ToHashSet();
            lstAtanmisKaptanlar.Items.Clear();
            lstTumKaptanlar.Items.Clear();
            foreach (var k in _atanmisKaptanlar) lstAtanmisKaptanlar.Items.Add(k);
            foreach (var k in _tumKaptanlar.Where(k => !atanmisIds.Contains(k.Id))) lstTumKaptanlar.Items.Add(k);
        }

        private async void btnAta_Click(object sender, EventArgs e)
        {
            var otobus = cmbOtobus.SelectedItem as OtobusItem;
            if (otobus == null || lstTumKaptanlar.SelectedItem is not KaptanItem kaptan) return;
            try
            {
                var payload = new { OtobusId = otobus.OtobusId, PersonelId = kaptan.Id };
                var resp = await AppConfig.Http.PostAsJsonAsync("api/otobuskaptan", payload);
                if (!resp.IsSuccessStatusCode)
                { XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                await AtanmislariYukle();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnKaldir_Click(object sender, EventArgs e)
        {
            if (lstAtanmisKaptanlar.SelectedItem is not KaptanAtamaItem atama) return;
            try
            {
                var resp = await AppConfig.Http.DeleteAsync($"api/otobuskaptan/{atama.Id}");
                if (!resp.IsSuccessStatusCode)
                { XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                await AtanmislariYukle();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private class OtobusItem { public int OtobusId { get; set; } public string Plaka { get; set; } = ""; public override string ToString() => Plaka; }
        private class KaptanItem { public int Id { get; set; } public string Ad { get; set; } = ""; public string Soyad { get; set; } = ""; public override string ToString() => $"{Ad} {Soyad}"; }
        private class KaptanAtamaItem { public int Id { get; set; } public int OtobusId { get; set; } public int PersonelId { get; set; } public string PersonelAdSoyad { get; set; } = ""; public override string ToString() => PersonelAdSoyad; }
    }
}
