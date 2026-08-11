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
            // lblOtobus
            // 
            lblOtobus.Location = new Point(9, 14);
            lblOtobus.Margin = new Padding(4, 3, 4, 3);
            lblOtobus.Name = "lblOtobus";
            lblOtobus.Size = new Size(39, 13);
            lblOtobus.TabIndex = 0;
            lblOtobus.Text = "Otobüs:";
            // 
            // cmbOtobus
            // 
            cmbOtobus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtobus.Location = new Point(70, 10);
            cmbOtobus.Margin = new Padding(4, 3, 4, 3);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.Size = new Size(349, 23);
            cmbOtobus.TabIndex = 1;
            cmbOtobus.SelectedIndexChanged += cmbOtobus_SelectedIndexChanged;
            // 
            // lblAtanmis
            // 
            lblAtanmis.Dock = DockStyle.Fill;
            lblAtanmis.Location = new Point(395, 12);
            lblAtanmis.Margin = new Padding(4, 3, 4, 3);
            lblAtanmis.Name = "lblAtanmis";
            lblAtanmis.Size = new Size(276, 13);
            lblAtanmis.TabIndex = 2;
            lblAtanmis.Text = "Otobüse Atanmış Kaptanlar";
            // 
            // lstAtanmisKaptanlar
            // 
            lstAtanmisKaptanlar.Dock = DockStyle.Fill;
            lstAtanmisKaptanlar.Location = new Point(395, 31);
            lstAtanmisKaptanlar.Margin = new Padding(4, 3, 4, 3);
            lstAtanmisKaptanlar.Name = "lstAtanmisKaptanlar";
            lstAtanmisKaptanlar.Size = new Size(276, 432);
            lstAtanmisKaptanlar.TabIndex = 3;
            // 
            // lblTum
            // 
            lblTum.Dock = DockStyle.Fill;
            lblTum.Location = new Point(13, 12);
            lblTum.Margin = new Padding(4, 3, 4, 3);
            lblTum.Name = "lblTum";
            lblTum.Size = new Size(223, 13);
            lblTum.TabIndex = 4;
            lblTum.Text = "Atanmamış Kaptanlar";
            // 
            // lstTumKaptanlar
            // 
            lstTumKaptanlar.Dock = DockStyle.Fill;
            lstTumKaptanlar.Location = new Point(13, 31);
            lstTumKaptanlar.Margin = new Padding(4, 3, 4, 3);
            lstTumKaptanlar.Name = "lstTumKaptanlar";
            lstTumKaptanlar.Size = new Size(223, 432);
            lstTumKaptanlar.TabIndex = 5;
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
            flpButonlar.Location = new Point(244, 31);
            flpButonlar.Margin = new Padding(4, 3, 4, 3);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Padding = new Padding(9, 69, 9, 0);
            flpButonlar.Size = new Size(143, 432);
            flpButonlar.TabIndex = 8;
            flpButonlar.WrapContents = false;
            // 
            // pnlOtobus
            // 
            pnlOtobus.Controls.Add(cmbOtobus);
            pnlOtobus.Controls.Add(lblOtobus);
            pnlOtobus.Dock = DockStyle.Top;
            pnlOtobus.Location = new Point(0, 0);
            pnlOtobus.Margin = new Padding(4, 3, 4, 3);
            pnlOtobus.Name = "pnlOtobus";
            pnlOtobus.Padding = new Padding(9, 9, 9, 0);
            pnlOtobus.Size = new Size(684, 46);
            pnlOtobus.TabIndex = 1;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tblMain.Controls.Add(lblTum, 0, 0);
            tblMain.Controls.Add(lstTumKaptanlar, 0, 1);
            tblMain.Controls.Add(flpButonlar, 1, 1);
            tblMain.Controls.Add(lblAtanmis, 2, 0);
            tblMain.Controls.Add(lstAtanmisKaptanlar, 2, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 46);
            tblMain.Margin = new Padding(4, 3, 4, 3);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(9, 9, 9, 9);
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(684, 475);
            tblMain.TabIndex = 0;
            // 
            // KaptanEslemeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Controls.Add(pnlOtobus);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KaptanEslemeControl";
            Size = new Size(684, 521);
            Load += KaptanEslemeControl_Load;
            ((System.ComponentModel.ISupportInitialize)lstAtanmisKaptanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstTumKaptanlar).EndInit();
            flpButonlar.ResumeLayout(false);
            pnlOtobus.ResumeLayout(false);
            pnlOtobus.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
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
