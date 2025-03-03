using ExcelDataReader;
using venta_semilla_de_trigo.Utilities;

namespace venta_semilla_de_trigo.Models
{
    public class Venta(IExcelDataReader reader)
    {
        public string Solicitante { get; set; } = reader.GetString(0);
        public string Variedad { get; set; } = reader.GetString(1);
        public bool Basica { get; set; } = reader.GetString(2) == "Básica";
        public int KgIncorporacion { get; set; } = (int?)reader.GetValue(3) ?? 0;
        public int KgSalida { get; set; } = (int)reader.GetDouble(4);
        public int Costo { get; set; } = (int)reader.GetDouble(5);
        public string FolioSalida { get; set; } = reader.GetString(6);
        public string FolioEntrada { get; set; } = reader.GetString(7);
        public string Ciclo { get; set; } = reader.GetString(8);
        public string Lote { get; set; } = reader.GetString(9);
        public string Etiquetas { get; set; } = reader.GetString(10);
        public string? Factura { get; set; } = reader.GetValue(11)?.ToString();
        public int Mes { get; set; } = DateConverter.MonthNameToInt(reader.GetString(12));
        public int Anio { get; set; } = (int)reader.GetDouble(13);
        public string Oficio { get; set; } = reader.GetString(14);
        public string? RegistroSIGI { get; set; } = reader.GetValue(15)?.ToString();
    }
}
