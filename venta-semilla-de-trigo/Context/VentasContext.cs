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

        public static Dictionary<string, int> GetCountGroup(Func<Venta, bool> predicate, Func<Venta, string> keySelector, out int count)
        {
            var registers = Data.Where(predicate);
            count = registers.Count();

            return registers.GroupBy(keySelector).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
