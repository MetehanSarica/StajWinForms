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
            spTC = new SpinEdit();
            lblAd = new LabelControl();
            txtboxAd = new TextEdit();
            lblSoyad = new LabelControl();
            txtboxSoyad = new TextEdit();
            lblEmail = new LabelControl();
            txtboxEmail = new TextEdit();
            lblTelefon = new LabelControl();
            txtboxTelefon = new TextEdit();
            lblSehir = new LabelControl();
            cmbSehir = new ComboBoxEdit();
            lblAdres = new LabelControl();
            memoAdres = new MemoEdit();
            lblCinsiyet = new LabelControl();
            cmbCinsiyet = new ComboBoxEdit();
            btnBiletOlustur = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)spTC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxTelefon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbSehir.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoAdres.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbCinsiyet.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblKoltukBilgi
            // 
            lblKoltukBilgi.Appearance.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKoltukBilgi.Appearance.ForeColor = Color.DarkBlue;
            lblKoltukBilgi.Appearance.Options.UseFont = true;
            lblKoltukBilgi.Appearance.Options.UseForeColor = true;
            lblKoltukBilgi.AutoSizeMode = LabelAutoSizeMode.None;
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
            lblTC.Size = new Size(74, 15);
            lblTC.TabIndex = 0;
            lblTC.Text = "TC Kimlik No:";
            // 
            // spTC
            //
            spTC.Location = new Point(120, 55);
            spTC.Name = "spTC";
            spTC.Properties.AllowMouseWheel = false;
            spTC.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            spTC.Properties.MaskSettings.Set("mask", "d");
            spTC.Properties.MaxLength = 11;
            spTC.Size = new Size(270, 20);
            spTC.TabIndex = 1;
            spTC.EditValueChanged += spTC_EditValueChanged;
            // 
            // lblAd
            // 
            lblAd.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAd.Appearance.Options.UseFont = true;
            lblAd.Location = new Point(20, 92);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(18, 15);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad:";
            // 
            // txtboxAd
            // 
            txtboxAd.Location = new Point(120, 90);
            txtboxAd.Name = "txtboxAd";
            txtboxAd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtboxAd.Properties.Mask.EditMask = "[a-zA-ZçÇğĞıİöÖşŞüÜ ]+";
            txtboxAd.Size = new Size(270, 20);
            txtboxAd.TabIndex = 3;
            // 
            // lblSoyad
            // 
            lblSoyad.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoyad.Appearance.Options.UseFont = true;
            lblSoyad.Location = new Point(20, 127);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(36, 15);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Soyad:";
            // 
            // txtboxSoyad
            // 
            txtboxSoyad.Location = new Point(120, 125);
            txtboxSoyad.Name = "txtboxSoyad";
            txtboxSoyad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtboxSoyad.Properties.Mask.EditMask = "[a-zA-ZçÇğĞıİöÖşŞüÜ ]+";
            txtboxSoyad.Size = new Size(270, 20);
            txtboxSoyad.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Appearance.Options.UseFont = true;
            lblEmail.Location = new Point(20, 162);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(32, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(120, 160);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtboxEmail.Properties.Mask.EditMask = "[\\w.-]+@[\\w.-]+\\.[a-zA-Z]{2,}";
            txtboxEmail.Size = new Size(270, 20);
            txtboxEmail.TabIndex = 7;
            // 
            // lblTelefon
            // 
            lblTelefon.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefon.Appearance.Options.UseFont = true;
            lblTelefon.Location = new Point(20, 197);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(46, 15);
            lblTelefon.TabIndex = 8;
            lblTelefon.Text = "Telefon:";
            // 
            // txtboxTelefon
            // 
            txtboxTelefon.Location = new Point(120, 195);
            txtboxTelefon.Name = "txtboxTelefon";
            txtboxTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            txtboxTelefon.Properties.Mask.EditMask = "(000) 000 00 00";
            txtboxTelefon.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtboxTelefon.Size = new Size(270, 20);
            txtboxTelefon.TabIndex = 9;
            // 
            // lblSehir
            // 
            lblSehir.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSehir.Appearance.Options.UseFont = true;
            lblSehir.Location = new Point(20, 232);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(32, 15);
            lblSehir.TabIndex = 10;
            lblSehir.Text = "Şehir:";
            // 
            // cmbSehir
            //
            cmbSehir.Location = new Point(120, 230);
            cmbSehir.Name = "cmbSehir";
            cmbSehir.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbSehir.Size = new Size(270, 20);
            cmbSehir.TabIndex = 11;
            // 
            // lblAdres
            // 
            lblAdres.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdres.Appearance.Options.UseFont = true;
            lblAdres.Location = new Point(20, 267);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(35, 15);
            lblAdres.TabIndex = 12;
            lblAdres.Text = "Adres:";
            // 
            // memoAdres
            //
            memoAdres.Location = new Point(120, 265);
            memoAdres.Name = "memoAdres";
            memoAdres.Size = new Size(270, 60);
            memoAdres.TabIndex = 13;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCinsiyet.Appearance.Options.UseFont = true;
            lblCinsiyet.Location = new Point(20, 342);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(46, 15);
            lblCinsiyet.TabIndex = 15;
            lblCinsiyet.Text = "Cinsiyet:";
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.Location = new Point(120, 340);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Properties.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbCinsiyet.Size = new Size(270, 20);
            cmbCinsiyet.TabIndex = 14;
            cmbCinsiyet.SelectedIndexChanged += cmbCinsiyet_SelectedIndexChanged;
            // 
            // btnBiletOlustur
            // 
            btnBiletOlustur.Location = new Point(142, 380);
            btnBiletOlustur.Name = "btnBiletOlustur";
            btnBiletOlustur.Size = new Size(135, 32);
            btnBiletOlustur.TabIndex = 15;
            btnBiletOlustur.Text = "Bilet Oluştur";
            btnBiletOlustur.Click += btnBiletOlustur_Click;
            // 
            // MusteriKaydi
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 432);
            Controls.Add(lblKoltukBilgi);
            Controls.Add(lblTC);
            Controls.Add(spTC);
            Controls.Add(lblAd);
            Controls.Add(txtboxAd);
            Controls.Add(lblSoyad);
            Controls.Add(txtboxSoyad);
            Controls.Add(lblEmail);
            Controls.Add(txtboxEmail);
            Controls.Add(lblTelefon);
            Controls.Add(txtboxTelefon);
            Controls.Add(lblSehir);
            Controls.Add(cmbSehir);
            Controls.Add(lblAdres);
            Controls.Add(memoAdres);
            Controls.Add(lblCinsiyet);
            Controls.Add(cmbCinsiyet);
            Controls.Add(btnBiletOlustur);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MusteriKaydi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Müşteri Kaydı";
            ((System.ComponentModel.ISupportInitialize)spTC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxTelefon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbSehir.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoAdres.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbCinsiyet.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblKoltukBilgi;
        private LabelControl lblTC;
        private SpinEdit spTC;
        private LabelControl lblAd;
        private TextEdit txtboxAd;
        private LabelControl lblSoyad;
        private TextEdit txtboxSoyad;
        private LabelControl lblEmail;
        private TextEdit txtboxEmail;
        private LabelControl lblTelefon;
        private TextEdit txtboxTelefon;
        private LabelControl lblSehir;
        private ComboBoxEdit cmbSehir;
        private LabelControl lblAdres;
        private MemoEdit memoAdres;
        private LabelControl lblCinsiyet;
        private ComboBoxEdit cmbCinsiyet;
        private SimpleButton btnBiletOlustur;
    }
}
