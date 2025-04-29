using System.Windows.Forms.DataVisualization.Charting;
using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Views
{
    public partial class FinanceGraphic: Form
    {
        public FinanceGraphic(List<FinanceModel> data, string title = "")
        {
            InitializeComponent();
            InitializeChart(data);
            Text = title;
        }

        private void InitializeChart(List<FinanceModel> data)
        {
            data = [.. data.DistinctBy(f => f.Serie)];
            FinanceChart.Series.Clear();

            foreach (var d in data)
            {
                var series = new Series(d.Serie)
                {
                    ChartType = SeriesChartType.Line
                };

                foreach (var point in d.Data)
                {
                    series.Points.AddXY(point.Key, point.Value);
                }

                FinanceChart.Series.Add(series);
            }
        }
    }
}
