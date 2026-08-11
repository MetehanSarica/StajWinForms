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
            riChkAktif = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            gridKullanicilar.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridKullanicilar.Location = new Point(0, 0);
            gridKullanicilar.MainView = gridView;
            gridKullanicilar.Margin = new Padding(4, 3, 4, 3);
            gridKullanicilar.Name = "gridKullanicilar";
            gridKullanicilar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { riChkAktif });
            gridKullanicilar.Size = new Size(640, 499);
            gridKullanicilar.TabIndex = 0;
            gridKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Appearance.Row.Options.UseTextOptions = true;
            gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5 });
            gridView.DetailHeight = 404;
            gridView.GridControl = gridKullanicilar;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "ID";
            gridColumn1.FieldName = "KullaniciId";
            gridColumn1.MinWidth = 23;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 47;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Kullanıcı Adı";
            gridColumn2.FieldName = "KullaniciAdi";
            gridColumn2.MinWidth = 23;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 175;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Ad Soyad";
            gridColumn3.FieldName = "AdSoyad";
            gridColumn3.MinWidth = 23;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 210;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Aktif";
            gridColumn4.ColumnEdit = riChkAktif;
            gridColumn4.FieldName = "Aktif";
            gridColumn4.MinWidth = 23;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 70;
            // 
            // riChkAktif
            // 
            riChkAktif.Name = "riChkAktif";
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Kayıt Tarihi";
            gridColumn5.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridColumn5.FieldName = "OlusturmaTarihi";
            gridColumn5.MinWidth = 23;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 152;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(13, 12);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(152, 40);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(13, 58);
            btnDegistir.Margin = new Padding(4, 3, 4, 3);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(152, 40);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(13, 104);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(152, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnIncele
            // 
            btnIncele.Location = new Point(13, 150);
            btnIncele.Margin = new Padding(4, 3, 4, 3);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(152, 40);
            btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(13, 196);
            btnYenile.Margin = new Padding(4, 3, 4, 3);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(152, 40);
            btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;
            // 
            // lblDurum
            // 
            lblDurum.Dock = DockStyle.Bottom;
            lblDurum.Location = new Point(0, 499);
            lblDurum.Margin = new Padding(4, 3, 4, 3);
            lblDurum.Name = "lblDurum";
            lblDurum.Padding = new Padding(5, 2, 0, 2);
            lblDurum.Size = new Size(5, 17);
            lblDurum.TabIndex = 6;
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
            flpButonlar.Location = new Point(640, 0);
            flpButonlar.Margin = new Padding(4, 3, 4, 3);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(9, 9, 9, 9);
            flpButonlar.Size = new Size(178, 499);
            flpButonlar.TabIndex = 7;
            flpButonlar.WrapContents = false;
            // 
            // KullaniciYonetimControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridKullanicilar);
            Controls.Add(flpButonlar);
            Controls.Add(lblDurum);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KullaniciYonetimControl";
            Size = new Size(818, 516);
            Load += KullaniciYonetimControl_Load;
            ((System.ComponentModel.ISupportInitialize)gridKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)riChkAktif).EndInit();
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
