using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms
{
    public partial class LoginForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                XtraMessageBox.Show("Kullanıcı adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                XtraMessageBox.Show("Şifre boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnGiris.Enabled = false;
            btnGiris.Text = "Giriş yapılıyor...";

            try
            {
                var payload = new { KullaniciAdi = txtKullaniciAdi.Text.Trim(), Sifre = txtSifre.Text };
                var response = await AppConfig.Http.PostAsJsonAsync("api/auth/login", payload);

                if (response.IsSuccessStatusCode)
                {
                    var sonuc = await response.Content.ReadFromJsonAsync<LoginSonucModel>(_jsonOpts);
                    Oturum.KullaniciId = sonuc!.KullaniciId;
                    Oturum.KullaniciAdi = sonuc.KullaniciAdi;
                    Oturum.AdSoyad = sonuc.AdSoyad ?? "";
                    Oturum.YetkiKodlari = sonuc.YetkiKodlari;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    var hata = await response.Content.ReadAsStringAsync();
                    XtraMessageBox.Show(hata, "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifre.Text = "";
                    txtSifre.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Sunucuya bağlanılamadı: {ex.Message}", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGiris.Enabled = true;
                btnGiris.Text = "Giriş Yap";
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGiris_Click(sender, e);
        }

        private class LoginSonucModel
        {
            public int KullaniciId { get; set; }
            public string KullaniciAdi { get; set; } = "";
            public string? AdSoyad { get; set; }
            public List<string> YetkiKodlari { get; set; } = new();
        }
    }
}
