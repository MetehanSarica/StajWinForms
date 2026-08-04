using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class PersonelBrowserForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlButonlar = new DevExpress.XtraEditors.PanelControl();
            btnEkle = new SimpleButton();
            btnDuzenle = new SimpleButton();
            btnSil = new SimpleButton();
            btnYenile = new SimpleButton();
            gridPersonel = new GridControl();
            gridView = new GridView();
            colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            colMaas = new DevExpress.XtraGrid.Columns.GridColumn();
            colIseGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)pnlButonlar).BeginInit();
            pnlButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPersonel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            //
            // pnlButonlar
            //
            pnlButonlar.Controls.Add(btnEkle);
            pnlButonlar.Controls.Add(btnDuzenle);
            pnlButonlar.Controls.Add(btnSil);
            pnlButonlar.Controls.Add(btnYenile);
            pnlButonlar.Dock = DockStyle.Top;
            pnlButonlar.Name = "pnlButonlar";
            pnlButonlar.Size = new Size(700, 46);
            pnlButonlar.TabIndex = 0;
            //
            // btnEkle
            //
            btnEkle.Location = new Point(8, 8);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 28);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            //
            // btnDuzenle
            //
            btnDuzenle.Location = new Point(106, 8);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(90, 28);
            btnDuzenle.TabIndex = 1;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.Click += btnDuzenle_Click;
            //
            // btnSil
            //
            btnSil.Location = new Point(204, 8);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 28);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            //
            // btnYenile
            //
            btnYenile.Location = new Point(302, 8);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(90, 28);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;
            //
            // gridPersonel
            //
            gridPersonel.Dock = DockStyle.Fill;
            gridPersonel.MainView = gridView;
            gridPersonel.Name = "gridPersonel";
            gridPersonel.TabIndex = 1;
            gridPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            //
            // gridView
            //
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAd, colSoyad, colUnvan, colEmail, colMaas, colIseGiris });
            gridView.GridControl = gridPersonel;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsView.ShowIndicator = false;
            //
            // colAd
            //
            colAd.Caption = "Ad";
            colAd.FieldName = "Ad";
            colAd.Name = "colAd";
            colAd.Visible = true;
            colAd.VisibleIndex = 0;
            colAd.Width = 120;
            //
            // colSoyad
            //
            colSoyad.Caption = "Soyad";
            colSoyad.FieldName = "Soyad";
            colSoyad.Name = "colSoyad";
            colSoyad.Visible = true;
            colSoyad.VisibleIndex = 1;
            colSoyad.Width = 120;
            //
            // colUnvan
            //
            colUnvan.Caption = "Ünvan";
            colUnvan.FieldName = "Unvan";
            colUnvan.Name = "colUnvan";
            colUnvan.Visible = true;
            colUnvan.VisibleIndex = 2;
            colUnvan.Width = 120;
            //
            // colEmail
            //
            colEmail.Caption = "E-posta";
            colEmail.FieldName = "Email";
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 3;
            colEmail.Width = 180;
            //
            // colMaas
            //
            colMaas.Caption = "Maaş";
            colMaas.FieldName = "Maas";
            colMaas.Name = "colMaas";
            colMaas.Visible = true;
            colMaas.VisibleIndex = 4;
            colMaas.Width = 100;
            //
            // colIseGiris
            //
            colIseGiris.Caption = "İşe Giriş";
            colIseGiris.FieldName = "IseGirisTarihi";
            colIseGiris.Name = "colIseGiris";
            colIseGiris.Visible = true;
            colIseGiris.VisibleIndex = 5;
            colIseGiris.Width = 100;
            //
            // PersonelBrowserForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 480);
            Controls.Add(gridPersonel);
            Controls.Add(pnlButonlar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PersonelBrowserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Personel Yönetimi";
            Load += PersonelBrowserForm_Load;
            ((System.ComponentModel.ISupportInitialize)pnlButonlar).EndInit();
            pnlButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPersonel).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        internal DevExpress.XtraEditors.PanelControl pnlButonlar;
        internal SimpleButton btnEkle;
        internal SimpleButton btnDuzenle;
        internal SimpleButton btnSil;
        internal SimpleButton btnYenile;
        internal GridControl gridPersonel;
        internal GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMaas;
        private DevExpress.XtraGrid.Columns.GridColumn colIseGiris;
    }
}
