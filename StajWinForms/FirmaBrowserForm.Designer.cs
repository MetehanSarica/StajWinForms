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
            btnYenile = new SimpleButton();
            lblDurum = new LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridFirmalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
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
            gridView.GridControl = gridFirmalar;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Appearance.Row.Options.UseTextOptions = true;
            gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2 });
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
            btnEkle.Location = new Point(630, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 35);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(630, 57);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(130, 35);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(630, 102);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 35);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnIncele
            // 
            btnIncele.Location = new Point(630, 147);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(130, 35);
            btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(630, 192);
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
            // FirmaBrowserForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 430);
            Controls.Add(gridFirmalar);
            Controls.Add(btnEkle);
            Controls.Add(btnDegistir);
            Controls.Add(btnSil);
            Controls.Add(btnIncele);
            Controls.Add(btnYenile);
            Controls.Add(lblDurum);
            MaximizeBox = false;
            Name = "FirmaBrowserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Firma Yönetimi";
            Load += FirmaBrowserForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridFirmalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
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
        private SimpleButton btnYenile;
        private LabelControl lblDurum;
    }
}
