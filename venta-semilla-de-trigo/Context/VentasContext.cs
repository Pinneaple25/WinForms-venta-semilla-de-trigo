using venta_semilla_de_trigo.Models;
using venta_semilla_de_trigo.Utilities;

namespace venta_semilla_de_trigo.Context
{
    public static class VentasContext
    {
        private static List<Venta> Data { get; } = [];

        public static void Insert(string filePath)
        {
            var nuevasVentas = ExcelHandler.ParseVentas(filePath);

            if (nuevasVentas == null)
            {
                return;
            }

            Data.AddRange(nuevasVentas);
            MessageBox.Show($"Se han registrado {nuevasVentas.Count} nuevas ventas.");
        }

        public static IEnumerable<TOut> GetItems<TOut>(Func<Venta, TOut> predicate) => 
            Data
            .Select(predicate)
            .Distinct()
            .OrderBy(x => x);

        public static Dictionary<string, int> GetCountGroup(Func<Venta, bool> predicate, Func<Venta, string> keySelector, Func<IGrouping<string, Venta>, int> groupBy) =>
            Data
            .Where(predicate)
            .GroupBy(keySelector)
            .ToDictionary(g => g.Key, groupBy);

        public static Dictionary<DateTime, int> GetFinances(Func<Venta, bool> predicate, DateTime minDate, DateTime maxDate, int months)
        {
            var result = new Dictionary<DateTime, int>();
            var data = Data
                .Where(predicate)
                .Where(v => v.Fecha >= minDate && v.Fecha < maxDate);

            if (!data.Any()) return result;

            var iMaxDate = minDate.AddMonths(months);
            var iMinDate = minDate;

            do
            {
                var costs = data
                    .Where(v => v.Fecha >= iMinDate)
                    .Where(v => v.Fecha < iMaxDate)
                    .Sum(v => v.Costo);

                result.Add(iMinDate, costs);

                iMinDate = iMaxDate;
                iMaxDate = iMaxDate.AddMonths(months);
            } while (iMaxDate < maxDate);

            return result;
        }
    }
}
