using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class MusteriBrowserForm
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
            gridMusteriler.Location = new Point(12, 12);
            gridMusteriler.MainView = gridView;
            gridMusteriler.Name = "gridMusteriler";
            gridMusteriler.Size = new Size(780, 400);
            gridMusteriler.TabIndex = 0;
            gridMusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            //
            // gridView
            //
            gridView.GridControl = gridMusteriler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAd, colSoyad, colTc, colEmail, colTelefon, colSehir, colCinsiyet, colKayitTarihi });
            //
            // colAd
            //
            colAd.Caption = "Ad"; colAd.FieldName = "Ad"; colAd.Name = "colAd";
            colAd.Visible = true; colAd.VisibleIndex = 0; colAd.Width = 90;
            //
            // colSoyad
            //
            colSoyad.Caption = "Soyad"; colSoyad.FieldName = "Soyad"; colSoyad.Name = "colSoyad";
            colSoyad.Visible = true; colSoyad.VisibleIndex = 1; colSoyad.Width = 90;
            //
            // colTc
            //
            colTc.Caption = "TC"; colTc.FieldName = "Tc"; colTc.Name = "colTc";
            colTc.Visible = true; colTc.VisibleIndex = 2; colTc.Width = 110;
            //
            // colEmail
            //
            colEmail.Caption = "E-posta"; colEmail.FieldName = "Email"; colEmail.Name = "colEmail";
            colEmail.Visible = true; colEmail.VisibleIndex = 3; colEmail.Width = 160;
            //
            // colTelefon
            //
            colTelefon.Caption = "Telefon"; colTelefon.FieldName = "Telefon"; colTelefon.Name = "colTelefon";
            colTelefon.Visible = true; colTelefon.VisibleIndex = 4; colTelefon.Width = 110;
            //
            // colSehir
            //
            colSehir.Caption = "Şehir"; colSehir.FieldName = "Sehir"; colSehir.Name = "colSehir";
            colSehir.Visible = true; colSehir.VisibleIndex = 5; colSehir.Width = 90;
            //
            // colCinsiyet
            //
            colCinsiyet.Caption = "Cinsiyet"; colCinsiyet.FieldName = "Cinsiyet"; colCinsiyet.Name = "colCinsiyet";
            colCinsiyet.Visible = true; colCinsiyet.VisibleIndex = 6; colCinsiyet.Width = 70;
            //
            // colKayitTarihi
            //
            colKayitTarihi.Caption = "Kayıt Tarihi"; colKayitTarihi.FieldName = "KayitTarihi"; colKayitTarihi.Name = "colKayitTarihi";
            colKayitTarihi.DisplayFormat.FormatString = "dd.MM.yyyy";
            colKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colKayitTarihi.Visible = true; colKayitTarihi.VisibleIndex = 7; colKayitTarihi.Width = 90;
            //
            // btnEkle
            //
            btnEkle.Location = new Point(3, 3); btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 35); btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle"; btnEkle.Click += btnEkle_Click;
            //
            // btnDuzenle
            //
            btnDuzenle.Location = new Point(3, 46); btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(130, 35); btnDuzenle.TabIndex = 2;
            btnDuzenle.Text = "Düzenle"; btnDuzenle.Click += btnDuzenle_Click;
            //
            // btnIncele
            //
            btnIncele.Location = new Point(3, 89); btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(130, 35); btnIncele.TabIndex = 3;
            btnIncele.Text = "İncele"; btnIncele.Click += btnIncele_Click;
            //
            // btnSil
            //
            btnSil.Location = new Point(3, 132); btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 35); btnSil.TabIndex = 4;
            btnSil.Text = "Sil"; btnSil.Click += btnSil_Click;
            //
            // btnYenile
            //
            btnYenile.Location = new Point(3, 175); btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(130, 35); btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile"; btnYenile.Click += btnYenile_Click;
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
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Location = new Point(805, 12);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.WrapContents = false;
            flpButonlar.TabIndex = 3;
            //
            // MusteriBrowserForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 430);
            Controls.Add(gridMusteriler);
            Controls.Add(flpButonlar);
            MaximizeBox = false;
            Name = "MusteriBrowserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Müşteri Yönetimi";
            Load += MusteriBrowserForm_Load;
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
