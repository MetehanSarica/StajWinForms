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
        }

        private async void SeferBrowserControl_Load(object sender, EventArgs e)
        {
            await SeferleriYukle();
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
        decimal Fiyat, int KoltukKapasitesi, string OtobusPlaka);
}
