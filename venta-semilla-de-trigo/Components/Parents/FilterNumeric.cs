namespace venta_semilla_de_trigo.Components
{
    public abstract partial class FilterNumeric : FilterComponent
    {
        protected int Minimun { get => (int)NudMin.Value; }
        protected int Maximun { get => (int)NudMax.Value; }

        public FilterNumeric(int increment)
        {
            InitializeComponent();
            LbTitle.Text = Id;
            NudMin.Increment = increment;
            NudMax.Increment = increment;
            NudMin.Maximum = increment * 100;
            NudMax.Maximum = increment * 100;
        }

        public override string GetValue() => $"entre {NudMin.Value} y {NudMax.Value}";

        public void OnLoadComponent(object sender, EventArgs e) => LbTitle.Text = Id;
    }
}
