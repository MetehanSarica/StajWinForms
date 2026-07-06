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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridSorgu).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtboxTC
            // 
            txtboxTC.Location = new Point(44, 56);
            txtboxTC.Name = "txtboxTC";
            txtboxTC.Size = new Size(179, 23);
            txtboxTC.TabIndex = 0;
            txtboxTC.TextChanged += txtboxTC_TextChanged;
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Location = new Point(44, 38);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(79, 15);
            lblTC.TabIndex = 1;
            lblTC.Text = "TC Kimlik No:";
            // 
            // btnBiletSorgu
            // 
            btnBiletSorgu.Location = new Point(44, 94);
            btnBiletSorgu.Name = "btnBiletSorgu";
            btnBiletSorgu.Size = new Size(179, 32);
            btnBiletSorgu.TabIndex = 2;
            btnBiletSorgu.Text = "Sorgula";
            btnBiletSorgu.UseVisualStyleBackColor = true;
            btnBiletSorgu.Click += btnBiletSorgu_Click;
            // 
            // dataGridSorgu
            // 
            dataGridSorgu.AllowUserToAddRows = false;
            dataGridSorgu.AllowUserToDeleteRows = false;
            dataGridSorgu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSorgu.Location = new Point(6, 154);
            dataGridSorgu.MultiSelect = false;
            dataGridSorgu.Name = "dataGridSorgu";
            dataGridSorgu.ReadOnly = true;
            dataGridSorgu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSorgu.Size = new Size(267, 266);
            dataGridSorgu.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTC);
            groupBox1.Controls.Add(btnBiletSorgu);
            groupBox1.Controls.Add(txtboxTC);
            groupBox1.Controls.Add(dataGridSorgu);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 426);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilet Sorgulama";
            // 
            // BiletSorgula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BiletSorgula";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)dataGridSorgu).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtboxTC;
        private Label lblTC;
        private Button btnBiletSorgu;
        private DataGridView dataGridSorgu;
        private GroupBox groupBox1;
    }
}