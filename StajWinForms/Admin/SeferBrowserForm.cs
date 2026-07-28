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
    public partial class SeferBrowserForm : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        public SeferBrowserForm()
        {
            InitializeComponent();
        }

        private async void SeferBrowserForm_Load(object sender, EventArgs e)
        {
            await SeferleriYukle();
        }

        private async Task SeferleriYukle()
        {
            var seferler = await _http.GetFromJsonAsync<List<SeferDto>>("api/seferler", _opts) ?? new();
            gridSeferler.DataSource = seferler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using var frm = new SeferEditForm();
            if (frm.ShowDialog(this) == DialogResult.OK)
                _ = SeferleriYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var sefer = (SeferDto)gridView.GetFocusedRow();
            using var frm = new SeferEditForm(sefer);
            if (frm.ShowDialog(this) == DialogResult.OK)
                _ = SeferleriYukle();
        }
        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var sefer = (SeferDto)gridView.GetFocusedRow();
            var onay = XtraMessageBox.Show($"{sefer.KalkisSehirAdi} → {sefer.VarisSehirAdi} seferini silmek istiyor musunuz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay != DialogResult.Yes) return;

            var resp = await _http.DeleteAsync($"api/seferler/{sefer.SeferId}");
            if (resp.IsSuccessStatusCode)
                await SeferleriYukle();
            else
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnYolcular_Click(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle < 0) return;
            var sefer = (SeferDto)gridView.GetFocusedRow();
            new YolcuListesiForm(sefer.SeferId, $"{sefer.KalkisSehirAdi} → {sefer.VarisSehirAdi}").ShowDialog(this);
        }

        private async void btnYenile_Click(object sender, EventArgs e)
        {
            await SeferleriYukle();
        }

    }

    class SeferDto
    {
        public int SeferId { get; set; }
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = "";
        public int KalkisSehirId { get; set; }
        public string KalkisSehirAdi { get; set; } = "";
        public int VarisSehirId { get; set; }
        public string VarisSehirAdi { get; set; } = "";
        public DateTime KalkisZamani { get; set; }
        public int SureDakika { get; set; }
        public decimal Fiyat { get; set; }
        public int KoltukKapasitesi { get; set; }
        public string? OtobusPlaka { get; set; }
    }
}
