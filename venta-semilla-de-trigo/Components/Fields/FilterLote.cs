using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterLote : FilterComboBox
    {
        public FilterLote(IEnumerable<string> items) : base(items) => Id = "Lote";

        public override Func<Venta, bool> GetCondition() =>
            v => v.Lote == SelectedItem;
    }
}
