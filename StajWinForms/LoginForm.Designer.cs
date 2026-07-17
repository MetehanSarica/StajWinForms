using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBaslik = new LabelControl();
            lblKullaniciAdi = new LabelControl();
            txtKullaniciAdi = new TextEdit();
            lblSifre = new LabelControl();
            txtSifre = new TextEdit();
            btnGiris = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).BeginInit();
            SuspendLayout();

            // lblBaslik
            lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            lblBaslik.Location = new System.Drawing.Point(90, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new System.Drawing.Size(220, 30);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Admin Paneli Girişi";

            // lblKullaniciAdi
            lblKullaniciAdi.Location = new System.Drawing.Point(40, 90);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new System.Drawing.Size(80, 13);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";

            // txtKullaniciAdi
            txtKullaniciAdi.Location = new System.Drawing.Point(140, 87);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new System.Drawing.Size(200, 20);
            txtKullaniciAdi.TabIndex = 2;

            // lblSifre
            lblSifre.Location = new System.Drawing.Point(40, 130);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new System.Drawing.Size(40, 13);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre:";

            // txtSifre
            txtSifre.Location = new System.Drawing.Point(140, 127);
            txtSifre.Name = "txtSifre";
            txtSifre.Properties.PasswordChar = '*';
            txtSifre.Size = new System.Drawing.Size(200, 20);
            txtSifre.TabIndex = 4;
            txtSifre.KeyDown += txtSifre_KeyDown;

            // btnGiris
            btnGiris.Location = new System.Drawing.Point(140, 170);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new System.Drawing.Size(200, 35);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş Yap";
            btnGiris.Click += btnGiris_Click;

            // LoginForm
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 240);
            Controls.Add(lblBaslik);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(txtSifre);
            Controls.Add(btnGiris);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Girişi";

            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblBaslik;
        private LabelControl lblKullaniciAdi;
        private TextEdit txtKullaniciAdi;
        private LabelControl lblSifre;
        private TextEdit txtSifre;
        private SimpleButton btnGiris;
    }
}
