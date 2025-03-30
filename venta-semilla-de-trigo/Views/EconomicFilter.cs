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
            var values = VentasContext.GetCostGroup(predicate, keySelector);

            var title = GenerateTag();
            BarGraphic view = new(values, title);
            view.Show(this);
        }

        private string GenerateTag()
        {
            var filters = dataFilter.GetValues();
            var selector = selectorData.GetValuesTags();

            if (filters != "")
                return $"Costo de las ventas de {filters}; por sus {selector}.";

            return $"Costo de las ventas por sus {selector}.";
        }
    }
}
