using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Services;

namespace venta_semilla_de_trigo.Views
{
    public partial class Stadistics : Form
    {
        private readonly DataService service;

        private readonly List<CheckBox> _filterCheckBoxes;
        private readonly Panel[] _filterPanels;
        private readonly UserControl[] _filterComponents;
        private readonly List<UserControl> _selectedFilters = [];

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

            _filterComponents =
            [
                new FilterComboBox(service.GetItems(v => v.Solicitante)),
                new FilterComboBox(service.GetItems(v => v.Variedad)),
                new FilterCategoria(),
                new FilterNumeric(50),
                new FilterNumeric(1000),
                new FilterComboBox(service.GetItems(v => v.Ciclo)),
                new FilterComboBox(service.GetItems(v => v.Lote)),
                new FilterDate(),
                new FilterComboBox(service.GetItems(v => v.Oficio)),
            ];

            foreach (var checkBox in _filterCheckBoxes)
            {
                checkBox.CheckedChanged += CheckMaxFiltersChecked!;
                checkBox.CheckedChanged += AddFilter!;
            }
        }

        private void CheckMaxFiltersChecked(object sender, EventArgs e)
        {
            var maxReached = _filterCheckBoxes.Count(cb => cb.Checked) >= 3;
            foreach (var checkBox in _filterCheckBoxes)
                if (!checkBox.Checked)
                    checkBox.Enabled = !maxReached;
        }

        private void AddFilter(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            int i = _filterCheckBoxes.IndexOf(checkBox);
            var component = _filterComponents[i];

            component.Text = checkBox.Text;

            if (checkBox.Checked)
                _selectedFilters.Add(component);
            else
                _selectedFilters.RemoveAll(f => f.Text == component.Text);

            DrawFilters();
        }

        private void DrawFilters()
        {
            for (int i = 0; i < _filterPanels.Length; i++)
            {
                _filterPanels[i].Controls.Clear();
                if (i < _selectedFilters.Count)
                    _filterPanels[i].Controls.Add(_selectedFilters[i]);
            }
        }
    }
}
