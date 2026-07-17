using DevExpress.XtraEditors;

namespace StajWinForms
{
    public partial class AdminPanelForm : XtraForm
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            lblHosgeldin.Text = $"Hoş geldiniz, {Oturum.AdSoyad} ({Oturum.KullaniciAdi})";
            YetkiyeGoreMenuGoster();
        }

        private void YetkiyeGoreMenuGoster()
        {
            btnFirmaBrowser.Visible     = Oturum.HasYetki("FIRMA");
            btnOtobusBrowser.Visible    = Oturum.HasYetki("OTOBUS");
            btnFirmaOtobusEsle.Visible  = Oturum.HasYetki("FIRMA_OTOBUS");
            btnKaptanBrowser.Visible    = Oturum.HasYetki("KAPTAN");
            btnKaptanEsle.Visible       = Oturum.HasYetki("KAPTAN");
            btnKullaniciYonetim.Visible = Oturum.HasYetki("KULLANICI");
            btnYetkiAtama.Visible       = Oturum.HasYetki("YETKI");
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

        private void btnKullaniciYonetim_Click(object sender, EventArgs e)
        {
            new KullaniciYonetimForm().ShowDialog();
        }

        private void btnYetkiAtama_Click(object sender, EventArgs e)
        {
            new YetkiAtamaForm().ShowDialog();
        }
    }
}
