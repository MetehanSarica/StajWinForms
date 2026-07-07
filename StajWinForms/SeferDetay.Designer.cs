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
            lblFirmaValue = new LabelControl();
            lblKalkisHeader = new LabelControl();
            lblKalkisValue = new LabelControl();
            lblVarisHeader = new LabelControl();
            lblVarisValue = new LabelControl();
            lblZamanHeader = new LabelControl();
            lblZamanValue = new LabelControl();
            lblFiyatHeader = new LabelControl();
            lblFiyatValue = new LabelControl();
            lblKoltukHeader = new LabelControl();
            lblKoltukValue = new LabelControl();
            SuspendLayout();
            //
            // lblFirmaHeader
            //
            lblFirmaHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFirmaHeader.Appearance.Options.UseFont = true;
            lblFirmaHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblFirmaHeader.Location = new Point(20, 20);
            lblFirmaHeader.Name = "lblFirmaHeader";
            lblFirmaHeader.Size = new Size(120, 20);
            lblFirmaHeader.Text = "Firma Adı:";
            //
            // lblFirmaValue
            //
            lblFirmaValue.AutoSizeMode = LabelAutoSizeMode.None;
            lblFirmaValue.Location = new Point(150, 20);
            lblFirmaValue.Name = "lblFirmaValue";
            lblFirmaValue.Size = new Size(220, 20);
            lblFirmaValue.Text = "-";
            //
            // lblKalkisHeader
            //
            lblKalkisHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKalkisHeader.Appearance.Options.UseFont = true;
            lblKalkisHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblKalkisHeader.Location = new Point(20, 60);
            lblKalkisHeader.Name = "lblKalkisHeader";
            lblKalkisHeader.Size = new Size(120, 20);
            lblKalkisHeader.Text = "Kalkış Şehri:";
            //
            // lblKalkisValue
            //
            lblKalkisValue.AutoSizeMode = LabelAutoSizeMode.None;
            lblKalkisValue.Location = new Point(150, 60);
            lblKalkisValue.Name = "lblKalkisValue";
            lblKalkisValue.Size = new Size(220, 20);
            lblKalkisValue.Text = "-";
            //
            // lblVarisHeader
            //
            lblVarisHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVarisHeader.Appearance.Options.UseFont = true;
            lblVarisHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblVarisHeader.Location = new Point(20, 100);
            lblVarisHeader.Name = "lblVarisHeader";
            lblVarisHeader.Size = new Size(120, 20);
            lblVarisHeader.Text = "Varış Şehri:";
            //
            // lblVarisValue
            //
            lblVarisValue.AutoSizeMode = LabelAutoSizeMode.None;
            lblVarisValue.Location = new Point(150, 100);
            lblVarisValue.Name = "lblVarisValue";
            lblVarisValue.Size = new Size(220, 20);
            lblVarisValue.Text = "-";
            //
            // lblZamanHeader
            //
            lblZamanHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblZamanHeader.Appearance.Options.UseFont = true;
            lblZamanHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblZamanHeader.Location = new Point(20, 140);
            lblZamanHeader.Name = "lblZamanHeader";
            lblZamanHeader.Size = new Size(120, 20);
            lblZamanHeader.Text = "Kalkış Zamanı:";
            //
            // lblZamanValue
            //
            lblZamanValue.AutoSizeMode = LabelAutoSizeMode.None;
            lblZamanValue.Location = new Point(150, 140);
            lblZamanValue.Name = "lblZamanValue";
            lblZamanValue.Size = new Size(220, 20);
            lblZamanValue.Text = "-";
            //
            // lblFiyatHeader
            //
            lblFiyatHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiyatHeader.Appearance.Options.UseFont = true;
            lblFiyatHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblFiyatHeader.Location = new Point(20, 180);
            lblFiyatHeader.Name = "lblFiyatHeader";
            lblFiyatHeader.Size = new Size(120, 20);
            lblFiyatHeader.Text = "Fiyat:";
            //
            // lblFiyatValue
            //
            lblFiyatValue.AutoSizeMode = LabelAutoSizeMode.None;
            lblFiyatValue.Location = new Point(150, 180);
            lblFiyatValue.Name = "lblFiyatValue";
            lblFiyatValue.Size = new Size(220, 20);
            lblFiyatValue.Text = "-";
            //
            // lblKoltukHeader
            //
            lblKoltukHeader.Appearance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKoltukHeader.Appearance.Options.UseFont = true;
            lblKoltukHeader.AutoSizeMode = LabelAutoSizeMode.None;
            lblKoltukHeader.Location = new Point(20, 220);
            lblKoltukHeader.Name = "lblKoltukHeader";
            lblKoltukHeader.Size = new Size(120, 20);
            lblKoltukHeader.Text = "Boş Koltuk:";
            //
            // lblKoltukValue
            //
            lblKoltukValue.AutoSizeMode = LabelAutoSizeMode.None;
            lblKoltukValue.Location = new Point(150, 220);
            lblKoltukValue.Name = "lblKoltukValue";
            lblKoltukValue.Size = new Size(220, 20);
            lblKoltukValue.Text = "-";
            //
            // SeferDetay
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 270);
            Controls.Add(lblFirmaHeader);
            Controls.Add(lblFirmaValue);
            Controls.Add(lblKalkisHeader);
            Controls.Add(lblKalkisValue);
            Controls.Add(lblVarisHeader);
            Controls.Add(lblVarisValue);
            Controls.Add(lblZamanHeader);
            Controls.Add(lblZamanValue);
            Controls.Add(lblFiyatHeader);
            Controls.Add(lblFiyatValue);
            Controls.Add(lblKoltukHeader);
            Controls.Add(lblKoltukValue);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SeferDetay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sefer Detayları";
            ResumeLayout(false);
        }

        #endregion

        private LabelControl lblFirmaHeader;
        private LabelControl lblFirmaValue;
        private LabelControl lblKalkisHeader;
        private LabelControl lblKalkisValue;
        private LabelControl lblVarisHeader;
        private LabelControl lblVarisValue;
        private LabelControl lblZamanHeader;
        private LabelControl lblZamanValue;
        private LabelControl lblFiyatHeader;
        private LabelControl lblFiyatValue;
        private LabelControl lblKoltukHeader;
        private LabelControl lblKoltukValue;
    }
}
