using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Text.Json;
using System.Net.Http;

namespace StajWinForms.Admin
{
    public partial class SeferEditForm : XtraForm
    {
        private static readonly HttpClient _http = AppConfig.Http;
        private static readonly JsonSerializerOptions _opts = new() { PropertyNameCaseInsensitive  = true };

        private SeferDto? _mevcut;

        public SeferEditForm() { InitializeComponent(); }

        internal SeferEditForm(SeferDto sefer) : this()
        {
            _mevcut = sefer;
            Text = "Sefer Düzenle";
        }

        private async void SeferEditForm_Load(object sender, EventArgs e)
        {
            var firmalar = await _http.GetFromJsonAsync<List<FirmaItem>>("api/firmalar", _opts) ?? new();
            cboFirma.Properties.Items.AddRange(firmalar);

            var sehirler = await _http.GetFromJsonAsync<List<SehirItem>>("api/sehirler", _opts) ?? new();
            cboKalkis.Properties.Items.AddRange(sehirler);
            cboVaris.Properties.Items.AddRange(sehirler);

            cboFirma.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cboKalkis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cboVaris.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            dtKalkisZamani.MouseClick += (s, ev) => dtKalkisZamani.ShowPopup();

            if (_mevcut != null)
            {
                cboFirma.SelectedItem = firmalar.FirstOrDefault(f => f.FirmaId == _mevcut.FirmaId);
                cboKalkis.SelectedItem = sehirler.FirstOrDefault(s => s.SehirId == _mevcut.KalkisSehirId);
                cboVaris.SelectedItem = sehirler.FirstOrDefault(s => s.SehirId == _mevcut.VarisSehirId);
                dtKalkisZamani.EditValue = _mevcut.KalkisZamani;
                spSure.Value = _mevcut.SureDakika;
                spFiyat.Value = _mevcut.Fiyat;
                spKapasite.Value = _mevcut.KoltukKapasitesi;
            }
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cboFirma.SelectedItem is not FirmaItem firma ||
                cboKalkis.SelectedItem is not SehirItem kalkis ||
                cboVaris.SelectedItem is not SehirItem varis ||
                dtKalkisZamani.EditValue == null)
            {
                XtraMessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new
            {
                FirmaId = firma.FirmaId,
                KalkisSehirId = kalkis.SehirId,
                VarisSehirId = varis.SehirId,
                KalkisZamani = (DateTime)dtKalkisZamani.EditValue,
                SureDakika = (int)spSure.Value,
                Fiyat = spFiyat.Value,
                KoltukKapasitesi = (int)spKapasite.Value
            };

            HttpResponseMessage resp;
            if (_mevcut == null)
                resp = await _http.PostAsJsonAsync("api/seferler", dto);
            else
                resp = await _http.PutAsJsonAsync($"api/seferler/{_mevcut.SeferId}", dto);

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

        record FirmaItem(int FirmaId, string FirmaAdi) { public override string ToString() => FirmaAdi; }
        record SehirItem(int SehirId, string SehirAdi) { public override string ToString() => SehirAdi; }
    }
}
