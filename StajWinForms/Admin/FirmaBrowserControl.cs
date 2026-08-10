using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWinForms.Admin
{
    public partial class FirmaBrowserControl : UserControl
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private List<FirmaModel> _firmalar = new();

        private readonly BackgroundWorker bgwVeriYukle = new() { WorkerReportsProgress = true };
        private readonly BackgroundWorker bgwIslem = new() { WorkerReportsProgress = false };

        public FirmaBrowserControl()
        {
            InitializeComponent();
            bgwVeriYukle.DoWork += BgwVeriYukle_DoWork;
            bgwVeriYukle.RunWorkerCompleted += BgwVeriYukle_RunWorkerCompleted;
            bgwIslem.DoWork += BgwIslem_DoWork;
            bgwIslem.RunWorkerCompleted += BgwIslem_RunWorkerCompleted;
        }

        private void FirmaBrowserControl_Load(object sender, EventArgs e)
        {
            VeriYukle();

            var y = Oturum.Yetkiler.FirstOrDefault(x => x.FormAdi == "btnFirmaBrowser");
            if (y != null)
            {
                btnEkle.Visible = y.Ekle;
                btnDegistir.Visible = y.Degistir;
                btnSil.Visible = y.Sil;
                btnIncele.Visible = y.Incele;
            }
        }

        private void VeriYukle()
        {
            if (bgwVeriYukle.IsBusy) return;
            SetButonlar(false);
            lblDurum.Text = "Yükleniyor...";
            bgwVeriYukle.RunWorkerAsync();
        }

        private void BgwVeriYukle_DoWork(object? sender, DoWorkEventArgs e)
        {
            var json = AppConfig.Http.GetStringAsync("api/firmalar").GetAwaiter().GetResult();
            e.Result = JsonSerializer.Deserialize<List<FirmaModel>>(json, _jsonOpts) ?? new();
        }

        private void BgwVeriYukle_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                XtraMessageBox.Show("Firmalar yüklenemedi: " + e.Error.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDurum.Text = "Hata!";
            }
            else
            {
                _firmalar = (List<FirmaModel>)e.Result!;
                gridFirmalar.DataSource = null;
                gridFirmalar.DataSource = _firmalar;
                gridView.RefreshData();
                lblDurum.Text = $"{_firmalar.Count} firma listelendi.";
            }
            SetButonlar(true);
        }

        private record IslemArgs(string Tur, object? Veri);

        private void BgwIslem_DoWork(object? sender, DoWorkEventArgs e)
        {
            var args = (IslemArgs)e.Argument!;
            switch (args.Tur)
            {
                case "EKLE":
                {
                    var firma = new { FirmaAdi = (string)args.Veri! };
                    var resp = AppConfig.Http.PostAsJsonAsync("api/firmalar", firma).GetAwaiter().GetResult();
                    resp.EnsureSuccessStatusCode();
                    break;
                }
                case "GUNCELLE":
                {
                    var (id, adi) = ((int, string))args.Veri!;
                    var firma = new { FirmaAdi = adi };
                    var resp = AppConfig.Http.PutAsJsonAsync($"api/firmalar/{id}", firma).GetAwaiter().GetResult();
                    resp.EnsureSuccessStatusCode();
                    break;
                }
                case "SIL":
                {
                    int id = (int)args.Veri!;
                    var resp = AppConfig.Http.DeleteAsync($"api/firmalar/{id}").GetAwaiter().GetResult();
                    if (!resp.IsSuccessStatusCode)
                    {
                        var hata = resp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        Invoke(() => XtraMessageBox.Show(hata, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning));
                    }
                    break;
                }
            }
        }

        private void BgwIslem_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                XtraMessageBox.Show(e.Error.Message, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetButonlar(true);
                lblDurum.Text = "Hazır.";
                return;
            }
            VeriYukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var adi = XtraInputBox.Show("Firma adı:", "Firma Ekle", "");
            if (string.IsNullOrWhiteSpace(adi)) return;
            if (bgwIslem.IsBusy) return;
            SetButonlar(false);
            lblDurum.Text = "Ekleniyor...";
            bgwIslem.RunWorkerAsync(new IslemArgs("EKLE", adi.Trim()));
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            var firma = GetSeciliFirma();
            if (firma == null) return;
            var yeniAdi = XtraInputBox.Show("Yeni firma adı:", "Firma Değiştir", firma.FirmaAdi);
            if (string.IsNullOrWhiteSpace(yeniAdi)) return;
            if (bgwIslem.IsBusy) return;
            SetButonlar(false);
            lblDurum.Text = "Güncelleniyor...";
            bgwIslem.RunWorkerAsync(new IslemArgs("GUNCELLE", (firma.FirmaId, yeniAdi.Trim())));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var firma = GetSeciliFirma();
            if (firma == null) return;
            if (XtraMessageBox.Show($"'{firma.FirmaAdi}' silinsin mi?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (bgwIslem.IsBusy) return;
            SetButonlar(false);
            lblDurum.Text = "Siliniyor...";
            bgwIslem.RunWorkerAsync(new IslemArgs("SIL", firma.FirmaId));
        }

        private void btnYenile_Click(object sender, EventArgs e) => VeriYukle();

        private void btnIncele_Click(object sender, EventArgs e)
        {
            var firma = GetSeciliFirma();
            if (firma == null) return;
            new FirmaInceleForm(firma).ShowDialog();
        }

        private FirmaModel? GetSeciliFirma()
        {
            var val = gridView.GetFocusedRowCellValue("FirmaId");
            if (val == null || val == DBNull.Value)
            {
                XtraMessageBox.Show("Lütfen bir firma seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return _firmalar.FirstOrDefault(f => f.FirmaId == Convert.ToInt32(val));
        }

        private void SetButonlar(bool aktif)
        {
            btnEkle.Enabled = aktif;
            btnDegistir.Enabled = aktif;
            btnSil.Enabled = aktif;
            btnYenile.Enabled = aktif;
            btnIncele.Enabled = aktif;
        }

        public class FirmaModel
        {
            public int FirmaId { get; set; }
            public string FirmaAdi { get; set; } = "";
        }
    }
}
