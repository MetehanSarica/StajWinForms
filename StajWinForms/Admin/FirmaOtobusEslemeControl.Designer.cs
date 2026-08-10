using DevExpress.XtraEditors;

namespace StajWinForms.Admin
{
    partial class FirmaOtobusEslemeControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblFirma = new LabelControl();
            cmbFirma = new System.Windows.Forms.ComboBox();
            lblFirmaOtobusler = new LabelControl();
            lstFirmaOtobusler = new ListBoxControl();
            lblDigerOtobusler = new LabelControl();
            lstDigerOtobusler = new ListBoxControl();
            btnAta = new SimpleButton();
            btnKaldir = new SimpleButton();
            flpButonlar = new FlowLayoutPanel();
            pnlFirma = new Panel();
            tblMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)lstFirmaOtobusler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lstDigerOtobusler).BeginInit();
            flpButonlar.SuspendLayout();
            pnlFirma.SuspendLayout();
            tblMain.SuspendLayout();
            SuspendLayout();
            //
            // pnlFirma
            //
            pnlFirma.Controls.Add(cmbFirma);
            pnlFirma.Controls.Add(lblFirma);
            pnlFirma.Dock = DockStyle.Top;
            pnlFirma.Height = 40;
            pnlFirma.Name = "pnlFirma";
            pnlFirma.Padding = new Padding(8, 8, 8, 0);
            //
            // lblFirma
            //
            lblFirma.Location = new Point(8, 12);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(30, 13);
            lblFirma.TabIndex = 0;
            lblFirma.Text = "Firma:";
            //
            // cmbFirma
            //
            cmbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFirma.Location = new Point(55, 9);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(300, 21);
            cmbFirma.TabIndex = 1;
            cmbFirma.SelectedIndexChanged += cmbFirma_SelectedIndexChanged;
            //
            // tblMain
            //
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tblMain.Controls.Add(lblDigerOtobusler, 0, 0);
            tblMain.Controls.Add(lstDigerOtobusler, 0, 1);
            tblMain.Controls.Add(flpButonlar, 1, 1);
            tblMain.Controls.Add(lblFirmaOtobusler, 2, 0);
            tblMain.Controls.Add(lstFirmaOtobusler, 2, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(8);
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.TabIndex = 0;
            //
            // lblDigerOtobusler
            //
            lblDigerOtobusler.Dock = DockStyle.Fill;
            lblDigerOtobusler.Name = "lblDigerOtobusler";
            lblDigerOtobusler.TabIndex = 4;
            lblDigerOtobusler.Text = "Atanmamış Otobüsler";
            //
            // lstDigerOtobusler
            //
            lstDigerOtobusler.Dock = DockStyle.Fill;
            lstDigerOtobusler.Name = "lstDigerOtobusler";
            lstDigerOtobusler.TabIndex = 5;
            //
            // flpButonlar
            //
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpButonlar.Controls.Add(btnAta);
            flpButonlar.Controls.Add(btnKaldir);
            flpButonlar.Dock = DockStyle.Fill;
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(8, 60, 8, 0);
            flpButonlar.WrapContents = false;
            flpButonlar.TabIndex = 8;
            //
            // btnAta
            //
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(100, 35);
            btnAta.TabIndex = 6;
            btnAta.Text = "Ata ►";
            btnAta.Click += btnAta_Click;
            //
            // btnKaldir
            //
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(100, 35);
            btnKaldir.TabIndex = 7;
            btnKaldir.Text = "◄ Kaldır";
            btnKaldir.Click += btnKaldir_Click;
            //
            // lblFirmaOtobusler
            //
            lblFirmaOtobusler.Dock = DockStyle.Fill;
            lblFirmaOtobusler.Name = "lblFirmaOtobusler";
            lblFirmaOtobusler.TabIndex = 2;
            lblFirmaOtobusler.Text = "Firmaya Atanmış Otobüsler";
            //
            // lstFirmaOtobusler
            //
            lstFirmaOtobusler.Dock = DockStyle.Fill;
            lstFirmaOtobusler.Name = "lstFirmaOtobusler";
            lstFirmaOtobusler.TabIndex = 3;
            //
            // FirmaOtobusEslemeControl
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Controls.Add(pnlFirma);
            Name = "FirmaOtobusEslemeControl";
            Load += FirmaOtobusEslemeControl_Load;
            ((System.ComponentModel.ISupportInitialize)lstFirmaOtobusler).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstDigerOtobusler).EndInit();
            flpButonlar.ResumeLayout(false);
            pnlFirma.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblFirma, lblFirmaOtobusler, lblDigerOtobusler;
        private System.Windows.Forms.ComboBox cmbFirma;
        private ListBoxControl lstFirmaOtobusler, lstDigerOtobusler;
        private SimpleButton btnKaldir, btnAta;
        private FlowLayoutPanel flpButonlar;
        private Panel pnlFirma;
        private TableLayoutPanel tblMain;
    }
}
