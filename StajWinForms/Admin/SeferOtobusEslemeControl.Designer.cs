using DevExpress.XtraEditors;

namespace StajWinForms.Admin
{
    partial class SeferOtobusEslemeControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSefer = new LabelControl();
            cmbSefer = new System.Windows.Forms.ComboBox();
            lblMevcutBaslik = new LabelControl();
            lblMevcut = new LabelControl();
            lblOtobus = new LabelControl();
            cmbOtobus = new System.Windows.Forms.ComboBox();
            btnAta = new SimpleButton();
            btnKaldir = new SimpleButton();
            flpButonlar = new FlowLayoutPanel();
            tblMain = new TableLayoutPanel();
            flpButonlar.SuspendLayout();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblSefer
            // 
            lblSefer.Location = new Point(14, 23);
            lblSefer.Margin = new Padding(0, 9, 9, 9);
            lblSefer.Name = "lblSefer";
            lblSefer.Size = new Size(30, 13);
            lblSefer.TabIndex = 0;
            lblSefer.Text = "Sefer:";
            // 
            // cmbSefer
            // 
            cmbSefer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSefer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSefer.Location = new Point(100, 19);
            cmbSefer.Margin = new Padding(0, 5, 0, 9);
            cmbSefer.Name = "cmbSefer";
            cmbSefer.Size = new Size(669, 23);
            cmbSefer.TabIndex = 0;
            cmbSefer.SelectedIndexChanged += cmbSefer_SelectedIndexChanged;
            // 
            // lblMevcutBaslik
            // 
            lblMevcutBaslik.Location = new Point(14, 60);
            lblMevcutBaslik.Margin = new Padding(0, 9, 9, 9);
            lblMevcutBaslik.Name = "lblMevcutBaslik";
            lblMevcutBaslik.Size = new Size(77, 13);
            lblMevcutBaslik.TabIndex = 1;
            lblMevcutBaslik.Text = "Mevcut Otobüs:";
            // 
            // lblMevcut
            // 
            lblMevcut.Anchor = AnchorStyles.Left;
            lblMevcut.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            lblMevcut.Appearance.ForeColor = Color.Navy;
            lblMevcut.Appearance.Options.UseFont = true;
            lblMevcut.Appearance.Options.UseForeColor = true;
            lblMevcut.Location = new Point(100, 60);
            lblMevcut.Margin = new Padding(0, 9, 0, 9);
            lblMevcut.Name = "lblMevcut";
            lblMevcut.Size = new Size(5, 13);
            lblMevcut.TabIndex = 2;
            lblMevcut.Text = "-";
            // 
            // lblOtobus
            // 
            lblOtobus.Location = new Point(14, 91);
            lblOtobus.Margin = new Padding(0, 9, 9, 9);
            lblOtobus.Name = "lblOtobus";
            lblOtobus.Size = new Size(59, 13);
            lblOtobus.TabIndex = 3;
            lblOtobus.Text = "Otobüs Seç:";
            // 
            // cmbOtobus
            // 
            cmbOtobus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbOtobus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtobus.Location = new Point(100, 87);
            cmbOtobus.Margin = new Padding(0, 5, 0, 9);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.Size = new Size(669, 23);
            cmbOtobus.TabIndex = 1;
            // 
            // btnAta
            // 
            btnAta.Location = new Point(4, 3);
            btnAta.Margin = new Padding(4, 3, 4, 3);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(140, 40);
            btnAta.TabIndex = 2;
            btnAta.Text = "Ata";
            btnAta.Click += btnAta_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.Location = new Point(152, 3);
            btnKaldir.Margin = new Padding(4, 3, 4, 3);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(140, 40);
            btnKaldir.TabIndex = 3;
            btnKaldir.Text = "Kaldır";
            btnKaldir.Click += btnKaldir_Click;
            // 
            // flpButonlar
            // 
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMain.SetColumnSpan(flpButonlar, 2);
            flpButonlar.Controls.Add(btnAta);
            flpButonlar.Controls.Add(btnKaldir);
            flpButonlar.Location = new Point(14, 128);
            flpButonlar.Margin = new Padding(0, 9, 0, 0);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Size = new Size(296, 46);
            flpButonlar.TabIndex = 4;
            flpButonlar.WrapContents = false;
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblSefer, 0, 0);
            tblMain.Controls.Add(cmbSefer, 1, 0);
            tblMain.Controls.Add(lblMevcutBaslik, 0, 1);
            tblMain.Controls.Add(lblMevcut, 1, 1);
            tblMain.Controls.Add(lblOtobus, 0, 2);
            tblMain.Controls.Add(cmbOtobus, 1, 2);
            tblMain.Controls.Add(flpButonlar, 0, 3);
            tblMain.Dock = DockStyle.Top;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 3, 4, 3);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(14, 14, 14, 14);
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(783, 188);
            tblMain.TabIndex = 0;
            // 
            // SeferOtobusEslemeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SeferOtobusEslemeControl";
            Size = new Size(783, 486);
            Load += SeferOtobusEslemeControl_Load;
            flpButonlar.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private LabelControl lblSefer, lblMevcutBaslik, lblMevcut, lblOtobus;
        private System.Windows.Forms.ComboBox cmbSefer, cmbOtobus;
        private SimpleButton btnAta, btnKaldir;
        private FlowLayoutPanel flpButonlar;
        private TableLayoutPanel tblMain;
    }
}
