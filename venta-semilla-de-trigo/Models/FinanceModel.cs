namespace venta_semilla_de_trigo.Models
{
    public class FinanceModel
    {
        public string Serie { get; set; } = "";
        public Dictionary<DateTime, int> Data { get; set; } = [];
    }
}
