using DevExpress.XtraEditors;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms.Admin
{
    public partial class SeferBrowserControl : UserControl
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        public SeferBrowserControl()
        {
            InitializeComponent();
            gridView.CustomColumnDisplayText += (s, e) =>
            {
                if (e.Column == colAktif && e.Value is bool aktif)
                    e.DisplayText = aktif ? "Aktif" : "Deaktif";
            };
        }

        private async void SeferBrowserControl_Load(object sender, EventArgs e)
        {
            await SeferleriYukle();
            var y = Oturum.Yetkiler.FirstOrDefault(x => x.FormAdi == "btnSeferBrowser");
            if (y != null)
            {
                btnEkle.Visible = y.Ekle;
                btnDuzenle.Visible = y.Degistir;
                btnSil.Visible = y.Sil;
                btnIptal.Visible = y.AktifPasif;
            }
        }

        private async Task SeferleriYukle()
        {
            var seferler = await _http.GetFromJsonAsync<List<SeferDto>>("api/seferler", _opts) ?? new();
            gridSeferler.DataSource = seferler;
            lblDurum.Text = $"{seferler.Count} sefer listelendi.";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using var frm = new SeferEditForm();
            if (frm.ShowDialog(this) == DialogResult.OK)
                _ = SeferleriYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var sefer = (SeferDto)gridView.GetFocusedRow();
            using var frm = new SeferEditForm(sefer);
            if (frm.ShowDialog(this) == DialogResult.OK)
                _ = SeferleriYukle();
        }

        private async void btnIptal_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var sefer = (SeferDto)gridView.GetFocusedRow();
            var eylem = sefer.Aktif ? "deaktif etmek" : "tekrar aktif etmek";
            var onay = XtraMessageBox.Show(
                $"{sefer.KalkisSehirAdi} → {sefer.VarisSehirAdi} seferini {eylem} istiyor musunuz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            var url = sefer.Aktif ? $"api/seferler/{sefer.SeferId}/iptal" : $"api/seferler/{sefer.SeferId}/aktifet";
            var resp = await _http.PutAsync(url, null);
            if (resp.IsSuccessStatusCode)
                await SeferleriYukle();
            else
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var sefer = (SeferDto)gridView.GetFocusedRow();
            var onay = XtraMessageBox.Show($"{sefer.KalkisSehirAdi} → {sefer.VarisSehirAdi} seferini silmek istiyor musunuz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            var resp = await _http.DeleteAsync($"api/seferler/{sefer.SeferId}");
            if (resp.IsSuccessStatusCode)
                await SeferleriYukle();
            else
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnYolcular_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var sefer = (SeferDto)gridView.GetFocusedRow();
            new YolcuListesiForm(sefer.SeferId, $"{sefer.KalkisSehirAdi} → {sefer.VarisSehirAdi}").ShowDialog(this);
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            await SeferleriYukle();
        }
    }

    public record SeferDto(
        int SeferId, int FirmaId, string FirmaAdi,
        int KalkisSehirId, string KalkisSehirAdi,
        int VarisSehirId, string VarisSehirAdi,
        DateTime KalkisZamani, int SureDakika,
        decimal Fiyat, 
        int KoltukKapasitesi, 
        string OtobusPlaka,
        bool Aktif);
}
