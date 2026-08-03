using DevExpress.XtraEditors;

namespace StajWinForms.Admin
{
    partial class SeferEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFirma = new LabelControl();
            cboFirma = new ComboBoxEdit();
            lblKalkis = new LabelControl();
            cboKalkis = new ComboBoxEdit();
            lblVaris = new LabelControl();
            cboVaris = new ComboBoxEdit();
            lblZaman = new LabelControl();
            dtKalkisZamani = new DateEdit();
            lblSure = new LabelControl();
            spSure = new SpinEdit();
            lblFiyat = new LabelControl();
            spFiyat = new SpinEdit();
            lblKapasite = new LabelControl();
            spKapasite = new SpinEdit();
            btnKaydet = new SimpleButton();
            btnIptal = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)cboFirma.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboKalkis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboVaris.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtKalkisZamani.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spSure.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spFiyat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spKapasite.Properties).BeginInit();
            SuspendLayout();
            //
            // lblFirma
            //
            lblFirma.Location = new Point(16, 20);
            lblFirma.Name = "lblFirma";
            lblFirma.Text = "Firma:";
            //
            // cboFirma
            //
            cboFirma.Location = new Point(130, 16);
            cboFirma.Name = "cboFirma";
            cboFirma.Size = new Size(220, 20);
            cboFirma.TabIndex = 0;
            //
            // lblKalkis
            //
            lblKalkis.Location = new Point(16, 55);
            lblKalkis.Name = "lblKalkis";
            lblKalkis.Text = "Kalkış Şehri:";
            //
            // cboKalkis
            //
            cboKalkis.Location = new Point(130, 51);
            cboKalkis.Name = "cboKalkis";
            cboKalkis.Size = new Size(220, 20);
            cboKalkis.TabIndex = 1;
            //
            // lblVaris
            //
            lblVaris.Location = new Point(16, 90);
            lblVaris.Name = "lblVaris";
            lblVaris.Text = "Varış Şehri:";
            //
            // cboVaris
            //
            cboVaris.Location = new Point(130, 86);
            cboVaris.Name = "cboVaris";
            cboVaris.Size = new Size(220, 20);
            cboVaris.TabIndex = 2;
            //
            // lblZaman
            //
            lblZaman.Location = new Point(16, 125);
            lblZaman.Name = "lblZaman";
            lblZaman.Text = "Kalkış Zamanı:";
            //
            // dtKalkisZamani
            //
            dtKalkisZamani.EditValue = null;
            dtKalkisZamani.Location = new Point(130, 121);
            dtKalkisZamani.Name = "dtKalkisZamani";
            dtKalkisZamani.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            dtKalkisZamani.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtKalkisZamani.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm";
            dtKalkisZamani.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtKalkisZamani.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dtKalkisZamani.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm";
            dtKalkisZamani.Size = new Size(220, 20);
            dtKalkisZamani.TabIndex = 3;
            //
            // lblSure
            //
            lblSure.Location = new Point(16, 160);
            lblSure.Name = "lblSure";
            lblSure.Text = "Süre (dk):";
            //
            // spSure
            //
            spSure.Location = new Point(130, 156);
            spSure.Name = "spSure";
            spSure.Properties.IsFloatValue = false;
            spSure.Properties.MaxValue = 9999;
            spSure.Properties.MinValue = 0;
            spSure.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            spSure.Properties.DisplayFormat.FormatString = "{0:0}";
            spSure.Properties.EditFormat.FormatString = "{0:0}";
            spSure.Size = new Size(220, 20);
            spSure.TabIndex = 4;
            //
            // lblFiyat
            //
            lblFiyat.Location = new Point(16, 195);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Text = "Fiyat (₺):";
            //
            // spFiyat
            //
            spFiyat.Location = new Point(130, 191);
            spFiyat.Name = "spFiyat";
            spFiyat.Properties.MaxValue = 99999;
            spFiyat.Properties.MinValue = 0;
            spFiyat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            spFiyat.Properties.DisplayFormat.FormatString = "{0:0.##}";
            spFiyat.Properties.EditFormat.FormatString = "{0:0.##}";
            spFiyat.Size = new Size(220, 20);
            spFiyat.TabIndex = 5;
            //
            // lblKapasite
            //
            lblKapasite.Location = new Point(16, 230);
            lblKapasite.Name = "lblKapasite";
            lblKapasite.Text = "Kapasite:";
            //
            // spKapasite
            //
            spKapasite.Location = new Point(130, 226);
            spKapasite.Name = "spKapasite";
            spKapasite.Properties.IsFloatValue = false;
            spKapasite.Properties.MaxValue = 999;
            spKapasite.Properties.MinValue = 0;
            spKapasite.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            spKapasite.Properties.DisplayFormat.FormatString = "{0:0}";
            spKapasite.Properties.EditFormat.FormatString = "{0:0}";
            spKapasite.Size = new Size(220, 20);
            spKapasite.TabIndex = 6;
            //
            // btnKaydet
            //
            btnKaydet.Location = new Point(130, 265);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 30);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            //
            // btnIptal
            //
            btnIptal.Location = new Point(250, 265);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 30);
            btnIptal.TabIndex = 8;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            //
            // SeferEditForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 315);
            Controls.Add(lblFirma);
            Controls.Add(cboFirma);
            Controls.Add(lblKalkis);
            Controls.Add(cboKalkis);
            Controls.Add(lblVaris);
            Controls.Add(cboVaris);
            Controls.Add(lblZaman);
            Controls.Add(dtKalkisZamani);
            Controls.Add(lblSure);
            Controls.Add(spSure);
            Controls.Add(lblFiyat);
            Controls.Add(spFiyat);
            Controls.Add(lblKapasite);
            Controls.Add(spKapasite);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SeferEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sefer";
            Load += SeferEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)cboFirma.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboKalkis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboVaris.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtKalkisZamani.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spSure.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spFiyat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spKapasite.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal LabelControl lblFirma;
        internal ComboBoxEdit cboFirma;
        internal LabelControl lblKalkis;
        internal ComboBoxEdit cboKalkis;
        internal LabelControl lblVaris;
        internal ComboBoxEdit cboVaris;
        internal LabelControl lblZaman;
        internal DateEdit dtKalkisZamani;
        internal LabelControl lblSure;
        internal SpinEdit spSure;
        internal LabelControl lblFiyat;
        internal SpinEdit spFiyat;
        internal LabelControl lblKapasite;
        internal SpinEdit spKapasite;
        internal SimpleButton btnKaydet;
        internal SimpleButton btnIptal;
    }
}
