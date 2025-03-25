using venta_semilla_de_trigo.Components;
using venta_semilla_de_trigo.Context;
using venta_semilla_de_trigo.Models;
using venta_semilla_de_trigo.Utilities;

namespace venta_semilla_de_trigo.Components
{
    public partial class FilterData : UserControl
    {
        private readonly List<CheckBox> _filterCheckBoxes;
        private readonly Panel[] _filterPanels = [];
        private readonly FilterComponent[] _filterComponents;
        private readonly List<FilterComponent> _selectedFilters = [];

        public FilterData(Panel[] panels)
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
                CbGrupo,
            ];

            _filterPanels = panels;

            _filterComponents =
            [
                new FilterSolicitante(VentasContext.GetItems(v => v.Solicitante)),
                new FilterVariedad(VentasContext.GetItems(v => v.Variedad)),
                new FilterCategoria(),
                new FilterKilogramos(50),
                new FilterCosto(1000),
                new FilterCiclo(VentasContext.GetItems(v => v.Ciclo)),
                new FilterLote(VentasContext.GetItems(v => v.Lote)),
                new FilterDate(),
                new FilterOficio(VentasContext.GetItems(v => v.Oficio)),
                new FilterGrupo(),
            ];


            foreach (var checkBox in _filterCheckBoxes)
            {
                checkBox.CheckedChanged += CheckMaxFiltersChecked!;
                checkBox.CheckedChanged += AddFilter!;
            }
        }

        private void CheckMaxFiltersChecked(object sender, EventArgs e)
        {
            var maxReached = _filterCheckBoxes.Count(cb => cb.Checked) >= _filterPanels.Length;
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

        public Func<Venta, bool> GetFilter()
        {
            Func<Venta, bool> expression = v => true;

            foreach (var filter in _selectedFilters)
                expression = expression.And(filter.GetCondition());

            return expression;
        }
    }
}
