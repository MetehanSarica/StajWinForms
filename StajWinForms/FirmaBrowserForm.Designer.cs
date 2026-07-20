using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms
{
    partial class FirmaBrowserForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            gridFirmalar.Location = new Point(12, 12);
            gridFirmalar.MainView = gridView;
            gridFirmalar.Name = "gridFirmalar";
            gridFirmalar.Size = new Size(600, 380);
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
            gridView.GridControl = gridFirmalar;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            //
            // gridColumn1
            //
            gridColumn1.Caption = "ID";
            gridColumn1.FieldName = "FirmaId";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 50;
            //
            // gridColumn2
            //
            gridColumn2.Caption = "Firma Adı";
            gridColumn2.FieldName = "FirmaAdi";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 300;
            //
            // btnEkle
            //
            btnEkle.Location = new Point(3, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 35);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            //
            // btnDegistir
            //
            btnDegistir.Location = new Point(3, 46);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(124, 35);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.Click += btnDegistir_Click;
            //
            // btnSil
            //
            btnSil.Location = new Point(3, 89);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 35);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            //
            // btnIncele
            //
            btnIncele.Location = new Point(3, 132);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(124, 35);
            btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;
            //
            // lblDurum
            //
            lblDurum.Location = new Point(12, 400);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(0, 13);
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
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Location = new Point(630, 12);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.WrapContents = false;
            flpButonlar.TabIndex = 7;
            //
            // btnYenile
            //
            btnYenile.Location = new Point(3, 175);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(124, 35);
            btnYenile.TabIndex = 5;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;
            //
            // FirmaBrowserForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 430);
            Controls.Add(gridFirmalar);
            Controls.Add(lblDurum);
            Controls.Add(flpButonlar);
            MaximizeBox = false;
            Name = "FirmaBrowserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Firma Yönetimi";
            Load += FirmaBrowserForm_Load;
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
