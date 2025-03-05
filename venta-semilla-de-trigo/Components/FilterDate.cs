namespace venta_semilla_de_trigo.Components
{
    public partial class FilterDate : UserControl
    {
        public override string Text
        {
            get => LbTitle.Text;
            set => LbTitle.Text = value;
        }

        public FilterDate()
        {
            InitializeComponent();
        }
    }
}
