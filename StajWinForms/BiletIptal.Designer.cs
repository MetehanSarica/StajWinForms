using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms
{
    partial class BiletIptal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTop = new PanelControl();
            lblTC = new LabelControl();
            spTC = new SpinEdit();
            btnSorgula = new SimpleButton();
            gridBiletler = new GridControl();
            gridView = new GridView();
            pnlBottom = new PanelControl();
            btnIptalEt = new SimpleButton();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)pnlTop).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spTC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBiletler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlBottom).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblTC);
            pnlTop.Controls.Add(spTC);
            pnlTop.Controls.Add(btnSorgula);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(460, 80);
            pnlTop.TabIndex = 0;
            // 
            // lblTC
            // 
            lblTC.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTC.Appearance.Options.UseFont = true;
            lblTC.Location = new Point(16, 12);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(74, 15);
            lblTC.TabIndex = 0;
            lblTC.Text = "TC Kimlik No:";
            // 
            // spTC
            // 
            spTC.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spTC.Location = new Point(16, 32);
            spTC.Name = "spTC";
            spTC.Properties.AllowMouseWheel = false;
            spTC.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            spTC.Properties.MaskSettings.Set("mask", "d");
            spTC.Properties.MaxLength = 11;
            spTC.RightToLeft = RightToLeft.Yes;
            spTC.Size = new Size(220, 20);
            spTC.TabIndex = 1;
            spTC.EditValueChanged += spTC_EditValueChanged;
            // 
            // btnSorgula
            // 
            btnSorgula.Location = new Point(252, 30);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(130, 26);
            btnSorgula.TabIndex = 2;
            btnSorgula.Text = "Sorgula";
            btnSorgula.Click += btnSorgula_Click;
            // 
            // gridBiletler
            // 
            gridBiletler.Dock = DockStyle.Fill;
            gridBiletler.Location = new Point(0, 80);
            gridBiletler.MainView = gridView;
            gridBiletler.Name = "gridBiletler";
            gridBiletler.Size = new Size(460, 345);
            gridBiletler.TabIndex = 1;
            gridBiletler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7 });
            gridView.GridControl = gridBiletler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsView.ShowDetailButtons = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.OptionsView.ShowIndicator = false;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnIptalEt);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 425);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(460, 55);
            pnlBottom.TabIndex = 4;
            // 
            // btnIptalEt
            // 
            btnIptalEt.Location = new Point(155, 13);
            btnIptalEt.Name = "btnIptalEt";
            btnIptalEt.Size = new Size(150, 29);
            btnIptalEt.TabIndex = 0;
            btnIptalEt.Text = "Bilet İptal Et";
            btnIptalEt.Click += btnIptalEt_Click;
            // 
            // gridColumn1
            // 
            gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn1.Caption = "Bilet No";
            gridColumn1.FieldName = "BiletID";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn2.Caption = "Koltuk No";
            gridColumn2.FieldName = "KoltukNo";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn3.Caption = "Firma Adı";
            gridColumn3.FieldName = "FirmaAdi";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn4.Caption = "Kalkış Şehri";
            gridColumn4.FieldName = "KalkisSehirAdi";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn5.Caption = "Varış Şehri";
            gridColumn5.FieldName = "VarisSehirAdi";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn6.Caption = "Kalkış Tarihi";
            gridColumn6.FieldName = "KalkisZamani";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn7.Caption = "Fiyat";
            gridColumn7.DisplayFormat.FormatString = "₺{0:N2}";
            gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn7.FieldName = "Fiyat";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            // 
            // BiletIptal
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 480);
            Controls.Add(gridBiletler);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BiletIptal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bilet İptal";
            ((System.ComponentModel.ISupportInitialize)pnlTop).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spTC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBiletler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlBottom).EndInit();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PanelControl pnlTop;
        private LabelControl lblTC;
        private SpinEdit spTC;
        private SimpleButton btnSorgula;
        private GridControl gridBiletler;
        private GridView gridView;
        private PanelControl pnlBottom;
        private SimpleButton btnIptalEt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}
