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

            ((System.ComponentModel.ISupportInitialize)lstFirmaOtobusler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lstDigerOtobusler).BeginInit();
            SuspendLayout();

            lblFirma.Location = new System.Drawing.Point(12, 15); lblFirma.Text = "Firma:";
            cmbFirma.Location = new System.Drawing.Point(60, 12); cmbFirma.Size = new System.Drawing.Size(300, 22);
            cmbFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFirma.SelectedIndexChanged += cmbFirma_SelectedIndexChanged;

            lblFirmaOtobusler.Location = new System.Drawing.Point(12, 50); lblFirmaOtobusler.Text = "Firmaya Atanmış Otobüsler";
            lstFirmaOtobusler.Location = new System.Drawing.Point(12, 70); lstFirmaOtobusler.Size = new System.Drawing.Size(200, 300);

            lblDigerOtobusler.Location = new System.Drawing.Point(340, 50); lblDigerOtobusler.Text = "Atanmamış Otobüsler";
            lstDigerOtobusler.Location = new System.Drawing.Point(340, 70); lstDigerOtobusler.Size = new System.Drawing.Size(200, 300);

            btnKaldir.Location = new System.Drawing.Point(225, 160); btnKaldir.Size = new System.Drawing.Size(100, 35);
            btnKaldir.Text = "◄ Kaldır"; btnKaldir.Click += btnKaldir_Click;

            btnAta.Location = new System.Drawing.Point(225, 200); btnAta.Size = new System.Drawing.Size(100, 35);
            btnAta.Text = "Ata ►"; btnAta.Click += btnAta_Click;

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(560, 400);
            Controls.Add(lblFirma); Controls.Add(cmbFirma);
            Controls.Add(lblFirmaOtobusler); Controls.Add(lstFirmaOtobusler);
            Controls.Add(lblDigerOtobusler); Controls.Add(lstDigerOtobusler);
            Controls.Add(btnKaldir); Controls.Add(btnAta);
            Name = "FirmaOtobusEslemeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Firma – Otobüs Eşleme";
            Load += FirmaOtobusEslemeForm_Load;

            ((System.ComponentModel.ISupportInitialize)lstFirmaOtobusler).EndInit();
            ((System.ComponentModel.ISupportInitialize)lstDigerOtobusler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblFirma, lblFirmaOtobusler, lblDigerOtobusler;
        private System.Windows.Forms.ComboBox cmbFirma;
        private ListBoxControl lstFirmaOtobusler, lstDigerOtobusler;
        private SimpleButton btnAta, btnKaldir;
    }
}
