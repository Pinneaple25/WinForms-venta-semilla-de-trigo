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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            PayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            LbTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)PayChart).BeginInit();
            SuspendLayout();
            // 
            // PayChart
            // 
            chartArea1.Name = "ChartArea1";
            PayChart.ChartAreas.Add(chartArea1);
            PayChart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            PayChart.Legends.Add(legend1);
            PayChart.Location = new Point(0, 0);
            PayChart.Name = "PayChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            PayChart.Series.Add(series1);
            PayChart.Size = new Size(760, 485);
            PayChart.TabIndex = 0;
            // 
            // LbTotal
            // 
            LbTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LbTotal.AutoSize = true;
            LbTotal.BackColor = Color.Transparent;
            LbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotal.Location = new Point(605, 448);
            LbTotal.Name = "LbTotal";
            LbTotal.Size = new Size(64, 28);
            LbTotal.TabIndex = 1;
            LbTotal.Text = "Total:";
            // 
            // PayGraphic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 485);
            Controls.Add(LbTotal);
            Controls.Add(PayChart);
            Name = "PayGraphic";
            ((System.ComponentModel.ISupportInitialize)PayChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PayChart;
        private Label LbTotal;
    }
}