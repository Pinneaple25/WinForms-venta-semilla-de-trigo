using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Models;
using venta_semilla_de_trigo.Services;
using venta_semilla_de_trigo.Utilities;

namespace venta_semilla_de_trigo.Views
{
    public partial class Stadistics : Form
    {
        private readonly DataService service;

        private readonly List<CheckBox> _filterCheckBoxes;
        private readonly Panel[] _filterPanels;
        private readonly FilterComponent[] _filterComponents;
        private readonly List<FilterComponent> _selectedFilters = [];

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
                new FilterSolicitante(service.GetItems(v => v.Solicitante)),
                new FilterVariedad(service.GetItems(v => v.Variedad)),
                new FilterCategoria(),
                new FilterKilogramos(50),
                new FilterCosto(1000),
                new FilterCiclo(service.GetItems(v => v.Ciclo)),
                new FilterLote(service.GetItems(v => v.Lote)),
                new FilterDate(),
                new FilterOficio(service.GetItems(v => v.Oficio)),
            ];

            foreach (var checkBox in _filterCheckBoxes)
            {
                checkBox.CheckedChanged += CheckMaxFiltersChecked!;
                checkBox.CheckedChanged += AddFilter!;
            }
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            var predicate = GetFilter();

            var keys = service.GetCountGroup(predicate, v => v.Solicitante);
            var view = new PayGraphic(keys);
            view.Show(this);
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

            if (checkBox.Checked)
                _selectedFilters.Add(component);
            else
                _selectedFilters.RemoveAll(f => f.Id == component.Id);

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

        private Func<Venta, bool> GetFilter()
        {
            Func<Venta, bool> expression = v => true;

            foreach (var filter in _selectedFilters)
                expression = expression.And(filter.GetCondition());

            return expression;
        }
    }
}
