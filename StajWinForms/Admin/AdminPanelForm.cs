using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Native;
using StajWinForms.Admin;
using System.Net.Http.Json;

namespace StajWinForms
{
    public partial class AdminPanelForm : XtraForm
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            lblHosgeldin.Text = $"Hoş geldiniz, {Oturum.AdSoyad} ({Oturum.KullaniciAdi})";
        }
        
        private void btnFirmaBrowser_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.FirmaBrowserControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnOtobusBrowser_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.OtobusBrowserControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnFirmaOtobusEsle_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.FirmaOtobusEslemeControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnOtogarBrowser_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.OtogarBrowserControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnPersonelBrowser_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.PersonelBrowserControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnMusteriBrowser_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.MusteriBrowserControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnKaptanEsle_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.KaptanEslemeControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnSeferOtobusEsle_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.SeferOtobusEslemeControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnKullaniciYonetim_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.KullaniciYonetimControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnYetkiAtama_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.YetkiAtamaControl(
                flpButonlar.Controls.OfType<SimpleButton>());
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new DashboardControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnSeferBrowser_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.SeferBrowserControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        private void btnBiletArama_Click(object sender, EventArgs e)
        {
            pnlIcerik.Controls.Clear();
            var uc = new Admin.BiletAramaControl();
            uc.Dock = DockStyle.Fill;
            pnlIcerik.Controls.Add(uc);
        }

        public bool CikisYapildi { get; private set; } = false;

        private void btnCikis_Click(object sender, EventArgs e)
        {
            CikisYapildi = true;
            Oturum.KullaniciId = 0;
            Oturum.KullaniciAdi = "";
            Oturum.AdSoyad = "";
            Oturum.Yetkiler = new();
            Close();
        }

        private async void AdminPanelForm_Load(object sender, EventArgs e)
        {
            var formlar = flpButonlar.Controls.OfType<SimpleButton>()
                .Where(b => b.Name != "btnCikis")
                .Select(b => new { FormAdi = b.Name, FormAciklamasi = b.Text})
                .ToList();
            await AppConfig.Http.PostAsJsonAsync("api/formlar/sync", formlar);

            foreach (Control cntrl in flpButonlar.Controls)
            {
                if (cntrl is SimpleButton btn && btn.Name != "btnCikis")
                {
                    var y = Oturum.Yetkiler.FirstOrDefault(x => x.FormAdi == btn.Name);
                    btn.Visible = y != null && (y.Ekle || y.Sil || y.Degistir || y.Incele || y.Ata || y.Kaldir || y.Kaydet);
                }
            }
        }
    }
}
