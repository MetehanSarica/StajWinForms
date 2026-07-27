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
            btnKaydet = new SimpleButton();
            btnKopyala = new SimpleButton();
            btnTemizle = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)lstKullanicilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYetkiler).BeginInit();
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
            lstKullanicilar.Size = new Size(180, 300);
            lstKullanicilar.TabIndex = 1;
            lstKullanicilar.SelectedIndexChanged += lstKullanicilar_SelectedIndexChanged;
            // 
            // lblSeciliKullanici
            // 
            lblSeciliKullanici.Appearance.ForeColor = Color.DimGray;
            lblSeciliKullanici.Appearance.Options.UseForeColor = true;
            lblSeciliKullanici.Location = new Point(205, 12);
            lblSeciliKullanici.Name = "lblSeciliKullanici";
            lblSeciliKullanici.Size = new Size(76, 13);
            lblSeciliKullanici.TabIndex = 2;
            lblSeciliKullanici.Text = "Kullanıcı seçin...";
            // 
            // dgvYetkiler
            // 
            dgvYetkiler.AllowUserToAddRows = false;
            dgvYetkiler.AllowUserToDeleteRows = false;
            dgvYetkiler.AllowUserToResizeColumns = false;
            dgvYetkiler.AllowUserToResizeRows = false;
            dgvYetkiler.Columns.AddRange(new DataGridViewColumn[] { colFormAdi, colEkle, colSil, colDegistir, colIncele, colAta, colKaldir, colKaydet });
            dgvYetkiler.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvYetkiler.Location = new Point(205, 30);
            dgvYetkiler.MultiSelect = false;
            dgvYetkiler.Name = "dgvYetkiler";
            dgvYetkiler.RowHeadersVisible = false;
            dgvYetkiler.Size = new Size(563, 265);
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
            // btnKaydet
            // 
            btnKaydet.Location = new Point(205, 310);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 35);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Yetkileri Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnKopyala
            // 
            btnKopyala.Location = new Point(618, 310);
            btnKopyala.Name = "btnKopyala";
            btnKopyala.Size = new Size(150, 35);
            btnKopyala.TabIndex = 5;
            btnKopyala.Text = "Yetkileri Kopyala";
            btnKopyala.Click += btnKopyala_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(414, 310);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(150, 35);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "Yetkileri Temizle";
            btnTemizle.Click += btnTemizle_Click;
            // 
            // YetkiAtamaForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 360);
            Controls.Add(btnTemizle);
            Controls.Add(btnKopyala);
            Controls.Add(lblKullanicilar);
            Controls.Add(lstKullanicilar);
            Controls.Add(lblSeciliKullanici);
            Controls.Add(dgvYetkiler);
            Controls.Add(btnKaydet);
            MaximizeBox = false;
            Name = "YetkiAtamaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yetki Atama";
            Load += YetkiAtamaForm_Load;
            ((System.ComponentModel.ISupportInitialize)lstKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYetkiler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblKullanicilar, lblSeciliKullanici;
        private ListBoxControl lstKullanicilar;
        private DataGridView dgvYetkiler;
        private DataGridViewTextBoxColumn colFormAdi;
        private DataGridViewCheckBoxColumn colEkle, colSil, colDegistir, colIncele, colAta, colKaldir, colKaydet;
        private SimpleButton btnKaydet;
        private SimpleButton btnKopyala;
        private SimpleButton btnTemizle;
    }
}
