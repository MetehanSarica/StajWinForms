using DevExpress.XtraEditors;

namespace StajWinForms.Admin
{
    partial class YetkiAtamaControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblKullanicilar = new LabelControl();
            lstKullanicilar = new ListBoxControl();
            lblSeciliKullanici = new LabelControl();
            dgvYetkiler = new DataGridView();
            colFormAdi = new DataGridViewTextBoxColumn();
            colEkle = new DataGridViewCheckBoxColumn();
            colSil = new DataGridViewCheckBoxColumn();
            colDegistir = new DataGridViewCheckBoxColumn();
            colIncele = new DataGridViewCheckBoxColumn();
            colAta = new DataGridViewCheckBoxColumn();
            colKaldir = new DataGridViewCheckBoxColumn();
            colKaydet = new DataGridViewCheckBoxColumn();
            colAktifPasif = new DataGridViewCheckBoxColumn();
            btnKaydet = new SimpleButton();
            btnKopyala = new SimpleButton();
            btnTemizle = new SimpleButton();
            tblMain = new TableLayoutPanel();
            pnlAlt = new Panel();
            ((System.ComponentModel.ISupportInitialize)lstKullanicilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYetkiler).BeginInit();
            tblMain.SuspendLayout();
            pnlAlt.SuspendLayout();
            SuspendLayout();
            // 
            // lblKullanicilar
            // 
            lblKullanicilar.Dock = DockStyle.Fill;
            lblKullanicilar.Location = new Point(9, 9);
            lblKullanicilar.Margin = new Padding(0, 0, 9, 5);
            lblKullanicilar.Name = "lblKullanicilar";
            lblKullanicilar.Size = new Size(224, 13);
            lblKullanicilar.TabIndex = 0;
            lblKullanicilar.Text = "Kullanıcılar";
            // 
            // lstKullanicilar
            // 
            lstKullanicilar.Dock = DockStyle.Fill;
            lstKullanicilar.Location = new Point(9, 27);
            lstKullanicilar.Margin = new Padding(0, 0, 9, 0);
            lstKullanicilar.Name = "lstKullanicilar";
            lstKullanicilar.Size = new Size(224, 447);
            lstKullanicilar.TabIndex = 1;
            lstKullanicilar.SelectedIndexChanged += lstKullanicilar_SelectedIndexChanged;
            // 
            // lblSeciliKullanici
            // 
            lblSeciliKullanici.Appearance.ForeColor = Color.DimGray;
            lblSeciliKullanici.Appearance.Options.UseForeColor = true;
            lblSeciliKullanici.Dock = DockStyle.Fill;
            lblSeciliKullanici.Location = new Point(242, 9);
            lblSeciliKullanici.Margin = new Padding(0, 0, 0, 5);
            lblSeciliKullanici.Name = "lblSeciliKullanici";
            lblSeciliKullanici.Size = new Size(445, 13);
            lblSeciliKullanici.TabIndex = 2;
            lblSeciliKullanici.Text = "Kullanıcı seçin...";
            // 
            // dgvYetkiler
            // 
            dgvYetkiler.AllowUserToAddRows = false;
            dgvYetkiler.AllowUserToDeleteRows = false;
            dgvYetkiler.AllowUserToResizeColumns = false;
            dgvYetkiler.AllowUserToResizeRows = false;
            dgvYetkiler.Columns.AddRange(new DataGridViewColumn[] { colFormAdi, colEkle, colSil, colDegistir, colIncele, colAta, colKaldir, colKaydet, colAktifPasif });
            dgvYetkiler.Dock = DockStyle.Fill;
            dgvYetkiler.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvYetkiler.Location = new Point(246, 30);
            dgvYetkiler.Margin = new Padding(4, 3, 4, 3);
            dgvYetkiler.MultiSelect = false;
            dgvYetkiler.Name = "dgvYetkiler";
            dgvYetkiler.RowHeadersVisible = false;
            dgvYetkiler.Size = new Size(437, 441);
            dgvYetkiler.TabIndex = 3;
            // 
            // colFormAdi
            // 
            colFormAdi.HeaderText = "Form";
            colFormAdi.Name = "colFormAdi";
            colFormAdi.ReadOnly = true;
            colFormAdi.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFormAdi.Width = 160;
            // 
            // colEkle
            // 
            colEkle.HeaderText = "Ekle";
            colEkle.Name = "colEkle";
            colEkle.Width = 50;
            // 
            // colSil
            // 
            colSil.HeaderText = "Sil";
            colSil.Name = "colSil";
            colSil.Width = 50;
            // 
            // colDegistir
            // 
            colDegistir.HeaderText = "Değiştir";
            colDegistir.Name = "colDegistir";
            colDegistir.Width = 65;
            // 
            // colIncele
            // 
            colIncele.HeaderText = "İncele";
            colIncele.Name = "colIncele";
            colIncele.Width = 60;
            // 
            // colAta
            // 
            colAta.HeaderText = "Ata";
            colAta.Name = "colAta";
            colAta.Width = 50;
            // 
            // colKaldir
            // 
            colKaldir.HeaderText = "Kaldır";
            colKaldir.Name = "colKaldir";
            colKaldir.Width = 60;
            // 
            // colKaydet
            //
            colKaydet.HeaderText = "Kaydet";
            colKaydet.Name = "colKaydet";
            colKaydet.Width = 65;
            //
            // colAktifPasif
            //
            colAktifPasif.HeaderText = "Aktif/Pasif";
            colAktifPasif.Name = "colAktifPasif";
            colAktifPasif.Width = 75;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(9, 9);
            btnKaydet.Margin = new Padding(4, 3, 4, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(175, 40);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Yetkileri Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKopyala
            // 
            btnKopyala.Location = new Point(378, 9);
            btnKopyala.Margin = new Padding(4, 3, 4, 3);
            btnKopyala.Name = "btnKopyala";
            btnKopyala.Size = new Size(175, 40);
            btnKopyala.TabIndex = 6;
            btnKopyala.Text = "Yetkileri Kopyala";
            btnKopyala.Click += btnKopyala_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(194, 9);
            btnTemizle.Margin = new Padding(4, 3, 4, 3);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(175, 40);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Yetkileri Temizle";
            btnTemizle.Click += btnTemizle_Click;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblKullanicilar, 0, 0);
            tblMain.Controls.Add(lstKullanicilar, 0, 1);
            tblMain.Controls.Add(lblSeciliKullanici, 1, 0);
            tblMain.Controls.Add(dgvYetkiler, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 3, 4, 3);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(9, 9, 9, 0);
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(696, 474);
            tblMain.TabIndex = 0;
            // 
            // pnlAlt
            // 
            pnlAlt.Controls.Add(btnKaydet);
            pnlAlt.Controls.Add(btnTemizle);
            pnlAlt.Controls.Add(btnKopyala);
            pnlAlt.Dock = DockStyle.Bottom;
            pnlAlt.Location = new Point(0, 474);
            pnlAlt.Margin = new Padding(4, 3, 4, 3);
            pnlAlt.Name = "pnlAlt";
            pnlAlt.Padding = new Padding(9, 9, 9, 5);
            pnlAlt.Size = new Size(696, 58);
            pnlAlt.TabIndex = 1;
            // 
            // YetkiAtamaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Controls.Add(pnlAlt);
            Margin = new Padding(4, 3, 4, 3);
            Name = "YetkiAtamaControl";
            Size = new Size(696, 532);
            Load += YetkiAtamaControl_Load;
            ((System.ComponentModel.ISupportInitialize)lstKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYetkiler).EndInit();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlAlt.ResumeLayout(false);
            ResumeLayout(false);
        }

        private LabelControl lblKullanicilar, lblSeciliKullanici;
        private ListBoxControl lstKullanicilar;
        private DataGridView dgvYetkiler;
        private DataGridViewTextBoxColumn colFormAdi;
        private DataGridViewCheckBoxColumn colEkle, colSil, colDegistir, colIncele, colAta, colKaldir, colKaydet, colAktifPasif;
        private SimpleButton btnKaydet, btnKopyala, btnTemizle;
        private TableLayoutPanel tblMain;
        private Panel pnlAlt;
    }
}
