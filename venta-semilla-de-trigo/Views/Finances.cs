using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Context;
using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Views
{
    public partial class Finances : Form
    {
        private readonly FilterSolicitante filterSolicitante;
        private readonly List<string> values = [];

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
                var values = GetPredicate();
                var months = GetMonths();
                var minDate = filterDate.GetMinDate();
                var maxDate = filterDate.GetMaxDate();

                List<FinanceModel> data = [];

                foreach (var value in values)
                {
                    bool predicate(Venta v) => v.Solicitante.Contains(value);
                    var datos = VentasContext.GetFinances(predicate, minDate, maxDate, months);
                    data.Add(new()
                    {
                        Serie = value,
                        Data = datos,
                    });
                }

                var title = GenerateTag();
                var view = new FinanceGraphic(data, title);
                view.Show(this);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una fecha valida");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not CheckBox check) return;

            check.Text = check.Checked ? "Por solicitante" : "Global";
            PFiltro.Visible = check.Checked;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var x = filterSolicitante.GetValue();
            values.Add(x);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            values.Clear();
        }

        private List<string> GetPredicate()
        {
            return CbGlobal.Checked ? values : [""];
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
