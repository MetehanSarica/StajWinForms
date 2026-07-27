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
            // 
            // lblPlaka
            // 
            lblPlaka.Location = new Point(20, 23);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(29, 13);
            lblPlaka.TabIndex = 0;
            lblPlaka.Text = "Plaka:";
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(130, 20);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(220, 20);
            txtPlaka.TabIndex = 1;
            txtPlaka.Properties.MaxLength = 9;
            txtPlaka.KeyPress += txtPlaka_KeyPress;
            // 
            // lblMarka
            // 
            lblMarka.Location = new Point(20, 55);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(33, 13);
            lblMarka.TabIndex = 2;
            lblMarka.Text = "Marka:";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(130, 52);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(220, 20);
            txtMarka.TabIndex = 3;
            // 
            // lblModel
            // 
            lblModel.Location = new Point(20, 87);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(32, 13);
            lblModel.TabIndex = 4;
            lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(130, 84);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(220, 20);
            txtModel.TabIndex = 5;
            // 
            // lblKoltuk
            // 
            lblKoltuk.Location = new Point(20, 119);
            lblKoltuk.Name = "lblKoltuk";
            lblKoltuk.Size = new Size(63, 13);
            lblKoltuk.TabIndex = 6;
            lblKoltuk.Text = "Koltuk Sayısı:";
            // 
            // spnKoltuk
            // 
            spnKoltuk.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spnKoltuk.Location = new Point(130, 116);
            spnKoltuk.Name = "spnKoltuk";
            spnKoltuk.Properties.Appearance.Options.UseTextOptions = true;
            spnKoltuk.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            spnKoltuk.Properties.MaskSettings.Set("mask", "d");
            spnKoltuk.Properties.MaxValue = new decimal(new int[] { 100, 0, 0, 0 });
            spnKoltuk.Properties.MinValue = new decimal(new int[] { 1, 0, 0, 0 });
            spnKoltuk.RightToLeft = RightToLeft.No;
            spnKoltuk.Size = new Size(220, 20);
            spnKoltuk.TabIndex = 7;
            // 
            // lblFirma
            // 
            lblFirma.Location = new Point(20, 151);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(30, 13);
            lblFirma.TabIndex = 8;
            lblFirma.Text = "Firma:";
            // 
            // cmbFirma
            // 
            cmbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFirma.Location = new Point(130, 148);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(220, 21);
            cmbFirma.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(130, 190);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 35);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(240, 190);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 35);
            btnIptal.TabIndex = 11;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            // 
            // OtobusEditForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 245);
            Controls.Add(lblPlaka);
            Controls.Add(txtPlaka);
            Controls.Add(lblMarka);
            Controls.Add(txtMarka);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblKoltuk);
            Controls.Add(spnKoltuk);
            Controls.Add(lblFirma);
            Controls.Add(cmbFirma);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OtobusEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Shown += OtobusEditForm_Shown;
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
