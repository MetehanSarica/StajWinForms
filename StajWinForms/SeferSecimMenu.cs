using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace StajWinForms
{
    public partial class SeferSecimMenu : DevExpress.XtraEditors.XtraForm
    {

        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };

        public SeferSecimMenu()
        {
            InitializeComponent();
        }

        private async void SeferSecimMenu_Load(object sender, EventArgs e)
        {
            try
            {
                await SehirleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şehirler yüklenemedi: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbKalkis.Text) || string.IsNullOrEmpty(cmbVaris.Text))
            {
                MessageBox.Show("Lütfen kalkış ve varış şehirlerini seçin.");
                return;
            }

            AnaMenu anaMenu = new AnaMenu(
                cmbKalkis.Text,
                cmbVaris.Text
                );
            anaMenu.ShowDialog();
            }

        private void btnTumSeferler_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.ShowDialog();
        }

        private async System.Threading.Tasks.Task SehirleriYukle()
        {
            var json = await _http.GetStringAsync($"/api/sehirler");
            var duraklar = JsonSerializer.Deserialize<List<SehirlerModel>>(json, _jsonOpts) ?? new();

            cmbKalkis.Properties.Items.Clear();
            cmbKalkis.Properties.Items.AddRange(duraklar.Select(d => d.SehirAdi).ToArray());

            cmbVaris.Properties.Items.Clear();
            cmbVaris.Properties.Items.AddRange(duraklar.Select(d => d.SehirAdi).ToArray());

        }
    }
    internal class SehirlerModel
    {
        public int SehirId { get; set; }
        public string SehirAdi { get; set; } = "";
    }
}
