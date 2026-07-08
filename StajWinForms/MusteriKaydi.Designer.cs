using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class MusteriKaydi
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
            lblKoltukBilgi = new LabelControl();
            lblTC = new LabelControl();
            txtboxTC = new TextEdit();
            lblAd = new LabelControl();
            txtboxAd = new TextEdit();
            lblSoyad = new LabelControl();
            txtboxSoyad = new TextEdit();
            lblEmail = new LabelControl();
            txtboxEmail = new TextEdit();
            lblTelefon = new LabelControl();
            txtboxTelefon = new TextEdit();
            lblSehir = new LabelControl();
            txtboxSehir = new TextEdit();
            lblAdres = new LabelControl();
            txtboxAdres = new TextEdit();
            btnBiletOlustur = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtboxTC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxTelefon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSehir.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAdres.Properties).BeginInit();
            SuspendLayout();
            //
            // lblKoltukBilgi
            //
            lblKoltukBilgi.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKoltukBilgi.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            lblKoltukBilgi.Appearance.Options.UseFont = true;
            lblKoltukBilgi.Appearance.Options.UseForeColor = true;
            lblKoltukBilgi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblKoltukBilgi.Location = new Point(20, 12);
            lblKoltukBilgi.Name = "lblKoltukBilgi";
            lblKoltukBilgi.Size = new Size(380, 22);
            lblKoltukBilgi.TabIndex = 16;
            lblKoltukBilgi.Text = "Seçilen Koltuk: -";
            //
            // lblTC
            //
            lblTC.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTC.Appearance.Options.UseFont = true;
            lblTC.Location = new Point(20, 57);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(95, 17);
            lblTC.TabIndex = 0;
            lblTC.Text = "TC Kimlik No:";
            //
            // txtboxTC
            //
            txtboxTC.Location = new Point(120, 55);
            txtboxTC.Name = "txtboxTC";
            txtboxTC.Size = new Size(270, 20);
            txtboxTC.TabIndex = 1;
            txtboxTC.EditValueChanged += txtboxTC_TextChanged;
            //
            // lblAd
            //
            lblAd.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAd.Appearance.Options.UseFont = true;
            lblAd.Location = new Point(20, 92);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(95, 17);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad:";
            //
            // txtboxAd
            //
            txtboxAd.Location = new Point(120, 90);
            txtboxAd.Name = "txtboxAd";
            txtboxAd.Size = new Size(270, 20);
            txtboxAd.TabIndex = 3;
            //
            // lblSoyad
            //
            lblSoyad.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoyad.Appearance.Options.UseFont = true;
            lblSoyad.Location = new Point(20, 127);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(95, 17);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad:";
            //
            // txtboxSoyad
            //
            txtboxSoyad.Location = new Point(120, 125);
            txtboxSoyad.Name = "txtboxSoyad";
            txtboxSoyad.Size = new Size(270, 20);
            txtboxSoyad.TabIndex = 5;
            //
            // lblEmail
            //
            lblEmail.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Appearance.Options.UseFont = true;
            lblEmail.Location = new Point(20, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(95, 17);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            //
            // txtboxEmail
            //
            txtboxEmail.Location = new Point(120, 160);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(270, 20);
            txtboxEmail.TabIndex = 7;
            //
            // lblTelefon
            //
            lblTelefon.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefon.Appearance.Options.UseFont = true;
            lblTelefon.Location = new Point(20, 197);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(95, 17);
            lblTelefon.TabIndex = 8;
            lblTelefon.Text = "Telefon:";
            //
            // txtboxTelefon
            //
            txtboxTelefon.Location = new Point(120, 195);
            txtboxTelefon.Name = "txtboxTelefon";
            txtboxTelefon.Size = new Size(270, 20);
            txtboxTelefon.TabIndex = 9;
            txtboxTelefon.EditValueChanged += txtboxTelefon_TextChanged;
            //
            // lblSehir
            //
            lblSehir.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSehir.Appearance.Options.UseFont = true;
            lblSehir.Location = new Point(20, 232);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(95, 17);
            lblSehir.TabIndex = 10;
            lblSehir.Text = "Şehir:";
            //
            // txtboxSehir
            //
            txtboxSehir.Location = new Point(120, 230);
            txtboxSehir.Name = "txtboxSehir";
            txtboxSehir.Size = new Size(270, 20);
            txtboxSehir.TabIndex = 11;
            //
            // lblAdres
            //
            lblAdres.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdres.Appearance.Options.UseFont = true;
            lblAdres.Location = new Point(20, 267);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(95, 17);
            lblAdres.TabIndex = 12;
            lblAdres.Text = "Adres:";
            //
            // txtboxAdres
            //
            txtboxAdres.Location = new Point(120, 265);
            txtboxAdres.Name = "txtboxAdres";
            txtboxAdres.Size = new Size(270, 20);
            txtboxAdres.TabIndex = 13;
            //
            // btnBiletOlustur
            //
            btnBiletOlustur.Location = new Point(142, 305);
            btnBiletOlustur.Name = "btnBiletOlustur";
            btnBiletOlustur.Size = new Size(135, 32);
            btnBiletOlustur.TabIndex = 14;
            btnBiletOlustur.Text = "Bilet Oluştur";
            btnBiletOlustur.Click += btnBiletOlustur_Click;
            //
            // MusteriKaydi
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 357);
            Controls.Add(lblKoltukBilgi);
            Controls.Add(lblTC);
            Controls.Add(txtboxTC);
            Controls.Add(lblAd);
            Controls.Add(txtboxAd);
            Controls.Add(lblSoyad);
            Controls.Add(txtboxSoyad);
            Controls.Add(lblEmail);
            Controls.Add(txtboxEmail);
            Controls.Add(lblTelefon);
            Controls.Add(txtboxTelefon);
            Controls.Add(lblSehir);
            Controls.Add(txtboxSehir);
            Controls.Add(lblAdres);
            Controls.Add(txtboxAdres);
            Controls.Add(btnBiletOlustur);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MusteriKaydi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Müşteri Kaydı";
            ((System.ComponentModel.ISupportInitialize)txtboxTC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxTelefon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSehir.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAdres.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblKoltukBilgi;
        private LabelControl lblTC;
        private TextEdit txtboxTC;
        private LabelControl lblAd;
        private TextEdit txtboxAd;
        private LabelControl lblSoyad;
        private TextEdit txtboxSoyad;
        private LabelControl lblEmail;
        private TextEdit txtboxEmail;
        private LabelControl lblTelefon;
        private TextEdit txtboxTelefon;
        private LabelControl lblSehir;
        private TextEdit txtboxSehir;
        private LabelControl lblAdres;
        private TextEdit txtboxAdres;
        private SimpleButton btnBiletOlustur;
    }
}
