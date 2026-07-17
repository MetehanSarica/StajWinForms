using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class KaptanEslemeForm
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
            lblOtobus = new LabelControl();
            cmbOtobus = new System.Windows.Forms.ComboBox();
            lblAtanmis = new LabelControl();
            lstAtanmisKaptanlar = new ListBoxControl();
            lblTum = new LabelControl();
            lstTumKaptanlar = new ListBoxControl();
            btnAta = new SimpleButton();
            btnKaldir = new SimpleButton();

            ((System.ComponentModel.ISupportInitialize)lstAtanmisKaptanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lstTumKaptanlar).BeginInit();
            SuspendLayout();

            lblOtobus.Location = new System.Drawing.Point(12, 15); lblOtobus.Text = "Otobüs:";
            cmbOtobus.Location = new System.Drawing.Point(65, 12); cmbOtobus.Size = new System.Drawing.Size(300, 22);
            cmbOtobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbOtobus.SelectedIndexChanged += cmbOtobus_SelectedIndexChanged;

            lblAtanmis.Location = new System.Drawing.Point(12, 50); lblAtanmis.Text = "Atanmış Kaptanlar";
            lstAtanmisKaptanlar.Location = new System.Drawing.Point(12, 70); lstAtanmisKaptanlar.Size = new System.Drawing.Size(200, 280);

            lblTum.Location = new System.Drawing.Point(340, 50); lblTum.Text = "Tüm Kaptanlar";
            lstTumKaptanlar.Location = new System.Drawing.Point(340, 70); lstTumKaptanlar.Size = new System.Drawing.Size(200, 280);

            btnKaldir.Location = new System.Drawing.Point(225, 150); btnKaldir.Size = new System.Drawing.Size(100, 35);
            btnKaldir.Text = "◄ Kaldır"; btnKaldir.Click += btnKaldir_Click;

            btnAta.Location = new System.Drawing.Point(225, 190); btnAta.Size = new System.Drawing.Size(100, 35);
            btnAta.Text = "Ata ►"; btnAta.Click += btnAta_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 380);
            Controls.Add(lblOtobus); Controls.Add(cmbOtobus);
            Controls.Add(lblAtanmis); Controls.Add(lstAtanmisKaptanlar);
            Controls.Add(lblTum); Controls.Add(lstTumKaptanlar);
            Controls.Add(btnKaldir); Controls.Add(btnAta);
            Name = "KaptanEslemeForm"; StartPosition = FormStartPosition.CenterParent;
            Text = "Otobüs – Kaptan Eşleme";
            Load += KaptanEslemeForm_Load;

            ((System.ComponentModel.ISupportInitialize)lstAtanmisKaptanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstTumKaptanlar).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        #endregion

        private LabelControl lblOtobus, lblAtanmis, lblTum;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private ListBoxControl lstAtanmisKaptanlar, lstTumKaptanlar;
        private SimpleButton btnAta, btnKaldir;
    }
}
