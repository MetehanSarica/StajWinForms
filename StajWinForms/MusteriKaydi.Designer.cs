namespace StajWinForms
{
    partial class MusteriKaydi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnKaydet = new Button();
            lblTC = new Label();
            lblAdres = new Label();
            lblSehir = new Label();
            lblTelefon = new Label();
            lblEmail = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            txtboxTC = new TextBox();
            txtboxAdres = new TextBox();
            txtboxSehir = new TextBox();
            txtboxTelefon = new TextBox();
            txtboxEmail = new TextBox();
            txtboxSoyad = new TextBox();
            txtboxAd = new TextBox();
            panel1.SuspendLayout();
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
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Location = new Point(34, 40);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(24, 15);
            lblTC.TabIndex = 14;
            lblTC.Text = "TC:";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(215, 103);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(40, 15);
            lblAdres.TabIndex = 13;
            lblAdres.Text = "Adres:";
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Location = new Point(215, 40);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(36, 15);
            lblSehir.TabIndex = 12;
            lblSehir.Text = "Sehir:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(34, 295);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(49, 15);
            lblTelefon.TabIndex = 11;
            lblTelefon.Text = "Telefon:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(34, 232);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(34, 167);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(42, 15);
            lblSoyad.TabIndex = 9;
            lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(34, 103);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 8;
            lblAd.Text = "Ad:";
            // 
            // txtboxTC
            // 
            txtboxTC.Location = new Point(34, 58);
            txtboxTC.Name = "txtboxTC";
            txtboxTC.Size = new Size(141, 23);
            txtboxTC.TabIndex = 7;
            txtboxTC.TextChanged += txtboxTC_TextChanged;
            // 
            // txtboxAdres
            // 
            txtboxAdres.Location = new Point(215, 121);
            txtboxAdres.Name = "txtboxAdres";
            txtboxAdres.Size = new Size(141, 23);
            txtboxAdres.TabIndex = 5;
            // 
            // txtboxSehir
            // 
            txtboxSehir.Location = new Point(215, 58);
            txtboxSehir.Name = "txtboxSehir";
            txtboxSehir.Size = new Size(141, 23);
            txtboxSehir.TabIndex = 4;
            // 
            // txtboxTelefon
            // 
            txtboxTelefon.Location = new Point(34, 313);
            txtboxTelefon.Name = "txtboxTelefon";
            txtboxTelefon.Size = new Size(141, 23);
            txtboxTelefon.TabIndex = 3;
            txtboxTelefon.TextChanged += txtboxTelefon_TextChanged;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(34, 250);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(141, 23);
            txtboxEmail.TabIndex = 2;
            // 
            // txtboxSoyad
            // 
            txtboxSoyad.Location = new Point(34, 185);
            txtboxSoyad.Name = "txtboxSoyad";
            txtboxSoyad.Size = new Size(141, 23);
            txtboxSoyad.TabIndex = 1;
            // 
            // txtboxAd
            // 
            txtboxAd.Location = new Point(34, 121);
            txtboxAd.Name = "txtboxAd";
            txtboxAd.Size = new Size(141, 23);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtboxTC;
        private TextBox txtboxAdres;
        private TextBox txtboxSehir;
        private TextBox txtboxTelefon;
        private TextBox txtboxEmail;
        private TextBox txtboxSoyad;
        private TextBox txtboxAd;
        private Label lblTC;
        private Label lblAdres;
        private Label lblSehir;
        private Label lblTelefon;
        private Label lblEmail;
        private Label lblSoyad;
        private Label lblAd;
        private Button btnKaydet;
    }
}