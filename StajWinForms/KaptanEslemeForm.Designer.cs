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
            // 
            // lblOtobus
            // 
            lblOtobus.Location = new Point(12, 15);
            lblOtobus.Name = "lblOtobus";
            lblOtobus.Size = new Size(39, 13);
            lblOtobus.TabIndex = 0;
            lblOtobus.Text = "Otobüs:";
            // 
            // cmbOtobus
            // 
            cmbOtobus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOtobus.Location = new Point(65, 12);
            cmbOtobus.Name = "cmbOtobus";
            cmbOtobus.Size = new Size(300, 21);
            cmbOtobus.TabIndex = 1;
            cmbOtobus.SelectedIndexChanged += cmbOtobus_SelectedIndexChanged;
            // 
            // lblAtanmis
            // 
            lblAtanmis.Location = new Point(12, 50);
            lblAtanmis.Name = "lblAtanmis";
            lblAtanmis.Size = new Size(87, 13);
            lblAtanmis.TabIndex = 2;
            lblAtanmis.Text = "Atanmış Kaptanlar";
            // 
            // lstAtanmisKaptanlar
            // 
            lstAtanmisKaptanlar.Location = new Point(12, 70);
            lstAtanmisKaptanlar.Name = "lstAtanmisKaptanlar";
            lstAtanmisKaptanlar.Size = new Size(200, 280);
            lstAtanmisKaptanlar.TabIndex = 3;
            // 
            // lblTum
            // 
            lblTum.Location = new Point(340, 50);
            lblTum.Name = "lblTum";
            lblTum.Size = new Size(69, 13);
            lblTum.TabIndex = 4;
            lblTum.Text = "Tüm Kaptanlar";
            // 
            // lstTumKaptanlar
            // 
            lstTumKaptanlar.Location = new Point(340, 70);
            lstTumKaptanlar.Name = "lstTumKaptanlar";
            lstTumKaptanlar.Size = new Size(200, 280);
            lstTumKaptanlar.TabIndex = 5;
            // 
            // btnAta
            // 
            btnAta.Location = new Point(225, 190);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(100, 35);
            btnAta.TabIndex = 7;
            btnAta.Text = "◄ Ata ";
            btnAta.Click += btnAta_Click;
            // 
            // btnKaldir
            // 
            btnKaldir.Location = new Point(225, 150);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(100, 35);
            btnKaldir.TabIndex = 6;
            btnKaldir.Text = "Kaldır ►";
            btnKaldir.Click += btnKaldir_Click;
            // 
            // KaptanEslemeForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 380);
            Controls.Add(lblOtobus);
            Controls.Add(cmbOtobus);
            Controls.Add(lblAtanmis);
            Controls.Add(lstAtanmisKaptanlar);
            Controls.Add(lblTum);
            Controls.Add(lstTumKaptanlar);
            Controls.Add(btnKaldir);
            Controls.Add(btnAta);
            MaximizeBox = false;
            Name = "KaptanEslemeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Otobüs – Kaptan Eşleme";
            Load += KaptanEslemeForm_Load;
            ((System.ComponentModel.ISupportInitialize)lstAtanmisKaptanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstTumKaptanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblOtobus, lblAtanmis, lblTum;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private ListBoxControl lstAtanmisKaptanlar, lstTumKaptanlar;
        private SimpleButton btnAta, btnKaldir;
    }
}
