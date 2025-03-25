using venta_semilla_de_trigo.Components.Ventas;

namespace venta_semilla_de_trigo.Views
{
    public partial class EconomicFilter : Form
    {
        private readonly SelectorData selectorData;

        public EconomicFilter()
        {
            InitializeComponent();

            selectorData = new SelectorData();
            SelectorPanel.Controls.Add(selectorData);
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            BarGraphic view = new();
            view.Show(this);
        }
    }
}
