using Microsoft.Extensions.DependencyInjection;
using venta_semilla_de_trigo.Services;

namespace venta_semilla_de_trigo.Views
{
    public partial class Home : Form
    {
        private readonly DataService service;
        private readonly IServiceProvider provider;

        public Home(DataService dataService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            service = dataService;
            provider = serviceProvider;
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog(this) != DialogResult.OK)
                return;

            BtnEstadisticas.Enabled = true;

            service.Insertar(OpenFile.FileName);
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            Hide();
            var view = provider.GetRequiredService<Stadistics>();
            view.ShowDialog(this);
            Show();
        }
    }
}
