using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class OtogarBrowserForm
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
            // gridOtogarlar
            //
            gridOtogarlar.Dock = DockStyle.Fill;
            gridOtogarlar.MainView = gridView;
            gridOtogarlar.Name = "gridOtogarlar";
            gridOtogarlar.TabIndex = 1;
            gridOtogarlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            //
            // gridView
            //
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colOtogarId, colSehir, colAd, colAdres, colTelefon });
            gridView.GridControl = gridOtogarlar;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsView.ShowIndicator = false;
            //
            // colOtogarId
            //
            colOtogarId.Caption = "ID";
            colOtogarId.FieldName = "OtogarId";
            colOtogarId.Name = "colOtogarId";
            colOtogarId.Visible = true;
            colOtogarId.VisibleIndex = 0;
            colOtogarId.Width = 50;
            //
            // colSehir
            //
            colSehir.Caption = "Şehir";
            colSehir.FieldName = "SehirAdi";
            colSehir.Name = "colSehir";
            colSehir.Visible = true;
            colSehir.VisibleIndex = 1;
            colSehir.Width = 120;
            //
            // colAd
            //
            colAd.Caption = "Otogar Adı";
            colAd.FieldName = "OtogarAdi";
            colAd.Name = "colAd";
            colAd.Visible = true;
            colAd.VisibleIndex = 2;
            colAd.Width = 180;
            //
            // colAdres
            //
            colAdres.Caption = "Adres";
            colAdres.FieldName = "Adres";
            colAdres.Name = "colAdres";
            colAdres.Visible = true;
            colAdres.VisibleIndex = 3;
            colAdres.Width = 200;
            //
            // colTelefon
            //
            colTelefon.Caption = "Telefon";
            colTelefon.FieldName = "Telefon";
            colTelefon.Name = "colTelefon";
            colTelefon.Visible = true;
            colTelefon.VisibleIndex = 4;
            colTelefon.Width = 110;
            //
            // OtogarBrowserForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 480);
            Controls.Add(gridOtogarlar);
            Controls.Add(pnlButonlar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OtogarBrowserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Otogar Yönetimi";
            Load += OtogarBrowserForm_Load;
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
