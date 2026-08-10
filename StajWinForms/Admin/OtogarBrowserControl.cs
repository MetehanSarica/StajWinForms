using DevExpress.XtraEditors;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms.Admin
{
    public partial class OtogarBrowserControl : UserControl
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        public OtogarBrowserControl()
        {
            InitializeComponent();
        }

        private async void OtogarBrowserControl_Load(object sender, EventArgs e)
        {
            await OtogarlariYukle();
        }

        private async Task OtogarlariYukle()
        {
            var otogarlar = await _http.GetFromJsonAsync<List<OtogarDto>>("api/otogarlar", _opts) ?? new();
            gridOtogarlar.DataSource = otogarlar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using var frm = new OtogarEditForm();
            if (frm.ShowDialog(this) == DialogResult.OK)
                _ = OtogarlariYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var otogar = (OtogarDto)gridView.GetFocusedRow();
            using var frm = new OtogarEditForm(otogar);
            if (frm.ShowDialog(this) == DialogResult.OK)
                _ = OtogarlariYukle();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var otogar = (OtogarDto)gridView.GetFocusedRow();
            var onay = XtraMessageBox.Show($"{otogar.OtogarAdi} otogarını silmek istiyor musunuz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            var resp = await _http.DeleteAsync($"api/otogarlar/{otogar.OtogarId}");
            if (resp.IsSuccessStatusCode)
                await OtogarlariYukle();
            else
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            await OtogarlariYukle();
        }
    }
}
