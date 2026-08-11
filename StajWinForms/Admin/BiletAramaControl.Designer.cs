using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class BiletAramaControl
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
            pnlFiltre = new PanelControl();
            lblKalkis = new LabelControl();
            cboKalkis = new ComboBoxEdit();
            lblVaris = new LabelControl();
            cboVaris = new ComboBoxEdit();
            lblTarih = new LabelControl();
            dtTarih = new DateEdit();
            btnAra = new SimpleButton();
            btnTemizle = new SimpleButton();
            gridBiletler = new GridControl();
            gridView = new GridView();
            colBiletId = new DevExpress.XtraGrid.Columns.GridColumn();
            colMusteri = new DevExpress.XtraGrid.Columns.GridColumn();
            colTc = new DevExpress.XtraGrid.Columns.GridColumn();
            colKoltuk = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            colKalkis = new DevExpress.XtraGrid.Columns.GridColumn();
            colVaris = new DevExpress.XtraGrid.Columns.GridColumn();
            colZaman = new DevExpress.XtraGrid.Columns.GridColumn();
            colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)pnlFiltre).BeginInit();
            pnlFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboKalkis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboVaris.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtTarih.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtTarih.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBiletler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // pnlFiltre
            // 
            pnlFiltre.Controls.Add(lblKalkis);
            pnlFiltre.Controls.Add(cboKalkis);
            pnlFiltre.Controls.Add(lblVaris);
            pnlFiltre.Controls.Add(cboVaris);
            pnlFiltre.Controls.Add(lblTarih);
            pnlFiltre.Controls.Add(dtTarih);
            pnlFiltre.Controls.Add(btnAra);
            pnlFiltre.Controls.Add(btnTemizle);
            pnlFiltre.Dock = DockStyle.Top;
            pnlFiltre.Location = new Point(0, 0);
            pnlFiltre.Margin = new Padding(4, 3, 4, 3);
            pnlFiltre.Name = "pnlFiltre";
            pnlFiltre.Size = new Size(931, 63);
            pnlFiltre.TabIndex = 0;
            // 
            // lblKalkis
            // 
            lblKalkis.Location = new Point(9, 21);
            lblKalkis.Margin = new Padding(4, 3, 4, 3);
            lblKalkis.Name = "lblKalkis";
            lblKalkis.Size = new Size(30, 13);
            lblKalkis.TabIndex = 0;
            lblKalkis.Text = "Kalkış:";
            // 
            // cboKalkis
            // 
            cboKalkis.Location = new Point(64, 16);
            cboKalkis.Margin = new Padding(4, 3, 4, 3);
            cboKalkis.Name = "cboKalkis";
            cboKalkis.Size = new Size(175, 20);
            cboKalkis.TabIndex = 0;
            // 
            // lblVaris
            // 
            lblVaris.Location = new Point(251, 21);
            lblVaris.Margin = new Padding(4, 3, 4, 3);
            lblVaris.Name = "lblVaris";
            lblVaris.Size = new Size(27, 13);
            lblVaris.TabIndex = 1;
            lblVaris.Text = "Varış:";
            // 
            // cboVaris
            // 
            cboVaris.Location = new Point(292, 16);
            cboVaris.Margin = new Padding(4, 3, 4, 3);
            cboVaris.Name = "cboVaris";
            cboVaris.Size = new Size(175, 20);
            cboVaris.TabIndex = 1;
            // 
            // lblTarih
            // 
            lblTarih.Location = new Point(478, 21);
            lblTarih.Margin = new Padding(4, 3, 4, 3);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(28, 13);
            lblTarih.TabIndex = 2;
            lblTarih.Text = "Tarih:";
            // 
            // dtTarih
            // 
            dtTarih.EditValue = null;
            dtTarih.Location = new Point(519, 16);
            dtTarih.Margin = new Padding(4, 3, 4, 3);
            dtTarih.Name = "dtTarih";
            dtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtTarih.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            dtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtTarih.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            dtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtTarih.Properties.Mask.EditMask = "dd.MM.yyyy";
            dtTarih.Size = new Size(140, 20);
            dtTarih.TabIndex = 2;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(677, 14);
            btnAra.Margin = new Padding(4, 3, 4, 3);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(105, 30);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.Click += btnAra_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(793, 14);
            btnTemizle.Margin = new Padding(4, 3, 4, 3);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(105, 30);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.Click += btnTemizle_Click;
            // 
            // gridBiletler
            // 
            gridBiletler.Dock = DockStyle.Fill;
            gridBiletler.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridBiletler.Location = new Point(0, 63);
            gridBiletler.MainView = gridView;
            gridBiletler.Margin = new Padding(4, 3, 4, 3);
            gridBiletler.Name = "gridBiletler";
            gridBiletler.Size = new Size(931, 439);
            gridBiletler.TabIndex = 1;
            gridBiletler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colBiletId, colMusteri, colTc, colKoltuk, colFirma, colKalkis, colVaris, colZaman, colFiyat });
            gridView.DetailHeight = 404;
            gridView.GridControl = gridBiletler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            // 
            // colBiletId
            // 
            colBiletId.Caption = "Bilet No";
            colBiletId.FieldName = "BiletId";
            colBiletId.MinWidth = 23;
            colBiletId.Name = "colBiletId";
            colBiletId.Visible = true;
            colBiletId.VisibleIndex = 0;
            colBiletId.Width = 70;
            // 
            // colMusteri
            // 
            colMusteri.Caption = "Ad Soyad";
            colMusteri.FieldName = "MusteriAdSoyad";
            colMusteri.MinWidth = 23;
            colMusteri.Name = "colMusteri";
            colMusteri.Visible = true;
            colMusteri.VisibleIndex = 1;
            colMusteri.Width = 152;
            // 
            // colTc
            // 
            colTc.Caption = "TC";
            colTc.FieldName = "MusteriTc";
            colTc.MinWidth = 23;
            colTc.Name = "colTc";
            colTc.Visible = true;
            colTc.VisibleIndex = 2;
            colTc.Width = 117;
            // 
            // colKoltuk
            // 
            colKoltuk.Caption = "Koltuk";
            colKoltuk.FieldName = "KoltukNo";
            colKoltuk.MinWidth = 23;
            colKoltuk.Name = "colKoltuk";
            colKoltuk.Visible = true;
            colKoltuk.VisibleIndex = 3;
            colKoltuk.Width = 64;
            // 
            // colFirma
            // 
            colFirma.Caption = "Firma";
            colFirma.FieldName = "FirmaAdi";
            colFirma.MinWidth = 23;
            colFirma.Name = "colFirma";
            colFirma.Visible = true;
            colFirma.VisibleIndex = 4;
            colFirma.Width = 117;
            // 
            // colKalkis
            // 
            colKalkis.Caption = "Kalkış";
            colKalkis.FieldName = "KalkisSehirAdi";
            colKalkis.MinWidth = 23;
            colKalkis.Name = "colKalkis";
            colKalkis.Visible = true;
            colKalkis.VisibleIndex = 5;
            colKalkis.Width = 105;
            // 
            // colVaris
            // 
            colVaris.Caption = "Varış";
            colVaris.FieldName = "VarisSehirAdi";
            colVaris.MinWidth = 23;
            colVaris.Name = "colVaris";
            colVaris.Visible = true;
            colVaris.VisibleIndex = 6;
            colVaris.Width = 105;
            // 
            // colZaman
            // 
            colZaman.Caption = "Kalkış Zamanı";
            colZaman.FieldName = "KalkisZamani";
            colZaman.MinWidth = 23;
            colZaman.Name = "colZaman";
            colZaman.Visible = true;
            colZaman.VisibleIndex = 7;
            colZaman.Width = 134;
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
            colFiyat.VisibleIndex = 8;
            colFiyat.Width = 87;
            // 
            // BiletAramaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridBiletler);
            Controls.Add(pnlFiltre);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BiletAramaControl";
            Size = new Size(931, 502);
            Load += BiletAramaControl_Load;
            ((System.ComponentModel.ISupportInitialize)pnlFiltre).EndInit();
            pnlFiltre.ResumeLayout(false);
            pnlFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboKalkis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboVaris.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtTarih.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtTarih.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBiletler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }

        private DevExpress.XtraEditors.PanelControl pnlFiltre;
        private LabelControl lblKalkis;
        internal ComboBoxEdit cboKalkis;
        private LabelControl lblVaris;
        internal ComboBoxEdit cboVaris;
        private LabelControl lblTarih;
        internal DateEdit dtTarih;
        internal SimpleButton btnAra, btnTemizle;
        internal GridControl gridBiletler;
        internal GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colBiletId, colMusteri, colTc, colKoltuk, colFirma, colKalkis, colVaris, colZaman, colFiyat;
    }
}
