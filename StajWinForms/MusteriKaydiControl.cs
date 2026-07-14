using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StajWinForms
{
    public partial class MusteriKaydiControl : DevExpress.XtraEditors.XtraUserControl
    {
        private static readonly HttpClient _http = AppConfig.Http;
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
            spTC.EditValue = null;
            lblKoltukBilgi.Text = $"Seçilen Koltuk: {_koltukNo}";
            _ = SehirleriYukle();
        }

        private async Task SehirleriYukle()
        {
            try
            {
                var sehirler = await _http.GetFromJsonAsync<List<SehirlerModel>>("api/sehirler") ?? new();
                cmbSehir.Properties.Items.AddRange(sehirler.Select(s => s.SehirAdi).ToArray());
            }
            catch
            {
                MessageBox.Show("Şehirler yüklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Dogrula()
        {
            string telefon = TelefonRakamlari();
            if (spTC.Text.Trim().Length == 0 ||
                txtboxAd.Text.Trim().Length == 0 ||
                txtboxSoyad.Text.Trim().Length == 0 ||
                txtboxEmail.Text.Trim().Length == 0 ||
                telefon.Length == 0 ||
                cmbSehir.SelectedIndex == -1 ||
                memoAdres.Text.Trim().Length == 0 ||
                cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show($"Koltuk {_koltukNo}: Lütfen tüm alanları doldurunuz.", "Eksik Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string tc = spTC.Text.Trim();
            if (tc.Length != 11 || tc[0] == '0')
            {
                MessageBox.Show($"Koltuk {_koltukNo}: TC Kimlik No 11 haneli olmalı ve 0 ile başlamamalıdır.", "Geçersiz TC",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (telefon.Length != 10)
            {
                MessageBox.Show($"Koltuk {_koltukNo}: Telefon numarası 11 haneli olmalıdır.", "Geçersiz Telefon",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string TelefonRakamlari() => Regex.Replace(txtboxTelefon.Text, "[^0-9]", "");

        internal SatinAlModel GetModel() => new SatinAlModel
        {
            SeferId = _seferId,
            KoltukNo = _koltukNo,
            BinisDurakSira = _binisSira,
            InisDurakSira = _inisSira,
            MusteriTc = spTC.Text.Trim(),
            MusteriAd = txtboxAd.Text.Trim(),
            MusteriSoyad = txtboxSoyad.Text.Trim(),
            MusteriMail = txtboxEmail.Text.Trim(),
            MusteriTelefon = TelefonRakamlari(),
            MusteriSehir = cmbSehir.Text.Trim(),
            MusteriAdres = memoAdres.Text.Trim(),
            MusteriCinsiyet = cmbCinsiyet.SelectedItem.ToString()!.Substring(0, 1).ToUpper(),
        };

        private void spTC_EditValueChanged(object sender, EventArgs e)
        {
            spTC.Properties.MaxLength = 11;
            if (Regex.IsMatch(spTC.Text, "[^0-9]"))
            {
                spTC.Text = Regex.Replace(spTC.Text, "[^0-9]", "");
                if (spTC.MaskBox != null)
                    spTC.MaskBox.MaskBoxSelectionStart = spTC.Text.Length;
            }
        }
    }
}
