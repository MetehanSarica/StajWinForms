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
            colAktif = new DevExpress.XtraGrid.Columns.GridColumn();
            flpButonlar = new FlowLayoutPanel();
            btnEkle = new SimpleButton();
            btnDuzenle = new SimpleButton();
            btnSil = new SimpleButton();
            btnYolcular = new SimpleButton();
            btnIptal = new SimpleButton();
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
            gridSeferler.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridSeferler.Location = new Point(0, 0);
            gridSeferler.MainView = gridView;
            gridSeferler.Margin = new Padding(4, 3, 4, 3);
            gridSeferler.Name = "gridSeferler";
            gridSeferler.Size = new Size(581, 498);
            gridSeferler.TabIndex = 0;
            gridSeferler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colFirma, colKalkis, colVaris, colTarih, colFiyat, colPlaka, colAktif });
            gridView.DetailHeight = 404;
            gridView.GridControl = gridSeferler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            // 
            // colId
            // 
            colId.Caption = "ID";
            colId.FieldName = "SeferId";
            colId.MinWidth = 23;
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 52;
            // 
            // colFirma
            // 
            colFirma.Caption = "Firma";
            colFirma.FieldName = "FirmaAdi";
            colFirma.MinWidth = 23;
            colFirma.Name = "colFirma";
            colFirma.Visible = true;
            colFirma.VisibleIndex = 1;
            colFirma.Width = 140;
            // 
            // colKalkis
            // 
            colKalkis.Caption = "Kalkış";
            colKalkis.FieldName = "KalkisSehirAdi";
            colKalkis.MinWidth = 23;
            colKalkis.Name = "colKalkis";
            colKalkis.Visible = true;
            colKalkis.VisibleIndex = 2;
            colKalkis.Width = 117;
            // 
            // colVaris
            // 
            colVaris.Caption = "Varış";
            colVaris.FieldName = "VarisSehirAdi";
            colVaris.MinWidth = 23;
            colVaris.Name = "colVaris";
            colVaris.Visible = true;
            colVaris.VisibleIndex = 3;
            colVaris.Width = 117;
            // 
            // colTarih
            // 
            colTarih.Caption = "Kalkış Zamanı";
            colTarih.FieldName = "KalkisZamani";
            colTarih.MinWidth = 23;
            colTarih.Name = "colTarih";
            colTarih.Visible = true;
            colTarih.VisibleIndex = 4;
            colTarih.Width = 152;
            // 
            // colFiyat
            // 
            colFiyat.Caption = "Fiyat";
            colFiyat.DisplayFormat.FormatString = "₺{0:N2}";
            colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colFiyat.FieldName = "Fiyat";
            colFiyat.MinWidth = 23;
            colFiyat.Name = "colFiyat";
            colFiyat.Visible = true;
            colFiyat.VisibleIndex = 5;
            colFiyat.Width = 93;
            // 
            // colPlaka
            // 
            colPlaka.Caption = "Otobüs";
            colPlaka.FieldName = "OtobusPlaka";
            colPlaka.MinWidth = 23;
            colPlaka.Name = "colPlaka";
            colPlaka.Visible = true;
            colPlaka.VisibleIndex = 6;
            colPlaka.Width = 93;
            // 
            // colAktif
            // 
            colAktif.Caption = "Durum";
            colAktif.FieldName = "Aktif";
            colAktif.MinWidth = 23;
            colAktif.Name = "colAktif";
            colAktif.Visible = true;
            colAktif.VisibleIndex = 7;
            colAktif.Width = 70;
            // 
            // flpButonlar
            // 
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpButonlar.Controls.Add(btnEkle);
            flpButonlar.Controls.Add(btnDuzenle);
            flpButonlar.Controls.Add(btnSil);
            flpButonlar.Controls.Add(btnYolcular);
            flpButonlar.Controls.Add(btnIptal);
            flpButonlar.Controls.Add(btnYenile);
            flpButonlar.Dock = DockStyle.Right;
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Location = new Point(581, 0);
            flpButonlar.Margin = new Padding(4, 3, 4, 3);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(9);
            flpButonlar.Size = new Size(178, 498);
            flpButonlar.TabIndex = 1;
            flpButonlar.WrapContents = false;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(13, 12);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(152, 40);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(13, 58);
            btnDuzenle.Margin = new Padding(4, 3, 4, 3);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(152, 40);
            btnDuzenle.TabIndex = 1;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(13, 104);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(152, 40);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnYolcular
            // 
            btnYolcular.Location = new Point(13, 150);
            btnYolcular.Margin = new Padding(4, 3, 4, 3);
            btnYolcular.Name = "btnYolcular";
            btnYolcular.Size = new Size(152, 40);
            btnYolcular.TabIndex = 3;
            btnYolcular.Text = "Yolcular";
            btnYolcular.Click += btnYolcular_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(13, 196);
            btnIptal.Margin = new Padding(4, 3, 4, 3);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(152, 40);
            btnIptal.TabIndex = 4;
            btnIptal.Text = "İptal Et / Aktif Et";
            btnIptal.Click += btnIptal_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(13, 242);
            btnYenile.Margin = new Padding(4, 3, 4, 3);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(152, 40);
            btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;
            // 
            // lblDurum
            // 
            lblDurum.Dock = DockStyle.Bottom;
            lblDurum.Location = new Point(0, 498);
            lblDurum.Margin = new Padding(4, 3, 4, 3);
            lblDurum.Name = "lblDurum";
            lblDurum.Padding = new Padding(5, 2, 0, 2);
            lblDurum.Size = new Size(5, 17);
            lblDurum.TabIndex = 2;
            // 
            // SeferBrowserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridSeferler);
            Controls.Add(flpButonlar);
            Controls.Add(lblDurum);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SeferBrowserControl";
            Size = new Size(759, 515);
            Load += SeferBrowserControl_Load;
            ((System.ComponentModel.ISupportInitialize)gridSeferler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        internal GridControl gridSeferler;
        internal GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId, colFirma, colKalkis, colVaris, colTarih, colFiyat, colPlaka, colAktif;
        private FlowLayoutPanel flpButonlar;
        internal SimpleButton btnEkle, btnDuzenle, btnSil, btnYolcular, btnIptal, btnYenile;
        private LabelControl lblDurum;
    }
}
