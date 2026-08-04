using DevExpress.XtraPdfViewer;

namespace StajWinForms.Musteri
{
    partial class BiletPdfForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pdfViewer = new PdfViewer();
            SuspendLayout();
            //
            // pdfViewer
            //
            pdfViewer.Dock = DockStyle.Fill;
            pdfViewer.Name = "pdfViewer";
            pdfViewer.TabIndex = 0;
            //
            // BiletPdfForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            Controls.Add(pdfViewer);
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BiletPdfForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bilet Önizleme";
            ResumeLayout(false);
        }

        private PdfViewer pdfViewer;
    }
}
