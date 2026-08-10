using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class KullaniciYonetimControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gridKullanicilar = new GridControl();
            gridView = new GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            riChkAktif = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            btnEkle = new SimpleButton();
            btnDegistir = new SimpleButton();
            btnSil = new SimpleButton();
            btnIncele = new SimpleButton();
            btnYenile = new SimpleButton();
            lblDurum = new LabelControl();
            flpButonlar = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)gridKullanicilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)riChkAktif).BeginInit();
            flpButonlar.SuspendLayout();
            SuspendLayout();
            //
            // gridKullanicilar
            //
            gridKullanicilar.Dock = DockStyle.Fill;
            gridKullanicilar.MainView = gridView;
            gridKullanicilar.Name = "gridKullanicilar";
            gridKullanicilar.TabIndex = 0;
            gridKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            gridKullanicilar.RepositoryItems.Add(riChkAktif);
            //
            // gridView
            //
            gridView.GridControl = gridKullanicilar;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Appearance.Row.Options.UseTextOptions = true;
            gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5 });
            //
            // gridColumn1
            //
            gridColumn1.Caption = "ID"; gridColumn1.FieldName = "KullaniciId"; gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true; gridColumn1.VisibleIndex = 0; gridColumn1.Width = 40;
            //
            // gridColumn2
            //
            gridColumn2.Caption = "Kullanıcı Adı"; gridColumn2.FieldName = "KullaniciAdi"; gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true; gridColumn2.VisibleIndex = 1; gridColumn2.Width = 150;
            //
            // gridColumn3
            //
            gridColumn3.Caption = "Ad Soyad"; gridColumn3.FieldName = "AdSoyad"; gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true; gridColumn3.VisibleIndex = 2; gridColumn3.Width = 180;
            //
            // gridColumn4
            //
            gridColumn4.Caption = "Aktif"; gridColumn4.FieldName = "Aktif"; gridColumn4.Name = "gridColumn4";
            gridColumn4.ColumnEdit = riChkAktif;
            gridColumn4.Visible = true; gridColumn4.VisibleIndex = 3; gridColumn4.Width = 60;
            //
            // gridColumn5
            //
            gridColumn5.Caption = "Kayıt Tarihi"; gridColumn5.FieldName = "OlusturmaTarihi"; gridColumn5.Name = "gridColumn5";
            gridColumn5.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridColumn5.Visible = true; gridColumn5.VisibleIndex = 4; gridColumn5.Width = 130;
            //
            // btnEkle
            //
            btnEkle.Location = new Point(3, 3); btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 35); btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle"; btnEkle.Click += btnEkle_Click;
            //
            // btnDegistir
            //
            btnDegistir.Location = new Point(3, 46); btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(130, 35); btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir"; btnDegistir.Click += btnDegistir_Click;
            //
            // btnSil
            //
            btnSil.Location = new Point(3, 89); btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 35); btnSil.TabIndex = 3;
            btnSil.Text = "Sil"; btnSil.Click += btnSil_Click;
            //
            // btnIncele
            //
            btnIncele.Location = new Point(3, 132); btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(130, 35); btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele"; btnIncele.Click += btnIncele_Click;
            //
            // btnYenile
            //
            btnYenile.Location = new Point(3, 175); btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(130, 35); btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile"; btnYenile.Click += btnYenile_Click;
            //
            // lblDurum
            //
            lblDurum.Dock = DockStyle.Bottom;
            lblDurum.Name = "lblDurum"; lblDurum.TabIndex = 6;
            lblDurum.Padding = new Padding(4, 2, 0, 2);
            //
            // flpButonlar
            //
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpButonlar.Controls.Add(btnEkle);
            flpButonlar.Controls.Add(btnDegistir);
            flpButonlar.Controls.Add(btnSil);
            flpButonlar.Controls.Add(btnIncele);
            flpButonlar.Controls.Add(btnYenile);
            flpButonlar.Dock = DockStyle.Right;
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(8);
            flpButonlar.WrapContents = false;
            flpButonlar.TabIndex = 7;
            //
            // KullaniciYonetimControl
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridKullanicilar);
            Controls.Add(flpButonlar);
            Controls.Add(lblDurum);
            Name = "KullaniciYonetimControl";
            Load += KullaniciYonetimControl_Load;
            ((System.ComponentModel.ISupportInitialize)riChkAktif).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private GridControl gridKullanicilar;
        private GridView gridView;
        private SimpleButton btnEkle, btnDegistir, btnSil, btnIncele, btnYenile;
        private LabelControl lblDurum;
        private FlowLayoutPanel flpButonlar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riChkAktif;
    }
}
