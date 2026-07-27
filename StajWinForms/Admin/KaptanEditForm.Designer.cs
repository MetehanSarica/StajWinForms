using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class KaptanEditForm
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
            lblAd = new LabelControl(); txtAd = new TextEdit();
            lblSoyad = new LabelControl(); txtSoyad = new TextEdit();
            lblEmail = new LabelControl(); txtEmail = new TextEdit();
            lblMaas = new LabelControl(); spnMaas = new SpinEdit();
            lblIseGiris = new LabelControl(); dtpIseGiris = new DateEdit();
            btnKaydet = new SimpleButton(); btnIptal = new SimpleButton();

            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnMaas.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpIseGiris.Properties).BeginInit();
            SuspendLayout();

            lblAd.Location = new System.Drawing.Point(20, 23);
            lblAd.Text = "Ad:";
            txtAd.Location = new System.Drawing.Point(130, 20);
            txtAd.Size = new System.Drawing.Size(220, 20);

            lblSoyad.Location = new System.Drawing.Point(20, 55);
            lblSoyad.Text = "Soyad:";
            txtSoyad.Location = new System.Drawing.Point(130, 52);
            txtSoyad.Size = new System.Drawing.Size(220, 20);

            lblEmail.Location = new System.Drawing.Point(20, 87);
            lblEmail.Text = "E-posta:";
            txtEmail.Location = new System.Drawing.Point(130, 84);
            txtEmail.Size = new System.Drawing.Size(220, 20);

            lblMaas.Location = new System.Drawing.Point(20, 119);
            lblMaas.Text = "Maaş (₺):";
            spnMaas.Location = new System.Drawing.Point(130, 116);
            spnMaas.Size = new System.Drawing.Size(220, 20);
            spnMaas.Properties.MinValue = 0;
            spnMaas.Properties.MaxValue = 999999;
            spnMaas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

            lblIseGiris.Location = new System.Drawing.Point(20, 151);
            lblIseGiris.Text = "İşe Giriş:";
            dtpIseGiris.Location = new System.Drawing.Point(130, 148);
            dtpIseGiris.Size = new System.Drawing.Size(220, 20);

            btnKaydet.Location = new System.Drawing.Point(130, 190);
            btnKaydet.Size = new System.Drawing.Size(100, 35);
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;

            btnIptal.Location = new System.Drawing.Point(240, 190);
            btnIptal.Size = new System.Drawing.Size(100, 35);
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, 245);
            Controls.Add(lblAd); Controls.Add(txtAd);
            Controls.Add(lblSoyad); Controls.Add(txtSoyad);
            Controls.Add(lblEmail); Controls.Add(txtEmail);
            Controls.Add(lblMaas); Controls.Add(spnMaas);
            Controls.Add(lblIseGiris); Controls.Add(dtpIseGiris);
            Controls.Add(btnKaydet); Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false; MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Name = "KaptanEditForm";
            Shown += KaptanEditForm_Shown;

            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnMaas.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpIseGiris.Properties).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        #endregion

        private LabelControl lblAd, lblSoyad, lblEmail, lblMaas, lblIseGiris;
        private TextEdit txtAd, txtSoyad, txtEmail;
        private SpinEdit spnMaas;
        private DateEdit dtpIseGiris;
        private SimpleButton btnKaydet, btnIptal;
    }
}
