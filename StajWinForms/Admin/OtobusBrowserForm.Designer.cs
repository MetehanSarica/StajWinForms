using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms
{
    partial class OtobusBrowserForm
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
            gridOtobusler = new GridControl();
            gridView = new GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            btnEkle = new SimpleButton();
            btnDegistir = new SimpleButton();
            btnSil = new SimpleButton();
            btnIncele = new SimpleButton();
            btnYenile = new SimpleButton();
            lblDurum = new LabelControl();
            flpButonlar = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)gridOtobusler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            flpButonlar.SuspendLayout();
            SuspendLayout();
            //
            // gridOtobusler
            //
            gridOtobusler.Location = new Point(12, 12);
            gridOtobusler.MainView = gridView;
            gridOtobusler.Name = "gridOtobusler";
            gridOtobusler.Size = new Size(700, 380);
            gridOtobusler.TabIndex = 0;
            gridOtobusler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            //
            // gridView
            //
            gridView.GridControl = gridOtobusler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Appearance.Row.Options.UseTextOptions = true;
            gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6 });
            //
            // gridColumn1
            //
            gridColumn1.Caption = "ID";
            gridColumn1.FieldName = "OtobusId";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 40;
            //
            // gridColumn2
            //
            gridColumn2.Caption = "Plaka";
            gridColumn2.FieldName = "Plaka";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 100;
            //
            // gridColumn3
            //
            gridColumn3.Caption = "Marka";
            gridColumn3.FieldName = "Marka";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 100;
            //
            // gridColumn4
            //
            gridColumn4.Caption = "Model";
            gridColumn4.FieldName = "Model";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 100;
            //
            // gridColumn5
            //
            gridColumn5.Caption = "Koltuk Kap.";
            gridColumn5.FieldName = "KoltukKapasitesi";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 80;
            //
            // gridColumn6
            //
            gridColumn6.Caption = "Firma";
            gridColumn6.FieldName = "FirmaAdi";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 150;
            //
            // btnEkle
            //
            btnEkle.Location = new Point(3, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 35);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            //
            // btnDegistir
            //
            btnDegistir.Location = new Point(3, 46);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(130, 35);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.Click += btnDegistir_Click;
            //
            // btnSil
            //
            btnSil.Location = new Point(3, 89);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 35);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            //
            // btnIncele
            //
            btnIncele.Location = new Point(3, 132);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(130, 35);
            btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;
            //
            // btnYenile
            //
            btnYenile.Location = new Point(3, 175);
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
            flpButonlar.Location = new Point(725, 12);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.WrapContents = false;
            flpButonlar.TabIndex = 7;
            //
            // OtobusBrowserForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 430);
            Controls.Add(gridOtobusler);
            Controls.Add(flpButonlar);
            Controls.Add(lblDurum);
            MaximizeBox = false;
            Name = "OtobusBrowserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Otobüs Yönetimi";
            Load += OtobusBrowserForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridOtobusler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GridControl gridOtobusler;
        private GridView gridView;
        private SimpleButton btnEkle, btnDegistir, btnSil, btnIncele, btnYenile;
        private LabelControl lblDurum;
        private FlowLayoutPanel flpButonlar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}
