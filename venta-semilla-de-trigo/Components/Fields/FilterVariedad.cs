using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public class FilterVariedad : FilterComboBox
    {
        public FilterVariedad(IEnumerable<string> items) : base(items) => Id = "Variedad";

        public override Func<Venta, bool> GetCondition() =>
            v => v.Variedad == SelectedItem;
    }
}
