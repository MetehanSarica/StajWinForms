using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class KullaniciEditForm
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
            lblKullaniciAdi = new LabelControl(); txtKullaniciAdi = new TextEdit();
            lblSifre = new LabelControl(); txtSifre = new TextEdit();
            lblSifreBilgi = new LabelControl();
            lblAdSoyad = new LabelControl(); txtAdSoyad = new TextEdit();
            chkAktif = new CheckEdit();
            btnKaydet = new SimpleButton(); btnIptal = new SimpleButton();

            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkAktif.Properties).BeginInit();
            SuspendLayout();

            lblKullaniciAdi.Location = new System.Drawing.Point(20, 23);
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            txtKullaniciAdi.Location = new System.Drawing.Point(130, 20);
            txtKullaniciAdi.Size = new System.Drawing.Size(220, 20);

            lblAdSoyad.Location = new System.Drawing.Point(20, 55);
            lblAdSoyad.Text = "Ad Soyad:";
            txtAdSoyad.Location = new System.Drawing.Point(130, 52);
            txtAdSoyad.Size = new System.Drawing.Size(220, 20);

            lblSifre.Location = new System.Drawing.Point(20, 87);
            lblSifre.Text = "Şifre:";
            txtSifre.Location = new System.Drawing.Point(130, 84);
            txtSifre.Size = new System.Drawing.Size(220, 20);
            txtSifre.Properties.PasswordChar = '*';

            lblSifreBilgi.Location = new System.Drawing.Point(130, 108);
            lblSifreBilgi.Size = new System.Drawing.Size(220, 13);
            lblSifreBilgi.Appearance.ForeColor = System.Drawing.Color.Gray;

            chkAktif.Location = new System.Drawing.Point(130, 128);
            chkAktif.Size = new System.Drawing.Size(100, 20);
            chkAktif.Properties.Caption = "Aktif";

            btnKaydet.Location = new System.Drawing.Point(130, 156);
            btnKaydet.Size = new System.Drawing.Size(100, 35);
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;

            btnIptal.Location = new System.Drawing.Point(240, 156);
            btnIptal.Size = new System.Drawing.Size(100, 35);
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, 211);
            Controls.Add(lblKullaniciAdi); Controls.Add(txtKullaniciAdi);
            Controls.Add(lblAdSoyad); Controls.Add(txtAdSoyad);
            Controls.Add(lblSifre); Controls.Add(txtSifre);
            Controls.Add(lblSifreBilgi);
            Controls.Add(chkAktif);
            Controls.Add(btnKaydet); Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false; MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Name = "KullaniciEditForm";
            Shown += KullaniciEditForm_Shown;

            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkAktif.Properties).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        #endregion

        private LabelControl lblKullaniciAdi, lblSifre, lblSifreBilgi, lblAdSoyad;
        private TextEdit txtKullaniciAdi, txtSifre, txtAdSoyad;
        private CheckEdit chkAktif;
        private SimpleButton btnKaydet, btnIptal;
    }
}
