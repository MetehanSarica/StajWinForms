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
            panelTop = new PanelControl();
            lblTC = new LabelControl();
            txtboxTC = new TextEdit();
            btnBiletSorgu = new SimpleButton();
            dataGridSorgu = new GridControl();
            gridView1 = new GridView();
            ((System.ComponentModel.ISupportInitialize)panelTop).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtboxTC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSorgu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            //
            // panelTop
            //
            panelTop.Controls.Add(lblTC);
            panelTop.Controls.Add(txtboxTC);
            panelTop.Controls.Add(btnBiletSorgu);
            panelTop.Dock = DockStyle.Top;
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(460, 80);
            panelTop.TabIndex = 0;
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
            dataGridSorgu.MainView = gridView1;
            dataGridSorgu.Name = "dataGridSorgu";
            dataGridSorgu.TabIndex = 1;
            dataGridSorgu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            //
            // gridView1
            //
            gridView1.GridControl = dataGridSorgu;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsSelection.MultiSelect = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            //
            // BiletSorgula
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 480);
            Controls.Add(dataGridSorgu);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BiletSorgula";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bilet Sorgulama";
            ((System.ComponentModel.ISupportInitialize)panelTop).EndInit();
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtboxTC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSorgu).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelControl panelTop;
        private LabelControl lblTC;
        private TextEdit txtboxTC;
        private SimpleButton btnBiletSorgu;
        private GridControl dataGridSorgu;
        private GridView gridView1;
    }
}
