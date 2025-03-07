using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterCosto : FilterNumeric
    {
        public FilterCosto(int increment) : base(increment) => Id = "Costo";

        public override Func<Venta, bool> GetCondition() =>
            v => v.Costo >= Minimun && v.Costo <= Maximun;
    }
}
