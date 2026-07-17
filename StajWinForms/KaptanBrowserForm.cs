using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms
{
    public partial class KaptanBrowserForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<PersonelModel> _personeller = new();

        public KaptanBrowserForm()
        {
            InitializeComponent();
        }

        private async void KaptanBrowserForm_Load(object sender, EventArgs e) => await VeriYukle();

        private async Task VeriYukle()
        {
            SetButonlar(false);
            lblDurum.Text = "Yükleniyor...";
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/personel");
                _personeller = JsonSerializer.Deserialize<List<PersonelModel>>(json, _jsonOpts) ?? new();
                gridPersonel.DataSource = null;
                gridPersonel.DataSource = _personeller;
                gridView.RefreshData();
                lblDurum.Text = $"{_personeller.Count} kaptan listelendi.";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Personel yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDurum.Text = "Hata!";
            }
            finally { SetButonlar(true); }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var dlg = new KaptanEditForm(null);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                var resp = await AppConfig.Http.PostAsJsonAsync("api/personel", dlg.Sonuc);
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private async void btnDegistir_Click(object sender, EventArgs e)
        {
            var p = GetSeciliPersonel();
            if (p == null) return;
            var dlg = new KaptanEditForm(p);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                var resp = await AppConfig.Http.PutAsJsonAsync($"api/personel/{p.Id}", dlg.Sonuc);
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            var p = GetSeciliPersonel();
            if (p == null) return;
            if (XtraMessageBox.Show($"'{p.Ad} {p.Soyad}' silinsin mi?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                var resp = await AppConfig.Http.DeleteAsync($"api/personel/{p.Id}");
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            var p = GetSeciliPersonel();
            if (p == null) return;
            XtraMessageBox.Show(
                $"ID: {p.Id}\nAd: {p.Ad}\nSoyad: {p.Soyad}\nEmail: {p.Email ?? "-"}\nMaaş: {p.Maas?.ToString("C") ?? "-"}\nİşe Giriş: {p.IseGirisTarihi?.ToString("dd.MM.yyyy") ?? "-"}",
                "Kaptan Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnYenile_Click(object sender, EventArgs e) => await VeriYukle();

        private PersonelModel? GetSeciliPersonel()
        {
            var val = gridView.GetFocusedRowCellValue("Id");
            if (val == null || val == DBNull.Value)
            {
                XtraMessageBox.Show("Lütfen bir kaptan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return _personeller.FirstOrDefault(p => p.Id == Convert.ToInt32(val));
        }

        private void SetButonlar(bool aktif)
        {
            btnEkle.Enabled = aktif; btnDegistir.Enabled = aktif;
            btnSil.Enabled = aktif; btnYenile.Enabled = aktif; btnIncele.Enabled = aktif;
        }

        public class PersonelModel
        {
            public int Id { get; set; }
            public string Ad { get; set; } = "";
            public string Soyad { get; set; } = "";
            public string? Email { get; set; }
            public decimal? Maas { get; set; }
            public DateOnly? IseGirisTarihi { get; set; }
        }
    }
}
