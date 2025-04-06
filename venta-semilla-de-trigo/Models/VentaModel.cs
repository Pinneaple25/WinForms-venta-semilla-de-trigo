using ExcelDataReader;
using venta_semilla_de_trigo.Utilities;

namespace venta_semilla_de_trigo.Models
{
    public class Venta(IExcelDataReader reader)
    {
        public string Solicitante { get; set; } = reader.GetString(0).Trim();
        public string Variedad { get; set; } = reader.GetString(1).Trim();
        public bool Basica { get; set; } = reader.GetString(2).StartsWith('B');
        public bool? Duro { get; set; } = reader.GetValue(3)?.ToString()?.StartsWith('D');
        public int KgIncorporacion { get; set; } = (int?)reader.GetValue(4) ?? 0;
        public int KgSalida { get; set; } = (int)reader.GetDouble(5);
        public int Costo { get; set; } = (int)reader.GetDouble(6);
        public string FolioSalida { get; set; } = reader.GetString(7)?.Trim() ?? "";
        public string FolioEntrada { get; set; } = reader.GetString(8)?.Trim() ?? "";
        public string Ciclo { get; set; } = reader.GetString(9)?.Trim() ?? "";
        public string Lote { get; set; } = reader.GetString(10)?.Trim() ?? "";
        public string Etiquetas { get; set; } = reader.GetString(11)?.Trim() ?? "";
        public string? Factura { get; set; } = reader.GetValue(12)?.ToString()?.Trim();
        public DateTime Fecha { get; set; } = new DateTime((int)reader.GetDouble(14), DateConverter.MonthNameToInt(reader.GetString(13)), 1);
        public string Oficio { get; set; } = reader.GetString(15)?.Trim() ?? "";
        public string? RegistroSIGI { get; set; } = reader.GetValue(16)?.ToString()?.Trim();
    }
}
