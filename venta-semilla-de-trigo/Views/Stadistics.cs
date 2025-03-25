using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Context;
using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Views
{
    public partial class Stadistics : Form
    {
        private readonly FilterData dataFilter;
        public Stadistics()
        {
            InitializeComponent();

            dataFilter = new FilterData([
                PFilter1,
                PFilter2,
                PFilter3,
                ]);

            FilterPanel.Controls.Add(dataFilter);
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            var predicate = dataFilter.GetFilter();
            var keySelector = GetParameter();

            var keys = VentasContext.GetCountGroup(predicate, keySelector, out int count);
            var view = new PayGraphic(keys, count);
            view.Show(this);
        }

        private Func<Venta, string> GetParameter()
        {
            if (RbSolicitante.Checked)
                return v => v.Solicitante;

            if (RbVariedad.Checked)
                return v => v.Variedad;

            if (RbCategoria.Checked)
                return v => v.Basica.ToString();

            if (RbCiclo.Checked)
                return v => v.Ciclo ?? "_N/R";

            if (RbLote.Checked)
                return v => v.Lote ?? "_N/R";

            if (RbOficio.Checked)
                return v => v.Oficio ?? "_N/R";

            return v => string.Empty;
        }
    }
}
