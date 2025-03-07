using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterOficio : FilterComboBox
    {
        public FilterOficio(IEnumerable<string> items) : base(items) => Id = "Oficio";

        public override Func<Venta, bool> GetCondition() =>
            v => v.Oficio == SelectedItem;
    }
}
