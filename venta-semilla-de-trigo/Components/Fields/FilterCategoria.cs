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
            if (RbTodos.Checked)
                return v => true;

            return v => v.Basica == RbBasica.Checked;
        }

        public override string? GetValue()
        {
            if (RbTodos.Checked)
                return null;

            return RbBasica.Checked ? "basicas" : "registradas";
        }
    }
}
