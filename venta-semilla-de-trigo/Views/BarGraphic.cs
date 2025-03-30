using System.Windows.Forms.DataVisualization.Charting;

namespace venta_semilla_de_trigo.Views
{
    public partial class BarGraphic : Form
    {
        public BarGraphic(Dictionary<string, int> data, string title)
        {
            InitializeComponent();
            InitializeChart(data);
            var total = data.Sum(d => d.Value);
            Text = title;
            LbTotal.Text = $"Total: {total:n2}";
        }

        private void InitializeChart(Dictionary<string, int> data)
        {
            BarChart.Series.Clear();

            int i = 1;
            foreach (var item in data)
            {
                Series series = new()
                {
                    ChartType = SeriesChartType.Bar,
                    Name = item.Key,
                    Label = item.Key,
                    IsVisibleInLegend = true,
                };

                series.Points.AddXY(i, item.Value);
                BarChart.Series.Add(series);
                i++;
            }

            BarChart.ChartAreas[0].AxisX.Title = "";
        }
    }
}
