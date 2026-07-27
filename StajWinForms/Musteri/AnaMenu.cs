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
        private static readonly HttpClient _http = AppConfig.Http;
        private List<SeferDetayModel> _tumSeferler = new();

        private readonly string? _filtreKalkis;
        private readonly string? _filtreVaris;
        private readonly DateTime? _filtreTarih;

        public AnaMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            Bounds = Screen.GetWorkingArea(this);
        }

        public AnaMenu(string kalkisSehir, string varisSehir, DateTime? kalkisTarihi = null)
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            Bounds = Screen.GetWorkingArea(this);
            _filtreKalkis = kalkisSehir;
            _filtreVaris = varisSehir;
            _filtreTarih = kalkisTarihi;
        }

        private async void AnaMenu_Load(object sender, EventArgs e) => await SeferleriYenile();

        private async Task SeferleriYenile()
        {
            try
            {
                var json = await _http.GetStringAsync("/api/seferdetay");
                var tumSeferler = JsonSerializer.Deserialize<List<SeferDetayModel>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new();

                if (!string.IsNullOrEmpty(_filtreKalkis))
                {
                    tumSeferler = tumSeferler
                        .Where(s =>
                            s.KalkisSehirAdi.Equals(_filtreKalkis, StringComparison.OrdinalIgnoreCase) &&
                            s.VarisSehirAdi.Equals(_filtreVaris, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                if (_filtreTarih.HasValue)
                    tumSeferler = tumSeferler
                        .Where(s => s.KalkisZamani.Date == _filtreTarih.Value.Date)
                        .ToList();

                _tumSeferler = tumSeferler;
                dataGridVeriler.DataSource = _tumSeferler;
                gridView1.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seferler yüklenemedi: " + ex.Message);
            }
        }

        private async void btnSec_Click(object sender, EventArgs e)
        {
            int seferID = GetSeciliSeferID();
            if (seferID <= 0) return;
            SecimEkrani secimEkrani = new SecimEkrani(seferID);
            secimEkrani.ShowDialog();
            await SeferleriYenile();
            int rowHandle = gridView1.LocateByValue("SeferId", seferID);
            if (rowHandle >= 0)
                gridView1.FocusedRowHandle = rowHandle;
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            int savedRowHandle = gridView1.FocusedRowHandle;
            BiletSorgula biletSorgula = new BiletSorgula();
            biletSorgula.ShowDialog();
            if (savedRowHandle >= 0)
                gridView1.FocusedRowHandle = savedRowHandle;
        }

        private void btnSeferDetaylar_Click(object sender, EventArgs e)
        {
            int savedRowHandle = gridView1.FocusedRowHandle;
            int seferID = GetSeciliSeferID();
            if (seferID <= 0) return;
            SeferDetay seferDetay = new SeferDetay(seferID);
            seferDetay.ShowDialog(this);
            if (savedRowHandle >= 0)
                gridView1.FocusedRowHandle = savedRowHandle;
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

        private async void btnBiletIptal_Click(object sender, EventArgs e)
        {
            int seferID = GetSeciliSeferID();
            BiletIptal biletIptal = new BiletIptal();
            biletIptal.ShowDialog();
            await SeferleriYenile();
            if (seferID > 0)
            {
                int rowHandle = gridView1.LocateByValue("SeferId", seferID);
                if (rowHandle >= 0)
                    gridView1.FocusedRowHandle = rowHandle;
            }
        }

        private async void dataGridVeriler_DoubleClick(object sender, EventArgs e)
        {
            int seferID = GetSeciliSeferID();
            if (seferID <= 0) return;
            SecimEkrani secimEkrani = new SecimEkrani(seferID);
            secimEkrani.ShowDialog(this);
            await SeferleriYenile();
            int rowHandle = gridView1.LocateByValue("SeferId", seferID);
            if (rowHandle >= 0)
                gridView1.FocusedRowHandle = rowHandle;
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_MOVE)
                return;
            base.WndProc(ref m);
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
        public List<string> Personeller { get; set; } = new();
        public string PnrKodu => $"TR{SeferId:D6}";
    }
}
