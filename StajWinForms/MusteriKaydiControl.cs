using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class MusteriKaydiControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly int _seferId;
        private readonly int _koltukNo;
        private readonly int _binisSira;
        private readonly int _inisSira;

        public MusteriKaydiControl(int seferId, int koltukNo, int binisSira, int inisSira)
        {
            _seferId = seferId;
            _koltukNo = koltukNo;
            _binisSira = binisSira;
            _inisSira = inisSira;
            InitializeComponent();
            lblKoltukBilgi.Text = $"Seçilen Koltuk: {_koltukNo}";
        }

        public bool Dogrula()
        {
            if (txtboxTC.Text.Trim().Length == 0 ||
                txtboxAd.Text.Trim().Length == 0 ||
                txtboxSoyad.Text.Trim().Length == 0 ||
                txtboxEmail.Text.Trim().Length == 0 ||
                txtboxTelefon.Text.Trim().Length == 0 ||
                txtboxSehir.Text.Trim().Length == 0 ||
                txtboxAdres.Text.Trim().Length == 0 ||
                cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show($"Koltuk {_koltukNo}: Lütfen tüm alanları doldurunuz.", "Eksik Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string tc = txtboxTC.Text.Trim();
            if (tc.Length != 11 || tc[0] == '0')
            {
                MessageBox.Show($"Koltuk {_koltukNo}: TC Kimlik No 11 haneli olmalı ve 0 ile başlamamalıdır.", "Geçersiz TC",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string telefon = txtboxTelefon.Text.Trim();
            if (telefon[0] != '0')
            {
                MessageBox.Show($"Koltuk {_koltukNo}: Telefon numarası 0 ile başlamalıdır.", "Geçersiz Telefon",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxTelefon.Text = "";
                return false;
            }

            return true;
        }

        internal SatinAlModel GetModel() => new SatinAlModel
        {
            SeferId = _seferId,
            KoltukNo = _koltukNo,
            BinisDurakSira = _binisSira,
            InisDurakSira = _inisSira,
            MusteriTc = txtboxTC.Text.Trim(),
            MusteriAd = txtboxAd.Text.Trim(),
            MusteriSoyad = txtboxSoyad.Text.Trim(),
            MusteriMail = txtboxEmail.Text.Trim(),
            MusteriTelefon = txtboxTelefon.Text.Trim(),
            MusteriSehir = txtboxSehir.Text.Trim(),
            MusteriAdres = txtboxAdres.Text.Trim(),
            MusteriCinsiyet = cmbCinsiyet.SelectedItem.ToString()!.Substring(0, 1).ToUpper(),
        };

        private void txtboxTC_TextChanged(object sender, EventArgs e)
        {
            txtboxTC.Properties.MaxLength = 11;
            if (Regex.IsMatch(txtboxTC.Text, "[^0-9]"))
            {
                txtboxTC.Text = Regex.Replace(txtboxTC.Text, "[^0-9]", "");
                if (txtboxTC.MaskBox != null)
                    txtboxTC.MaskBox.MaskBoxSelectionStart = txtboxTC.Text.Length;
            }
        }

        private void txtboxTelefon_TextChanged(object sender, EventArgs e)
        {
            txtboxTelefon.Properties.MaxLength = 11;
            if (Regex.IsMatch(txtboxTelefon.Text, "[^0-9]"))
            {
                txtboxTelefon.Text = Regex.Replace(txtboxTelefon.Text, "[^0-9]", "");
                if (txtboxTelefon.MaskBox != null)
                    txtboxTelefon.MaskBox.MaskBoxSelectionStart = txtboxTelefon.Text.Length;
            }
        }
    }
}
