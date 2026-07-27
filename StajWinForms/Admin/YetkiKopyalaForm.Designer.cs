using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms
{
    partial class YetkiKopyalaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBaslik = new LabelControl();
            gridKullanicilar = new GridControl();
            gridView = new GridView();
            colSec = new DevExpress.XtraGrid.Columns.GridColumn();
            riSec = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            btnKopyala = new SimpleButton();
            btnIptal = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridKullanicilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)riSec).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(186, 13);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Yetkiler şu kullanıcı(lar)a kopyalanacak:";
            // 
            // gridKullanicilar
            // 
            gridKullanicilar.Location = new Point(20, 45);
            gridKullanicilar.MainView = gridView;
            gridKullanicilar.Name = "gridKullanicilar";
            gridKullanicilar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { riSec });
            gridKullanicilar.Size = new Size(360, 285);
            gridKullanicilar.TabIndex = 1;
            gridKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colSec, colKullaniciAdi });
            gridView.GridControl = gridKullanicilar;
            gridView.Name = "gridView";
            gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colSec
            // 
            colSec.Caption = "Seç";
            colSec.ColumnEdit = riSec;
            colSec.FieldName = "Sec";
            colSec.Name = "colSec";
            colSec.Visible = true;
            colSec.VisibleIndex = 0;
            colSec.Width = 61;
            // 
            // riSec
            // 
            riSec.AutoHeight = false;
            riSec.Name = "riSec";
            // 
            // colKullaniciAdi
            // 
            colKullaniciAdi.Caption = "Kullanıcı Adı";
            colKullaniciAdi.FieldName = "KullaniciAdi";
            colKullaniciAdi.Name = "colKullaniciAdi";
            colKullaniciAdi.OptionsColumn.AllowEdit = false;
            colKullaniciAdi.Visible = true;
            colKullaniciAdi.VisibleIndex = 1;
            colKullaniciAdi.Width = 274;
            // 
            // btnKopyala
            // 
            btnKopyala.Location = new Point(180, 345);
            btnKopyala.Name = "btnKopyala";
            btnKopyala.Size = new Size(95, 35);
            btnKopyala.TabIndex = 2;
            btnKopyala.Text = "Kopyala";
            btnKopyala.Click += btnKopyala_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(285, 345);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(95, 35);
            btnIptal.TabIndex = 3;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            // 
            // YetkiKopyalaForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 395);
            Controls.Add(lblBaslik);
            Controls.Add(gridKullanicilar);
            Controls.Add(btnKopyala);
            Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "YetkiKopyalaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yetki Kopyala";
            Load += YetkiKopyalaForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)riSec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblBaslik;
        private GridControl gridKullanicilar;
        private GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colSec;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riSec;
        private SimpleButton btnKopyala;
        private SimpleButton btnIptal;
    }
}
