using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class OtogarBrowserControl
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
            gridOtogarlar = new GridControl();
            gridView = new GridView();
            colOtogarId = new DevExpress.XtraGrid.Columns.GridColumn();
            colSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)pnlButonlar).BeginInit();
            pnlButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOtogarlar).BeginInit();
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
            pnlButonlar.Size = new Size(834, 53);
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
            // gridOtogarlar
            // 
            gridOtogarlar.Dock = DockStyle.Fill;
            gridOtogarlar.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridOtogarlar.Location = new Point(0, 53);
            gridOtogarlar.MainView = gridView;
            gridOtogarlar.Margin = new Padding(4, 3, 4, 3);
            gridOtogarlar.Name = "gridOtogarlar";
            gridOtogarlar.Size = new Size(834, 484);
            gridOtogarlar.TabIndex = 1;
            gridOtogarlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colOtogarId, colSehir, colAd, colAdres, colTelefon });
            gridView.DetailHeight = 404;
            gridView.GridControl = gridOtogarlar;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            // 
            // colOtogarId
            // 
            colOtogarId.Caption = "ID";
            colOtogarId.FieldName = "OtogarId";
            colOtogarId.MinWidth = 23;
            colOtogarId.Name = "colOtogarId";
            colOtogarId.Visible = true;
            colOtogarId.VisibleIndex = 0;
            colOtogarId.Width = 58;
            // 
            // colSehir
            // 
            colSehir.Caption = "Şehir";
            colSehir.FieldName = "SehirAdi";
            colSehir.MinWidth = 23;
            colSehir.Name = "colSehir";
            colSehir.Visible = true;
            colSehir.VisibleIndex = 1;
            colSehir.Width = 140;
            // 
            // colAd
            // 
            colAd.Caption = "Otogar Adı";
            colAd.FieldName = "OtogarAdi";
            colAd.MinWidth = 23;
            colAd.Name = "colAd";
            colAd.Visible = true;
            colAd.VisibleIndex = 2;
            colAd.Width = 210;
            // 
            // colAdres
            // 
            colAdres.Caption = "Adres";
            colAdres.FieldName = "Adres";
            colAdres.MinWidth = 23;
            colAdres.Name = "colAdres";
            colAdres.Visible = true;
            colAdres.VisibleIndex = 3;
            colAdres.Width = 233;
            // 
            // colTelefon
            // 
            colTelefon.Caption = "Telefon";
            colTelefon.FieldName = "Telefon";
            colTelefon.MinWidth = 23;
            colTelefon.Name = "colTelefon";
            colTelefon.Visible = true;
            colTelefon.VisibleIndex = 4;
            colTelefon.Width = 128;
            // 
            // OtogarBrowserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridOtogarlar);
            Controls.Add(pnlButonlar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OtogarBrowserControl";
            Size = new Size(834, 537);
            Load += OtogarBrowserControl_Load;
            ((System.ComponentModel.ISupportInitialize)pnlButonlar).EndInit();
            pnlButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOtogarlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        internal DevExpress.XtraEditors.PanelControl pnlButonlar;
        internal SimpleButton btnEkle;
        internal SimpleButton btnDuzenle;
        internal SimpleButton btnSil;
        internal SimpleButton btnYenile;
        internal GridControl gridOtogarlar;
        internal GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOtogarId;
        private DevExpress.XtraGrid.Columns.GridColumn colSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
    }
}
