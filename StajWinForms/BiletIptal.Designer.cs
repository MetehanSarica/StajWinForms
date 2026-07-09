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
            txtboxTC = new TextEdit();
            btnSorgula = new SimpleButton();
            gridBiletler = new GridControl();
            gridView = new GridView();
            pnlBottom = new PanelControl();
            btnIptalEt = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)pnlTop).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtboxTC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBiletler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlBottom).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            //
            // pnlTop
            //
            pnlTop.Controls.Add(lblTC);
            pnlTop.Controls.Add(txtboxTC);
            pnlTop.Controls.Add(btnSorgula);
            pnlTop.Dock = DockStyle.Top;
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
            lblTC.TabIndex = 0;
            lblTC.Text = "TC Kimlik No:";
            //
            // txtboxTC
            //
            txtboxTC.Location = new Point(16, 32);
            txtboxTC.Name = "txtboxTC";
            txtboxTC.Size = new Size(220, 20);
            txtboxTC.TabIndex = 1;
            txtboxTC.EditValueChanged += txtboxTC_TextChanged;
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
            gridBiletler.MainView = gridView;
            gridBiletler.Name = "gridBiletler";
            gridBiletler.TabIndex = 1;
            gridBiletler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            //
            // gridView
            //
            gridView.GridControl = gridBiletler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsSelection.MultiSelect = false;
            gridView.OptionsView.ShowGroupPanel = false;
            //
            // pnlBottom
            //
            pnlBottom.Controls.Add(btnIptalEt);
            pnlBottom.Dock = DockStyle.Bottom;
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
            Name = "BiletIptal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bilet İptal";
            ((System.ComponentModel.ISupportInitialize)pnlTop).EndInit();
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtboxTC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBiletler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlBottom).EndInit();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PanelControl pnlTop;
        private LabelControl lblTC;
        private TextEdit txtboxTC;
        private SimpleButton btnSorgula;
        private GridControl gridBiletler;
        private GridView gridView;
        private PanelControl pnlBottom;
        private SimpleButton btnIptalEt;
    }
}
