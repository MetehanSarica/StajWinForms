using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using static System.Net.WebRequestMethods;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class AnaMenu : DevExpress.XtraEditors.XtraForm
    {
        private static readonly HttpClient _http = AppConfig.CreateHttpClient();
        private List<SeferDetayModel> _tumSeferler = new();

        private readonly string? _filtreKalkis;
        private readonly string? _filtreVaris;
        private readonly DateTime? _filtreZaman;

        public AnaMenu()
        {
            InitializeComponent();
        }

        public AnaMenu(string kalkisSehir, string varisSehir)
        {
            InitializeComponent();
            _filtreKalkis = kalkisSehir;
            _filtreVaris = varisSehir;
        }

        private async void AnaMenu_Load(object sender, EventArgs e)
        {
            try
            {
                var json = await _http.GetStringAsync("/api/seferdetay");
                _tumSeferler = JsonSerializer.Deserialize<List<SeferDetayModel>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new();

                if (!string.IsNullOrEmpty(_filtreKalkis))
                {
                    _tumSeferler = _tumSeferler
                        .Where(s =>
                            s.KalkisSehirAdi.Equals(_filtreKalkis, StringComparison.OrdinalIgnoreCase) &&
                            s.VarisSehirAdi.Equals(_filtreVaris, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    this.Text = $"Ana Menü — {_filtreKalkis} → {_filtreVaris}";
                }

                if (_filtreZaman.HasValue)
                {
                    _tumSeferler = _tumSeferler
                        .Where(s => s.KalkisZamani >= _filtreZaman.Value)
                        .ToList();
                }

                dataGridVeriler.DataSource = _tumSeferler;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seferler yüklenemedi: " + ex.Message);
            }
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

        private void btnBiletIptal_Click(object sender, EventArgs e)
        {
            BiletIptal biletIptal = new BiletIptal();
            biletIptal.ShowDialog();
        }

        private void dataGridVeriler_DoubleClick(object sender, EventArgs e)
        {
            int seferID = GetSeciliSeferID();
            if (seferID <= 0) return;
            SeferDetay seferDetay = new SeferDetay(seferID);
            seferDetay.ShowDialog(this);
        }
    }

    internal class SeferDetayModel
    {
        public int SeferId { get; set; }
        public string FirmaAdi { get; set; } = "";
        public string KalkisSehirAdi { get; set; } = "";
        public string VarisSehirAdi { get; set; } = "";
        public DateTime KalkisZamani { get; set; }
        public string KalkisSaati => KalkisZamani.ToString("HH:mm");
        public decimal Fiyat { get; set; }
        public int BosKoltuk { get; set; }
        public List<string> Duraklar { get; set; } = new();

    }
}
