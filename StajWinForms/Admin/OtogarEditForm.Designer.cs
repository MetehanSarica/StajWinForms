using DevExpress.XtraEditors;

namespace StajWinForms.Admin
{
    partial class OtogarEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSehir = new LabelControl();
            cboSehir = new ComboBoxEdit();
            lblAd = new LabelControl();
            txtAd = new TextEdit();
            lblAdres = new LabelControl();
            txtAdres = new TextEdit();
            lblTelefon = new LabelControl();
            txtTelefon = new TextEdit();
            btnKaydet = new SimpleButton();
            btnIptal = new SimpleButton();
            ((System.ComponentModel.ISupportInitialize)cboSehir.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdres.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).BeginInit();
            SuspendLayout();
            //
            // lblSehir
            //
            lblSehir.Location = new Point(16, 20);
            lblSehir.Name = "lblSehir";
            lblSehir.Text = "Şehir:";
            //
            // cboSehir
            //
            cboSehir.Location = new Point(110, 16);
            cboSehir.Name = "cboSehir";
            cboSehir.Size = new Size(220, 20);
            cboSehir.TabIndex = 0;
            //
            // lblAd
            //
            lblAd.Location = new Point(16, 55);
            lblAd.Name = "lblAd";
            lblAd.Text = "Otogar Adı:";
            //
            // txtAd
            //
            txtAd.Location = new Point(110, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(220, 20);
            txtAd.TabIndex = 1;
            //
            // lblAdres
            //
            lblAdres.Location = new Point(16, 90);
            lblAdres.Name = "lblAdres";
            lblAdres.Text = "Adres:";
            //
            // txtAdres
            //
            txtAdres.Location = new Point(110, 86);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(220, 20);
            txtAdres.TabIndex = 2;
            //
            // lblTelefon
            //
            lblTelefon.Location = new Point(16, 125);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Text = "Telefon:";
            //
            // txtTelefon
            //
            txtTelefon.Location = new Point(110, 121);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(220, 20);
            txtTelefon.TabIndex = 3;
            //
            // btnKaydet
            //
            btnKaydet.Location = new Point(110, 160);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 30);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            //
            // btnIptal
            //
            btnIptal.Location = new Point(230, 160);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 30);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "İptal";
            btnIptal.Click += btnIptal_Click;
            //
            // OtogarEditForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 210);
            Controls.Add(lblSehir);
            Controls.Add(cboSehir);
            Controls.Add(lblAd);
            Controls.Add(txtAd);
            Controls.Add(lblAdres);
            Controls.Add(txtAdres);
            Controls.Add(lblTelefon);
            Controls.Add(txtTelefon);
            Controls.Add(btnKaydet);
            Controls.Add(btnIptal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OtogarEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Otogar";
            Load += OtogarEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)cboSehir.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdres.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal LabelControl lblSehir;
        internal ComboBoxEdit cboSehir;
        internal LabelControl lblAd;
        internal TextEdit txtAd;
        internal LabelControl lblAdres;
        internal TextEdit txtAdres;
        internal LabelControl lblTelefon;
        internal TextEdit txtTelefon;
        internal SimpleButton btnKaydet;
        internal SimpleButton btnIptal;
    }
}
