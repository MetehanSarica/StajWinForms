using DevExpress.XtraEditors;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace StajWinForms
{
    public partial class BiletSorgula : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        public BiletSorgula()
        {
            InitializeComponent();
            spTC.EditValue = null;
        }

        private async void btnBiletSorgu_Click(object sender, EventArgs e)
        {
            string tc = System.Text.RegularExpressions.Regex.Replace(spTC.Text, "[^0-9]", "");
            if (!Dogrulama.TcGecerliMi(tc))
            {
                MessageBox.Show("TC Kimlik No 11 haneli olmalı ve 0 ile başlamamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                spTC.EditValue = null;
                return;
            }
            try
            {
                var response = await _http.GetAsync($"api/biletler/musteri/{tc}");
                var biletler = await response.Content.ReadFromJsonAsync<IEnumerable<BiletSorgulaModel>>(_jsonOpts);

                dataGridSorgu.DataSource = biletler?.ToList() ?? new List<BiletSorgulaModel>();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Bilet sorgulanırken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException)
            {
                MessageBox.Show("Bilet verileri işlenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void spTC_EditValueChanged(object sender, EventArgs e)
        {
            spTC.Properties.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(spTC.Text, "[^0-9]"))
            {
                spTC.Text = System.Text.RegularExpressions.Regex.Replace(spTC.Text, "[^0-9]", "");
                if (spTC.MaskBox != null)
                    spTC.MaskBox.MaskBoxSelectionStart = spTC.Text.Length;
            }
        }
    }
    public class BiletSorgulaModel
    {
        public int BiletID { get; set; }
        public int KoltukNo { get; set; }
        public string FirmaAdi { get; set; } = string.Empty;
        public string KalkisSehirAdi { get; set; } = string.Empty;
        public string VarisSehirAdi { get; set; } = string.Empty;
        public DateTime KalkisZamani { get; set; }
        public decimal Fiyat { get; set; }
    }
}
