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

            int lx = 20, tx = 130, tw = 220, th = 20, gap = 12, y = 20;

            lblKullaniciAdi.Location = new System.Drawing.Point(lx, y + 3); lblKullaniciAdi.Text = "Kullanıcı Adı:";
            txtKullaniciAdi.Location = new System.Drawing.Point(tx, y); txtKullaniciAdi.Size = new System.Drawing.Size(tw, th); y += th + gap;

            lblAdSoyad.Location = new System.Drawing.Point(lx, y + 3); lblAdSoyad.Text = "Ad Soyad:";
            txtAdSoyad.Location = new System.Drawing.Point(tx, y); txtAdSoyad.Size = new System.Drawing.Size(tw, th); y += th + gap;

            lblSifre.Location = new System.Drawing.Point(lx, y + 3); lblSifre.Text = "Şifre:";
            txtSifre.Location = new System.Drawing.Point(tx, y); txtSifre.Size = new System.Drawing.Size(tw, th);
            txtSifre.Properties.PasswordChar = '*'; y += th + 4;

            lblSifreBilgi.Location = new System.Drawing.Point(tx, y);
            lblSifreBilgi.Size = new System.Drawing.Size(tw, 13);
            lblSifreBilgi.Appearance.ForeColor = System.Drawing.Color.Gray;
            y += 20;

            chkAktif.Location = new System.Drawing.Point(tx, y); chkAktif.Size = new System.Drawing.Size(100, 20);
            chkAktif.Properties.Caption = "Aktif"; y += 28;

            btnKaydet.Location = new System.Drawing.Point(tx, y); btnKaydet.Size = new System.Drawing.Size(100, 35);
            btnKaydet.Text = "Kaydet"; btnKaydet.Click += btnKaydet_Click;

            btnIptal.Location = new System.Drawing.Point(tx + 110, y); btnIptal.Size = new System.Drawing.Size(100, 35);
            btnIptal.Text = "İptal"; btnIptal.Click += btnIptal_Click;
            y += 35 + 20;

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, y);
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
