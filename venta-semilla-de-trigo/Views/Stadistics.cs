namespace venta_semilla_de_trigo.Views
{
    public partial class Stadistics : Form
    {
        private readonly List<CheckBox> _filterCheckBoxes;

        public Stadistics()
        {
            InitializeComponent();
            _filterCheckBoxes =
            [
                CbSolicitud,
                CbVariedad,
                CbCategoria,
                CbKgSalida,
                CbCosto,
                CbCiclo,
                CbLote,
                CbFecha,
                CbOficio,
            ];
            _filterCheckBoxes.ForEach(cd => cd.CheckedChanged += Cbx_CheckedChanged!);
        }

        private void Cbx_CheckedChanged(object sender, EventArgs e)
        {
            var maxReached = _filterCheckBoxes.Count(cb => cb.Checked) >= 3;
            _filterCheckBoxes.ForEach(cb => 
            {
                if (!cb.Checked)
                    cb.Enabled = !maxReached;
            });
        }
    }
}
