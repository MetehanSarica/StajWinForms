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

            lblKullanicilar.Location = new System.Drawing.Point(12, 12); lblKullanicilar.Text = "Kullanıcılar";
            lstKullanicilar.Location = new System.Drawing.Point(12, 30); lstKullanicilar.Size = new System.Drawing.Size(200, 300);
            lstKullanicilar.SelectedIndexChanged += lstKullanicilar_SelectedIndexChanged;

            lblYetkiler.Location = new System.Drawing.Point(230, 12); lblYetkiler.Text = "Yetkiler";
            clbYetkiler.Location = new System.Drawing.Point(230, 30); clbYetkiler.Size = new System.Drawing.Size(250, 200);

            lblSeciliKullanici.Location = new System.Drawing.Point(230, 245);
            lblSeciliKullanici.Size = new System.Drawing.Size(250, 13);
            lblSeciliKullanici.Text = "Kullanıcı seçin...";
            lblSeciliKullanici.Appearance.ForeColor = System.Drawing.Color.DimGray;

            btnKaydet.Location = new System.Drawing.Point(230, 270); btnKaydet.Size = new System.Drawing.Size(150, 40);
            btnKaydet.Text = "Yetkileri Kaydet"; btnKaydet.Click += btnKaydet_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(500, 350);
            Controls.Add(lblKullanicilar); Controls.Add(lstKullanicilar);
            Controls.Add(lblYetkiler); Controls.Add(clbYetkiler);
            Controls.Add(lblSeciliKullanici); Controls.Add(btnKaydet);
            Name = "YetkiAtamaForm"; StartPosition = FormStartPosition.CenterParent; Text = "Yetki Atama";
            Load += YetkiAtamaForm_Load;

            ((System.ComponentModel.ISupportInitialize)lstKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)clbYetkiler).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        #endregion

        private LabelControl lblKullanicilar, lblYetkiler, lblSeciliKullanici;
        private ListBoxControl lstKullanicilar;
        private CheckedListBoxControl clbYetkiler;
        private SimpleButton btnKaydet;
    }
}
