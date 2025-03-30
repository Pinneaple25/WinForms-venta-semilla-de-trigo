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
    }
}
