using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Context;
using venta_semilla_de_trigo.Models;

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
                var predicate = GetPredicate();
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

        private void CbGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not CheckBox check) return;

            check.Text = check.Checked ? "Por solicitante" : "Global";
            PFiltro.Visible = check.Checked;
        }

        private Func<Venta, bool> GetPredicate()
        {
            return CbGlobal.Checked
                ? filterSolicitante.GetCondition()
                : v => true;
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
            return CbGlobal.Checked 
                ? $"Evolución de costos de {solicitante}, {fecha}"
                : $"Evolución de costos {fecha}";
        }
    }
}
