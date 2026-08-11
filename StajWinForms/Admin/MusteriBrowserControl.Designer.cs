using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class MusteriBrowserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gridMusteriler = new GridControl();
            gridView = new GridView();
            colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            colTc = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            colSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            colCinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();
            colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            btnEkle = new SimpleButton();
            btnDuzenle = new SimpleButton();
            btnIncele = new SimpleButton();
            btnSil = new SimpleButton();
            btnYenile = new SimpleButton();
            flpButonlar = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)gridMusteriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            flpButonlar.SuspendLayout();
            SuspendLayout();
            // 
            // gridMusteriler
            // 
            gridMusteriler.Dock = DockStyle.Fill;
            gridMusteriler.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridMusteriler.Location = new Point(0, 0);
            gridMusteriler.MainView = gridView;
            gridMusteriler.Margin = new Padding(4, 3, 4, 3);
            gridMusteriler.Name = "gridMusteriler";
            gridMusteriler.Size = new Size(650, 498);
            gridMusteriler.TabIndex = 0;
            gridMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAd, colSoyad, colTc, colEmail, colTelefon, colSehir, colCinsiyet, colKayitTarihi });
            gridView.DetailHeight = 404;
            gridView.GridControl = gridMusteriler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colAd
            // 
            colAd.Caption = "Ad";
            colAd.FieldName = "Ad";
            colAd.MinWidth = 23;
            colAd.Name = "colAd";
            colAd.Visible = true;
            colAd.VisibleIndex = 0;
            colAd.Width = 105;
            // 
            // colSoyad
            // 
            colSoyad.Caption = "Soyad";
            colSoyad.FieldName = "Soyad";
            colSoyad.MinWidth = 23;
            colSoyad.Name = "colSoyad";
            colSoyad.Visible = true;
            colSoyad.VisibleIndex = 1;
            colSoyad.Width = 105;
            // 
            // colTc
            // 
            colTc.Caption = "TC";
            colTc.FieldName = "Tc";
            colTc.MinWidth = 23;
            colTc.Name = "colTc";
            colTc.Visible = true;
            colTc.VisibleIndex = 2;
            colTc.Width = 128;
            // 
            // colEmail
            // 
            colEmail.Caption = "E-posta";
            colEmail.FieldName = "Email";
            colEmail.MinWidth = 23;
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 3;
            colEmail.Width = 187;
            // 
            // colTelefon
            // 
            colTelefon.Caption = "Telefon";
            colTelefon.FieldName = "Telefon";
            colTelefon.MinWidth = 23;
            colTelefon.Name = "colTelefon";
            colTelefon.Visible = true;
            colTelefon.VisibleIndex = 4;
            colTelefon.Width = 128;
            // 
            // colSehir
            // 
            colSehir.Caption = "Şehir";
            colSehir.FieldName = "Sehir";
            colSehir.MinWidth = 23;
            colSehir.Name = "colSehir";
            colSehir.Visible = true;
            colSehir.VisibleIndex = 5;
            colSehir.Width = 105;
            // 
            // colCinsiyet
            // 
            colCinsiyet.Caption = "Cinsiyet";
            colCinsiyet.FieldName = "Cinsiyet";
            colCinsiyet.MinWidth = 23;
            colCinsiyet.Name = "colCinsiyet";
            colCinsiyet.Visible = true;
            colCinsiyet.VisibleIndex = 6;
            colCinsiyet.Width = 82;
            // 
            // colKayitTarihi
            // 
            colKayitTarihi.Caption = "Kayıt Tarihi";
            colKayitTarihi.DisplayFormat.FormatString = "dd.MM.yyyy";
            colKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colKayitTarihi.FieldName = "KayitTarihi";
            colKayitTarihi.MinWidth = 23;
            colKayitTarihi.Name = "colKayitTarihi";
            colKayitTarihi.Visible = true;
            colKayitTarihi.VisibleIndex = 7;
            colKayitTarihi.Width = 105;
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
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(13, 58);
            btnDuzenle.Margin = new Padding(4, 3, 4, 3);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(152, 40);
            btnDuzenle.TabIndex = 2;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnIncele
            // 
            btnIncele.Location = new Point(13, 104);
            btnIncele.Margin = new Padding(4, 3, 4, 3);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(152, 40);
            btnIncele.TabIndex = 3;
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(13, 150);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(152, 40);
            btnSil.TabIndex = 4;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
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
            // flpButonlar
            // 
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpButonlar.Controls.Add(btnEkle);
            flpButonlar.Controls.Add(btnDuzenle);
            flpButonlar.Controls.Add(btnIncele);
            flpButonlar.Controls.Add(btnSil);
            flpButonlar.Controls.Add(btnYenile);
            flpButonlar.Dock = DockStyle.Right;
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Location = new Point(650, 0);
            flpButonlar.Margin = new Padding(4, 3, 4, 3);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(9, 9, 9, 9);
            flpButonlar.Size = new Size(178, 498);
            flpButonlar.TabIndex = 3;
            flpButonlar.WrapContents = false;
            // 
            // MusteriBrowserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridMusteriler);
            Controls.Add(flpButonlar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MusteriBrowserControl";
            Size = new Size(828, 498);
            Load += MusteriBrowserControl_Load;
            ((System.ComponentModel.ISupportInitialize)gridMusteriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private GridControl gridMusteriler;
        private GridView gridView;
        private SimpleButton btnEkle, btnDuzenle, btnIncele, btnSil, btnYenile;
        private FlowLayoutPanel flpButonlar;
        private DevExpress.XtraGrid.Columns.GridColumn colAd, colSoyad, colTc, colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon, colSehir, colCinsiyet, colKayitTarihi;
    }
}
