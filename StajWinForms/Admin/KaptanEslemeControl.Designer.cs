using DevExpress.XtraEditors;

namespace StajWinForms.Admin
{
    partial class KaptanEslemeControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblOtobus = new LabelControl();
            cmbOtobus = new System.Windows.Forms.ComboBox();
            lblAtanmis = new LabelControl();
            lstAtanmisKaptanlar = new ListBoxControl();
            lblTum = new LabelControl();
            lstTumKaptanlar = new ListBoxControl();
            btnAta = new SimpleButton();
            btnKaldir = new SimpleButton();
            flpButonlar = new FlowLayoutPanel();
            pnlOtobus = new Panel();
            tblMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)lstAtanmisKaptanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lstTumKaptanlar).BeginInit();
            flpButonlar.SuspendLayout();
            pnlOtobus.SuspendLayout();
            tblMain.SuspendLayout();
            SuspendLayout();
            //
            // pnlOtobus
            //
            pnlOtobus.Controls.Add(cmbOtobus);
            pnlOtobus.Controls.Add(lblOtobus);
            pnlOtobus.Dock = DockStyle.Top;
            pnlOtobus.Height = 40;
            pnlOtobus.Name = "pnlOtobus";
            pnlOtobus.Padding = new Padding(8, 8, 8, 0);
            //
            // lblOtobus
            //
            lblOtobus.Location = new Point(8, 12);
            lblOtobus.Name = "lblOtobus";
            lblOtobus.Size = new Size(39, 13);
            lblOtobus.TabIndex = 0;
            lblOtobus.Text = "Otobüs:";
            //
            // cmbOtobus
            //
            cmbOtobus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtobus.Location = new Point(60, 9);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.Size = new Size(300, 21);
            cmbOtobus.TabIndex = 1;
            cmbOtobus.SelectedIndexChanged += cmbOtobus_SelectedIndexChanged;
            //
            // tblMain
            //
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tblMain.Controls.Add(lblTum, 0, 0);
            tblMain.Controls.Add(lstTumKaptanlar, 0, 1);
            tblMain.Controls.Add(flpButonlar, 1, 1);
            tblMain.Controls.Add(lblAtanmis, 2, 0);
            tblMain.Controls.Add(lstAtanmisKaptanlar, 2, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(8);
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.TabIndex = 0;
            //
            // lblTum
            //
            lblTum.Dock = DockStyle.Fill;
            lblTum.Name = "lblTum";
            lblTum.TabIndex = 4;
            lblTum.Text = "Atanmamış Kaptanlar";
            //
            // lstTumKaptanlar
            //
            lstTumKaptanlar.Dock = DockStyle.Fill;
            lstTumKaptanlar.Name = "lstTumKaptanlar";
            lstTumKaptanlar.TabIndex = 5;
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
            // lblAtanmis
            //
            lblAtanmis.Dock = DockStyle.Fill;
            lblAtanmis.Name = "lblAtanmis";
            lblAtanmis.TabIndex = 2;
            lblAtanmis.Text = "Otobüse Atanmış Kaptanlar";
            //
            // lstAtanmisKaptanlar
            //
            lstAtanmisKaptanlar.Dock = DockStyle.Fill;
            lstAtanmisKaptanlar.Name = "lstAtanmisKaptanlar";
            lstAtanmisKaptanlar.TabIndex = 3;
            //
            // KaptanEslemeControl
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Controls.Add(pnlOtobus);
            Name = "KaptanEslemeControl";
            Load += KaptanEslemeControl_Load;
            ((System.ComponentModel.ISupportInitialize)lstAtanmisKaptanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstTumKaptanlar).EndInit();
            flpButonlar.ResumeLayout(false);
            pnlOtobus.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private LabelControl lblOtobus, lblAtanmis, lblTum;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private ListBoxControl lstAtanmisKaptanlar, lstTumKaptanlar;
        private SimpleButton btnAta, btnKaldir;
        private FlowLayoutPanel flpButonlar;
        private Panel pnlOtobus;
        private TableLayoutPanel tblMain;
    }
}
