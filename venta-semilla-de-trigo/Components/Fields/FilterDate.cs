using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterDate : FilterComponent
    {
        public FilterDate()
        {
            InitializeComponent();
            Id = "Fecha";
            LbTitle.Text = Id;
        }

        public override Func<Venta, bool> GetCondition()
        {
            var minDate = new DateTime((int)NudMinYear.Value, CbxMinMonth.SelectedIndex + 1, 1);
            var maxDate = new DateTime((int)NudMaxYear.Value, CbxMaxMonth.SelectedIndex + 1, 1);
            return v => v.Fecha >= minDate && v.Fecha < maxDate;
        }
    }
}
