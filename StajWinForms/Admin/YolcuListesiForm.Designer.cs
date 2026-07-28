using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class YolcuListesiForm
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
            lblGuzerah = new LabelControl();
            gridYolcular = new GridControl();
            gridView = new GridView();
            colKoltuk = new DevExpress.XtraGrid.Columns.GridColumn();
            colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            colTc = new DevExpress.XtraGrid.Columns.GridColumn();
            colCinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridYolcular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // lblGuzerah
            // 
            lblGuzerah.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGuzerah.Appearance.Options.UseFont = true;
            lblGuzerah.Dock = DockStyle.Top;
            lblGuzerah.Location = new Point(0, 0);
            lblGuzerah.Name = "lblGuzerah";
            lblGuzerah.Padding = new Padding(8, 10, 8, 10);
            lblGuzerah.Size = new Size(16, 37);
            lblGuzerah.TabIndex = 0;
            // 
            // gridYolcular
            // 
            gridYolcular.Dock = DockStyle.Fill;
            gridYolcular.Location = new Point(0, 37);
            gridYolcular.MainView = gridView;
            gridYolcular.Name = "gridYolcular";
            gridYolcular.Size = new Size(460, 383);
            gridYolcular.TabIndex = 1;
            gridYolcular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colKoltuk, colAdSoyad, colTc, colCinsiyet });
            gridView.GridControl = gridYolcular;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            // 
            // colKoltuk
            // 
            colKoltuk.Caption = "Koltuk";
            colKoltuk.FieldName = "KoltukNo";
            colKoltuk.Name = "colKoltuk";
            colKoltuk.Visible = true;
            colKoltuk.VisibleIndex = 0;
            colKoltuk.Width = 60;
            // 
            // colAdSoyad
            // 
            colAdSoyad.Caption = "Ad Soyad";
            colAdSoyad.FieldName = "MusteriAdSoyad";
            colAdSoyad.Name = "colAdSoyad";
            colAdSoyad.Visible = true;
            colAdSoyad.VisibleIndex = 1;
            colAdSoyad.Width = 160;
            // 
            // colTc
            // 
            colTc.Caption = "TC";
            colTc.FieldName = "MusteriTc";
            colTc.Name = "colTc";
            colTc.Visible = true;
            colTc.VisibleIndex = 2;
            colTc.Width = 110;
            // 
            // colCinsiyet
            // 
            colCinsiyet.Caption = "Cinsiyet";
            colCinsiyet.FieldName = "Cinsiyet";
            colCinsiyet.Name = "colCinsiyet";
            colCinsiyet.Visible = true;
            colCinsiyet.VisibleIndex = 3;
            colCinsiyet.Width = 70;
            // 
            // YolcuListesiForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 420);
            Controls.Add(gridYolcular);
            Controls.Add(lblGuzerah);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "YolcuListesiForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yolcu Listesi";
            Load += YolcuListesiForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridYolcular).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal LabelControl lblGuzerah;
        internal GridControl gridYolcular;
        internal GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colKoltuk;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTc;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsiyet;
    }
}
