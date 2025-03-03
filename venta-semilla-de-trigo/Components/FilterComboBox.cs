namespace venta_semilla_de_trigo.Components
{
    public partial class FilterComboBox : UserControl
    {
        public override string? Text { set => LbItems.Text = value; }

        public FilterComboBox(IEnumerable<string> items)
        {
            InitializeComponent();
            items = items.Select(x => string.IsNullOrWhiteSpace(x) ? "SIN REGISTRAR" : x);
            CbxItems.Items.AddRange(items.ToArray());
        }
    }
}
