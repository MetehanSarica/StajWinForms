using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms
{
    partial class BiletSorgula
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            panelTop = new PanelControl();
            spTC = new SpinEdit();
            lblTC = new LabelControl();
            btnBiletSorgu = new SimpleButton();
            dataGridSorgu = new GridControl();
            gridView1 = new GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelTop).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spTC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSorgu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(spTC);
            panelTop.Controls.Add(lblTC);
            panelTop.Controls.Add(btnBiletSorgu);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(460, 80);
            panelTop.TabIndex = 0;
            // 
            // spTC
            // 
            spTC.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spTC.Location = new Point(16, 31);
            spTC.Name = "spTC";
            spTC.Properties.AllowMouseWheel = false;
            spTC.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            spTC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, false, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            spTC.Properties.MaskSettings.Set("mask", "d");
            spTC.Properties.MaxLength = 11;
            spTC.RightToLeft = RightToLeft.Yes;
            spTC.Size = new Size(220, 20);
            spTC.TabIndex = 3;
            spTC.EditValueChanged += spTC_EditValueChanged;
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
            // btnBiletSorgu
            // 
            btnBiletSorgu.Location = new Point(252, 30);
            btnBiletSorgu.Name = "btnBiletSorgu";
            btnBiletSorgu.Size = new Size(130, 26);
            btnBiletSorgu.TabIndex = 2;
            btnBiletSorgu.Text = "Sorgula";
            btnBiletSorgu.Click += btnBiletSorgu_Click;
            // 
            // dataGridSorgu
            // 
            dataGridSorgu.Dock = DockStyle.Fill;
            dataGridSorgu.Location = new Point(0, 80);
            dataGridSorgu.MainView = gridView1;
            dataGridSorgu.Name = "dataGridSorgu";
            dataGridSorgu.Size = new Size(460, 400);
            dataGridSorgu.TabIndex = 1;
            dataGridSorgu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7 });
            gridView1.GridControl = dataGridSorgu;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsDetail.EnableMasterViewMode = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowDetailButtons = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn1.Caption = "Bilet No";
            gridColumn1.FieldName = "BiletId";
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
            // BiletSorgula
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 480);
            Controls.Add(dataGridSorgu);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BiletSorgula";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bilet Sorgulama";
            ((System.ComponentModel.ISupportInitialize)panelTop).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spTC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSorgu).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelControl panelTop;
        private LabelControl lblTC;
        private SimpleButton btnBiletSorgu;
        private GridControl dataGridSorgu;
        private GridView gridView1;
        private SpinEdit spTC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}
