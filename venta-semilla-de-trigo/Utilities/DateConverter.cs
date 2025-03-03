namespace venta_semilla_de_trigo.Utilities
{
    public static class DateConverter
    {
        public static int MonthNameToInt(string monthName)
        {
            return monthName.ToUpper() switch
            {
                "ENERO" => 1,
                "FEBRERO" => 2,
                "MARZO" => 3,
                "ABRIL" => 4,
                "MAYO" => 5,
                "JUNIO" => 6,
                "JULIO" => 7,
                "AGOSTO" => 8,
                "SEPTIEMBRE" => 9,
                "OCTUBRE" => 10,
                "NOVIEMBRE" => 11,
                "DICIEMBRE" => 12,
                _ => throw new ArgumentException("Nombre de mes no válido")
            };
        }
    }
}
