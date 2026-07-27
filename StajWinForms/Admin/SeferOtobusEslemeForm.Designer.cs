using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class SeferOtobusEslemeForm
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
            lblSefer = new LabelControl();
            cmbSefer = new System.Windows.Forms.ComboBox();
            lblMevcutBaslik = new LabelControl();
            lblMevcut = new LabelControl();
            lblOtobus = new LabelControl();
            cmbOtobus = new System.Windows.Forms.ComboBox();
            btnAta = new SimpleButton();
            btnKaldir = new SimpleButton();
            flpButonlar = new FlowLayoutPanel();
            flpButonlar.SuspendLayout();
            SuspendLayout();

            lblSefer.Location = new Point(12, 18);
            lblSefer.Name = "lblSefer";
            lblSefer.Text = "Sefer:";

            cmbSefer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSefer.Location = new Point(75, 15);
            cmbSefer.Name = "cmbSefer";
            cmbSefer.Size = new Size(415, 21);
            cmbSefer.TabIndex = 0;
            cmbSefer.SelectedIndexChanged += cmbSefer_SelectedIndexChanged;

            lblMevcutBaslik.Location = new Point(12, 55);
            lblMevcutBaslik.Name = "lblMevcutBaslik";
            lblMevcutBaslik.Text = "Mevcut Otobüs:";

            lblMevcut.Location = new Point(120, 55);
            lblMevcut.Name = "lblMevcut";
            lblMevcut.Text = "-";
            lblMevcut.Appearance.ForeColor = System.Drawing.Color.Navy;
            lblMevcut.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);

            lblOtobus.Location = new Point(12, 95);
            lblOtobus.Name = "lblOtobus";
            lblOtobus.Text = "Otobüs Seç:";

            cmbOtobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbOtobus.Location = new Point(100, 92);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.Size = new Size(280, 21);
            cmbOtobus.TabIndex = 1;

            //
            // btnAta
            //
            btnAta.Location = new Point(3, 3);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(120, 35);
            btnAta.TabIndex = 2;
            btnAta.Text = "Ata";
            btnAta.Click += btnAta_Click;

            //
            // btnKaldir
            //
            btnKaldir.Location = new Point(129, 3);
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
            flpButonlar.Location = new Point(12, 135);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.WrapContents = false;
            flpButonlar.TabIndex = 4;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 195);
            Controls.Add(lblSefer);
            Controls.Add(cmbSefer);
            Controls.Add(lblMevcutBaslik);
            Controls.Add(lblMevcut);
            Controls.Add(lblOtobus);
            Controls.Add(cmbOtobus);
            Controls.Add(flpButonlar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SeferOtobusEslemeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sefer – Otobüs Eşleme";
            Load += SeferOtobusEslemeForm_Load;
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblSefer, lblMevcutBaslik, lblMevcut, lblOtobus;
        private System.Windows.Forms.ComboBox cmbSefer, cmbOtobus;
        private SimpleButton btnAta, btnKaldir;
        private FlowLayoutPanel flpButonlar;
    }
}
