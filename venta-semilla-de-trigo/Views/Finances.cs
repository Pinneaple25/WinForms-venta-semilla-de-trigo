using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Components.Ventas;
using venta_semilla_de_trigo.Context;

namespace venta_semilla_de_trigo.Views
{
    public partial class Finances : Form
    {
        private readonly FilterSolicitante filterSolicitante;
        public Finances()
        {
            InitializeComponent();
            filterSolicitante = new FilterSolicitante(VentasContext.GetItems(v => v.Solicitante));
            PFiltro.Controls.Add(filterSolicitante);
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            try
            {
                var predicate = filterSolicitante.GetCondition();
                var months = GetMonths();
                var minDate = filterDate.GetMinDate();
                var maxDate = filterDate.GetMaxDate();

                var values = VentasContext.GetFinances(predicate, minDate, maxDate, months);

                var title = GenerateTag();
                var view = new FinanceGraphic(values, title);
                view.Show(this);
            }
            catch
            {
                MessageBox.Show("Seleccione una fecha valida");
            }
        }

        private int GetMonths()
        {
            if (RbLustros.Checked) return 12 * 5;

            if (RbAnual.Checked) return 12;
            
            if (RbSemestral.Checked) return 6;
            
            if (RbCuatrimestral.Checked) return 4;
            
            if (RbTrimestral.Checked) return 3;
            
            if (RbBimestral.Checked) return 2;
            
            if (RbMensual.Checked) return 1;

            throw new NotImplementedException();
        }

        private string GenerateTag()
        {
            var solicitante = filterSolicitante.GetValue();
            var fecha = filterDate.GetValue();
            return $"Evolución de costos de {solicitante}, {fecha}";
        }
    }
}
