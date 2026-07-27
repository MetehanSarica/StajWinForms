using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms
{
    public partial class FirmaOtobusEslemeForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<OtobusItem> _tumOtobusler = new();

        public FirmaOtobusEslemeForm()
        {
            InitializeComponent();
        }

        private async void FirmaOtobusEslemeForm_Load(object sender, EventArgs e)
        {
            await FirmalariYukle();
            await OtubusleriYukle();

            var y = Oturum.Yetkiler.FirstOrDefault(x => x.FormAdi == "btnFirmaOtobusEsle");
            if (y != null)
            {
                btnKaldir.Visible = y.Ata;
                btnAta.Visible = y.Kaldir;
            }
        }

        private async Task FirmalariYukle()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/firmalar");
                var firmalar = JsonSerializer.Deserialize<List<FirmaItem>>(json, _jsonOpts) ?? new();
                cmbFirma.Items.Clear();
                cmbFirma.DisplayMember = "FirmaAdi";
                foreach (var f in firmalar) cmbFirma.Items.Add(f);
                if (cmbFirma.Items.Count > 0) cmbFirma.SelectedIndex = 0;
            }
            catch (Exception ex) { XtraMessageBox.Show("Firmalar yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task OtubusleriYukle()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/otobusler");
                _tumOtobusler = JsonSerializer.Deserialize<List<OtobusItem>>(json, _jsonOpts) ?? new();
                ListeleriGuncelle();
            }
            catch (Exception ex) { XtraMessageBox.Show("Otobüsler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e) => ListeleriGuncelle();

        private void ListeleriGuncelle()
        {
            var firma = cmbFirma.SelectedItem as FirmaItem;
            if (firma == null) return;

            lstFirmaOtobusler.Items.Clear();
            lstDigerOtobusler.Items.Clear();

            foreach (var o in _tumOtobusler)
            {
                if (o.FirmaId == firma.FirmaId)
                    lstFirmaOtobusler.Items.Add(o);
                else
                    lstDigerOtobusler.Items.Add(o);
            }
        }

        private async void btnAta_Click(object sender, EventArgs e)
        {
            var firma = cmbFirma.SelectedItem as FirmaItem;
            if (firma == null || lstDigerOtobusler.SelectedItem is not OtobusItem otobus) return;
            if (otobus.FirmaId != null)
            {
                XtraMessageBox.Show($"Bu otobüs '{otobus.FirmaAdi}' firmasına atanmış. Önce mevcut firmadan kaldırın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var resp = await AppConfig.Http.PutAsJsonAsync($"api/otobusler/{otobus.OtobusId}/firma", firma.FirmaId);
                if (!resp.IsSuccessStatusCode)
                { XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                otobus.FirmaId = firma.FirmaId;
                otobus.FirmaAdi = firma.FirmaAdi;
                ListeleriGuncelle();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnKaldir_Click(object sender, EventArgs e)
        {
            if (lstFirmaOtobusler.SelectedItem is not OtobusItem otobus) return;
            try
            {
                var resp = await AppConfig.Http.PutAsJsonAsync<int?>($"api/otobusler/{otobus.OtobusId}/firma", null);
                if (!resp.IsSuccessStatusCode)
                { XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                otobus.FirmaId = null;
                otobus.FirmaAdi = null;
                ListeleriGuncelle();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private class FirmaItem { public int FirmaId { get; set; } public string FirmaAdi { get; set; } = ""; public override string ToString() => FirmaAdi; }
        private class OtobusItem { public int OtobusId { get; set; } public string Plaka { get; set; } = ""; public int? FirmaId { get; set; } public string? FirmaAdi { get; set; } public override string ToString() => Plaka; }
    }
}
