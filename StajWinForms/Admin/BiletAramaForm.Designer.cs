using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class BiletAramaForm
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
            pnlFiltre = new DevExpress.XtraEditors.PanelControl();
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
            pnlFiltre.Name = "pnlFiltre";
            pnlFiltre.Size = new Size(900, 55);
            pnlFiltre.TabIndex = 0;
            //
            // lblKalkis
            //
            lblKalkis.Location = new Point(8, 18);
            lblKalkis.Name = "lblKalkis";
            lblKalkis.Text = "Kalkış:";
            //
            // cboKalkis
            //
            cboKalkis.Location = new Point(55, 14);
            cboKalkis.Name = "cboKalkis";
            cboKalkis.Size = new Size(150, 20);
            cboKalkis.TabIndex = 0;
            //
            // lblVaris
            //
            lblVaris.Location = new Point(215, 18);
            lblVaris.Name = "lblVaris";
            lblVaris.Text = "Varış:";
            //
            // cboVaris
            //
            cboVaris.Location = new Point(250, 14);
            cboVaris.Name = "cboVaris";
            cboVaris.Size = new Size(150, 20);
            cboVaris.TabIndex = 1;
            //
            // lblTarih
            //
            lblTarih.Location = new Point(410, 18);
            lblTarih.Name = "lblTarih";
            lblTarih.Text = "Tarih:";
            //
            // dtTarih
            //
            dtTarih.EditValue = null;
            dtTarih.Location = new Point(445, 14);
            dtTarih.Name = "dtTarih";
            dtTarih.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            dtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtTarih.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            dtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            dtTarih.Properties.Mask.EditMask = "dd.MM.yyyy";
            dtTarih.Size = new Size(120, 20);
            dtTarih.TabIndex = 2;
            //
            // btnAra
            //
            btnAra.Location = new Point(580, 12);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(90, 26);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.Click += btnAra_Click;
            //
            // btnTemizle
            //
            btnTemizle.Location = new Point(680, 12);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(90, 26);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.Click += btnTemizle_Click;
            //
            // gridBiletler
            //
            gridBiletler.Dock = DockStyle.Fill;
            gridBiletler.MainView = gridView;
            gridBiletler.Name = "gridBiletler";
            gridBiletler.TabIndex = 1;
            gridBiletler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            //
            // gridView
            //
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colBiletId, colMusteri, colTc, colKoltuk, colFirma, colKalkis, colVaris, colZaman, colFiyat });
            gridView.GridControl = gridBiletler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsView.ShowIndicator = false;
            //
            // colBiletId
            //
            colBiletId.Caption = "Bilet No";
            colBiletId.FieldName = "BiletId";
            colBiletId.Name = "colBiletId";
            colBiletId.Visible = true;
            colBiletId.VisibleIndex = 0;
            colBiletId.Width = 60;
            //
            // colMusteri
            //
            colMusteri.Caption = "Ad Soyad";
            colMusteri.FieldName = "MusteriAdSoyad";
            colMusteri.Name = "colMusteri";
            colMusteri.Visible = true;
            colMusteri.VisibleIndex = 1;
            colMusteri.Width = 130;
            //
            // colTc
            //
            colTc.Caption = "TC";
            colTc.FieldName = "MusteriTc";
            colTc.Name = "colTc";
            colTc.Visible = true;
            colTc.VisibleIndex = 2;
            colTc.Width = 100;
            //
            // colKoltuk
            //
            colKoltuk.Caption = "Koltuk";
            colKoltuk.FieldName = "KoltukNo";
            colKoltuk.Name = "colKoltuk";
            colKoltuk.Visible = true;
            colKoltuk.VisibleIndex = 3;
            colKoltuk.Width = 55;
            //
            // colFirma
            //
            colFirma.Caption = "Firma";
            colFirma.FieldName = "FirmaAdi";
            colFirma.Name = "colFirma";
            colFirma.Visible = true;
            colFirma.VisibleIndex = 4;
            colFirma.Width = 100;
            //
            // colKalkis
            //
            colKalkis.Caption = "Kalkış";
            colKalkis.FieldName = "KalkisSehirAdi";
            colKalkis.Name = "colKalkis";
            colKalkis.Visible = true;
            colKalkis.VisibleIndex = 5;
            colKalkis.Width = 90;
            //
            // colVaris
            //
            colVaris.Caption = "Varış";
            colVaris.FieldName = "VarisSehirAdi";
            colVaris.Name = "colVaris";
            colVaris.Visible = true;
            colVaris.VisibleIndex = 6;
            colVaris.Width = 90;
            //
            // colZaman
            //
            colZaman.Caption = "Kalkış Zamanı";
            colZaman.FieldName = "KalkisZamani";
            colZaman.Name = "colZaman";
            colZaman.Visible = true;
            colZaman.VisibleIndex = 7;
            colZaman.Width = 115;
            //
            // colFiyat
            //
            colFiyat.Caption = "Fiyat";
            colFiyat.FieldName = "Fiyat";
            colFiyat.DisplayFormat.FormatString = "₺{0:N2}";
            colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colFiyat.Name = "colFiyat";
            colFiyat.Visible = true;
            colFiyat.VisibleIndex = 8;
            colFiyat.Width = 75;
            //
            // BiletAramaForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 520);
            Controls.Add(gridBiletler);
            Controls.Add(pnlFiltre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BiletAramaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bilet Arama";
            Load += BiletAramaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pnlFiltre).EndInit();
            pnlFiltre.ResumeLayout(false);
            pnlFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cboKalkis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboVaris.Properties).EndInit();
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
        internal SimpleButton btnAra;
        internal SimpleButton btnTemizle;
        internal GridControl gridBiletler;
        internal GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colBiletId;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn colTc;
        private DevExpress.XtraGrid.Columns.GridColumn colKoltuk;
        private DevExpress.XtraGrid.Columns.GridColumn colFirma;
        private DevExpress.XtraGrid.Columns.GridColumn colKalkis;
        private DevExpress.XtraGrid.Columns.GridColumn colVaris;
        private DevExpress.XtraGrid.Columns.GridColumn colZaman;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
    }
}
