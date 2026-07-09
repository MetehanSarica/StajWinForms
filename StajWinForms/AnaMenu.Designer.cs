using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms
{
    partial class AnaMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new PanelControl();
            btnBiletIptal = new SimpleButton();
            btnBiletSorgula = new SimpleButton();
            btnSeferDetaylar = new SimpleButton();
            btnSec = new SimpleButton();
            dataGridVeriler = new GridControl();
            gridView1 = new GridView();
            txtboxAra = new TextEdit();
            panelControl1 = new PanelControl();
            ((System.ComponentModel.ISupportInitialize)panel1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVeriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAra.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBiletIptal);
            panel1.Controls.Add(btnBiletSorgula);
            panel1.Controls.Add(btnSeferDetaylar);
            panel1.Controls.Add(btnSec);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 87);
            panel1.TabIndex = 0;
            // 
            // btnBiletIptal
            // 
            btnBiletIptal.Location = new Point(294, 3);
            btnBiletIptal.Name = "btnBiletIptal";
            btnBiletIptal.Size = new Size(90, 78);
            btnBiletIptal.TabIndex = 8;
            btnBiletIptal.Text = "Bilet Iptal";
            btnBiletIptal.Click += btnBiletIptal_Click;
            // 
            // btnBiletSorgula
            // 
            btnBiletSorgula.Location = new Point(198, 3);
            btnBiletSorgula.Name = "btnBiletSorgula";
            btnBiletSorgula.Size = new Size(90, 78);
            btnBiletSorgula.TabIndex = 7;
            btnBiletSorgula.Text = "Bilet Sorgulama";
            btnBiletSorgula.Click += btnSorgu_Click;
            // 
            // btnSeferDetaylar
            // 
            btnSeferDetaylar.Location = new Point(102, 3);
            btnSeferDetaylar.Name = "btnSeferDetaylar";
            btnSeferDetaylar.Size = new Size(90, 78);
            btnSeferDetaylar.TabIndex = 6;
            btnSeferDetaylar.Text = "Sefer Detayları";
            btnSeferDetaylar.Click += btnSeferDetaylar_Click;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(6, 3);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(90, 78);
            btnSec.TabIndex = 5;
            btnSec.Text = "Seç";
            btnSec.Click += btnSec_Click;
            // 
            // dataGridVeriler
            // 
            dataGridVeriler.Dock = DockStyle.Fill;
            dataGridVeriler.Location = new Point(0, 143);
            dataGridVeriler.MainView = gridView1;
            dataGridVeriler.Name = "dataGridVeriler";
            dataGridVeriler.Size = new Size(686, 247);
            dataGridVeriler.TabIndex = 2;
            dataGridVeriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = dataGridVeriler;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtboxAra
            // 
            txtboxAra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtboxAra.Location = new Point(251, 18);
            txtboxAra.Name = "txtboxAra";
            txtboxAra.Size = new Size(173, 20);
            txtboxAra.TabIndex = 1;
            txtboxAra.EditValueChanged += txtboxAra_EditValueChanged;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(txtboxAra);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 87);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(686, 56);
            panelControl1.TabIndex = 3;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(dataGridVeriler);
            Controls.Add(panelControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)panel1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridVeriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAra.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PanelControl panel1;
        private GridControl dataGridVeriler;
        private GridView gridView1;
        private SimpleButton btnBiletSorgula;
        private SimpleButton btnSeferDetaylar;
        private SimpleButton btnSec;
        private TextEdit txtboxAra;
        private PanelControl panelControl1;
        private SimpleButton btnBiletIptal;
    }
}
