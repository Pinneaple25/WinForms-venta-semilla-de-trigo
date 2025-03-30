using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components.Ventas
{
    public partial class SelectorData : UserControl
    {
        public SelectorData()
        {
            InitializeComponent();
        }

        public Func<Venta, string> GetParameter()
        {
            if (RbSolicitante.Checked)
                return v => v.Solicitante;

            if (RbVariedad.Checked)
                return v => v.Variedad;

            if (RbCategoria.Checked)
                return v => v.Basica ? "Básica" : "Registrada";

            if (RbGrupo.Checked)
                return v => !v.Duro.HasValue 
                    ? "Sin registrar" 
                    : v.Duro.Value ? "Duro" : "Harinero";

            if (RbCiclo.Checked)
                return v => v.Ciclo ?? "_N/R";

            if (RbLote.Checked)
                return v => v.Lote ?? "_N/R";

            if (RbOficio.Checked)
                return v => v.Oficio ?? "_N/R";

            return v => string.Empty;
        }

        public string? GetValuesTags()
        {
            if (RbSolicitante.Checked)
                return "solicitantes";

            if (RbVariedad.Checked)
                return "variedades";

            if (RbCategoria.Checked)
                return "categorías";

            if (RbGrupo.Checked)
                return "grupos";

            if (RbCiclo.Checked)
                return "ciclos";

            if (RbLote.Checked)
                return "lotes";

            if (RbOficio.Checked)
                return "oficios";

            return null;
        }
    }
}
