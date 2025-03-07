using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterCiclo : FilterComboBox
    {
        public FilterCiclo(IEnumerable<string> items) : base(items) => Id = "Ciclo";

        public override Func<Venta, bool> GetCondition() =>
            v => v.Ciclo == SelectedItem;
    }
}
