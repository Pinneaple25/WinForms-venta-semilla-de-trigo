using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Services;

namespace venta_semilla_de_trigo.Views
{
    public partial class Stadistics : Form
    {
        public int FilterIndex { get => _filterCheckBoxes.Count(cb => cb.Checked); }

        private readonly DataService service;

        private readonly List<CheckBox> _filterCheckBoxes;
        private readonly Panel[] _filterPanels;

        public Stadistics(DataService dataService)
        {
            InitializeComponent();
            service = dataService;

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
            _filterPanels =
            [
                PFilter1,
                PFilter2,
                PFilter3,
            ];
            _filterCheckBoxes.ForEach(cd => cd.CheckedChanged += CheckMaxFiltersChecked!);
        }

        private void CheckMaxFiltersChecked(object sender, EventArgs e)
        {
            var maxReached = _filterCheckBoxes.Count(cb => cb.Checked) >= 3;
            _filterCheckBoxes.ForEach(cb =>
            {
                if (!cb.Checked)
                    cb.Enabled = !maxReached;
            });
        }

        private void CbSolicitud_CheckedChanged(object sender, EventArgs e)
        {
            var items = service.GetItems(v => v.Solicitante);
            var component = new FilterComboBox(items);
            AddFilter((CheckBox)sender, component);
        }

        private void CbVariedad_CheckedChanged(object sender, EventArgs e)
        {
            var items = service.GetItems(v => v.Variedad);
            var component = new FilterComboBox(items);
            AddFilter((CheckBox)sender, component);
        }

        private void CbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            var component = new FilterCategoria();
            AddFilter((CheckBox)sender, component);
        }

        private void CbKgSalida_CheckedChanged(object sender, EventArgs e)
        {
            var component = new FilterNumeric(50);
            AddFilter((CheckBox)sender, component);
        }

        private void CbCosto_CheckedChanged(object sender, EventArgs e)
        {
            var component = new FilterNumeric(1000);
            AddFilter((CheckBox)sender, component);
        }

        private void CbCiclo_CheckedChanged(object sender, EventArgs e)
        {
            var items = service.GetItems(v => v.Ciclo);
            var component = new FilterComboBox(items);
            AddFilter((CheckBox)sender, component);
        }

        private void CbLote_CheckedChanged(object sender, EventArgs e)
        {
            var items = service.GetItems(v => v.Lote);
            var component = new FilterComboBox(items);
            AddFilter((CheckBox)sender, component);
        }

        private void CbFecha_CheckedChanged(object sender, EventArgs e)
        {
            var component = new FilterDate();
            AddFilter((CheckBox)sender, component);
        }

        private void CbOficio_CheckedChanged(object sender, EventArgs e)
        {
            var items = service.GetItems(v => v.Oficio);
            var component = new FilterComboBox(items);
            AddFilter((CheckBox)sender, component);
        }

        private void AddFilter(CheckBox sender, UserControl filterComponent)
        {
            if (!sender.Checked)
            {
                _filterPanels[FilterIndex].Controls.Clear();
                return;
            }

            filterComponent.Text = sender.Text;
            _filterPanels[FilterIndex - 1].Controls.Add(filterComponent);
        }
    }
}
