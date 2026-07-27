using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Text.Json;

namespace StajWinForms
{
    public partial class YetkiKopyalaForm : XtraForm
    {
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        private readonly int _kaynakKullaniciId;
        private BindingList<KullaniciSecim> _liste = new();

        public YetkiKopyalaForm(int kaynakKullaniciId)
        {
            InitializeComponent();
            _kaynakKullaniciId = kaynakKullaniciId;
        }

        public List<(int Id, string Adi)> HedefKullanicilar { get; private set; } = new();

        private async void YetkiKopyalaForm_Load(object sender, EventArgs e)
        {
            try
            {
                var json = await AppConfig.Http.GetStringAsync("api/kullanicilar");
                var kullanicilar = JsonSerializer.Deserialize<List<KullaniciItem>>(json, _jsonOpts) ?? new();
                _liste = new BindingList<KullaniciSecim>(
                    kullanicilar
                        .Where(k => k.KullaniciId != _kaynakKullaniciId)
                        .Select(k => new KullaniciSecim { KullaniciId = k.KullaniciId, KullaniciAdi = k.KullaniciAdi })
                        .ToList()
                );
                gridKullanicilar.DataSource = _liste;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kullanıcılar yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            gridView.CloseEditor();
            gridView.UpdateCurrentRow();

            HedefKullanicilar = _liste
                .Where(x => x.Sec)
                .Select(x => (x.KullaniciId, x.KullaniciAdi))
                .ToList();

            if (HedefKullanicilar.Count == 0)
            {
                XtraMessageBox.Show("En az bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private record KullaniciItem(int KullaniciId, string KullaniciAdi);

        private class KullaniciSecim
        {
            public bool Sec { get; set; }
            public int KullaniciId { get; set; }
            public string KullaniciAdi { get; set; } = "";
        }
    }
}
