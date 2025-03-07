namespace venta_semilla_de_trigo.Components
{
    public abstract partial class FilterComboBox : FilterComponent
    {
        protected string? SelectedItem
        {
            get
            {
                string? item = CbxItems.SelectedItem?.ToString();
                return item != "_N/R" ? item : null;
            }
        }

        public FilterComboBox(IEnumerable<string> items)
        {
            InitializeComponent();
            items = items.Select(x => string.IsNullOrWhiteSpace(x) ? "_N/R" : x);
            CbxItems.Items.AddRange(items.ToArray());
        }

        public void OnLoadComponent(object sender, EventArgs e) => LbTitle.Text = Id;
    }
}
