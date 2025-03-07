using venta_semilla_de_trigo.Models;
using venta_semilla_de_trigo.Utilities;

namespace venta_semilla_de_trigo.Services
{
    public class DataService
    {
        private readonly List<Venta> ventas = [];

        public void Insert(string filePath)
        {
            var nuevasVentas = ExcelHandler.ParseVentas(filePath);

            if (nuevasVentas == null)
            {
                return;
            }

            ventas.AddRange(nuevasVentas);
            MessageBox.Show($"Se han registrado {nuevasVentas.Count} nuevas ventas.");
        }

        public IEnumerable<TOut> GetItems<TOut>(Func<Venta, TOut> predicate) => 
            ventas
            .Select(predicate)
            .Distinct()
            .OrderBy(x => x);

        public Dictionary<string, int> GetCountGroup(Func<Venta, bool> predicate, Func<Venta, string> keySelector) => 
            ventas
            .Where(predicate)
            .GroupBy(keySelector)
            .ToDictionary(g => g.Key, g => g.Count());
    }
}
