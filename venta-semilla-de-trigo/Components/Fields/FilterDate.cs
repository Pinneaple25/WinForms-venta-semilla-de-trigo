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
            var minDate = GetMinDate();
            var maxDate = GetMaxDate();
            return v => v.Fecha >= minDate && v.Fecha < maxDate;
        }

        public override string GetValue() => $"entre {CbxMinMonth.Text} del {NudMinYear.Value} al {CbxMaxMonth.Text} del {NudMaxYear.Value}";

        private DateTime GetMinDate() => new((int)NudMinYear.Value, CbxMinMonth.SelectedIndex + 1, 1);

        private DateTime GetMaxDate() => new((int)NudMaxYear.Value, CbxMaxMonth.SelectedIndex + 1, 1);
    }
}
