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
            flpButonlar = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)lstAtanmisKaptanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lstTumKaptanlar).BeginInit();
            flpButonlar.SuspendLayout();
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
            lblAtanmis.Location = new Point(340, 50);
            lblAtanmis.Name = "lblAtanmis";
            lblAtanmis.Size = new Size(129, 13);
            lblAtanmis.TabIndex = 2;
            lblAtanmis.Text = "Otobüse Atanmış Kaptanlar";
            //
            // lstAtanmisKaptanlar
            //
            lstAtanmisKaptanlar.Location = new Point(340, 70);
            lstAtanmisKaptanlar.Name = "lstAtanmisKaptanlar";
            lstAtanmisKaptanlar.Size = new Size(200, 300);
            lstAtanmisKaptanlar.TabIndex = 3;
            //
            // lblTum
            //
            lblTum.Location = new Point(12, 50);
            lblTum.Name = "lblTum";
            lblTum.Size = new Size(102, 13);
            lblTum.TabIndex = 4;
            lblTum.Text = "Atanmamış Kaptanlar";
            //
            // lstTumKaptanlar
            //
            lstTumKaptanlar.Location = new Point(12, 70);
            lstTumKaptanlar.Name = "lstTumKaptanlar";
            lstTumKaptanlar.Size = new Size(200, 300);
            lstTumKaptanlar.TabIndex = 5;
            //
            // btnAta
            //
            btnAta.Location = new Point(3, 3);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(100, 35);
            btnAta.TabIndex = 6;
            btnAta.Text = "Ata ►";
            btnAta.Click += btnAta_Click;
            //
            // btnKaldir
            //
            btnKaldir.Location = new Point(3, 44);
            btnKaldir.Name = "btnKaldir";
            btnKaldir.Size = new Size(100, 35);
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
            flpButonlar.FlowDirection = FlowDirection.TopDown;
            flpButonlar.Location = new Point(225, 160);
            flpButonlar.Name = "flpButonlar";
            flpButonlar.Size = new Size(106, 82);
            flpButonlar.TabIndex = 8;
            flpButonlar.WrapContents = false;
            //
            // KaptanEslemeForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 400);
            Controls.Add(lblOtobus);
            Controls.Add(cmbOtobus);
            Controls.Add(lblTum);
            Controls.Add(lstTumKaptanlar);
            Controls.Add(flpButonlar);
            Controls.Add(lblAtanmis);
            Controls.Add(lstAtanmisKaptanlar);
            MaximizeBox = false;
            Name = "KaptanEslemeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Otobüs – Kaptan Eşleme";
            Load += KaptanEslemeForm_Load;
            ((System.ComponentModel.ISupportInitialize)lstAtanmisKaptanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstTumKaptanlar).EndInit();
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblOtobus, lblAtanmis, lblTum;
        private System.Windows.Forms.ComboBox cmbOtobus;
        private ListBoxControl lstAtanmisKaptanlar, lstTumKaptanlar;
        private SimpleButton btnAta, btnKaldir;
        private FlowLayoutPanel flpButonlar;
    }
}
