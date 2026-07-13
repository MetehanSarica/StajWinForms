using DevExpress.XtraEditors;

namespace StajWinForms
{
    partial class SeferSecimMenu
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
            lblKalkis = new LabelControl();
            lblVaris = new LabelControl();
            cmbKalkis = new ComboBoxEdit();
            cmbVaris = new ComboBoxEdit();
            lblTarih = new LabelControl();
            dateKalkis = new DateEdit();
            btnAra = new SimpleButton();
            btnTumSeferler = new SimpleButton();
            lblBaslik = new LabelControl();
            ((System.ComponentModel.ISupportInitialize)cmbKalkis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbVaris.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateKalkis.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateKalkis.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // lblKalkis
            // 
            lblKalkis.Appearance.Font = new Font("Tahoma", 10F);
            lblKalkis.Appearance.Options.UseFont = true;
            lblKalkis.Location = new Point(30, 75);
            lblKalkis.Name = "lblKalkis";
            lblKalkis.Size = new Size(66, 16);
            lblKalkis.TabIndex = 1;
            lblKalkis.Text = "Gidiş Şehri:";
            // 
            // lblVaris
            // 
            lblVaris.Appearance.Font = new Font("Tahoma", 10F);
            lblVaris.Appearance.Options.UseFont = true;
            lblVaris.Location = new Point(30, 115);
            lblVaris.Name = "lblVaris";
            lblVaris.Size = new Size(68, 16);
            lblVaris.TabIndex = 3;
            lblVaris.Text = "Varış Şehri:";
            // 
            // cmbKalkis
            // 
            cmbKalkis.Location = new Point(155, 72);
            cmbKalkis.Name = "cmbKalkis";
            cmbKalkis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbKalkis.Size = new Size(240, 20);
            cmbKalkis.TabIndex = 2;
            cmbKalkis.SelectedIndexChanged += cmbKalkis_SelectedIndexChanged;
            // 
            // cmbVaris
            // 
            cmbVaris.Location = new Point(155, 112);
            cmbVaris.Name = "cmbVaris";
            cmbVaris.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbVaris.Size = new Size(240, 20);
            cmbVaris.TabIndex = 4;
            cmbVaris.SelectedIndexChanged += cmbVaris_SelectedIndexChanged;
            // 
            // lblTarih
            // 
            lblTarih.Appearance.Font = new Font("Tahoma", 10F);
            lblTarih.Appearance.Options.UseFont = true;
            lblTarih.Location = new Point(30, 155);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(35, 16);
            lblTarih.TabIndex = 6;
            lblTarih.Text = "Tarih:";
            // 
            // dateKalkis
            // 
            dateKalkis.EditValue = new DateTime(2026, 7, 10, 8, 52, 14, 344);
            dateKalkis.Location = new Point(155, 152);
            dateKalkis.Name = "dateKalkis";
            dateKalkis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateKalkis.Size = new Size(240, 20);
            dateKalkis.TabIndex = 7;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(80, 240);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(130, 40);
            btnAra.TabIndex = 10;
            btnAra.Text = "Sefer Ara";
            btnAra.Click += btnAra_Click;
            // 
            // btnTumSeferler
            // 
            btnTumSeferler.Location = new Point(230, 240);
            btnTumSeferler.Name = "btnTumSeferler";
            btnTumSeferler.Size = new Size(130, 40);
            btnTumSeferler.TabIndex = 11;
            btnTumSeferler.Text = "Tüm Seferler";
            btnTumSeferler.Click += btnTumSeferler_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.Appearance.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblBaslik.Appearance.Options.UseFont = true;
            lblBaslik.Location = new Point(120, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(116, 23);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Sefer Arama";
            // 
            // SeferSecimMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 310);
            Controls.Add(lblBaslik);
            Controls.Add(lblKalkis);
            Controls.Add(cmbKalkis);
            Controls.Add(lblVaris);
            Controls.Add(cmbVaris);
            Controls.Add(lblTarih);
            Controls.Add(dateKalkis);
            Controls.Add(btnAra);
            Controls.Add(btnTumSeferler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SeferSecimMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sefer Arama";
            Load += SeferSecimMenu_Load;
            ((System.ComponentModel.ISupportInitialize)cmbKalkis.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbVaris.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateKalkis.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateKalkis.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LabelControl lblKalkis;
        private LabelControl lblVaris;
        private ComboBoxEdit cmbKalkis;
        private ComboBoxEdit cmbVaris;
        private LabelControl lblTarih;
        private DateEdit dateKalkis;
        private SimpleButton btnAra;
        private SimpleButton btnTumSeferler;
        private LabelControl lblBaslik;
    }
}
