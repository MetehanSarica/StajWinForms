using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http;

namespace StajWinForms.Admin
{
    public partial class BiletAramaForm : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        public BiletAramaForm()
        {
            InitializeComponent();
        }

        private async void BiletAramaForm_Load(object sender, EventArgs e)
        {
            var sehirler = await _http.GetFromJsonAsync<List<SehirItem>>("api/sehirler", _opts) ?? new();
            cboKalkis.Properties.Items.Add(new SehirItem(0, "(Tümü)"));
            cboVaris.Properties.Items.Add(new SehirItem(0, "(Tümü)"));
            cboKalkis.Properties.Items.AddRange(sehirler);
            cboVaris.Properties.Items.AddRange(sehirler);
            cboKalkis.SelectedIndex = 0;
            cboVaris.SelectedIndex = 0;
            cboKalkis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cboVaris.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            dtTarih.MouseClick += (s, ev) => dtTarih.ShowPopup();
        }

        private async void btnAra_Click(object sender, EventArgs e)
        {
            var kalkis = cboKalkis.SelectedItem as SehirItem;
            var varis = cboVaris.SelectedItem as SehirItem;
            var tarih = dtTarih.EditValue as DateTime?;

            var url = "api/biletler/ara?";
            if (kalkis?.SehirId > 0) url += $"kalkisId={kalkis.SehirId}&";
            if (varis?.SehirId > 0) url += $"varisId={varis.SehirId}&";
            if (tarih.HasValue) url += $"tarih={tarih.Value:yyyy-MM-dd}";

            var biletler = await _http.GetFromJsonAsync<List<BiletAramaDto>>(url, _opts) ?? new();
            gridBiletler.DataSource = biletler;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cboKalkis.SelectedIndex = 0;
            cboVaris.SelectedIndex = 0;
            dtTarih.EditValue = null;
            gridBiletler.DataSource = null;
        }

        record SehirItem(int SehirId, string SehirAdi) { public override string ToString() => SehirAdi; }

        record BiletAramaDto(
            int BiletId, int KoltukNo, string MusteriAdSoyad, string MusteriTc,
            string KalkisSehirAdi, string VarisSehirAdi, DateTime KalkisZamani,
            string FirmaAdi, decimal Fiyat);
    }
}
