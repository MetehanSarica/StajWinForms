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
            btnEkle = new SimpleButton();
            btnDegistir = new SimpleButton();
            btnSil = new SimpleButton();
            btnIncele = new SimpleButton();
            btnYenile = new SimpleButton();
            lblDurum = new LabelControl();

            ((System.ComponentModel.ISupportInitialize)gridOtobusler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();

            gridOtobusler.Location = new System.Drawing.Point(12, 12);
            gridOtobusler.MainView = gridView;
            gridOtobusler.Name = "gridOtobusler";
            gridOtobusler.Size = new System.Drawing.Size(700, 380);
            gridOtobusler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });

            gridView.GridControl = gridOtobusler;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.Editable = false;

            int bx = 725, by = 12, bw = 130, bh = 35, bgap = 10;

            btnEkle.Location = new System.Drawing.Point(bx, by); by += bh + bgap;
            btnEkle.Size = new System.Drawing.Size(bw, bh); btnEkle.Text = "Ekle"; btnEkle.Click += btnEkle_Click;

            btnDegistir.Location = new System.Drawing.Point(bx, by); by += bh + bgap;
            btnDegistir.Size = new System.Drawing.Size(bw, bh); btnDegistir.Text = "Değiştir"; btnDegistir.Click += btnDegistir_Click;

            btnSil.Location = new System.Drawing.Point(bx, by); by += bh + bgap;
            btnSil.Size = new System.Drawing.Size(bw, bh); btnSil.Text = "Sil"; btnSil.Click += btnSil_Click;

            btnIncele.Location = new System.Drawing.Point(bx, by); by += bh + bgap;
            btnIncele.Size = new System.Drawing.Size(bw, bh); btnIncele.Text = "İncele"; btnIncele.Click += btnIncele_Click;

            btnYenile.Location = new System.Drawing.Point(bx, by);
            btnYenile.Size = new System.Drawing.Size(bw, bh); btnYenile.Text = "Yenile"; btnYenile.Click += btnYenile_Click;

            lblDurum.Location = new System.Drawing.Point(12, 400);
            lblDurum.Name = "lblDurum"; lblDurum.Text = "";

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(870, 430);
            Controls.Add(gridOtobusler);
            Controls.Add(btnEkle); Controls.Add(btnDegistir); Controls.Add(btnSil);
            Controls.Add(btnIncele); Controls.Add(btnYenile); Controls.Add(lblDurum);
            Name = "OtobusBrowserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Otobüs Yönetimi";
            Load += OtobusBrowserForm_Load;

            ((System.ComponentModel.ISupportInitialize)gridOtobusler).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GridControl gridOtobusler;
        private GridView gridView;
        private SimpleButton btnEkle, btnDegistir, btnSil, btnIncele, btnYenile;
        private LabelControl lblDurum;
    }
}
