using DevExpress.XtraEditors;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class SeferDetay : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.CreateHttpClient();
        private readonly int _seferID;

        public SeferDetay(int seferID)
        {
            _seferID = seferID;
            InitializeComponent();
            Shown += SeferDetay_Shown;
        }

        private async void SeferDetay_Shown(object? sender, EventArgs e)
        {
            Text = $"Sefer Detayları - #{_seferID}";

            if (_seferID <= 0)
            {
                MessageBox.Show("Geçersiz sefer ID.", "Hata");
                return;
            }

            try
            {
                var response = await _http.GetAsync($"/api/seferdetay/{_seferID}");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var sefer = JsonSerializer.Deserialize<SeferDetayModel>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (sefer == null)
                {
                    MessageBox.Show("Sefer verisi boş geldi.", "Hata");
                    return;
                }

                txtFirmaValue.Text = sefer.FirmaAdi;
                txtKalkisValue.Text = sefer.KalkisSehirAdi;
                txtVarisValue.Text = sefer.VarisSehirAdi;
                txtZamanValue.Text = sefer.KalkisZamani.ToString("dd.MM.yyyy HH:mm");
                txtFiyatValue.Text = sefer.Fiyat.ToString("C2");
                txtKoltukValue.Text = sefer.BosKoltuk.ToString();
                txtDuraklar.Text = string.Join(" → ", sefer.Duraklar);
                Text = "Sefer Detayları";
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"API bağlantı hatası (#{_seferID}):\n{ex.Message}", "Hata");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sefer #{_seferID} yüklenemedi:\n{ex.Message}", "Hata");
            }
        }
    }
}
