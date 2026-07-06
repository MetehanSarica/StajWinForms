namespace StajWinForms
{
    partial class BiletSorgula
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
            txtboxTC = new TextBox();
            lblTC = new Label();
            btnBiletSorgu = new Button();
            dataGridSorgu = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridSorgu).BeginInit();
            SuspendLayout();
            // 
            // txtboxTC
            // 
            txtboxTC.Location = new Point(56, 49);
            txtboxTC.Name = "txtboxTC";
            txtboxTC.Size = new Size(179, 23);
            txtboxTC.TabIndex = 0;
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Location = new Point(56, 31);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(79, 15);
            lblTC.TabIndex = 1;
            lblTC.Text = "TC Kimlik No:";
            // 
            // btnBiletSorgu
            // 
            btnBiletSorgu.Location = new Point(56, 97);
            btnBiletSorgu.Name = "btnBiletSorgu";
            btnBiletSorgu.Size = new Size(179, 32);
            btnBiletSorgu.TabIndex = 2;
            btnBiletSorgu.Text = "Bilet Sorgula";
            btnBiletSorgu.UseVisualStyleBackColor = true;
            btnBiletSorgu.Click += btnBiletSorgu_Click;
            // 
            // dataGridSorgu
            // 
            dataGridSorgu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSorgu.Location = new Point(12, 172);
            dataGridSorgu.Name = "dataGridSorgu";
            dataGridSorgu.Size = new Size(279, 266);
            dataGridSorgu.TabIndex = 3;
            // 
            // BiletSorgula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 450);
            Controls.Add(dataGridSorgu);
            Controls.Add(btnBiletSorgu);
            Controls.Add(lblTC);
            Controls.Add(txtboxTC);
            Name = "BiletSorgula";
            Text = "BiletSorgula";
            ((System.ComponentModel.ISupportInitialize)dataGridSorgu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxTC;
        private Label lblTC;
        private Button btnBiletSorgu;
        private DataGridView dataGridSorgu;
    }
}