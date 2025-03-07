using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterCategoria : FilterComponent
    {
        public FilterCategoria()
        {
            InitializeComponent();
            Id = "Categoria";
            LbTitle.Text = Id;
        }

        public override Func<Venta, bool> GetCondition()
        {
            throw new NotImplementedException();
        }
    }
}
