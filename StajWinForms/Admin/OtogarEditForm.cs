using DevExpress.XtraEditors;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http;

namespace StajWinForms.Admin
{
    public partial class OtogarEditForm : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive = true };

        private OtogarDto? _mevcut;

        public OtogarEditForm() 
        { 
            InitializeComponent(); 
        }

        internal OtogarEditForm(OtogarDto otogar) : this()
        {
            _mevcut = otogar;
            Text = "Otogar Düzenle";
        }

        private async void OtogarEditForm_Load(object sender, EventArgs e)
        {
            var sehirler = await _http.GetFromJsonAsync<List<SehirItem>>("api/sehirler", _opts) ?? new();
            cboSehir.Properties.Items.AddRange(sehirler);
            cboSehir.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            if (_mevcut != null)
            {
                cboSehir.SelectedItem = sehirler.FirstOrDefault(s => s.SehirId == _mevcut.SehirId);
                txtAd.Text = _mevcut.OtogarAdi;
                txtAdres.Text = _mevcut.Adres ?? "";
                txtTelefon.Text = _mevcut.Telefon ?? "";
            }

            txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            txtTelefon.Properties.Mask.EditMask = @"\0(000) 000 00 00";
            txtTelefon.MouseUp += (s, e) =>
            {
                int firstEmpty = txtTelefon.Text.IndexOf('_');
                txtTelefon.SelectionStart = firstEmpty >= 0 ? firstEmpty : txtTelefon.Text.Length;
            };
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cboSehir.SelectedItem is not SehirItem sehir || string.IsNullOrWhiteSpace(txtAd.Text))
            {
                XtraMessageBox.Show("Şehir ve Otogar Adı zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }

            var dto = new
            {
                SehirId = sehir.SehirId,
                OtogarAdi = txtAd.Text.Trim(),
                Adres = txtAdres.Text.Trim(),
                Telefon = txtTelefon.Text.Trim()
            };

            HttpResponseMessage resp;
            if (_mevcut == null)
                resp = await _http.PostAsJsonAsync("api/otogarlar", dto);
            else
                resp = await _http.PutAsJsonAsync($"api/otogarlar/{_mevcut.OtogarId}", dto);

            if (resp.IsSuccessStatusCode)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                XtraMessageBox.Show(await resp.Content.ReadAsStringAsync(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        record SehirItem(int SehirId, string SehirAdi) { public override string ToString() => SehirAdi; }
    }

    class OtogarDto
    {
        public int OtogarId { get; set; }
        public int SehirId { get; set; }
        public string SehirAdi { get; set; } = "";
        public string OtogarAdi { get; set; } = "";
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
    }
}
