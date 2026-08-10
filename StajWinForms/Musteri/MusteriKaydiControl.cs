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
            txtboxTelefon.Properties.Mask.EditMask = @"\0(000) 000 00 00";
            txtboxTelefon.MouseUp += (s, e) =>
            {
                int firstEmpty = txtboxTelefon.Text.IndexOf('_');
                txtboxTelefon.SelectionStart = firstEmpty >= 0 ? firstEmpty : txtboxTelefon.Text.Length;
            };
            spTC.EditValue = null;
            lblKoltukBilgi.Text = $"Seçilen Koltuk: {_koltukNo}";
            this.Load += async (s, e) => await SehirleriYukle();
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
            string prefix = $"Koltuk {_koltukNo}: ";

            if (spTC.Text.Trim().Length == 0)
                return Uyar(prefix + "TC Kimlik No boş bırakılamaz.");

            string tc = spTC.Text.Trim();
            if (!Dogrulama.TcGecerliMi(tc))
                return Uyar(prefix + "Geçersiz TC Kimlik No.");

            if (txtboxAd.Text.Trim().Length == 0)
                return Uyar(prefix + "Ad alanı boş bırakılamaz.");

            if (txtboxSoyad.Text.Trim().Length == 0)
                return Uyar(prefix + "Soyad alanı boş bırakılamaz.");

            if (txtboxEmail.Text.Trim().Length == 0)
                return Uyar(prefix + "E-posta alanı boş bırakılamaz.");

            if (!Dogrulama.EmailGecerliMi(txtboxEmail.Text.Trim()))
                return Uyar(prefix + "Geçerli bir e-posta adresi giriniz (örn: ornek@mail.com).");

            string telefon = TelefonRakamlari();
            if (telefon.Length == 0)
                return Uyar(prefix + "Telefon alanı boş bırakılamaz.");

            if (!Dogrulama.TelefonGecerliMi(telefon))
                return Uyar(prefix + "Telefon numarası 11 haneli olmalı ve 0 ile başlamalıdır.");

            if (cmbSehir.SelectedIndex == -1)
                return Uyar(prefix + "Şehir seçiniz.");

            if (memoAdres.Text.Trim().Length == 0)
                return Uyar(prefix + "Adres alanı boş bırakılamaz.");

            if (cmbCinsiyet.SelectedIndex == -1)
                return Uyar(prefix + "Cinsiyet seçiniz.");

            return true;
        }

        private static bool Uyar(string mesaj)
        {
            MessageBox.Show(mesaj, "Geçersiz Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
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
