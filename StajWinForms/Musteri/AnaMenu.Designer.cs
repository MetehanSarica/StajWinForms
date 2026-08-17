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
            components = new System.ComponentModel.Container();
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
            pnlDoviz = new PanelControl();
            lblDovizBaslik = new LabelControl();
            lblKaynakDoviz = new LabelControl();
            cmbKaynak = new ComboBoxEdit();
            lblHedefDoviz = new LabelControl();
            cmbHedef = new ComboBoxEdit();
            lblMiktarBaslik = new LabelControl();
            txtMiktar = new TextEdit();
            lblSonuc = new LabelControl();
            lblGuncelleme = new LabelControl();
            timerKur = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)panel1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVeriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlDoviz).BeginInit();
            pnlDoviz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbKaynak.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbHedef.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMiktar.Properties).BeginInit();
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
            // pnlDoviz
            //
            pnlDoviz.Controls.Add(lblGuncelleme);
            pnlDoviz.Controls.Add(lblSonuc);
            pnlDoviz.Controls.Add(txtMiktar);
            pnlDoviz.Controls.Add(lblMiktarBaslik);
            pnlDoviz.Controls.Add(cmbHedef);
            pnlDoviz.Controls.Add(lblHedefDoviz);
            pnlDoviz.Controls.Add(cmbKaynak);
            pnlDoviz.Controls.Add(lblKaynakDoviz);
            pnlDoviz.Controls.Add(lblDovizBaslik);
            pnlDoviz.Dock = DockStyle.Right;
            pnlDoviz.Name = "pnlDoviz";
            pnlDoviz.Size = new Size(270, 390);
            pnlDoviz.TabIndex = 3;
            //
            // lblDovizBaslik
            //
            lblDovizBaslik.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblDovizBaslik.Appearance.Options.UseFont = true;
            lblDovizBaslik.Appearance.Options.UseTextOptions = true;
            lblDovizBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblDovizBaslik.AutoSizeMode = LabelAutoSizeMode.None;
            lblDovizBaslik.Location = new Point(10, 15);
            lblDovizBaslik.Name = "lblDovizBaslik";
            lblDovizBaslik.Size = new Size(248, 24);
            lblDovizBaslik.Text = "Döviz Çevirici";
            //
            // lblKaynakDoviz
            //
            lblKaynakDoviz.Location = new Point(10, 55);
            lblKaynakDoviz.Name = "lblKaynakDoviz";
            lblKaynakDoviz.Text = "Kaynak Döviz:";
            //
            // cmbKaynak
            //
            cmbKaynak.Location = new Point(10, 73);
            cmbKaynak.Name = "cmbKaynak";
            cmbKaynak.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbKaynak.Size = new Size(248, 22);
            cmbKaynak.TabIndex = 10;
            cmbKaynak.SelectedIndexChanged += cmbKaynak_SelectedIndexChanged;
            //
            // lblHedefDoviz
            //
            lblHedefDoviz.Location = new Point(10, 110);
            lblHedefDoviz.Name = "lblHedefDoviz";
            lblHedefDoviz.Text = "Hedef Döviz:";
            //
            // cmbHedef
            //
            cmbHedef.Location = new Point(10, 128);
            cmbHedef.Name = "cmbHedef";
            cmbHedef.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbHedef.Size = new Size(248, 22);
            cmbHedef.TabIndex = 11;
            cmbHedef.SelectedIndexChanged += cmbHedef_SelectedIndexChanged;
            //
            // lblMiktarBaslik
            //
            lblMiktarBaslik.Location = new Point(10, 165);
            lblMiktarBaslik.Name = "lblMiktarBaslik";
            lblMiktarBaslik.Text = "Miktar:";
            //
            // txtMiktar
            //
            txtMiktar.Location = new Point(10, 183);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(248, 22);
            txtMiktar.TabIndex = 12;
            txtMiktar.EditValueChanged += txtMiktar_EditValueChanged;
            //
            // lblSonuc
            //
            lblSonuc.Appearance.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            lblSonuc.Appearance.Options.UseFont = true;
            lblSonuc.Appearance.Options.UseTextOptions = true;
            lblSonuc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblSonuc.AutoSizeMode = LabelAutoSizeMode.None;
            lblSonuc.Location = new Point(10, 225);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(248, 30);
            lblSonuc.Text = "-";
            //
            // lblGuncelleme
            //
            lblGuncelleme.Appearance.Font = new Font("Tahoma", 7.5F);
            lblGuncelleme.Appearance.Options.UseFont = true;
            lblGuncelleme.Location = new Point(10, 270);
            lblGuncelleme.Name = "lblGuncelleme";
            lblGuncelleme.Text = "Henüz güncellenmedi";
            //
            // timerKur
            //
            timerKur.Interval = 60000;
            timerKur.Tick += timerKur_Tick;
            //
            // AnaMenu
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 390);
            Controls.Add(dataGridVeriler);
            Controls.Add(pnlDoviz);
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
            ((System.ComponentModel.ISupportInitialize)pnlDoviz).EndInit();
            pnlDoviz.ResumeLayout(false);
            pnlDoviz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbKaynak.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbHedef.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMiktar.Properties).EndInit();
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
        private PanelControl pnlDoviz;
        private LabelControl lblDovizBaslik;
        private LabelControl lblKaynakDoviz;
        private ComboBoxEdit cmbKaynak;
        private LabelControl lblHedefDoviz;
        private ComboBoxEdit cmbHedef;
        private LabelControl lblMiktarBaslik;
        private TextEdit txtMiktar;
        private LabelControl lblSonuc;
        private LabelControl lblGuncelleme;
        private System.Windows.Forms.Timer timerKur;
    }
}
