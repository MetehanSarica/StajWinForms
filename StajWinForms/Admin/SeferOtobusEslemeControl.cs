using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms.Admin
{
    public partial class SeferOtobusEslemeControl : UserControl
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<SeferItem> _seferler = new();
        private List<OtobusItem> _otobusler = new();

        public SeferOtobusEslemeControl()
        {
            InitializeComponent();
        }

        private async void SeferOtobusEslemeControl_Load(object sender, EventArgs e)
        {
            await OtubusleriYukle();
            await SeferleriYukle();

            var y = Oturum.Yetkiler.FirstOrDefault(x => x.FormAdi == "btnSeferOtobusEsle");
            if (y != null)
            {
                btnAta.Visible = y.Ata;
                btnKaldir.Visible = y.Kaldir;
            }
        }

        private async Task SeferleriYukle()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/seferler");
                _seferler = JsonSerializer.Deserialize<List<SeferItem>>(json, _jsonOpts) ?? new();
                var prev = cmbSefer.SelectedItem is SeferItem s ? s.SeferId : -1;
                cmbSefer.SelectedIndexChanged -= cmbSefer_SelectedIndexChanged;
                cmbSefer.Items.Clear();
                foreach (var sefer in _seferler) cmbSefer.Items.Add(sefer);
                cmbSefer.SelectedIndexChanged += cmbSefer_SelectedIndexChanged;
                var idx = _seferler.FindIndex(s => s.SeferId == prev);
                cmbSefer.SelectedIndex = idx >= 0 ? idx : (cmbSefer.Items.Count > 0 ? 0 : -1);
                GuncelleMevcutEtiket();
            }
            catch (Exception ex) { XtraMessageBox.Show("Seferler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async Task OtubusleriYukle()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/otobusler");
                _otobusler = JsonSerializer.Deserialize<List<OtobusItem>>(json, _jsonOpts) ?? new();
                cmbOtobus.Items.Clear();
                foreach (var o in _otobusler) cmbOtobus.Items.Add(o);
                if (cmbOtobus.Items.Count > 0) cmbOtobus.SelectedIndex = 0;
            }
            catch (Exception ex) { XtraMessageBox.Show("Otobüsler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbSefer_SelectedIndexChanged(object sender, EventArgs e) => GuncelleMevcutEtiket();

        private void GuncelleMevcutEtiket()
        {
            if (cmbSefer.SelectedItem is not SeferItem sefer) { lblMevcut.Text = "-"; return; }
            lblMevcut.Text = sefer.OtobusPlaka ?? "Atanmamış";
        }

        private async void btnAta_Click(object sender, EventArgs e)
        {
            if (cmbSefer.SelectedItem is not SeferItem sefer) return;
            if (cmbOtobus.SelectedItem is not OtobusItem otobus) return;
            try
            {
                var resp = await AppConfig.Http.PutAsJsonAsync($"api/seferler/{sefer.SeferId}/otobus", new { OtobusId = otobus.OtobusId });
                if (!resp.IsSuccessStatusCode)
                { XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                await SeferleriYukle();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnKaldir_Click(object sender, EventArgs e)
        {
            if (cmbSefer.SelectedItem is not SeferItem sefer) return;
            if (sefer.OtobusPlaka == null)
            { XtraMessageBox.Show("Bu sefere otobüs atanmamış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                var resp = await AppConfig.Http.DeleteAsync($"api/seferler/{sefer.SeferId}/otobus");
                if (!resp.IsSuccessStatusCode)
                { XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                await SeferleriYukle();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private class SeferItem
        {
            public int SeferId { get; set; }
            public string KalkisSehirAdi { get; set; } = "";
            public string VarisSehirAdi { get; set; } = "";
            public DateTime KalkisZamani { get; set; }
            public int? OtobusId { get; set; }
            public string? OtobusPlaka { get; set; }
            public override string ToString() => $"#{SeferId} {KalkisSehirAdi} → {VarisSehirAdi} ({KalkisZamani:dd.MM.yyyy HH:mm})";
        }

        private class OtobusItem
        {
            public int OtobusId { get; set; }
            public string Plaka { get; set; } = "";
            public string? Marka { get; set; }
            public string? Model { get; set; }
            public override string ToString() => Marka != null ? $"{Plaka} ({Marka} {Model})" : Plaka;
        }
    }
}
