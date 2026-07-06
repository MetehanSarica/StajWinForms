namespace StajWinForms
{
    partial class AnaMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            btnSorgu = new Button();
            btnSec = new Button();
            btnAra = new Button();
            txtboxAra = new TextBox();
            bindingSource1 = new BindingSource(components);
            dataGridVeriler = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridVeriler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSorgu);
            panel2.Controls.Add(btnSec);
            panel2.Controls.Add(btnAra);
            panel2.Controls.Add(txtboxAra);
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 350);
            panel2.TabIndex = 1;
            // 
            // btnSorgu
            // 
            btnSorgu.Location = new Point(12, 307);
            btnSorgu.Name = "btnSorgu";
            btnSorgu.Size = new Size(177, 31);
            btnSorgu.TabIndex = 2;
            btnSorgu.Text = "Bilet Sorgula";
            btnSorgu.UseVisualStyleBackColor = true;
            btnSorgu.Click += btnSorgu_Click;
            // 
            // btnSec
            // 
            btnSec.Location = new Point(12, 89);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(177, 31);
            btnSec.TabIndex = 1;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(12, 52);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(177, 31);
            btnAra.TabIndex = 0;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtboxAra
            // 
            txtboxAra.Location = new Point(12, 23);
            txtboxAra.Name = "txtboxAra";
            txtboxAra.Size = new Size(177, 23);
            txtboxAra.TabIndex = 0;
            // 
            // dataGridVeriler
            // 
            dataGridVeriler.AllowUserToAddRows = false;
            dataGridVeriler.AllowUserToDeleteRows = false;
            dataGridVeriler.AutoGenerateColumns = false;
            dataGridVeriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVeriler.DataSource = bindingSource1;
            dataGridVeriler.Location = new Point(206, 106);
            dataGridVeriler.Name = "dataGridVeriler";
            dataGridVeriler.ReadOnly = true;
            dataGridVeriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVeriler.Size = new Size(582, 332);
            dataGridVeriler.TabIndex = 2;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridVeriler);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AnaMenu";
            Text = "Ana Menü";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridVeriler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnAra;
        private TextBox txtboxAra;
        private BindingSource bindingSource1;
        private DataGridView dataGridVeriler;
        private Button btnSec;
        private Button btnSorgu;
    }
}
