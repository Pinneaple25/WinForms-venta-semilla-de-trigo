using System.Windows.Forms.DataVisualization.Charting;

namespace venta_semilla_de_trigo.Views
{
    public partial class FinanceGraphic: Form
    {
        public FinanceGraphic(Dictionary<DateTime, int> data, string title = "")
        {
            InitializeComponent();
            InitializeChart(data);
            Text = title;
        }

        private void InitializeChart(Dictionary<DateTime, int> data)
        {
            FinanceChart.Series.Clear();
            ChartArea chartArea = new()
            {
                Name = "ChartArea",
            };
            chartArea.AxisX.Interval = 1;
            FinanceChart.ChartAreas.Add(chartArea);

            Series series = new()
            {
                ChartType = SeriesChartType.Line,
                IsVisibleInLegend = true,
                BorderWidth = 3,
            };

            var i = 1;
            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
                i++;
            }

            FinanceChart.Series.Add(series);
        }
    }
}
