using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class FirmaInceleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblFirmaId = new LabelControl();
            txtFirmaId = new TextEdit();
            lblFirmaAdi = new LabelControl();
            txtFirmaAdi = new TextEdit();
            btnKapat = new SimpleButton();

            ((System.ComponentModel.ISupportInitialize)txtFirmaId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFirmaAdi.Properties).BeginInit();
            SuspendLayout();

            lblFirmaId.Location = new System.Drawing.Point(20, 23);
            lblFirmaId.Text = "Firma ID:";

            txtFirmaId.Location = new System.Drawing.Point(130, 20);
            txtFirmaId.Size = new System.Drawing.Size(220, 20);
            txtFirmaId.ReadOnly = true;

            lblFirmaAdi.Location = new System.Drawing.Point(20, 55);
            lblFirmaAdi.Text = "Firma Adı:";

            txtFirmaAdi.Location = new System.Drawing.Point(130, 52);
            txtFirmaAdi.Size = new System.Drawing.Size(220, 20);
            txtFirmaAdi.ReadOnly = true;

            btnKapat.Location = new System.Drawing.Point(130, 90);
            btnKapat.Size = new System.Drawing.Size(100, 35);
            btnKapat.Text = "Kapat";
            btnKapat.Click += btnKapat_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, 145);
            Controls.Add(lblFirmaId); Controls.Add(txtFirmaId);
            Controls.Add(lblFirmaAdi); Controls.Add(txtFirmaAdi);
            Controls.Add(btnKapat);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false; MinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Name = "FirmaInceleForm";
            Text = "Firma Detayı";

            ((System.ComponentModel.ISupportInitialize)txtFirmaId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFirmaAdi.Properties).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        #endregion

        private LabelControl lblFirmaId, lblFirmaAdi;
        private TextEdit txtFirmaId, txtFirmaAdi;
        private SimpleButton btnKapat;
    }
}
