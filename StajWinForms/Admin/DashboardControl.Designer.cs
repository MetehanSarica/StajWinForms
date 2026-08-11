namespace StajWinForms.Admin
{
    partial class DashboardControl
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
            tileControl = new DevExpress.XtraEditors.TileControl();
            chartControl = new DevExpress.XtraCharts.ChartControl();
            chartPie = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)chartControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            SuspendLayout();
            // 
            // tileControl
            // 
            tileControl.AllowDrag = false;
            tileControl.Dock = DockStyle.Top;
            tileControl.Location = new Point(0, 0);
            tileControl.Margin = new Padding(4, 3, 4, 3);
            tileControl.Name = "tileControl";
            tileControl.Padding = new Padding(21);
            tileControl.Size = new Size(968, 219);
            tileControl.TabIndex = 2;
            // 
            // chartControl
            // 
            chartControl.Dock = DockStyle.Fill;
            chartControl.Location = new Point(0, 219);
            chartControl.Margin = new Padding(4, 3, 4, 3);
            chartControl.Name = "chartControl";
            chartControl.Size = new Size(525, 314);
            chartControl.TabIndex = 0;
            // 
            // chartPie
            // 
            chartPie.Dock = DockStyle.Right;
            chartPie.Location = new Point(525, 219);
            chartPie.Margin = new Padding(4, 3, 4, 3);
            chartPie.Name = "chartPie";
            chartPie.Size = new Size(443, 314);
            chartPie.TabIndex = 1;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chartControl);
            Controls.Add(chartPie);
            Controls.Add(tileControl);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardControl";
            Size = new Size(968, 533);
            ((System.ComponentModel.ISupportInitialize)chartControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            ResumeLayout(false);
        }

        internal DevExpress.XtraEditors.TileControl tileControl;
        internal DevExpress.XtraCharts.ChartControl chartControl;
        internal DevExpress.XtraCharts.ChartControl chartPie;
    }
}
