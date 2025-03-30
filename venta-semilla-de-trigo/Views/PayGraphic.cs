using System.Windows.Forms.DataVisualization.Charting;

namespace venta_semilla_de_trigo.Views
{
    public partial class PayGraphic : Form
    {
        public PayGraphic(Dictionary<string, int> data, string title)
        {
            InitializeComponent();
            InitializeChart(data);
            var total = data.Sum(d => d.Value);
            Text = title;
            LbTotal.Text = $"Total: {total}";
        }

        private void InitializeChart(Dictionary<string, int> data)
        {
            data = data.OrderBy(x => x.Key).ToDictionary();

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
