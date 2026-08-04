using DevExpress.XtraEditors;

namespace StajWinForms.Admin
{
    partial class MusteriEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtAd = new TextEdit();
            txtSoyad = new TextEdit();
            txtTc = new TextEdit();
            txtEmail = new TextEdit();
            txtTelefon = new TextEdit();
            txtSehir = new TextEdit();
            cmbCinsiyet = new ComboBoxEdit();
            dtKayitTarihi = new DateEdit();
            btnKaydet = new SimpleButton();
            btnIptal = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTc.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSehir.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCinsiyet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtKayitTarihi.Properties).BeginInit();
            SuspendLayout();
            //
            // txtAd
            //
            txtAd.Location = new Point(110, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 20);
            txtAd.TabIndex = 0;
            //
            // txtSoyad
            //
            txtSoyad.Location = new Point(110, 47);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(220, 20);
            txtSoyad.TabIndex = 1;
            //
            // txtTc
            //
            txtTc.Location = new Point(110, 82);
            txtTc.Name = "txtTc";
            txtTc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtTc.Properties.Mask.EditMask = "[1-9][0-9]{10}";
            txtTc.Size = new Size(220, 20);
            txtTc.TabIndex = 2;
            //
            // txtEmail
            //
            txtEmail.Location = new Point(110, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 20);
            txtEmail.TabIndex = 3;
            //
            // txtTelefon
            //
            txtTelefon.Location = new Point(110, 152);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtTelefon.Properties.Mask.EditMask = "0[0-9]{10}";
            txtTelefon.Size = new Size(220, 20);
            txtTelefon.TabIndex = 4;
            //
            // txtSehir
            //
            txtSehir.Location = new Point(110, 187);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(220, 20);
            txtSehir.TabIndex = 5;
            //
            // cmbCinsiyet
            //
            cmbCinsiyet.Location = new Point(110, 222);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbCinsiyet.Size = new Size(220, 20);
            cmbCinsiyet.TabIndex = 6;
            //
            // dtKayitTarihi
            //
            dtKayitTarihi.Location = new Point(110, 257);
            dtKayitTarihi.Name = "dtKayitTarihi";
            dtKayitTarihi.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            dtKayitTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtKayitTarihi.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            dtKayitTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtKayitTarihi.Size = new Size(220, 20);
            dtKayitTarihi.TabIndex = 7;
            //
            // btnKaydet
            //
            btnKaydet.Location = new Point(110, 300);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 30);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            //
            // btnIptal
            //
            btnIptal.Location = new Point(220, 300);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 30);
            btnIptal.TabIndex = 9;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            //
            // Labels
            //
            var lblAd = new LabelControl { Text = "Ad *", Location = new Point(12, 15), Size = new Size(90, 13), AutoSizeMode = LabelAutoSizeMode.None };
            var lblSoyad = new LabelControl { Text = "Soyad *", Location = new Point(12, 50), Size = new Size(90, 13), AutoSizeMode = LabelAutoSizeMode.None };
            var lblTc = new LabelControl { Text = "TC *", Location = new Point(12, 85), Size = new Size(90, 13), AutoSizeMode = LabelAutoSizeMode.None };
            var lblEmail = new LabelControl { Text = "E-posta", Location = new Point(12, 120), Size = new Size(90, 13), AutoSizeMode = LabelAutoSizeMode.None };
            var lblTelefon = new LabelControl { Text = "Telefon", Location = new Point(12, 155), Size = new Size(90, 13), AutoSizeMode = LabelAutoSizeMode.None };
            var lblSehir = new LabelControl { Text = "Şehir", Location = new Point(12, 190), Size = new Size(90, 13), AutoSizeMode = LabelAutoSizeMode.None };
            var lblCinsiyet = new LabelControl { Text = "Cinsiyet", Location = new Point(12, 225), Size = new Size(90, 13), AutoSizeMode = LabelAutoSizeMode.None };
            var lblKayit = new LabelControl { Text = "Kayıt Tarihi", Location = new Point(12, 260), Size = new Size(90, 13), AutoSizeMode = LabelAutoSizeMode.None };
            //
            // MusteriEditForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 345);
            Controls.AddRange(new Control[] {
                lblAd, txtAd, lblSoyad, txtSoyad, lblTc, txtTc,
                lblEmail, txtEmail, lblTelefon, txtTelefon,
                lblSehir, txtSehir, lblCinsiyet, cmbCinsiyet,
                lblKayit, dtKayitTarihi, btnKaydet, btnIptal
            });
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MusteriEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Müşteri";
            Load += MusteriEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTc.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSehir.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCinsiyet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtKayitTarihi.Properties).EndInit();
            ResumeLayout(false);
        }

        private TextEdit txtAd, txtSoyad, txtTc, txtEmail, txtTelefon, txtSehir;
        private ComboBoxEdit cmbCinsiyet;
        private DateEdit dtKayitTarihi;
        private SimpleButton btnKaydet, btnIptal;
    }
}
