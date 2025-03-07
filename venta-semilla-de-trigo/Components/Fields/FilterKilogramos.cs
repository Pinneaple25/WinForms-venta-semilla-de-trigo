using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterKilogramos : FilterNumeric
    {
        public FilterKilogramos(int increment) : base(increment) => Id = "KG. Salida";

        public override Func<Venta, bool> GetCondition() => 
            v => v.KgSalida >= Minimun && v.KgSalida <= Maximun;
    }
}
