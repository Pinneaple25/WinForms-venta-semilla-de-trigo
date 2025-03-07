using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterDate : FilterComponent
    {
        public FilterDate()
        {
            InitializeComponent();
            Id = "Fecha";
            LbTitle.Text = Id;
        }

        public override Func<Venta, bool> GetCondition()
        {
            throw new NotImplementedException();
        }
    }
}
