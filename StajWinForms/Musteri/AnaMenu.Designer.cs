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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            panel1 = new PanelControl();
            btnBiletIptal = new SimpleButton();
            btnBiletSorgula = new SimpleButton();
            btnSeferDetaylar = new SimpleButton();
            btnSec = new SimpleButton();
            dataGridVeriler = new GridControl();
            gridView1 = new GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panel1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVeriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
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
            btnBiletIptal.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
            btnBiletIptal.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnBiletIptal.ImageOptions.SvgImage");
            btnBiletIptal.ImageOptions.SvgImageSize = new Size(50, 50);
            btnBiletIptal.Location = new Point(294, 3);
            btnBiletIptal.Name = "btnBiletIptal";
            btnBiletIptal.Size = new Size(90, 78);
            btnBiletIptal.TabIndex = 8;
            btnBiletIptal.Text = "Bilet Iptal";
            btnBiletIptal.Click += btnBiletIptal_Click;
            // 
            // btnBiletSorgula
            // 
            btnBiletSorgula.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
            btnBiletSorgula.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnBiletSorgula.ImageOptions.SvgImage");
            btnBiletSorgula.ImageOptions.SvgImageSize = new Size(50, 50);
            btnBiletSorgula.Location = new Point(198, 3);
            btnBiletSorgula.Name = "btnBiletSorgula";
            btnBiletSorgula.Size = new Size(90, 78);
            btnBiletSorgula.TabIndex = 7;
            btnBiletSorgula.Text = "Bilet Sorgulama";
            btnBiletSorgula.Click += btnSorgu_Click;
            // 
            // btnSeferDetaylar
            // 
            btnSeferDetaylar.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
            btnSeferDetaylar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSeferDetaylar.ImageOptions.SvgImage");
            btnSeferDetaylar.ImageOptions.SvgImageSize = new Size(50, 50);
            btnSeferDetaylar.Location = new Point(102, 3);
            btnSeferDetaylar.Name = "btnSeferDetaylar";
            btnSeferDetaylar.Size = new Size(90, 78);
            btnSeferDetaylar.TabIndex = 6;
            btnSeferDetaylar.Text = "Sefer Detayları";
            btnSeferDetaylar.Click += btnSeferDetaylar_Click;
            // 
            // btnSec
            // 
            btnSec.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
            btnSec.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSec.ImageOptions.SvgImage");
            btnSec.ImageOptions.SvgImageSize = new Size(50, 50);
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
            dataGridVeriler.Location = new Point(0, 87);
            dataGridVeriler.MainView = gridView1;
            dataGridVeriler.Name = "dataGridVeriler";
            dataGridVeriler.Size = new Size(686, 303);
            dataGridVeriler.TabIndex = 2;
            dataGridVeriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            dataGridVeriler.DoubleClick += dataGridVeriler_DoubleClick;
            // 
            // gridView1
            // 
            gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Appearance.Row.Options.UseTextOptions = true;
            gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8 });
            gridView1.GridControl = dataGridVeriler;
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
            gridColumn1.Caption = "Sefer Kodu";
            gridColumn1.FieldName = "PnrKodu";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Firma Adı";
            gridColumn2.FieldName = "FirmaAdi";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Kalkış Şehri";
            gridColumn3.FieldName = "KalkisSehirAdi";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Varış Şehri";
            gridColumn4.FieldName = "VarisSehirAdi";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Kalkış Tarihi";
            gridColumn5.FieldName = "KalkisZamani";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Kalkış Saati";
            gridColumn6.FieldName = "KalkisSaati";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Fiyat";
            gridColumn7.DisplayFormat.FormatString = "₺{0:N2}";
            gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn7.FieldName = "Fiyat";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "Boş Koltuk";
            gridColumn8.FieldName = "BosKoltuk";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 7;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 390);
            Controls.Add(dataGridVeriler);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menü";
            Load += AnaMenu_Load;
            ((System.ComponentModel.ISupportInitialize)panel1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridVeriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelControl panel1;
        private GridControl dataGridVeriler;
        private GridView gridView1;
        private SimpleButton btnBiletSorgula;
        private SimpleButton btnSeferDetaylar;
        private SimpleButton btnSec;
        private SimpleButton btnBiletIptal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}
