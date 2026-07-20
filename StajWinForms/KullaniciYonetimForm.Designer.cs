using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms
{
    partial class KullaniciYonetimForm
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
            gridKullanicilar = new GridControl();
            gridView = new GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            btnEkle = new SimpleButton();
            btnDegistir = new SimpleButton();
            btnSil = new SimpleButton();
            btnIncele = new SimpleButton();
            btnYenile = new SimpleButton();
            lblDurum = new LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridKullanicilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // gridKullanicilar
            // 
            gridKullanicilar.Location = new Point(12, 12);
            gridKullanicilar.MainView = gridView;
            gridKullanicilar.Name = "gridKullanicilar";
            gridKullanicilar.Size = new Size(620, 380);
            gridKullanicilar.TabIndex = 0;
            gridKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
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
            gridColumn1.Caption = "ID";
            gridColumn1.FieldName = "KullaniciId";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 40;
            //
            // gridColumn2
            //
            gridColumn2.Caption = "Kullanıcı Adı";
            gridColumn2.FieldName = "KullaniciAdi";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 150;
            //
            // gridColumn3
            //
            gridColumn3.Caption = "Ad Soyad";
            gridColumn3.FieldName = "AdSoyad";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 180;
            //
            // gridColumn4
            //
            gridColumn4.Caption = "Aktif";
            gridColumn4.FieldName = "Aktif";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 60;
            //
            // gridColumn5
            //
            gridColumn5.Caption = "Kayıt Tarihi";
            gridColumn5.FieldName = "OlusturmaTarihi";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 130;
            //
            // btnEkle
            // 
            btnEkle.Location = new Point(645, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 35);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(645, 57);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(130, 35);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(645, 102);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 35);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnIncele
            // 
            btnIncele.Location = new Point(645, 147);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(130, 35);
            btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(645, 192);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(130, 35);
            btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;
            // 
            // lblDurum
            // 
            lblDurum.Location = new Point(12, 400);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 13);
            lblDurum.TabIndex = 6;
            // 
            // KullaniciYonetimForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 430);
            Controls.Add(gridKullanicilar);
            Controls.Add(btnEkle);
            Controls.Add(btnDegistir);
            Controls.Add(btnSil);
            Controls.Add(btnIncele);
            Controls.Add(btnYenile);
            Controls.Add(lblDurum);
            MaximizeBox = false;
            Name = "KullaniciYonetimForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kullanıcı Yönetimi";
            Load += KullaniciYonetimForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GridControl gridKullanicilar;
        private GridView gridView;
        private SimpleButton btnEkle, btnDegistir, btnSil, btnIncele, btnYenile;
        private LabelControl lblDurum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}
