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
            btnEkle = new SimpleButton(); btnDegistir = new SimpleButton();
            btnSil = new SimpleButton(); btnIncele = new SimpleButton(); btnYenile = new SimpleButton();
            lblDurum = new LabelControl();

            ((System.ComponentModel.ISupportInitialize)gridPersonel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();

            gridPersonel.Location = new System.Drawing.Point(12, 12);
            gridPersonel.MainView = gridView;
            gridPersonel.Size = new System.Drawing.Size(650, 380);
            gridPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            gridView.GridControl = gridPersonel;
            gridView.OptionsBehavior.Editable = false;

            int bx = 675, by = 12, bw = 130, bh = 35, bgap = 10;
            btnEkle.Location = new System.Drawing.Point(bx, by); by += bh + bgap; btnEkle.Size = new System.Drawing.Size(bw, bh); btnEkle.Text = "Ekle"; btnEkle.Click += btnEkle_Click;
            btnDegistir.Location = new System.Drawing.Point(bx, by); by += bh + bgap; btnDegistir.Size = new System.Drawing.Size(bw, bh); btnDegistir.Text = "Değiştir"; btnDegistir.Click += btnDegistir_Click;
            btnSil.Location = new System.Drawing.Point(bx, by); by += bh + bgap; btnSil.Size = new System.Drawing.Size(bw, bh); btnSil.Text = "Sil"; btnSil.Click += btnSil_Click;
            btnIncele.Location = new System.Drawing.Point(bx, by); by += bh + bgap; btnIncele.Size = new System.Drawing.Size(bw, bh); btnIncele.Text = "İncele"; btnIncele.Click += btnIncele_Click;
            btnYenile.Location = new System.Drawing.Point(bx, by); btnYenile.Size = new System.Drawing.Size(bw, bh); btnYenile.Text = "Yenile"; btnYenile.Click += btnYenile_Click;

            lblDurum.Location = new System.Drawing.Point(12, 400); lblDurum.Text = "";

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(820, 430);
            Controls.Add(gridPersonel); Controls.Add(btnEkle); Controls.Add(btnDegistir);
            Controls.Add(btnSil); Controls.Add(btnIncele); Controls.Add(btnYenile); Controls.Add(lblDurum);
            Name = "KaptanBrowserForm"; StartPosition = FormStartPosition.CenterParent; Text = "Kaptan Yönetimi";
            Load += KaptanBrowserForm_Load;

            ((System.ComponentModel.ISupportInitialize)gridPersonel).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        #endregion

        private GridControl gridPersonel;
        private GridView gridView;
        private SimpleButton btnEkle, btnDegistir, btnSil, btnIncele, btnYenile;
        private LabelControl lblDurum;
    }
}
