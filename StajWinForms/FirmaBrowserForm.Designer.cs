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
            btnEkle = new SimpleButton();
            btnDegistir = new SimpleButton();
            btnSil = new SimpleButton();
            btnIncele = new SimpleButton();
            btnYenile = new SimpleButton();
            lblDurum = new LabelControl();

            ((System.ComponentModel.ISupportInitialize)gridFirmalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();

            // gridFirmalar
            gridFirmalar.Location = new System.Drawing.Point(12, 12);
            gridFirmalar.MainView = gridView;
            gridFirmalar.Name = "gridFirmalar";
            gridFirmalar.Size = new System.Drawing.Size(600, 380);
            gridFirmalar.TabIndex = 0;
            gridFirmalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });

            // gridView
            gridView.GridControl = gridFirmalar;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;

            // butonlar
            int bx = 630, by = 12, bw = 130, bh = 35, bgap = 10;

            btnEkle.Location = new System.Drawing.Point(bx, by); by += bh + bgap;
            btnEkle.Size = new System.Drawing.Size(bw, bh);
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;

            btnDegistir.Location = new System.Drawing.Point(bx, by); by += bh + bgap;
            btnDegistir.Size = new System.Drawing.Size(bw, bh);
            btnDegistir.Text = "Değiştir";
            btnDegistir.Click += btnDegistir_Click;

            btnSil.Location = new System.Drawing.Point(bx, by); by += bh + bgap;
            btnSil.Size = new System.Drawing.Size(bw, bh);
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;

            btnIncele.Location = new System.Drawing.Point(bx, by); by += bh + bgap;
            btnIncele.Size = new System.Drawing.Size(bw, bh);
            btnIncele.Text = "İncele";
            btnIncele.Click += btnIncele_Click;

            btnYenile.Location = new System.Drawing.Point(bx, by);
            btnYenile.Size = new System.Drawing.Size(bw, bh);
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;

            lblDurum.Location = new System.Drawing.Point(12, 400);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new System.Drawing.Size(200, 13);
            lblDurum.Text = "";

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(780, 430);
            Controls.Add(gridFirmalar);
            Controls.Add(btnEkle);
            Controls.Add(btnDegistir);
            Controls.Add(btnSil);
            Controls.Add(btnIncele);
            Controls.Add(btnYenile);
            Controls.Add(lblDurum);
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
        private SimpleButton btnEkle;
        private SimpleButton btnDegistir;
        private SimpleButton btnSil;
        private SimpleButton btnIncele;
        private SimpleButton btnYenile;
        private LabelControl lblDurum;
    }
}
