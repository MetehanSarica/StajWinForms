namespace StajWinForms.Admin
{
    partial class DashboardForm
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
            tileControl.Dock = DockStyle.Top;
            tileControl.Height = 190;
            tileControl.Name = "tileControl";
            tileControl.AllowDrag = false;
            //
            // chartControl
            //
            chartControl.Dock = DockStyle.Fill;
            chartControl.Name = "chartControl";
            //
            // chartPie
            //
            chartPie.Dock = DockStyle.Right;
            chartPie.Width = 380;
            chartPie.Name = "chartPie";
            //
            // DashboardForm
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 520);
            Controls.Add(chartControl);
            Controls.Add(chartPie);
            Controls.Add(tileControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)chartControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            ResumeLayout(false);
        }

        internal DevExpress.XtraEditors.TileControl tileControl;
        internal DevExpress.XtraCharts.ChartControl chartControl;
        internal DevExpress.XtraCharts.ChartControl chartPie;
    }
}
