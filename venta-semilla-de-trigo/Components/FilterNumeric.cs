namespace venta_semilla_de_trigo.Components
{
    public partial class FilterNumeric : UserControl
    {
        public override string Text
        {
            get => LbTitle.Text;
            set => LbTitle.Text = value;
        }

        public FilterNumeric(int increment)
        {
            InitializeComponent();
            NudMin.Increment = increment;
            NudMax.Increment = increment;
            NudMin.Maximum = increment * 100;
            NudMax.Maximum = increment * 100;
        }
    }
}
