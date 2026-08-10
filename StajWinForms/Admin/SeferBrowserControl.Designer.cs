using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class SeferBrowserControl
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
            gridSeferler = new GridControl();
            gridView = new GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            colKalkis = new DevExpress.XtraGrid.Columns.GridColumn();
            colVaris = new DevExpress.XtraGrid.Columns.GridColumn();
            colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            colPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            flpButonlar = new FlowLayoutPanel();
            btnEkle = new SimpleButton();
            btnDuzenle = new SimpleButton();
            btnSil = new SimpleButton();
            btnYolcular = new SimpleButton();
            btnYenile = new SimpleButton();
            lblDurum = new LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridSeferler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            flpButonlar.SuspendLayout();
            SuspendLayout();
            //
            // gridSeferler
            //
            gridSeferler.Dock = DockStyle.Fill;
            gridSeferler.MainView = gridView;
            gridSeferler.Name = "gridSeferler";
            gridSeferler.TabIndex = 0;
            gridSeferler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            //
            // gridView
            //
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colFirma, colKalkis, colVaris, colTarih, colFiyat, colPlaka });
            gridView.GridControl = gridSeferler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            //
            // colId
            //
            colId.Caption = "ID"; colId.FieldName = "SeferId"; colId.Name = "colId";
            colId.Visible = true; colId.VisibleIndex = 0; colId.Width = 45;
            //
            // colFirma
            //
            colFirma.Caption = "Firma"; colFirma.FieldName = "FirmaAdi"; colFirma.Name = "colFirma";
            colFirma.Visible = true; colFirma.VisibleIndex = 1; colFirma.Width = 120;
            //
            // colKalkis
            //
            colKalkis.Caption = "Kalkış"; colKalkis.FieldName = "KalkisSehirAdi"; colKalkis.Name = "colKalkis";
            colKalkis.Visible = true; colKalkis.VisibleIndex = 2; colKalkis.Width = 100;
            //
            // colVaris
            //
            colVaris.Caption = "Varış"; colVaris.FieldName = "VarisSehirAdi"; colVaris.Name = "colVaris";
            colVaris.Visible = true; colVaris.VisibleIndex = 3; colVaris.Width = 100;
            //
            // colTarih
            //
            colTarih.Caption = "Kalkış Zamanı"; colTarih.FieldName = "KalkisZamani"; colTarih.Name = "colTarih";
            colTarih.Visible = true; colTarih.VisibleIndex = 4; colTarih.Width = 130;
            //
            // colFiyat
            //
            colFiyat.Caption = "Fiyat";
            colFiyat.DisplayFormat.FormatString = "₺{0:N2}";
            colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colFiyat.FieldName = "Fiyat"; colFiyat.Name = "colFiyat";
            colFiyat.Visible = true; colFiyat.VisibleIndex = 5; colFiyat.Width = 80;
            //
            // colPlaka
            //
            colPlaka.Caption = "Otobüs"; colPlaka.FieldName = "OtobusPlaka"; colPlaka.Name = "colPlaka";
            colPlaka.Visible = true; colPlaka.VisibleIndex = 6; colPlaka.Width = 80;
            //
            // flpButonlar
            //
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpButonlar.Controls.Add(btnEkle);
            flpButonlar.Controls.Add(btnDuzenle);
            flpButonlar.Controls.Add(btnSil);
            flpButonlar.Controls.Add(btnYolcular);
            flpButonlar.Controls.Add(btnYenile);
            flpButonlar.Dock = DockStyle.Right;
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(8);
            flpButonlar.WrapContents = false;
            flpButonlar.TabIndex = 1;
            //
            // btnEkle
            //
            btnEkle.Name = "btnEkle"; btnEkle.Size = new Size(130, 35);
            btnEkle.TabIndex = 0; btnEkle.Text = "Ekle"; btnEkle.Click += btnEkle_Click;
            //
            // btnDuzenle
            //
            btnDuzenle.Name = "btnDuzenle"; btnDuzenle.Size = new Size(130, 35);
            btnDuzenle.TabIndex = 1; btnDuzenle.Text = "Düzenle"; btnDuzenle.Click += btnDuzenle_Click;
            //
            // btnSil
            //
            btnSil.Name = "btnSil"; btnSil.Size = new Size(130, 35);
            btnSil.TabIndex = 2; btnSil.Text = "Sil"; btnSil.Click += btnSil_Click;
            //
            // btnYolcular
            //
            btnYolcular.Name = "btnYolcular"; btnYolcular.Size = new Size(130, 35);
            btnYolcular.TabIndex = 3; btnYolcular.Text = "Yolcular"; btnYolcular.Click += btnYolcular_Click;
            //
            // btnYenile
            //
            btnYenile.Name = "btnYenile"; btnYenile.Size = new Size(130, 35);
            btnYenile.TabIndex = 4; btnYenile.Text = "Yenile"; btnYenile.Click += btnYenile_Click;
            //
            // lblDurum
            //
            lblDurum.Dock = DockStyle.Bottom;
            lblDurum.Name = "lblDurum"; lblDurum.TabIndex = 2;
            lblDurum.Padding = new Padding(4, 2, 0, 2);
            //
            // SeferBrowserControl
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridSeferler);
            Controls.Add(flpButonlar);
            Controls.Add(lblDurum);
            Name = "SeferBrowserControl";
            Load += SeferBrowserControl_Load;
            ((System.ComponentModel.ISupportInitialize)gridSeferler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal GridControl gridSeferler;
        internal GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId, colFirma, colKalkis, colVaris, colTarih, colFiyat, colPlaka;
        private FlowLayoutPanel flpButonlar;
        internal SimpleButton btnEkle, btnDuzenle, btnSil, btnYolcular, btnYenile;
        private LabelControl lblDurum;
    }
}
