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
        private static readonly HttpClient _http = AppConfig.CreateHttpClient();
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        public BiletSorgula()
        {
            InitializeComponent();
        }

        private async void btnBiletSorgu_Click(object sender, EventArgs e)
        {
            if (txtboxTC.Text.Length < 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxTC.EditValue = null;
                return;
            }
            try { 
            var response = await _http.GetAsync($"api/biletler/musteri/{txtboxTC.Text}");
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
        private void txtboxTC_TextChanged(object sender, EventArgs e)
        {
            txtboxTC.Properties.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtboxTC.Text, "[^0-9]"))
            {
                txtboxTC.Text = System.Text.RegularExpressions.Regex.Replace(txtboxTC.Text, "[^0-9]", "");
                if (txtboxTC.MaskBox != null)
                    txtboxTC.MaskBox.MaskBoxSelectionStart = txtboxTC.Text.Length;
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
