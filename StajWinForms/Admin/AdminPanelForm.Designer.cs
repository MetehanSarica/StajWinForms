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
            lblHosgeldin = new LabelControl();
            flpButonlar = new FlowLayoutPanel();
            pnlIcerik = new Panel();
            btnFirmaBrowser = new SimpleButton();
            btnOtobusBrowser = new SimpleButton();
            btnFirmaOtobusEsle = new SimpleButton();
            btnMusteriBrowser = new SimpleButton();
            btnOtogarBrowser = new SimpleButton();
            btnPersonelBrowser = new SimpleButton();
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
            // lblHosgeldin
            //
            lblHosgeldin.Dock = DockStyle.Top;
            lblHosgeldin.Padding = new Padding(8, 6, 0, 4);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(1200, 24);
            lblHosgeldin.TabIndex = 1;
            //
            // flpButonlar
            //
            flpButonlar.AutoSize = false;
            flpButonlar.Controls.Add(btnDashboard);
            flpButonlar.Controls.Add(btnSeferBrowser);
            flpButonlar.Controls.Add(btnBiletArama);
            flpButonlar.Controls.Add(btnFirmaBrowser);
            flpButonlar.Controls.Add(btnOtobusBrowser);
            flpButonlar.Controls.Add(btnMusteriBrowser);
            flpButonlar.Controls.Add(btnOtogarBrowser);
            flpButonlar.Controls.Add(btnPersonelBrowser);
            flpButonlar.Controls.Add(btnFirmaOtobusEsle);
            flpButonlar.Controls.Add(btnKaptanEsle);
            flpButonlar.Controls.Add(btnSeferOtobusEsle);
            flpButonlar.Controls.Add(btnKullaniciYonetim);
            flpButonlar.Controls.Add(btnYetkiAtama);
            flpButonlar.Controls.Add(btnCikis);
            flpButonlar.FlowDirection = FlowDirection.LeftToRight;
            flpButonlar.Dock = DockStyle.Top;
            flpButonlar.Height = 95;
            flpButonlar.Name = "flpButonlar";
            flpButonlar.TabIndex = 2;
            flpButonlar.WrapContents = true;
            //
            // btnFirmaBrowser
            //
            btnFirmaBrowser.Location = new Point(3, 3);
            btnFirmaBrowser.Name = "btnFirmaBrowser";
            btnFirmaBrowser.Size = new Size(130, 40);
            btnFirmaBrowser.TabIndex = 0;
            btnFirmaBrowser.Text = "Firma Yönetimi";
            btnFirmaBrowser.Click += btnFirmaBrowser_Click;
            //
            // btnOtobusBrowser
            //
            btnOtobusBrowser.Location = new Point(3, 49);
            btnOtobusBrowser.Name = "btnOtobusBrowser";
            btnOtobusBrowser.Size = new Size(130, 40);
            btnOtobusBrowser.TabIndex = 1;
            btnOtobusBrowser.Text = "Otobüs Yönetimi";
            btnOtobusBrowser.Click += btnOtobusBrowser_Click;
            //
            // btnMusteriBrowser
            //
            btnMusteriBrowser.Location = new Point(3, 3);
            btnMusteriBrowser.Name = "btnMusteriBrowser";
            btnMusteriBrowser.Size = new Size(130, 40);
            btnMusteriBrowser.TabIndex = 14;
            btnMusteriBrowser.Text = "Müşteri Yönetimi";
            btnMusteriBrowser.Click += btnMusteriBrowser_Click;
            //
            // btnOtogarBrowser
            //
            btnOtogarBrowser.Location = new Point(3, 3);
            btnOtogarBrowser.Name = "btnOtogarBrowser";
            btnOtogarBrowser.Size = new Size(130, 40);
            btnOtogarBrowser.TabIndex = 12;
            btnOtogarBrowser.Text = "Otogar Yönetimi";
            btnOtogarBrowser.Click += btnOtogarBrowser_Click;
            //
            // btnPersonelBrowser
            //
            btnPersonelBrowser.Location = new Point(3, 3);
            btnPersonelBrowser.Name = "btnPersonelBrowser";
            btnPersonelBrowser.Size = new Size(130, 40);
            btnPersonelBrowser.TabIndex = 13;
            btnPersonelBrowser.Text = "Personel Yönetimi";
            btnPersonelBrowser.Click += btnPersonelBrowser_Click;
            //
            // btnFirmaOtobusEsle
            //
            btnFirmaOtobusEsle.Location = new Point(3, 95);
            btnFirmaOtobusEsle.Name = "btnFirmaOtobusEsle";
            btnFirmaOtobusEsle.Size = new Size(160, 40);
            btnFirmaOtobusEsle.TabIndex = 2;
            btnFirmaOtobusEsle.Text = "Firma – Otobüs Eşleme";
            btnFirmaOtobusEsle.Click += btnFirmaOtobusEsle_Click;
            //
            // btnKaptanEsle
            //
            btnKaptanEsle.Location = new Point(3, 187);
            btnKaptanEsle.Name = "btnKaptanEsle";
            btnKaptanEsle.Size = new Size(160, 40);
            btnKaptanEsle.TabIndex = 4;
            btnKaptanEsle.Text = "Otobüs – Kaptan Eşleme";
            btnKaptanEsle.Click += btnKaptanEsle_Click;
            //
            // btnSeferOtobusEsle
            //
            btnSeferOtobusEsle.Location = new Point(3, 233);
            btnSeferOtobusEsle.Name = "btnSeferOtobusEsle";
            btnSeferOtobusEsle.Size = new Size(160, 40);
            btnSeferOtobusEsle.TabIndex = 5;
            btnSeferOtobusEsle.Text = "Sefer – Otobüs Eşleme";
            btnSeferOtobusEsle.Click += btnSeferOtobusEsle_Click;
            //
            // btnKullaniciYonetim
            //
            btnKullaniciYonetim.Location = new Point(3, 279);
            btnKullaniciYonetim.Name = "btnKullaniciYonetim";
            btnKullaniciYonetim.Size = new Size(140, 40);
            btnKullaniciYonetim.TabIndex = 6;
            btnKullaniciYonetim.Text = "Kullanıcı Yönetimi";
            btnKullaniciYonetim.Click += btnKullaniciYonetim_Click;
            //
            // btnYetkiAtama
            //
            btnYetkiAtama.Location = new Point(3, 325);
            btnYetkiAtama.Name = "btnYetkiAtama";
            btnYetkiAtama.Size = new Size(120, 40);
            btnYetkiAtama.TabIndex = 7;
            btnYetkiAtama.Text = "Yetki Atama";
            btnYetkiAtama.Click += btnYetkiAtama_Click;
            //
            // btnDashboard
            //
            btnDashboard.Location = new Point(3, 371);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(110, 40);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += btnDashboard_Click;
            //
            // btnSeferBrowser
            //
            btnSeferBrowser.Location = new Point(3, 417);
            btnSeferBrowser.Name = "btnSeferBrowser";
            btnSeferBrowser.Size = new Size(130, 40);
            btnSeferBrowser.TabIndex = 10;
            btnSeferBrowser.Text = "Sefer Yönetimi";
            btnSeferBrowser.Click += btnSeferBrowser_Click;
            //
            // btnBiletArama
            //
            btnBiletArama.Location = new Point(3, 463);
            btnBiletArama.Name = "btnBiletArama";
            btnBiletArama.Size = new Size(110, 40);
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
            btnCikis.Size = new Size(100, 40);
            btnCikis.TabIndex = 9;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.Click += btnCikis_Click;
            //
            // AdminPanelForm
            //
            pnlIcerik.Dock = DockStyle.Fill;
            pnlIcerik.Name = "pnlIcerik";
            pnlIcerik.TabIndex = 3;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlIcerik);
            Controls.Add(flpButonlar);
            Controls.Add(lblHosgeldin);
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            Name = "AdminPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Paneli";
            Load += AdminPanelForm_Load;
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblHosgeldin;
        private FlowLayoutPanel flpButonlar;
        private Panel pnlIcerik;
        private SimpleButton btnFirmaBrowser;
        private SimpleButton btnOtobusBrowser;
        private SimpleButton btnFirmaOtobusEsle;
        private SimpleButton btnMusteriBrowser;
        private SimpleButton btnKaptanEsle;
        private SimpleButton btnSeferOtobusEsle;
        private SimpleButton btnKullaniciYonetim;
        private SimpleButton btnYetkiAtama;
        private SimpleButton btnDashboard;
        private SimpleButton btnSeferBrowser;
        private SimpleButton btnBiletArama;
        private SimpleButton btnOtogarBrowser;
        private SimpleButton btnPersonelBrowser;
        private SimpleButton btnCikis;
    }
}
