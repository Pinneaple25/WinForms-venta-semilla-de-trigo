using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Components.Ventas;
using venta_semilla_de_trigo.Context;

namespace venta_semilla_de_trigo.Views
{
    public partial class EconomicFilter : Form
    {
        private readonly FilterData dataFilter;
        private readonly SelectorData selectorData;

        public EconomicFilter()
        {
            InitializeComponent();

            dataFilter = new FilterData([
                PFilter1,
                PFilter2,
                PFilter3,
                ]);

            selectorData = new SelectorData();

            FilterPanel.Controls.Add(dataFilter);
            SelectorPanel.Controls.Add(selectorData);
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            var predicate = dataFilter.GetFilter();
            var keySelector = selectorData.GetParameter();

            var values = VentasContext.GetCountGroup(
                dataFilter.GetFilter(), 
                selectorData.GetParameter(),
                g => g.Sum(v => RbBy.Checked ? v.KgSalida : v.Costo));

            var title = GenerateTag();
            BarGraphic view = new(values, title);
            view.Show(this);
        }

        private string GenerateTag()
        {
            var filters = dataFilter.GetValues();
            var selector = selectorData.GetValuesTags();
            var param = RbBy.Checked ? "Kilogramos de salida" : "Costo";

            if (filters != "")
                return $"{param} de las ventas de {filters}; por sus {selector}.";

            return $"{param} de las ventas por sus {selector}.";
        }

        private void TbBy_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
                radioButton.Text = radioButton.Checked ? "Mostrar por kilogramos de salida." : "Mostrar por costo.";
        }
    }
}
