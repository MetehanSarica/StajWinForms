using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class YetkiAtamaForm
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
            lblKullanicilar = new LabelControl();
            lstKullanicilar = new ListBoxControl();
            lblYetkiler = new LabelControl();
            clbYetkiler = new CheckedListBoxControl();
            lblSeciliKullanici = new LabelControl();
            btnKaydet = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)lstKullanicilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clbYetkiler).BeginInit();
            SuspendLayout();
            // 
            // lblKullanicilar
            // 
            lblKullanicilar.Location = new Point(12, 12);
            lblKullanicilar.Name = "lblKullanicilar";
            lblKullanicilar.Size = new Size(49, 13);
            lblKullanicilar.TabIndex = 0;
            lblKullanicilar.Text = "Kullanıcılar";
            // 
            // lstKullanicilar
            // 
            lstKullanicilar.Location = new Point(12, 30);
            lstKullanicilar.Name = "lstKullanicilar";
            lstKullanicilar.Size = new Size(200, 300);
            lstKullanicilar.TabIndex = 1;
            lstKullanicilar.SelectedIndexChanged += lstKullanicilar_SelectedIndexChanged;
            // 
            // lblYetkiler
            // 
            lblYetkiler.Location = new Point(230, 12);
            lblYetkiler.Name = "lblYetkiler";
            lblYetkiler.Size = new Size(35, 13);
            lblYetkiler.TabIndex = 2;
            lblYetkiler.Text = "Yetkiler";
            // 
            // clbYetkiler
            // 
            clbYetkiler.Location = new Point(230, 30);
            clbYetkiler.Name = "clbYetkiler";
            clbYetkiler.Size = new Size(250, 200);
            clbYetkiler.TabIndex = 3;
            // 
            // lblSeciliKullanici
            // 
            lblSeciliKullanici.Appearance.ForeColor = Color.DimGray;
            lblSeciliKullanici.Appearance.Options.UseForeColor = true;
            lblSeciliKullanici.Location = new Point(230, 245);
            lblSeciliKullanici.Name = "lblSeciliKullanici";
            lblSeciliKullanici.Size = new Size(76, 13);
            lblSeciliKullanici.TabIndex = 4;
            lblSeciliKullanici.Text = "Kullanıcı seçin...";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(230, 270);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 40);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Yetkileri Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // YetkiAtamaForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(lblKullanicilar);
            Controls.Add(lstKullanicilar);
            Controls.Add(lblYetkiler);
            Controls.Add(clbYetkiler);
            Controls.Add(lblSeciliKullanici);
            Controls.Add(btnKaydet);
            MaximizeBox = false;
            Name = "YetkiAtamaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yetki Atama";
            Load += YetkiAtamaForm_Load;
            ((System.ComponentModel.ISupportInitialize)lstKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)clbYetkiler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblKullanicilar, lblYetkiler, lblSeciliKullanici;
        private ListBoxControl lstKullanicilar;
        private CheckedListBoxControl clbYetkiler;
        private SimpleButton btnKaydet;
    }
}
