using System.Windows.Forms.DataVisualization.Charting;

namespace venta_semilla_de_trigo.Views
{
    public partial class PayGraphic : Form
    {
        public PayGraphic(Dictionary<string, int> data)
        {
            InitializeComponent();
            InitializeChart(data);
        }

        private void InitializeChart(Dictionary<string, int> data)
        {
            PayChart.Series.Clear();
            Series series = new()
            {
                ChartType = SeriesChartType.Pie,
                Name = "Ventas"
            };

            foreach (var item in data)
            {
                string key = item.Key;
                if (key.Length > 20)
                    key = key[..20] + "...";
                series.Points.AddXY(key, item.Value);
            }

            PayChart.Series.Add(series);
        }
    }
}
