using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class OtobusEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPlaka = new LabelControl();
            txtPlaka = new TextEdit();
            lblMarka = new LabelControl();
            txtMarka = new TextEdit();
            lblModel = new LabelControl();
            txtModel = new TextEdit();
            lblKoltuk = new LabelControl();
            spnKoltuk = new SpinEdit();
            lblFirma = new LabelControl();
            cmbFirma = new System.Windows.Forms.ComboBox();
            btnKaydet = new SimpleButton();
            btnIptal = new SimpleButton();

            ((System.ComponentModel.ISupportInitialize)txtPlaka.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMarka.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtModel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnKoltuk.Properties).BeginInit();
            SuspendLayout();

            int lx = 20, tx = 130, tw = 220, th = 20, gap = 12, y = 20;

            lblPlaka.Location = new System.Drawing.Point(lx, y + 3); lblPlaka.Text = "Plaka:";
            txtPlaka.Location = new System.Drawing.Point(tx, y); txtPlaka.Size = new System.Drawing.Size(tw, th); y += th + gap;

            lblMarka.Location = new System.Drawing.Point(lx, y + 3); lblMarka.Text = "Marka:";
            txtMarka.Location = new System.Drawing.Point(tx, y); txtMarka.Size = new System.Drawing.Size(tw, th); y += th + gap;

            lblModel.Location = new System.Drawing.Point(lx, y + 3); lblModel.Text = "Model:";
            txtModel.Location = new System.Drawing.Point(tx, y); txtModel.Size = new System.Drawing.Size(tw, th); y += th + gap;

            lblKoltuk.Location = new System.Drawing.Point(lx, y + 3); lblKoltuk.Text = "Koltuk Sayısı:";
            spnKoltuk.Location = new System.Drawing.Point(tx, y); spnKoltuk.Size = new System.Drawing.Size(tw, th);
            spnKoltuk.Properties.MinValue = 1; spnKoltuk.Properties.MaxValue = 100;
            y += th + gap;

            lblFirma.Location = new System.Drawing.Point(lx, y + 3); lblFirma.Text = "Firma:";
            cmbFirma.Location = new System.Drawing.Point(tx, y); cmbFirma.Size = new System.Drawing.Size(tw, th);
            cmbFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            y += th + gap + 10;

            btnKaydet.Location = new System.Drawing.Point(tx, y); btnKaydet.Size = new System.Drawing.Size(100, 35);
            btnKaydet.Text = "Kaydet"; btnKaydet.Click += btnKaydet_Click;

            btnIptal.Location = new System.Drawing.Point(tx + 110, y); btnIptal.Size = new System.Drawing.Size(100, 35);
            btnIptal.Text = "İptal"; btnIptal.Click += btnIptal_Click;

            y += 35 + 20;

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, y);
            Controls.Add(lblPlaka); Controls.Add(txtPlaka);
            Controls.Add(lblMarka); Controls.Add(txtMarka);
            Controls.Add(lblModel); Controls.Add(txtModel);
            Controls.Add(lblKoltuk); Controls.Add(spnKoltuk);
            Controls.Add(lblFirma); Controls.Add(cmbFirma);
            Controls.Add(btnKaydet); Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false; MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Name = "OtobusEditForm";

            ((System.ComponentModel.ISupportInitialize)txtPlaka.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMarka.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtModel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnKoltuk.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblPlaka, lblMarka, lblModel, lblKoltuk, lblFirma;
        private TextEdit txtPlaka, txtMarka, txtModel;
        private SpinEdit spnKoltuk;
        private System.Windows.Forms.ComboBox cmbFirma;
        private SimpleButton btnKaydet, btnIptal;
    }
}
