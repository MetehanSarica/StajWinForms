using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class MusteriKaydi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new PanelControl();
            btnKaydet = new SimpleButton();
            lblTC = new LabelControl();
            lblAdres = new LabelControl();
            lblSehir = new LabelControl();
            lblTelefon = new LabelControl();
            lblEmail = new LabelControl();
            lblSoyad = new LabelControl();
            lblAd = new LabelControl();
            txtboxTC = new TextEdit();
            txtboxAdres = new TextEdit();
            txtboxSehir = new TextEdit();
            txtboxTelefon = new TextEdit();
            txtboxEmail = new TextEdit();
            txtboxSoyad = new TextEdit();
            txtboxAd = new TextEdit();
            ((System.ComponentModel.ISupportInitialize)panel1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtboxTC.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAdres.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSehir.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxTelefon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAd.Properties).BeginInit();
            SuspendLayout();
            //
            // panel1
            //
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(lblTC);
            panel1.Controls.Add(lblAdres);
            panel1.Controls.Add(lblSehir);
            panel1.Controls.Add(lblTelefon);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblSoyad);
            panel1.Controls.Add(lblAd);
            panel1.Controls.Add(txtboxTC);
            panel1.Controls.Add(txtboxAdres);
            panel1.Controls.Add(txtboxSehir);
            panel1.Controls.Add(txtboxTelefon);
            panel1.Controls.Add(txtboxEmail);
            panel1.Controls.Add(txtboxSoyad);
            panel1.Controls.Add(txtboxAd);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            //
            // btnKaydet
            //
            btnKaydet.Location = new Point(215, 176);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(141, 32);
            btnKaydet.TabIndex = 15;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            //
            // lblTC
            //
            lblTC.Location = new Point(34, 40);
            lblTC.Name = "lblTC";
            lblTC.TabIndex = 14;
            lblTC.Text = "TC:";
            //
            // lblAdres
            //
            lblAdres.Location = new Point(215, 103);
            lblAdres.Name = "lblAdres";
            lblAdres.TabIndex = 13;
            lblAdres.Text = "Adres:";
            //
            // lblSehir
            //
            lblSehir.Location = new Point(215, 40);
            lblSehir.Name = "lblSehir";
            lblSehir.TabIndex = 12;
            lblSehir.Text = "Sehir:";
            //
            // lblTelefon
            //
            lblTelefon.Location = new Point(34, 295);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.TabIndex = 11;
            lblTelefon.Text = "Telefon:";
            //
            // lblEmail
            //
            lblEmail.Location = new Point(34, 232);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            //
            // lblSoyad
            //
            lblSoyad.Location = new Point(34, 167);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.TabIndex = 9;
            lblSoyad.Text = "Soyad:";
            //
            // lblAd
            //
            lblAd.Location = new Point(34, 103);
            lblAd.Name = "lblAd";
            lblAd.TabIndex = 8;
            lblAd.Text = "Ad:";
            //
            // txtboxTC
            //
            txtboxTC.Location = new Point(34, 58);
            txtboxTC.Name = "txtboxTC";
            txtboxTC.Size = new Size(141, 20);
            txtboxTC.TabIndex = 7;
            txtboxTC.EditValueChanged += txtboxTC_TextChanged;
            //
            // txtboxAdres
            //
            txtboxAdres.Location = new Point(215, 121);
            txtboxAdres.Name = "txtboxAdres";
            txtboxAdres.Size = new Size(141, 20);
            txtboxAdres.TabIndex = 5;
            //
            // txtboxSehir
            //
            txtboxSehir.Location = new Point(215, 58);
            txtboxSehir.Name = "txtboxSehir";
            txtboxSehir.Size = new Size(141, 20);
            txtboxSehir.TabIndex = 4;
            //
            // txtboxTelefon
            //
            txtboxTelefon.Location = new Point(34, 313);
            txtboxTelefon.Name = "txtboxTelefon";
            txtboxTelefon.Size = new Size(141, 20);
            txtboxTelefon.TabIndex = 3;
            txtboxTelefon.EditValueChanged += txtboxTelefon_TextChanged;
            //
            // txtboxEmail
            //
            txtboxEmail.Location = new Point(34, 250);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(141, 20);
            txtboxEmail.TabIndex = 2;
            //
            // txtboxSoyad
            //
            txtboxSoyad.Location = new Point(34, 185);
            txtboxSoyad.Name = "txtboxSoyad";
            txtboxSoyad.Size = new Size(141, 20);
            txtboxSoyad.TabIndex = 1;
            //
            // txtboxAd
            //
            txtboxAd.Location = new Point(34, 121);
            txtboxAd.Name = "txtboxAd";
            txtboxAd.Size = new Size(141, 20);
            txtboxAd.TabIndex = 0;
            //
            // MusteriKaydi
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MusteriKaydi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MusteriKaydi";
            ((System.ComponentModel.ISupportInitialize)panel1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtboxTC.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAdres.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSehir.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxTelefon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtboxAd.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PanelControl panel1;
        private TextEdit txtboxTC;
        private TextEdit txtboxAdres;
        private TextEdit txtboxSehir;
        private TextEdit txtboxTelefon;
        private TextEdit txtboxEmail;
        private TextEdit txtboxSoyad;
        private TextEdit txtboxAd;
        private LabelControl lblTC;
        private LabelControl lblAdres;
        private LabelControl lblSehir;
        private LabelControl lblTelefon;
        private LabelControl lblEmail;
        private LabelControl lblSoyad;
        private LabelControl lblAd;
        private SimpleButton btnKaydet;
    }
}
