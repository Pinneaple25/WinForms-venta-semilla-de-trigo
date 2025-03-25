namespace venta_semilla_de_trigo.Views
{
    partial class BarGraphic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)BarChart).BeginInit();
            SuspendLayout();
            // 
            // BarChart
            // 
            chartArea1.Name = "ChartArea1";
            BarChart.ChartAreas.Add(chartArea1);
            BarChart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            BarChart.Legends.Add(legend1);
            BarChart.Location = new Point(0, 0);
            BarChart.Name = "BarChart";
            BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            BarChart.Series.Add(series1);
            BarChart.Size = new Size(800, 450);
            BarChart.TabIndex = 0;
            // 
            // BarGraphic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BarChart);
            Name = "BarGraphic";
            ((System.ComponentModel.ISupportInitialize)BarChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
    }
}