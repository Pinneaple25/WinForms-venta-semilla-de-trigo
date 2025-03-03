using ExcelDataReader;
using System.Text;
using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Utilities
{
    public static class ExcelHandler
    {
        public static List<Venta>? ParseVentas(string filePath)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);

            if (!EsArchivoBD(reader))
            {
                var fileName = filePath.Split('\\').Last().Replace(".xlsx", "");
                MessageBox.Show($"El archivo { fileName } no contiene la estructura de la base de datos correcta.");
                return null;
            }

            List<Venta> ventas = [];
            int i = 0;
            while (reader.Read())
            {
                i++;
                try
                {
                    if (reader.IsDBNull(0))
                        break;

                    ventas.Add(new(reader));
                }
                catch 
                {
                    MessageBox.Show($"Error al leer la columna: { i }");
                }
            }
            return ventas;
        }

        public static bool EsArchivoBD(IExcelDataReader reader)
        {
            do
            {
                while (reader.Read())
                {
                    if (reader.GetValue(0)?.ToString() == "SOLICITANTE - COMPRADOR")
                    {
                        reader.Read();
                        return true;
                    }
                }
            } while (reader.NextResult());

            return false;
        }
    }
}
