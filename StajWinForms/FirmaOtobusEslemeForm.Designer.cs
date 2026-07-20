using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class FirmaOtobusEslemeForm
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
            lblFirma = new LabelControl();
            cmbFirma = new System.Windows.Forms.ComboBox();
            lblFirmaOtobusler = new LabelControl();
            lstFirmaOtobusler = new ListBoxControl();
            lblDigerOtobusler = new LabelControl();
            lstDigerOtobusler = new ListBoxControl();
            btnAta = new SimpleButton();
            btnKaldir = new SimpleButton();
            flpButonlar = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)lstFirmaOtobusler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lstDigerOtobusler).BeginInit();
            flpButonlar.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirma
            // 
            lblFirma.Location = new Point(12, 15);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(30, 13);
            lblFirma.TabIndex = 0;
            lblFirma.Text = "Firma:";
            // 
            // cmbFirma
            // 
            cmbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFirma.Location = new Point(60, 12);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(300, 21);
            cmbFirma.TabIndex = 1;
            cmbFirma.SelectedIndexChanged += cmbFirma_SelectedIndexChanged;
            // 
            // lblFirmaOtobusler
            // 
            lblFirmaOtobusler.Location = new Point(340, 50);
            lblFirmaOtobusler.Name = "lblFirmaOtobusler";
            lblFirmaOtobusler.Size = new Size(129, 13);
            lblFirmaOtobusler.TabIndex = 2;
            lblFirmaOtobusler.Text = "Firmaya Atanmış Otobüsler";
            // 
            // lstFirmaOtobusler
            // 
            lstFirmaOtobusler.Location = new Point(340, 70);
            lstFirmaOtobusler.Name = "lstFirmaOtobusler";
            lstFirmaOtobusler.Size = new Size(200, 300);
            lstFirmaOtobusler.TabIndex = 3;
            // 
            // lblDigerOtobusler
            // 
            lblDigerOtobusler.Location = new Point(12, 50);
            lblDigerOtobusler.Name = "lblDigerOtobusler";
            lblDigerOtobusler.Size = new Size(102, 13);
            lblDigerOtobusler.TabIndex = 4;
            lblDigerOtobusler.Text = "Atanmamış Otobüsler";
            // 
            // lstDigerOtobusler
            // 
            lstDigerOtobusler.Location = new Point(12, 70);
            lstDigerOtobusler.Name = "lstDigerOtobusler";
            lstDigerOtobusler.Size = new Size(200, 300);
            lstDigerOtobusler.TabIndex = 5;
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
            // FirmaOtobusEslemeForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 400);
            Controls.Add(lblFirma);
            Controls.Add(cmbFirma);
            Controls.Add(lblDigerOtobusler);
            Controls.Add(lstDigerOtobusler);
            Controls.Add(flpButonlar);
            Controls.Add(lblFirmaOtobusler);
            Controls.Add(lstFirmaOtobusler);
            MaximizeBox = false;
            Name = "FirmaOtobusEslemeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Firma – Otobüs Eşleme";
            Load += FirmaOtobusEslemeForm_Load;
            ((System.ComponentModel.ISupportInitialize)lstFirmaOtobusler).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstDigerOtobusler).EndInit();
            flpButonlar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblFirma, lblFirmaOtobusler, lblDigerOtobusler;
        private System.Windows.Forms.ComboBox cmbFirma;
        private ListBoxControl lstFirmaOtobusler, lstDigerOtobusler;
        private SimpleButton btnKaldir, btnAta;
        private FlowLayoutPanel flpButonlar;
    }
}
