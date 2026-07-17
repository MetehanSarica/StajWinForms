using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms
{
    public partial class OtobusBrowserForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<OtobusModel> _otobusler = new();

        public OtobusBrowserForm()
        {
            InitializeComponent();
        }

        private async void OtobusBrowserForm_Load(object sender, EventArgs e) => await VeriYukle();

        private async Task VeriYukle()
        {
            SetButonlar(false);
            lblDurum.Text = "Yükleniyor...";
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/otobusler");
                _otobusler = JsonSerializer.Deserialize<List<OtobusModel>>(json, _jsonOpts) ?? new();
                gridOtobusler.DataSource = null;
                gridOtobusler.DataSource = _otobusler;
                gridView.RefreshData();
                lblDurum.Text = $"{_otobusler.Count} otobüs listelendi.";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Otobüsler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDurum.Text = "Hata!";
            }
            finally { SetButonlar(true); }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var firmalar = await FirmalariGetir();
            var dlg = new OtobusEditForm(null, firmalar);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                var resp = await AppConfig.Http.PostAsJsonAsync("api/otobusler", dlg.Sonuc);
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private async void btnDegistir_Click(object sender, EventArgs e)
        {
            var otobus = GetSeciliOtobus();
            if (otobus == null) return;
            var firmalar = await FirmalariGetir();
            var dlg = new OtobusEditForm(otobus, firmalar);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                var resp = await AppConfig.Http.PutAsJsonAsync($"api/otobusler/{otobus.OtobusId}", dlg.Sonuc);
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            var otobus = GetSeciliOtobus();
            if (otobus == null) return;
            if (XtraMessageBox.Show($"'{otobus.Plaka}' plakalı otobüs silinsin mi?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                var resp = await AppConfig.Http.DeleteAsync($"api/otobusler/{otobus.OtobusId}");
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            var otobus = GetSeciliOtobus();
            if (otobus == null) return;
            XtraMessageBox.Show(
                $"Otobüs ID: {otobus.OtobusId}\nPlaka: {otobus.Plaka}\nMarka: {otobus.Marka}\nModel: {otobus.Model}\nKoltuk: {otobus.KoltukKapasitesi}\nFirma: {otobus.FirmaAdi ?? "-"}",
                "Otobüs Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnYenile_Click(object sender, EventArgs e) => await VeriYukle();

        private OtobusModel? GetSeciliOtobus()
        {
            var val = gridView.GetFocusedRowCellValue("OtobusId");
            if (val == null || val == DBNull.Value)
            {
                XtraMessageBox.Show("Lütfen bir otobüs seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return _otobusler.FirstOrDefault(o => o.OtobusId == Convert.ToInt32(val));
        }

        private async Task<List<FirmaComboItem>> FirmalariGetir()
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/firmalar");
                var firmalar = JsonSerializer.Deserialize<List<FirmaComboItem>>(json, _jsonOpts) ?? new();
                return firmalar;
            }
            catch { return new(); }
        }

        private void SetButonlar(bool aktif)
        {
            btnEkle.Enabled = aktif;
            btnDegistir.Enabled = aktif;
            btnSil.Enabled = aktif;
            btnYenile.Enabled = aktif;
            btnIncele.Enabled = aktif;
        }

        public class OtobusModel
        {
            public int OtobusId { get; set; }
            public string Plaka { get; set; } = "";
            public string? Marka { get; set; }
            public string? Model { get; set; }
            public int KoltukKapasitesi { get; set; }
            public int? FirmaId { get; set; }
            public string? FirmaAdi { get; set; }
        }

        public class FirmaComboItem
        {
            public int FirmaId { get; set; }
            public string FirmaAdi { get; set; } = "";
            public override string ToString() => FirmaAdi;
        }
    }
}
