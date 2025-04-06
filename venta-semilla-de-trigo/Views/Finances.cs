using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Context;

namespace venta_semilla_de_trigo.Views
{
    public partial class Finances : Form
    {
        public Finances()
        {
            InitializeComponent();
            PFiltro.Controls.Add(new FilterSolicitante(VentasContext.GetItems(v => v.Solicitante)));
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            var view = new FinanceGraphic();
            view.Show(this);
        }
    }
}
