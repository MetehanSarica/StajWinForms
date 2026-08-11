using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms.Admin
{
    partial class OtobusBrowserControl
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
            gridOtobusler.Dock = DockStyle.Fill;
            gridOtobusler.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            gridOtobusler.Location = new Point(0, 0);
            gridOtobusler.MainView = gridView;
            gridOtobusler.Margin = new Padding(4, 3, 4, 3);
            gridOtobusler.Name = "gridOtobusler";
            gridOtobusler.Size = new Size(659, 513);
            gridOtobusler.TabIndex = 0;
            gridOtobusler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Appearance.Row.Options.UseTextOptions = true;
            gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6 });
            gridView.DetailHeight = 404;
            gridView.GridControl = gridOtobusler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;
            gridView.OptionsEditForm.PopupEditFormWidth = 933;
            gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "ID";
            gridColumn1.FieldName = "OtobusId";
            gridColumn1.MinWidth = 23;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 47;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Plaka";
            gridColumn2.FieldName = "Plaka";
            gridColumn2.MinWidth = 23;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 117;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Marka";
            gridColumn3.FieldName = "Marka";
            gridColumn3.MinWidth = 23;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 117;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Model";
            gridColumn4.FieldName = "Model";
            gridColumn4.MinWidth = 23;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 117;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Koltuk Kap.";
            gridColumn5.FieldName = "KoltukKapasitesi";
            gridColumn5.MinWidth = 23;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 93;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Firma";
            gridColumn6.FieldName = "FirmaAdi";
            gridColumn6.MinWidth = 23;
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 175;
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
            lblDurum.Location = new Point(0, 513);
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
            flpButonlar.Location = new Point(659, 0);
            flpButonlar.Margin = new Padding(4, 3, 4, 3);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(9, 9, 9, 9);
            flpButonlar.Size = new Size(178, 513);
            flpButonlar.TabIndex = 7;
            flpButonlar.WrapContents = false;
            // 
            // OtobusBrowserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridOtobusler);
            Controls.Add(flpButonlar);
            Controls.Add(lblDurum);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OtobusBrowserControl";
            Size = new Size(837, 530);
            Load += OtobusBrowserControl_Load;
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
