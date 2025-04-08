namespace venta_semilla_de_trigo.Views
{
    partial class FinanceGraphic
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
            FinanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)FinanceChart).BeginInit();
            SuspendLayout();
            // 
            // FinanceChart
            // 
            chartArea2.Name = "ChartArea1";
            FinanceChart.ChartAreas.Add(chartArea2);
            FinanceChart.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            FinanceChart.Legends.Add(legend2);
            FinanceChart.Location = new Point(0, 0);
            FinanceChart.Name = "FinanceChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            FinanceChart.Series.Add(series2);
            FinanceChart.Size = new Size(800, 450);
            FinanceChart.TabIndex = 0;
            FinanceChart.Text = "chart1";
            // 
            // FinanceGraphic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FinanceChart);
            Name = "FinanceGraphic";
            ((System.ComponentModel.ISupportInitialize)FinanceChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart FinanceChart;
    }
}