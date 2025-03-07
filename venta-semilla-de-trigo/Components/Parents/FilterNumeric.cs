using venta_semilla_de_trigo.Models;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterNumeric : FilterComponent
    {
        public FilterNumeric(int increment)
        {
            InitializeComponent();
            LbTitle.Text = Id;
            NudMin.Increment = increment;
            NudMax.Increment = increment;
            NudMin.Maximum = increment * 100;
            NudMax.Maximum = increment * 100;
        }

        public override Func<Venta, bool> GetCondition()
        {
            throw new NotImplementedException();
        }
    }
}
