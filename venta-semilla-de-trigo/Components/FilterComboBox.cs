namespace venta_semilla_de_trigo.Components
{
    public partial class FilterComboBox : UserControl
    {
        public override string Text
        {
            get => LbTitle.Text;
            set => LbTitle.Text = value;
        }

        public FilterComboBox(IEnumerable<string> items)
        {
            InitializeComponent();
            items = items.Select(x => string.IsNullOrWhiteSpace(x) ? "_SIN REGISTRAR_" : x);
            CbxItems.Items.AddRange(items.ToArray());
        }
    }
}
