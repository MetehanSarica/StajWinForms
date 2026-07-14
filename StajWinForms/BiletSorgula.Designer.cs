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
            gridView1.GridControl = dataGridSorgu;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsDetail.EnableMasterViewMode = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowDetailButtons = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowIndicator = false;
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
    }
}
