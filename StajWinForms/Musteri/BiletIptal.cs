using DevExpress.XtraEditors;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class BiletIptal : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        public BiletIptal()
        {
            InitializeComponent();
            spTC.EditValue = null;
        }

        private async void btnSorgula_Click(object sender, EventArgs e)
        {
            string tc = System.Text.RegularExpressions.Regex.Replace(spTC.Text, "[^0-9]", "");
            if (string.IsNullOrWhiteSpace(tc))
            {
                MessageBox.Show("TC Kimlik No boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var response = await _http.GetAsync($"api/biletler/musteri/{tc}");
                var biletler = await response.Content.ReadFromJsonAsync<IEnumerable<BiletSorgulaModel>>(_jsonOpts);

                gridBiletler.DataSource = biletler?.ToList() ?? new List<BiletSorgulaModel>();
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

        private async void btnIptalEt_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0)
            {
                MessageBox.Show("Lütfen iptal edilecek bileti seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int biletID = Convert.ToInt32(gridView.GetFocusedRowCellValue("BiletID"));

            var onay = MessageBox.Show("Bu bileti iptal etmek istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;


            try
            {
                var response = await _http.DeleteAsync($"api/biletler/{biletID}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Bilet başarıyla iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSorgula_Click(sender, e);
                }
                else
                    MessageBox.Show("Bilet iptal edilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Sunucuya ulaşılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
