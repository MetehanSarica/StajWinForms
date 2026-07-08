using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class AnaMenu : DevExpress.XtraEditors.XtraForm
    {
        private static readonly HttpClient _http = new() { BaseAddress = new Uri("http://localhost:8081") };
        private List<SeferDetayModel> _tumSeferler = new();

        public AnaMenu()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var json = await _http.GetStringAsync("/api/seferdetay");
                _tumSeferler = JsonSerializer.Deserialize<List<SeferDetayModel>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new();
                dataGridVeriler.DataSource = _tumSeferler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seferler yüklenemedi: " + ex.Message);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var filtre = txtboxAra.Text.Trim();
            if (string.IsNullOrEmpty(filtre))
            {
                dataGridVeriler.DataSource = null;
                dataGridVeriler.DataSource = _tumSeferler;
                return;
            }

            var sonuc = _tumSeferler.Where(s =>
                s.FirmaAdi.Contains(filtre, StringComparison.OrdinalIgnoreCase) ||
                s.KalkisSehirAdi.Contains(filtre, StringComparison.OrdinalIgnoreCase) ||
                s.VarisSehirAdi.Contains(filtre, StringComparison.OrdinalIgnoreCase)).ToList();

            dataGridVeriler.DataSource = null;
            dataGridVeriler.DataSource = sonuc;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int seferID = GetSeciliSeferID();
            if (seferID <= 0) return;
            SecimEkrani secimEkrani = new SecimEkrani(seferID);
            secimEkrani.ShowDialog();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            BiletSorgula biletSorgula = new BiletSorgula();
            biletSorgula.ShowDialog();
        }

        private void btnSeferDetaylar_Click(object sender, EventArgs e)
        {
            int seferID = GetSeciliSeferID();
            if (seferID <= 0) return;
            SeferDetay seferDetay = new SeferDetay(seferID);
            seferDetay.ShowDialog(this);
        }

        private int GetSeciliSeferID()
        {
            var val = gridView1.GetFocusedRowCellValue("SeferId");
            if (val == null || val == DBNull.Value)
            {
                MessageBox.Show("Lütfen önce bir sefer seçin.");
                return 0;
            }
            int id = Convert.ToInt32(val);
            if (id <= 0) MessageBox.Show("Lütfen önce bir sefer seçin.");
            return id;
        }
    }

    internal class SeferDetayModel
    {
        public int SeferId { get; set; }
        public string FirmaAdi { get; set; } = "";
        public string KalkisSehirAdi { get; set; } = "";
        public string VarisSehirAdi { get; set; } = "";
        public DateTime KalkisZamani { get; set; }
        public decimal Fiyat { get; set; }
        public int BosKoltuk { get; set; }
    }
}
