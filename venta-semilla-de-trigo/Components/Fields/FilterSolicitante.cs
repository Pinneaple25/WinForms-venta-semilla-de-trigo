using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterSolicitante : FilterComboBox
    {
        public FilterSolicitante(IEnumerable<string> items) : base(items) => Id = "Solicitante";

        public override Func<Venta, bool> GetCondition() =>
            v => v.Solicitante == SelectedItem;
    }
}
