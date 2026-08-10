using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class FirmaBrowserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            gridFirmalar = new GridControl();
            gridView = new GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            btnEkle = new SimpleButton();
            btnDegistir = new SimpleButton();
            btnSil = new SimpleButton();
            btnIncele = new SimpleButton();
            lblDurum = new LabelControl();
            flpButonlar = new FlowLayoutPanel();
            btnYenile = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridFirmalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            flpButonlar.SuspendLayout();
            SuspendLayout();
            // 
            // gridFirmalar
            // 
            gridFirmalar.Dock = DockStyle.Fill;
            gridFirmalar.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridFirmalar.Location = new Point(0, 0);
            gridFirmalar.MainView = gridView;
            gridFirmalar.Margin = new Padding(4, 3, 4, 3);
            gridFirmalar.Name = "gridFirmalar";
            gridFirmalar.Size = new Size(4, 156);
            gridFirmalar.TabIndex = 0;
            gridFirmalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Appearance.Row.Options.UseTextOptions = true;
            gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2 });
            gridView.DetailHeight = 404;
            gridView.GridControl = gridFirmalar;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "ID";
            gridColumn1.FieldName = "FirmaId";
            gridColumn1.MinWidth = 23;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 58;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Firma Adı";
            gridColumn2.FieldName = "FirmaAdi";
            gridColumn2.MinWidth = 23;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 350;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(13, 12);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(145, 40);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(13, 58);
            btnDegistir.Margin = new Padding(4, 3, 4, 3);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(145, 40);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(13, 104);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(145, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnIncele
            // 
            btnIncele.Location = new Point(13, 150);
            btnIncele.Margin = new Padding(4, 3, 4, 3);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(145, 40);
            btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;
            // 
            // lblDurum
            // 
            lblDurum.Dock = DockStyle.Bottom;
            lblDurum.Location = new Point(0, 156);
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
            flpButonlar.Location = new Point(4, 0);
            flpButonlar.Margin = new Padding(4, 3, 4, 3);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(9);
            flpButonlar.Size = new Size(171, 156);
            flpButonlar.TabIndex = 7;
            flpButonlar.WrapContents = false;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(13, 196);
            btnYenile.Margin = new Padding(4, 3, 4, 3);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(145, 40);
            btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;
            // 
            // FirmaBrowserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridFirmalar);
            Controls.Add(flpButonlar);
            Controls.Add(lblDurum);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FirmaBrowserControl";
            Size = new Size(175, 173);
            Load += FirmaBrowserControl_Load;
            ((System.ComponentModel.ISupportInitialize)gridFirmalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GridControl gridFirmalar;
        private GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private SimpleButton btnEkle;
        private SimpleButton btnDegistir;
        private SimpleButton btnSil;
        private SimpleButton btnIncele;
        private LabelControl lblDurum;
        private FlowLayoutPanel flpButonlar;
        private SimpleButton btnYenile;
    }
}
