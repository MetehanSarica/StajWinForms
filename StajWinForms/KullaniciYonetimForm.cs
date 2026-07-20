using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms
{
    public partial class KullaniciYonetimForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<KullaniciModel> _kullanicilar = new();

        public KullaniciYonetimForm()
        {
            InitializeComponent();
        }

        private async void KullaniciYonetimForm_Load(object sender, EventArgs e) => await VeriYukle();

        private async Task VeriYukle()
        {
            SetButonlar(false);
            lblDurum.Text = "Yükleniyor...";
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/kullanicilar");
                _kullanicilar = JsonSerializer.Deserialize<List<KullaniciModel>>(json, _jsonOpts) ?? new();
                gridKullanicilar.DataSource = null;
                gridKullanicilar.DataSource = _kullanicilar;
                gridView.RefreshData();
                lblDurum.Text = $"{_kullanicilar.Count} kullanıcı listelendi.";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kullanıcılar yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDurum.Text = "Hata!";
            }
            finally { SetButonlar(true); }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var dlg = new KullaniciEditForm(null);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                var resp = await AppConfig.Http.PostAsJsonAsync("api/kullanicilar", dlg.Sonuc);
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private async void btnDegistir_Click(object sender, EventArgs e)
        {
            var k = GetSeciliKullanici();
            if (k == null) return;
            var dlg = new KullaniciEditForm(k);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                var resp = await AppConfig.Http.PutAsJsonAsync($"api/kullanicilar/{k.KullaniciId}", dlg.Sonuc);
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            var k = GetSeciliKullanici();
            if (k == null) return;
            if (k.KullaniciId == Oturum.KullaniciId)
            {
                XtraMessageBox.Show("Kendi hesabınızı silemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (XtraMessageBox.Show($"'{k.KullaniciAdi}' silinsin mi?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                var resp = await AppConfig.Http.DeleteAsync($"api/kullanicilar/{k.KullaniciId}");
                if (!resp.IsSuccessStatusCode)
                    XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            await VeriYukle();
        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            var k = GetSeciliKullanici();
            if (k == null) return;
            new KullaniciEditForm(k, incele: true).ShowDialog();
        }

        private async void btnYenile_Click(object sender, EventArgs e) => await VeriYukle();

        private KullaniciModel? GetSeciliKullanici()
        {
            var val = gridView.GetFocusedRowCellValue("KullaniciId");
            if (val == null || val == DBNull.Value)
            {
                XtraMessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return _kullanicilar.FirstOrDefault(k => k.KullaniciId == Convert.ToInt32(val));
        }

        private void SetButonlar(bool aktif)
        {
            btnEkle.Enabled = aktif; btnDegistir.Enabled = aktif;
            btnSil.Enabled = aktif; btnYenile.Enabled = aktif; btnIncele.Enabled = aktif;
        }

        public class KullaniciModel
        {
            public int KullaniciId { get; set; }
            public string KullaniciAdi { get; set; } = "";
            public string? AdSoyad { get; set; }
            public bool Aktif { get; set; }
            public DateTime OlusturmaTarihi { get; set; }
        }
    }
}
