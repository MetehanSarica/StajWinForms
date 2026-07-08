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
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(500, 70);
            pnlTop.TabIndex = 0;
            //
            // lblTC
            //
            lblTC.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTC.Appearance.Options.UseFont = true;
            lblTC.Location = new Point(12, 26);
            lblTC.Name = "lblTC";
            lblTC.Text = "TC Kimlik No:";
            //
            // txtboxTC
            //
            txtboxTC.Location = new Point(110, 23);
            txtboxTC.Name = "txtboxTC";
            txtboxTC.Size = new Size(200, 20);
            txtboxTC.TabIndex = 1;
            txtboxTC.EditValueChanged += txtboxTC_TextChanged;
            //
            // btnSorgula
            //
            btnSorgula.Location = new Point(325, 21);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(100, 25);
            btnSorgula.TabIndex = 2;
            btnSorgula.Text = "Sorgula";
            btnSorgula.Click += btnSorgula_Click;
            //
            // gridBiletler
            //
            gridBiletler.Dock = DockStyle.Fill;
            gridBiletler.Location = new Point(0, 70);
            gridBiletler.MainView = gridView;
            gridBiletler.Name = "gridBiletler";
            gridBiletler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            gridBiletler.TabIndex = 3;
            //
            // gridView
            //
            gridView.GridControl = gridBiletler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            //
            // pnlBottom
            //
            pnlBottom.Controls.Add(btnIptalEt);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 420);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(500, 55);
            pnlBottom.TabIndex = 4;
            //
            // btnIptalEt
            //
            btnIptalEt.Location = new Point(175, 13);
            btnIptalEt.Name = "btnIptalEt";
            btnIptalEt.Size = new Size(150, 29);
            btnIptalEt.TabIndex = 0;
            btnIptalEt.Text = "Bilet İptal Et";
            btnIptalEt.Click += btnIptalEt_Click;
            //
            // BiletIptal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 475);
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
