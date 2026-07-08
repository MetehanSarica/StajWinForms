using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class SeferDetay
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
            lblFirmaHeader = new LabelControl();
            txtFirmaValue = new TextBox();
            lblKalkisHeader = new LabelControl();
            txtKalkisValue = new TextBox();
            lblVarisHeader = new LabelControl();
            txtVarisValue = new TextBox();
            lblZamanHeader = new LabelControl();
            txtZamanValue = new TextBox();
            lblFiyatHeader = new LabelControl();
            txtFiyatValue = new TextBox();
            lblKoltukHeader = new LabelControl();
            txtKoltukValue = new TextBox();
            lblDuraklar = new LabelControl();
            txtDuraklar = new TextBox();
            SuspendLayout();
            // 
            // lblFirmaHeader
            // 
            lblFirmaHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirmaHeader.Appearance.Options.UseFont = true;
            lblFirmaHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblFirmaHeader.Location = new Point(17, 17);
            lblFirmaHeader.Name = "lblFirmaHeader";
            lblFirmaHeader.Size = new Size(103, 17);
            lblFirmaHeader.TabIndex = 0;
            lblFirmaHeader.Text = "Firma Adı:";
            // 
            // txtFirmaValue
            // 
            txtFirmaValue.Location = new Point(129, 16);
            txtFirmaValue.Name = "txtFirmaValue";
            txtFirmaValue.ReadOnly = true;
            txtFirmaValue.Size = new Size(189, 21);
            txtFirmaValue.TabIndex = 1;
            // 
            // lblKalkisHeader
            // 
            lblKalkisHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKalkisHeader.Appearance.Options.UseFont = true;
            lblKalkisHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblKalkisHeader.Location = new Point(17, 52);
            lblKalkisHeader.Name = "lblKalkisHeader";
            lblKalkisHeader.Size = new Size(103, 17);
            lblKalkisHeader.TabIndex = 2;
            lblKalkisHeader.Text = "Kalkış Şehri:";
            // 
            // txtKalkisValue
            // 
            txtKalkisValue.Location = new Point(129, 50);
            txtKalkisValue.Name = "txtKalkisValue";
            txtKalkisValue.ReadOnly = true;
            txtKalkisValue.Size = new Size(189, 21);
            txtKalkisValue.TabIndex = 3;
            // 
            // lblVarisHeader
            // 
            lblVarisHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVarisHeader.Appearance.Options.UseFont = true;
            lblVarisHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblVarisHeader.Location = new Point(17, 87);
            lblVarisHeader.Name = "lblVarisHeader";
            lblVarisHeader.Size = new Size(103, 17);
            lblVarisHeader.TabIndex = 4;
            lblVarisHeader.Text = "Varış Şehri:";
            // 
            // txtVarisValue
            // 
            txtVarisValue.Location = new Point(129, 85);
            txtVarisValue.Name = "txtVarisValue";
            txtVarisValue.ReadOnly = true;
            txtVarisValue.Size = new Size(189, 21);
            txtVarisValue.TabIndex = 5;
            // 
            // lblZamanHeader
            // 
            lblZamanHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblZamanHeader.Appearance.Options.UseFont = true;
            lblZamanHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblZamanHeader.Location = new Point(17, 121);
            lblZamanHeader.Name = "lblZamanHeader";
            lblZamanHeader.Size = new Size(103, 17);
            lblZamanHeader.TabIndex = 6;
            lblZamanHeader.Text = "Kalkış Zamanı:";
            // 
            // txtZamanValue
            // 
            txtZamanValue.Location = new Point(129, 120);
            txtZamanValue.Name = "txtZamanValue";
            txtZamanValue.ReadOnly = true;
            txtZamanValue.Size = new Size(189, 21);
            txtZamanValue.TabIndex = 7;
            // 
            // lblFiyatHeader
            // 
            lblFiyatHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiyatHeader.Appearance.Options.UseFont = true;
            lblFiyatHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblFiyatHeader.Location = new Point(17, 156);
            lblFiyatHeader.Name = "lblFiyatHeader";
            lblFiyatHeader.Size = new Size(103, 17);
            lblFiyatHeader.TabIndex = 8;
            lblFiyatHeader.Text = "Fiyat:";
            // 
            // txtFiyatValue
            // 
            txtFiyatValue.Location = new Point(129, 154);
            txtFiyatValue.Name = "txtFiyatValue";
            txtFiyatValue.ReadOnly = true;
            txtFiyatValue.Size = new Size(189, 21);
            txtFiyatValue.TabIndex = 9;
            // 
            // lblKoltukHeader
            // 
            lblKoltukHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKoltukHeader.Appearance.Options.UseFont = true;
            lblKoltukHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblKoltukHeader.Location = new Point(17, 191);
            lblKoltukHeader.Name = "lblKoltukHeader";
            lblKoltukHeader.Size = new Size(103, 17);
            lblKoltukHeader.TabIndex = 10;
            lblKoltukHeader.Text = "Boş Koltuk:";
            // 
            // txtKoltukValue
            // 
            txtKoltukValue.Location = new Point(129, 189);
            txtKoltukValue.Name = "txtKoltukValue";
            txtKoltukValue.ReadOnly = true;
            txtKoltukValue.Size = new Size(189, 21);
            txtKoltukValue.TabIndex = 11;
            //
            // lblDuraklar
            //
            lblDuraklar.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuraklar.Appearance.Options.UseFont = true;
            lblDuraklar.AutoSizeMode = LabelAutoSizeMode.None;
            lblDuraklar.Location = new Point(17, 226);
            lblDuraklar.Name = "lblDuraklar";
            lblDuraklar.Size = new Size(103, 17);
            lblDuraklar.TabIndex = 12;
            lblDuraklar.Text = "Güzergah:";
            //
            // txtDuraklar
            //
            txtDuraklar.Location = new Point(129, 224);
            txtDuraklar.Name = "txtDuraklar";
            txtDuraklar.ReadOnly = true;
            txtDuraklar.Size = new Size(319, 21);
            txtDuraklar.TabIndex = 13;
            //
            // SeferDetay
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 270);
            Controls.Add(txtKalkisValue);
            Controls.Add(txtVarisValue);
            Controls.Add(txtZamanValue);
            Controls.Add(txtFiyatValue);
            Controls.Add(txtKoltukValue);
            Controls.Add(txtFirmaValue);
            Controls.Add(lblFirmaHeader);
            Controls.Add(lblKalkisHeader);
            Controls.Add(lblVarisHeader);
            Controls.Add(lblZamanHeader);
            Controls.Add(lblFiyatHeader);
            Controls.Add(txtDuraklar);
            Controls.Add(lblDuraklar);
            Controls.Add(lblKoltukHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SeferDetay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sefer Detayları";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelControl lblFirmaHeader;
        private TextBox txtFirmaValue;
        private LabelControl lblKalkisHeader;
        private TextBox txtKalkisValue;
        private LabelControl lblVarisHeader;
        private TextBox txtVarisValue;
        private LabelControl lblZamanHeader;
        private TextBox txtZamanValue;
        private LabelControl lblFiyatHeader;
        private TextBox txtFiyatValue;
        private LabelControl lblKoltukHeader;
        private TextBox txtKoltukValue;
        private LabelControl lblDuraklar;
        private TextBox txtDuraklar;
    }
}
