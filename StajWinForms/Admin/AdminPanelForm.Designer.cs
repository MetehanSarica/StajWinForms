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
            flpButonlar = new FlowLayoutPanel();
            btnFirmaBrowser = new SimpleButton();
            btnOtobusBrowser = new SimpleButton();
            btnFirmaOtobusEsle = new SimpleButton();
            btnKaptanBrowser = new SimpleButton();
            btnOtogarBrowser = new SimpleButton();
            btnKaptanEsle = new SimpleButton();
            btnSeferOtobusEsle = new SimpleButton();
            btnKullaniciYonetim = new SimpleButton();
            btnYetkiAtama = new SimpleButton();
            btnDashboard = new SimpleButton();
            btnSeferBrowser = new SimpleButton();
            btnBiletArama = new SimpleButton();
            btnCikis = new SimpleButton();
            flpButonlar.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            lblBaslik.Appearance.Options.UseFont = true;
            lblBaslik.Location = new Point(20, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(156, 29);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Admin Paneli";
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.Location = new Point(20, 60);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(0, 13);
            lblHosgeldin.TabIndex = 1;
            // 
            // flpButonlar
            // 
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpButonlar.Controls.Add(btnDashboard);
            flpButonlar.Controls.Add(btnSeferBrowser);
            flpButonlar.Controls.Add(btnBiletArama);
            flpButonlar.Controls.Add(btnFirmaBrowser);
            flpButonlar.Controls.Add(btnOtobusBrowser);
            flpButonlar.Controls.Add(btnKaptanBrowser);
            flpButonlar.Controls.Add(btnOtogarBrowser);
            flpButonlar.Controls.Add(btnFirmaOtobusEsle);
            flpButonlar.Controls.Add(btnKaptanEsle);
            flpButonlar.Controls.Add(btnSeferOtobusEsle);
            flpButonlar.Controls.Add(btnKullaniciYonetim);
            flpButonlar.Controls.Add(btnYetkiAtama);
            flpButonlar.Controls.Add(btnCikis);
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Location = new Point(20, 85);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Size = new Size(306, 455);
            flpButonlar.TabIndex = 2;
            flpButonlar.WrapContents = false;
            // 
            // btnFirmaBrowser
            // 
            btnFirmaBrowser.Location = new Point(3, 3);
            btnFirmaBrowser.Name = "btnFirmaBrowser";
            btnFirmaBrowser.Size = new Size(300, 40);
            btnFirmaBrowser.TabIndex = 0;
            btnFirmaBrowser.Text = "Firma Yönetimi";
            btnFirmaBrowser.Click += btnFirmaBrowser_Click;
            // 
            // btnOtobusBrowser
            // 
            btnOtobusBrowser.Location = new Point(3, 49);
            btnOtobusBrowser.Name = "btnOtobusBrowser";
            btnOtobusBrowser.Size = new Size(300, 40);
            btnOtobusBrowser.TabIndex = 1;
            btnOtobusBrowser.Text = "Otobüs Yönetimi";
            btnOtobusBrowser.Click += btnOtobusBrowser_Click;
            // 
            // btnOtogarBrowser
            //
            btnOtogarBrowser.Location = new Point(3, 3);
            btnOtogarBrowser.Name = "btnOtogarBrowser";
            btnOtogarBrowser.Size = new Size(300, 40);
            btnOtogarBrowser.TabIndex = 12;
            btnOtogarBrowser.Text = "Otogar Yönetimi";
            btnOtogarBrowser.Click += btnOtogarBrowser_Click;
            // btnFirmaOtobusEsle
            //
            btnFirmaOtobusEsle.Location = new Point(3, 95);
            btnFirmaOtobusEsle.Name = "btnFirmaOtobusEsle";
            btnFirmaOtobusEsle.Size = new Size(300, 40);
            btnFirmaOtobusEsle.TabIndex = 2;
            btnFirmaOtobusEsle.Text = "Firma – Otobüs Eşleme";
            btnFirmaOtobusEsle.Click += btnFirmaOtobusEsle_Click;
            // 
            // btnKaptanBrowser
            // 
            btnKaptanBrowser.Location = new Point(3, 141);
            btnKaptanBrowser.Name = "btnKaptanBrowser";
            btnKaptanBrowser.Size = new Size(300, 40);
            btnKaptanBrowser.TabIndex = 3;
            btnKaptanBrowser.Text = "Kaptan Yönetimi";
            btnKaptanBrowser.Click += btnKaptanBrowser_Click;
            // 
            // btnKaptanEsle
            // 
            btnKaptanEsle.Location = new Point(3, 187);
            btnKaptanEsle.Name = "btnKaptanEsle";
            btnKaptanEsle.Size = new Size(300, 40);
            btnKaptanEsle.TabIndex = 4;
            btnKaptanEsle.Text = "Otobüs – Kaptan Eşleme";
            btnKaptanEsle.Click += btnKaptanEsle_Click;
            // 
            // btnSeferOtobusEsle
            // 
            btnSeferOtobusEsle.Location = new Point(3, 233);
            btnSeferOtobusEsle.Name = "btnSeferOtobusEsle";
            btnSeferOtobusEsle.Size = new Size(300, 40);
            btnSeferOtobusEsle.TabIndex = 5;
            btnSeferOtobusEsle.Text = "Sefer – Otobüs Eşleme";
            btnSeferOtobusEsle.Click += btnSeferOtobusEsle_Click;
            // 
            // btnKullaniciYonetim
            // 
            btnKullaniciYonetim.Location = new Point(3, 279);
            btnKullaniciYonetim.Name = "btnKullaniciYonetim";
            btnKullaniciYonetim.Size = new Size(300, 40);
            btnKullaniciYonetim.TabIndex = 6;
            btnKullaniciYonetim.Text = "Kullanıcı Yönetimi";
            btnKullaniciYonetim.Click += btnKullaniciYonetim_Click;
            // 
            // btnYetkiAtama
            // 
            btnYetkiAtama.Location = new Point(3, 325);
            btnYetkiAtama.Name = "btnYetkiAtama";
            btnYetkiAtama.Size = new Size(300, 40);
            btnYetkiAtama.TabIndex = 7;
            btnYetkiAtama.Text = "Yetki Atama";
            btnYetkiAtama.Click += btnYetkiAtama_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(3, 371);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(300, 40);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            //
            // btnSeferBrowser
            //
            btnSeferBrowser.Location = new Point(3, 417);
            btnSeferBrowser.Name = "btnSeferBrowser";
            btnSeferBrowser.Size = new Size(300, 40);
            btnSeferBrowser.TabIndex = 10;
            btnSeferBrowser.Text = "Sefer Yönetimi";
            btnSeferBrowser.Click += btnSeferBrowser_Click;
            //
            // btnBiletArama
            //
            btnBiletArama.Location = new Point(3, 463);
            btnBiletArama.Name = "btnBiletArama";
            btnBiletArama.Size = new Size(300, 40);
            btnBiletArama.TabIndex = 11;
            btnBiletArama.Text = "Bilet Arama";
            btnBiletArama.Click += btnBiletArama_Click;
            //
            // btnCikis
            //
            btnCikis.Appearance.BackColor = Color.FromArgb(220, 53, 69);
            btnCikis.Appearance.ForeColor = Color.White;
            btnCikis.Appearance.Options.UseBackColor = true;
            btnCikis.Appearance.Options.UseForeColor = true;
            btnCikis.Location = new Point(3, 417);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(300, 35);
            btnCikis.TabIndex = 9;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.Click += btnCikis_Click;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 640);
            Controls.Add(lblBaslik);
            Controls.Add(lblHosgeldin);
            Controls.Add(flpButonlar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Paneli";
            Load += AdminPanelForm_Load;
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblBaslik;
        private LabelControl lblHosgeldin;
        private FlowLayoutPanel flpButonlar;
        private SimpleButton btnFirmaBrowser;
        private SimpleButton btnOtobusBrowser;
        private SimpleButton btnFirmaOtobusEsle;
        private SimpleButton btnKaptanBrowser;
        private SimpleButton btnKaptanEsle;
        private SimpleButton btnSeferOtobusEsle;
        private SimpleButton btnKullaniciYonetim;
        private SimpleButton btnYetkiAtama;
        private SimpleButton btnDashboard;
        private SimpleButton btnSeferBrowser;
        private SimpleButton btnBiletArama;
        private SimpleButton btnOtogarBrowser;
        private SimpleButton btnCikis;
    }
}
