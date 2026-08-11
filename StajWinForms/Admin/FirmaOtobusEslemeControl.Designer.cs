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
            // lblFirma
            // 
            lblFirma.Location = new Point(9, 14);
            lblFirma.Margin = new Padding(4, 3, 4, 3);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(30, 13);
            lblFirma.TabIndex = 0;
            lblFirma.Text = "Firma:";
            // 
            // cmbFirma
            // 
            cmbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFirma.Location = new Point(64, 10);
            cmbFirma.Margin = new Padding(4, 3, 4, 3);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(349, 23);
            cmbFirma.TabIndex = 1;
            cmbFirma.SelectedIndexChanged += cmbFirma_SelectedIndexChanged;
            // 
            // lblFirmaOtobusler
            // 
            lblFirmaOtobusler.Dock = DockStyle.Fill;
            lblFirmaOtobusler.Location = new Point(357, 12);
            lblFirmaOtobusler.Margin = new Padding(4, 3, 4, 3);
            lblFirmaOtobusler.Name = "lblFirmaOtobusler";
            lblFirmaOtobusler.Size = new Size(230, 13);
            lblFirmaOtobusler.TabIndex = 2;
            lblFirmaOtobusler.Text = "Firmaya Atanmış Otobüsler";
            // 
            // lstFirmaOtobusler
            // 
            lstFirmaOtobusler.Dock = DockStyle.Fill;
            lstFirmaOtobusler.Location = new Point(357, 31);
            lstFirmaOtobusler.Margin = new Padding(4, 3, 4, 3);
            lstFirmaOtobusler.Name = "lstFirmaOtobusler";
            lstFirmaOtobusler.Size = new Size(230, 427);
            lstFirmaOtobusler.TabIndex = 3;
            // 
            // lblDigerOtobusler
            // 
            lblDigerOtobusler.Dock = DockStyle.Fill;
            lblDigerOtobusler.Location = new Point(13, 12);
            lblDigerOtobusler.Margin = new Padding(4, 3, 4, 3);
            lblDigerOtobusler.Name = "lblDigerOtobusler";
            lblDigerOtobusler.Size = new Size(185, 13);
            lblDigerOtobusler.TabIndex = 4;
            lblDigerOtobusler.Text = "Atanmamış Otobüsler";
            // 
            // lstDigerOtobusler
            // 
            lstDigerOtobusler.Dock = DockStyle.Fill;
            lstDigerOtobusler.Location = new Point(13, 31);
            lstDigerOtobusler.Margin = new Padding(4, 3, 4, 3);
            lstDigerOtobusler.Name = "lstDigerOtobusler";
            lstDigerOtobusler.Size = new Size(185, 427);
            lstDigerOtobusler.TabIndex = 5;
            // 
            // btnAta
            // 
            btnAta.Location = new Point(13, 72);
            btnAta.Margin = new Padding(4, 3, 4, 3);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(117, 40);
            btnAta.TabIndex = 6;
            btnAta.Text = "Ata ►";
            btnAta.Click += btnAta_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.Location = new Point(13, 118);
            btnKaldir.Margin = new Padding(4, 3, 4, 3);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(117, 40);
            btnKaldir.TabIndex = 7;
            btnKaldir.Text = "◄ Kaldır";
            btnKaldir.Click += btnKaldir_Click;
            // 
            // flpButonlar
            // 
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpButonlar.Controls.Add(btnAta);
            flpButonlar.Controls.Add(btnKaldir);
            flpButonlar.Dock = DockStyle.Fill;
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Location = new Point(206, 31);
            flpButonlar.Margin = new Padding(4, 3, 4, 3);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(9, 69, 9, 0);
            flpButonlar.Size = new Size(143, 427);
            flpButonlar.TabIndex = 8;
            flpButonlar.WrapContents = false;
            // 
            // pnlFirma
            // 
            pnlFirma.Controls.Add(cmbFirma);
            pnlFirma.Controls.Add(lblFirma);
            pnlFirma.Dock = DockStyle.Top;
            pnlFirma.Location = new Point(0, 0);
            pnlFirma.Margin = new Padding(4, 3, 4, 3);
            pnlFirma.Name = "pnlFirma";
            pnlFirma.Padding = new Padding(9, 9, 9, 0);
            pnlFirma.Size = new Size(600, 46);
            pnlFirma.TabIndex = 1;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tblMain.Controls.Add(lblDigerOtobusler, 0, 0);
            tblMain.Controls.Add(lstDigerOtobusler, 0, 1);
            tblMain.Controls.Add(flpButonlar, 1, 1);
            tblMain.Controls.Add(lblFirmaOtobusler, 2, 0);
            tblMain.Controls.Add(lstFirmaOtobusler, 2, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 46);
            tblMain.Margin = new Padding(4, 3, 4, 3);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(9, 9, 9, 9);
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(600, 470);
            tblMain.TabIndex = 0;
            // 
            // FirmaOtobusEslemeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Controls.Add(pnlFirma);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FirmaOtobusEslemeControl";
            Size = new Size(600, 516);
            Load += FirmaOtobusEslemeControl_Load;
            ((System.ComponentModel.ISupportInitialize)lstFirmaOtobusler).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstDigerOtobusler).EndInit();
            flpButonlar.ResumeLayout(false);
            pnlFirma.ResumeLayout(false);
            pnlFirma.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
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
