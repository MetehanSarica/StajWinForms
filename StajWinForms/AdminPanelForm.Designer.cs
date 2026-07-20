using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class AdminPanelForm
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
            lblHosgeldin = new LabelControl();
            btnFirmaBrowser = new SimpleButton();
            btnOtobusBrowser = new SimpleButton();
            btnFirmaOtobusEsle = new SimpleButton();
            btnKaptanBrowser = new SimpleButton();
            btnKaptanEsle = new SimpleButton();
            btnKullaniciYonetim = new SimpleButton();
            btnYetkiAtama = new SimpleButton();
            SuspendLayout();

            // lblBaslik
            lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            lblBaslik.Location = new System.Drawing.Point(20, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new System.Drawing.Size(200, 35);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Admin Paneli";

            // lblHosgeldin
            lblHosgeldin.Location = new System.Drawing.Point(20, 65);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new System.Drawing.Size(300, 13);
            lblHosgeldin.TabIndex = 1;
            lblHosgeldin.Text = "";

            // btnFirmaBrowser
            btnFirmaBrowser.Location = new System.Drawing.Point(20, 100);
            btnFirmaBrowser.Name = "btnFirmaBrowser";
            btnFirmaBrowser.Size = new System.Drawing.Size(300, 45);
            btnFirmaBrowser.TabIndex = 2;
            btnFirmaBrowser.Text = "Firma Yönetimi";
            btnFirmaBrowser.Click += btnFirmaBrowser_Click;

            // btnOtobusBrowser
            btnOtobusBrowser.Location = new System.Drawing.Point(20, 155);
            btnOtobusBrowser.Name = "btnOtobusBrowser";
            btnOtobusBrowser.Size = new System.Drawing.Size(300, 45);
            btnOtobusBrowser.TabIndex = 3;
            btnOtobusBrowser.Text = "Otobüs Yönetimi";
            btnOtobusBrowser.Click += btnOtobusBrowser_Click;

            // btnFirmaOtobusEsle
            btnFirmaOtobusEsle.Location = new System.Drawing.Point(20, 210);
            btnFirmaOtobusEsle.Name = "btnFirmaOtobusEsle";
            btnFirmaOtobusEsle.Size = new System.Drawing.Size(300, 45);
            btnFirmaOtobusEsle.TabIndex = 4;
            btnFirmaOtobusEsle.Text = "Firma – Otobüs Eşleme";
            btnFirmaOtobusEsle.Click += btnFirmaOtobusEsle_Click;

            // btnKaptanBrowser
            btnKaptanBrowser.Location = new System.Drawing.Point(20, 265);
            btnKaptanBrowser.Name = "btnKaptanBrowser";
            btnKaptanBrowser.Size = new System.Drawing.Size(300, 45);
            btnKaptanBrowser.TabIndex = 5;
            btnKaptanBrowser.Text = "Kaptan Yönetimi";
            btnKaptanBrowser.Click += btnKaptanBrowser_Click;

            // btnKaptanEsle
            btnKaptanEsle.Location = new System.Drawing.Point(20, 320);
            btnKaptanEsle.Name = "btnKaptanEsle";
            btnKaptanEsle.Size = new System.Drawing.Size(300, 45);
            btnKaptanEsle.TabIndex = 6;
            btnKaptanEsle.Text = "Otobüs – Kaptan Eşleme";
            btnKaptanEsle.Click += btnKaptanEsle_Click;

            // btnKullaniciYonetim
            btnKullaniciYonetim.Location = new System.Drawing.Point(20, 375);
            btnKullaniciYonetim.Name = "btnKullaniciYonetim";
            btnKullaniciYonetim.Size = new System.Drawing.Size(300, 45);
            btnKullaniciYonetim.TabIndex = 7;
            btnKullaniciYonetim.Text = "Kullanıcı Yönetimi";
            btnKullaniciYonetim.Click += btnKullaniciYonetim_Click;

            // btnYetkiAtama
            btnYetkiAtama.Location = new System.Drawing.Point(20, 430);
            btnYetkiAtama.Name = "btnYetkiAtama";
            btnYetkiAtama.Size = new System.Drawing.Size(300, 45);
            btnYetkiAtama.TabIndex = 8;
            btnYetkiAtama.Text = "Yetki Atama";
            btnYetkiAtama.Click += btnYetkiAtama_Click;

            // AdminPanelForm
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(360, 505);
            Controls.Add(lblBaslik);
            Controls.Add(lblHosgeldin);
            Controls.Add(btnFirmaBrowser);
            Controls.Add(btnOtobusBrowser);
            Controls.Add(btnFirmaOtobusEsle);
            Controls.Add(btnKaptanBrowser);
            Controls.Add(btnKaptanEsle);
            Controls.Add(btnKullaniciYonetim);
            Controls.Add(btnYetkiAtama);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblBaslik;
        private LabelControl lblHosgeldin;
        private SimpleButton btnFirmaBrowser;
        private SimpleButton btnOtobusBrowser;
        private SimpleButton btnFirmaOtobusEsle;
        private SimpleButton btnKaptanBrowser;
        private SimpleButton btnKaptanEsle;
        private SimpleButton btnKullaniciYonetim;
        private SimpleButton btnYetkiAtama;
    }
}
