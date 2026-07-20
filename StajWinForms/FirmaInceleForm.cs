using DevExpress.XtraEditors;
using static StajWinForms.FirmaBrowserForm;

namespace StajWinForms
{
    public partial class FirmaInceleForm : XtraForm
    {
        public FirmaInceleForm(FirmaModel firma)
        {
            InitializeComponent();
            txtFirmaId.Text = firma.FirmaId.ToString();
            txtFirmaAdi.Text = firma.FirmaAdi;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
