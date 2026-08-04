using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraPdfViewer;

namespace StajWinForms.Musteri
{
    public partial class BiletPdfForm : XtraForm
    {
        private readonly MemoryStream _pdfStream;

        public BiletPdfForm(BiletReport report)
        {
            InitializeComponent();
            _pdfStream = new MemoryStream();
            report.ExportToPdf(_pdfStream);
            _pdfStream.Position = 0;
            pdfViewer.LoadDocument(_pdfStream);
            pdfViewer.ZoomMode = PdfZoomMode.FitToVisible;
        }
    }
}
