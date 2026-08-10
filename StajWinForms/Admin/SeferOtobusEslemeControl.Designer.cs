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
            // tblMain
            //
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblSefer, 0, 0);
            tblMain.Controls.Add(cmbSefer, 1, 0);
            tblMain.Controls.Add(lblMevcutBaslik, 0, 1);
            tblMain.Controls.Add(lblMevcut, 1, 1);
            tblMain.Controls.Add(lblOtobus, 0, 2);
            tblMain.Controls.Add(cmbOtobus, 1, 2);
            tblMain.Controls.Add(flpButonlar, 0, 3);
            tblMain.SetColumnSpan(flpButonlar, 2);
            tblMain.Dock = DockStyle.Top;
            tblMain.AutoSize = true;
            tblMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(12);
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblMain.TabIndex = 0;
            //
            // lblSefer
            //
            lblSefer.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lblSefer.Margin = new Padding(0, 8, 8, 8);
            lblSefer.Name = "lblSefer";
            lblSefer.Text = "Sefer:";
            //
            // cmbSefer
            //
            cmbSefer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbSefer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSefer.Margin = new Padding(0, 4, 0, 8);
            cmbSefer.Name = "cmbSefer";
            cmbSefer.TabIndex = 0;
            cmbSefer.SelectedIndexChanged += cmbSefer_SelectedIndexChanged;
            //
            // lblMevcutBaslik
            //
            lblMevcutBaslik.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lblMevcutBaslik.Margin = new Padding(0, 8, 8, 8);
            lblMevcutBaslik.Name = "lblMevcutBaslik";
            lblMevcutBaslik.Text = "Mevcut Otobüs:";
            //
            // lblMevcut
            //
            lblMevcut.Anchor = AnchorStyles.Left;
            lblMevcut.Margin = new Padding(0, 8, 0, 8);
            lblMevcut.Name = "lblMevcut";
            lblMevcut.Text = "-";
            lblMevcut.Appearance.ForeColor = System.Drawing.Color.Navy;
            lblMevcut.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            //
            // lblOtobus
            //
            lblOtobus.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lblOtobus.Margin = new Padding(0, 8, 8, 8);
            lblOtobus.Name = "lblOtobus";
            lblOtobus.Text = "Otobüs Seç:";
            //
            // cmbOtobus
            //
            cmbOtobus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbOtobus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtobus.Margin = new Padding(0, 4, 0, 8);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.TabIndex = 1;
            //
            // btnAta
            //
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(120, 35);
            btnAta.TabIndex = 2;
            btnAta.Text = "Ata";
            btnAta.Click += btnAta_Click;
            //
            // btnKaldir
            //
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(120, 35);
            btnKaldir.TabIndex = 3;
            btnKaldir.Text = "Kaldır";
            btnKaldir.Click += btnKaldir_Click;
            //
            // flpButonlar
            //
            flpButonlar.AutoSize = true;
            flpButonlar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpButonlar.Controls.Add(btnAta);
            flpButonlar.Controls.Add(btnKaldir);
            flpButonlar.FlowDirection = FlowDirection.LeftToRight;
            flpButonlar.Margin = new Padding(0, 8, 0, 0);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.WrapContents = false;
            flpButonlar.TabIndex = 4;
            //
            // SeferOtobusEslemeControl
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Name = "SeferOtobusEslemeControl";
            Load += SeferOtobusEslemeControl_Load;
            flpButonlar.ResumeLayout(false);
            tblMain.ResumeLayout(false);
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
