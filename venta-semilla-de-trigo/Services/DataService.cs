using venta_semilla_de_trigo.Models;
using venta_semilla_de_trigo.Utilities;

namespace venta_semilla_de_trigo.Services
{
    public class DataService
    {
        private readonly List<Venta> ventas = [];

        public void Insertar(string filePath)
        {
            var nuevasVentas = ExcelHandler.ParseVentas(filePath);

            if (nuevasVentas == null)
            {
                return;
            }

            ventas.AddRange(nuevasVentas);
            MessageBox.Show($"Se han registrado {nuevasVentas.Count} nuevas ventas.");
        }
    }
}
