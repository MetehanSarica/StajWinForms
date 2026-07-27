using DevExpress.XtraEditors;
using static StajWinForms.KullaniciYonetimForm;

namespace StajWinForms
{
    public partial class KullaniciEditForm : XtraForm
    {
        public object Sonuc { get; private set; } = null!;
        private readonly bool _yeniKayit;

        private readonly bool _incele;

        public KullaniciEditForm(KullaniciModel? mevcut, bool incele = false)
        {
            InitializeComponent();
            _yeniKayit = mevcut == null;
            _incele = incele;
            if (mevcut != null)
            {
                txtKullaniciAdi.Text = mevcut.KullaniciAdi;
                txtAdSoyad.Text = mevcut.AdSoyad ?? "";
                chkAktif.Checked = mevcut.Aktif;
                lblSifreBilgi.Text = "Yeni şifre girmezseniz mevcut şifre korunur.";
                Text = "Kullanıcı Değiştir";
            }
            else
            {
                chkAktif.Checked = true;
                lblSifreBilgi.Text = "Şifre zorunludur.";
                Text = "Kullanıcı Ekle";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                XtraMessageBox.Show("Kullanıcı adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                XtraMessageBox.Show("İsim ve soyisim boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_yeniKayit && string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                XtraMessageBox.Show("Yeni kayıt için şifre zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_yeniKayit)
            {
                Sonuc = new
                {
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                    Sifre = txtSifre.Text,
                    AdSoyad = string.IsNullOrWhiteSpace(txtAdSoyad.Text) ? null : txtAdSoyad.Text.Trim(),
                    Aktif = chkAktif.Checked
                };
            }
            else
            {
                Sonuc = new
                {
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                    YeniSifre = string.IsNullOrWhiteSpace(txtSifre.Text) ? null : txtSifre.Text,
                    AdSoyad = string.IsNullOrWhiteSpace(txtAdSoyad.Text) ? null : txtAdSoyad.Text.Trim(),
                    Aktif = chkAktif.Checked
                };
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void KullaniciEditForm_Shown(object sender, EventArgs e)
        {
            if (_incele)
            {
                txtKullaniciAdi.ReadOnly = true;
                txtAdSoyad.ReadOnly = true;
                txtSifre.ReadOnly = true;
                chkAktif.Enabled = false;
                btnKaydet.Visible = false;
                btnIptal.Text = "Kapat";
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
