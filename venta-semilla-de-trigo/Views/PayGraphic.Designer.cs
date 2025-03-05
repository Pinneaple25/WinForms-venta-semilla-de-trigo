namespace venta_semilla_de_trigo.Views
{
    partial class PayGraphic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            PayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)PayChart).BeginInit();
            SuspendLayout();
            // 
            // PayChart
            // 
            chartArea2.Name = "ChartArea1";
            PayChart.ChartAreas.Add(chartArea2);
            PayChart.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            PayChart.Legends.Add(legend2);
            PayChart.Location = new Point(0, 0);
            PayChart.Name = "PayChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            PayChart.Series.Add(series2);
            PayChart.Size = new Size(760, 485);
            PayChart.TabIndex = 0;
            // 
            // PayGraphic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 485);
            Controls.Add(PayChart);
            Name = "PayGraphic";
            ((System.ComponentModel.ISupportInitialize)PayChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PayChart;
    }
}