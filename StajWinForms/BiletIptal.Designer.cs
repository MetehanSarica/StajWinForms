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
    }
}
