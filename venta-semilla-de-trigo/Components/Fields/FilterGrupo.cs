using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterGrupo : FilterComponent
    {
        public FilterGrupo()
        {
            InitializeComponent();
            Id = "Grupo";
            LbTitle.Text = Id;
        }

        public override Func<Venta, bool> GetCondition()
        {
            if (RbTodos.Checked)
                return v => v.Duro == null;

            return v => v.Duro != null && v.Duro == RbDuro.Checked;
        }
    }
}
