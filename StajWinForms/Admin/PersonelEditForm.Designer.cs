using DevExpress.XtraEditors;

namespace StajWinForms.Admin
{
    partial class PersonelEditForm
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
            lblAd = new LabelControl();
            txtAd = new TextEdit();
            lblSoyad = new LabelControl();
            txtSoyad = new TextEdit();
            lblEmail = new LabelControl();
            txtEmail = new TextEdit();
            lblUnvan = new LabelControl();
            txtUnvan = new TextEdit();
            lblMaas = new LabelControl();
            spnMaas = new SpinEdit();
            lblIseGiris = new LabelControl();
            dtIseGiris = new DateEdit();
            btnKaydet = new SimpleButton();
            btnIptal = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnvan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnMaas.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtIseGiris.Properties).BeginInit();
            SuspendLayout();
            //
            // lblAd
            //
            lblAd.Location = new Point(16, 20);
            lblAd.Name = "lblAd";
            lblAd.Text = "Ad:";
            //
            // txtAd
            //
            txtAd.Location = new Point(120, 16);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(210, 20);
            txtAd.TabIndex = 0;
            //
            // lblSoyad
            //
            lblSoyad.Location = new Point(16, 55);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Text = "Soyad:";
            //
            // txtSoyad
            //
            txtSoyad.Location = new Point(120, 51);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(210, 20);
            txtSoyad.TabIndex = 1;
            //
            // lblEmail
            //
            lblEmail.Location = new Point(16, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Text = "E-posta:";
            //
            // txtEmail
            //
            txtEmail.Location = new Point(120, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 20);
            txtEmail.TabIndex = 2;
            //
            // lblUnvan
            //
            lblUnvan.Location = new Point(16, 125);
            lblUnvan.Name = "lblUnvan";
            lblUnvan.Text = "Ünvan:";
            //
            // txtUnvan
            //
            txtUnvan.Location = new Point(120, 121);
            txtUnvan.Name = "txtUnvan";
            txtUnvan.Size = new Size(210, 20);
            txtUnvan.TabIndex = 3;
            //
            // lblMaas
            //
            lblMaas.Location = new Point(16, 160);
            lblMaas.Name = "lblMaas";
            lblMaas.Text = "Maaş (₺):";
            //
            // spnMaas
            //
            spnMaas.Location = new Point(120, 156);
            spnMaas.Name = "spnMaas";
            spnMaas.Properties.DisplayFormat.FormatString = "₺#,##0.00";
            spnMaas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spnMaas.Properties.EditFormat.FormatString = "#,##0.00";
            spnMaas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spnMaas.Properties.Increment = 100;
            spnMaas.Properties.MaxValue = 999999;
            spnMaas.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            spnMaas.Size = new Size(210, 20);
            spnMaas.TabIndex = 3;
            //
            // lblIseGiris
            //
            lblIseGiris.Location = new Point(16, 195);
            lblIseGiris.Name = "lblIseGiris";
            lblIseGiris.Text = "İşe Giriş:";
            //
            // dtIseGiris
            //
            dtIseGiris.Location = new Point(120, 191);
            dtIseGiris.Name = "dtIseGiris";
            dtIseGiris.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            dtIseGiris.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            dtIseGiris.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtIseGiris.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            dtIseGiris.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtIseGiris.Size = new Size(210, 20);
            dtIseGiris.TabIndex = 4;
            //
            // btnKaydet
            //
            btnKaydet.Location = new Point(120, 235);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 30);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            //
            // btnIptal
            //
            btnIptal.Location = new Point(230, 235);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 30);
            btnIptal.TabIndex = 6;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            //
            // PersonelEditForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 285);
            Controls.Add(lblAd);
            Controls.Add(txtAd);
            Controls.Add(lblSoyad);
            Controls.Add(txtSoyad);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblUnvan);
            Controls.Add(txtUnvan);
            Controls.Add(lblMaas);
            Controls.Add(spnMaas);
            Controls.Add(lblIseGiris);
            Controls.Add(dtIseGiris);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PersonelEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel";
            Load += PersonelEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnvan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnMaas.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtIseGiris.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal LabelControl lblAd;
        internal TextEdit txtAd;
        internal LabelControl lblSoyad;
        internal TextEdit txtSoyad;
        internal LabelControl lblEmail;
        internal TextEdit txtEmail;
        internal LabelControl lblUnvan;
        internal TextEdit txtUnvan;
        internal LabelControl lblMaas;
        internal SpinEdit spnMaas;
        internal LabelControl lblIseGiris;
        internal DateEdit dtIseGiris;
        internal SimpleButton btnKaydet;
        internal SimpleButton btnIptal;
    }
}
