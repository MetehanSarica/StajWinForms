using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Native;
using StajWinForms.Admin;

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
            new FirmaBrowserForm().ShowDialog();
        }

        private void btnOtobusBrowser_Click(object sender, EventArgs e)
        {
            new OtobusBrowserForm().ShowDialog();
        }

        private void btnFirmaOtobusEsle_Click(object sender, EventArgs e)
        {
            new FirmaOtobusEslemeForm().ShowDialog();
        }

        private void btnKaptanBrowser_Click(object sender, EventArgs e)
        {
            new KaptanBrowserForm().ShowDialog();
        }

        private void btnKaptanEsle_Click(object sender, EventArgs e)
        {
            new KaptanEslemeForm().ShowDialog();
        }

        private void btnSeferOtobusEsle_Click(object sender, EventArgs e)
        {
            new SeferOtobusEslemeForm().ShowDialog();
        }

        private void btnKullaniciYonetim_Click(object sender, EventArgs e)
        {
            new KullaniciYonetimForm().ShowDialog();
        }

        private void btnYetkiAtama_Click(object sender, EventArgs e)
        {
            new YetkiAtamaForm().ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new DashboardForm().ShowDialog();
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

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
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
