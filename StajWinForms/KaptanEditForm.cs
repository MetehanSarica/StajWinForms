using DevExpress.XtraEditors;
using static StajWinForms.KaptanBrowserForm;

namespace StajWinForms
{
    public partial class KaptanEditForm : XtraForm
    {
        public object Sonuc { get; private set; } = null!;

        public KaptanEditForm(PersonelModel? mevcut)
        {
            InitializeComponent();
            if (mevcut != null)
            {
                txtAd.Text = mevcut.Ad;
                txtSoyad.Text = mevcut.Soyad;
                txtEmail.Text = mevcut.Email ?? "";
                if (mevcut.Maas.HasValue) spnMaas.Value = mevcut.Maas.Value;
                if (mevcut.IseGirisTarihi.HasValue)
                    dtpIseGiris.DateTime = mevcut.IseGirisTarihi.Value.ToDateTime(TimeOnly.MinValue);
                Text = "Kaptan Değiştir";
            }
            else
            {
                dtpIseGiris.DateTime = DateTime.Today;
                Text = "Kaptan Ekle";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                XtraMessageBox.Show("Ad ve soyad zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sonuc = new
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Maas = spnMaas.Value > 0 ? (decimal?)spnMaas.Value : null,
                IseGirisTarihi = DateOnly.FromDateTime(dtpIseGiris.DateTime)
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
