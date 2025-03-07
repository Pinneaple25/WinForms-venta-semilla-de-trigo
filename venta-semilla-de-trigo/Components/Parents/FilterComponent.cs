using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public abstract class FilterComponent : UserControl
    {
        public string Id { get; protected set; } = string.Empty;

        public abstract Func<Venta, bool> GetCondition();
    }
}
