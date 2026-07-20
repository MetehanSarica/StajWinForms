using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace StajWinForms
{
    partial class KaptanBrowserForm
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
            gridPersonel = new GridControl();
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
            ((System.ComponentModel.ISupportInitialize)gridPersonel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // gridPersonel
            // 
            gridPersonel.Location = new Point(12, 12);
            gridPersonel.MainView = gridView;
            gridPersonel.Name = "gridPersonel";
            gridPersonel.Size = new Size(650, 380);
            gridPersonel.TabIndex = 0;
            gridPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // gridView
            // 
            gridView.GridControl = gridPersonel;
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
            gridColumn1.FieldName = "Id";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 40;
            //
            // gridColumn2
            //
            gridColumn2.Caption = "Ad";
            gridColumn2.FieldName = "Ad";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 100;
            //
            // gridColumn3
            //
            gridColumn3.Caption = "Soyad";
            gridColumn3.FieldName = "Soyad";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 100;
            //
            // gridColumn4
            //
            gridColumn4.Caption = "E-posta";
            gridColumn4.FieldName = "Email";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 180;
            //
            // gridColumn5
            //
            gridColumn5.Caption = "Maaş";
            gridColumn5.FieldName = "Maas";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.DisplayFormat.FormatString = "₺{0:N2}";
            gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 100;
            //
            // gridColumn6
            //
            gridColumn6.Caption = "İşe Giriş";
            gridColumn6.FieldName = "IseGirisTarihi";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.DisplayFormat.FormatString = "dd.MM.yyyy";
            gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 100;
            //
            // btnEkle
            // 
            btnEkle.Location = new Point(675, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 35);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(675, 57);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(130, 35);
            btnDegistir.TabIndex = 2;
            btnDegistir.Text = "Değiştir";
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(675, 102);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 35);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnIncele
            // 
            btnIncele.Location = new Point(675, 147);
            btnIncele.Name = "btnIncele";
            btnIncele.Size = new Size(130, 35);
            btnIncele.TabIndex = 4;
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(675, 192);
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
            // KaptanBrowserForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 430);
            Controls.Add(gridPersonel);
            Controls.Add(btnEkle);
            Controls.Add(btnDegistir);
            Controls.Add(btnSil);
            Controls.Add(btnIncele);
            Controls.Add(btnYenile);
            Controls.Add(lblDurum);
            MaximizeBox = false;
            Name = "KaptanBrowserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kaptan Yönetimi";
            Load += KaptanBrowserForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridPersonel).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GridControl gridPersonel;
        private GridView gridView;
        private SimpleButton btnEkle, btnDegistir, btnSil, btnIncele, btnYenile;
        private LabelControl lblDurum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}
