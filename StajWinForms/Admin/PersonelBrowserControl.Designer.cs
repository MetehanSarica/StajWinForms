using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class PersonelBrowserControl
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
            pnlButonlar = new PanelControl();
            btnEkle = new SimpleButton();
            btnDuzenle = new SimpleButton();
            btnSil = new SimpleButton();
            btnYenile = new SimpleButton();
            gridPersonel = new GridControl();
            gridView = new GridView();
            colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
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
            pnlButonlar.Location = new Point(0, 0);
            pnlButonlar.Margin = new Padding(4, 3, 4, 3);
            pnlButonlar.Name = "pnlButonlar";
            pnlButonlar.Size = new Size(816, 53);
            pnlButonlar.TabIndex = 0;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(9, 9);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(105, 32);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(124, 9);
            btnDuzenle.Margin = new Padding(4, 3, 4, 3);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(105, 32);
            btnDuzenle.TabIndex = 1;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(238, 9);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(105, 32);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(352, 9);
            btnYenile.Margin = new Padding(4, 3, 4, 3);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(105, 32);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;
            // 
            // gridPersonel
            // 
            gridPersonel.Dock = DockStyle.Fill;
            gridPersonel.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridPersonel.Location = new Point(0, 53);
            gridPersonel.MainView = gridView;
            gridPersonel.Margin = new Padding(4, 3, 4, 3);
            gridPersonel.Name = "gridPersonel";
            gridPersonel.Size = new Size(816, 458);
            gridPersonel.TabIndex = 1;
            gridPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAd, colSoyad, colUnvan, colEmail, colMaas, colIseGiris });
            gridView.DetailHeight = 404;
            gridView.GridControl = gridPersonel;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            // 
            // colAd
            // 
            colAd.Caption = "Ad";
            colAd.FieldName = "Ad";
            colAd.MinWidth = 23;
            colAd.Name = "colAd";
            colAd.Visible = true;
            colAd.VisibleIndex = 0;
            colAd.Width = 140;
            // 
            // colSoyad
            // 
            colSoyad.Caption = "Soyad";
            colSoyad.FieldName = "Soyad";
            colSoyad.MinWidth = 23;
            colSoyad.Name = "colSoyad";
            colSoyad.Visible = true;
            colSoyad.VisibleIndex = 1;
            colSoyad.Width = 140;
            // 
            // colUnvan
            // 
            colUnvan.Caption = "Ünvan";
            colUnvan.FieldName = "Unvan";
            colUnvan.MinWidth = 23;
            colUnvan.Name = "colUnvan";
            colUnvan.Visible = true;
            colUnvan.VisibleIndex = 2;
            colUnvan.Width = 140;
            // 
            // colEmail
            // 
            colEmail.Caption = "E-posta";
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 23;
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 3;
            colEmail.Width = 210;
            // 
            // colMaas
            // 
            colMaas.Caption = "Maaş";
            colMaas.FieldName = "Maas";
            colMaas.MinWidth = 23;
            colMaas.Name = "colMaas";
            colMaas.Visible = true;
            colMaas.VisibleIndex = 4;
            colMaas.Width = 117;
            // 
            // colIseGiris
            // 
            colIseGiris.Caption = "İşe Giriş";
            colIseGiris.FieldName = "IseGirisTarihi";
            colIseGiris.MinWidth = 23;
            colIseGiris.Name = "colIseGiris";
            colIseGiris.Visible = true;
            colIseGiris.VisibleIndex = 5;
            colIseGiris.Width = 117;
            // 
            // PersonelBrowserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridPersonel);
            Controls.Add(pnlButonlar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PersonelBrowserControl";
            Size = new Size(816, 511);
            Load += PersonelBrowserControl_Load;
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
