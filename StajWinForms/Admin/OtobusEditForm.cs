using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Internal;
using StajWinForms.Admin;

namespace StajWinForms
{
    public partial class OtobusEditForm : XtraForm
    {
        public object Sonuc { get; private set; } = null!;
        private Boolean incele = false;

        public OtobusEditForm(OtobusModel? mevcut, List<FirmaComboItem> firmalar, Boolean _incele = false)
        {
            InitializeComponent();
            incele = _incele;
            cmbFirma.Items.Add(new FirmaComboItem { FirmaId = 0, FirmaAdi = "(Firma Yok)" });
            foreach (var f in firmalar) cmbFirma.Items.Add(f);
            cmbFirma.DisplayMember = "FirmaAdi";

            if (mevcut != null)
            {
                txtPlaka.Text = mevcut.Plaka;
                txtMarka.Text = mevcut.Marka ?? "";
                txtModel.Text = mevcut.Model ?? "";
                spnKoltuk.Value = mevcut.KoltukKapasitesi;
                var secili = cmbFirma.Items.Cast<FirmaComboItem>().FirstOrDefault(f => f.FirmaId == mevcut.FirmaId);
                cmbFirma.SelectedItem = secili ?? cmbFirma.Items[0];
                Text = "Otobüs Değiştir";
            }
            else
            {
                cmbFirma.SelectedIndex = 0;
                spnKoltuk.Value = 36;
                Text = "Otobüs Ekle";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaka.Text))
            {
                XtraMessageBox.Show("Plaka boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPlaka.Text.Length < 7 || txtPlaka.Text.Length > 9)
            {
                XtraMessageBox.Show("Geçersiz plaka.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                XtraMessageBox.Show("Marka boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                XtraMessageBox.Show("Model boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var firma = cmbFirma.SelectedItem as FirmaComboItem;
            Sonuc = new
            {
                Plaka = txtPlaka.Text.Trim().ToUpperInvariant(),
                Marka = string.IsNullOrWhiteSpace(txtMarka.Text) ? null : txtMarka.Text.Trim(),
                Model = string.IsNullOrWhiteSpace(txtModel.Text) ? null : txtModel.Text.Trim(),
                KoltukKapasitesi = (int)spnKoltuk.Value,
                FirmaId = (firma?.FirmaId > 0) ? (int?)firma.FirmaId : null
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtPlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            if (!char.IsLetterOrDigit(e.KeyChar)) { e.Handled = true; return; }
            e.KeyChar = char.ToUpperInvariant(e.KeyChar);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OtobusEditForm_Shown(object sender, EventArgs e)
        {
            if (incele)
            {
                txtPlaka.ReadOnly = true;
                txtMarka.ReadOnly = true;
                txtModel.ReadOnly = true;
                spnKoltuk.ReadOnly = true;
                cmbFirma.Enabled = false;
                btnKaydet.Visible = false;
                btnIptal.Text = "Kapat";
            }
        }
    }
}
