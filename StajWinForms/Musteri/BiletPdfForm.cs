using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraPdfViewer;

namespace StajWinForms.Musteri
{
    public partial class BiletPdfForm : XtraForm
    {
        public BiletPdfForm(BiletReport report)
        {
            InitializeComponent();
            using var stream = new MemoryStream();
            report.ExportToPdf(stream);
            stream.Position = 0;
            pdfViewer.LoadDocument(stream);
        }
    }
}
