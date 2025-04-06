using Microsoft.Extensions.DependencyInjection;
using venta_semilla_de_trigo.Context;

namespace venta_semilla_de_trigo.Views
{
    public partial class Home : Form
    {
        private readonly IServiceProvider provider;

        public Home(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            provider = serviceProvider;
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog(this) != DialogResult.OK)
                return;

            BtnEstadisticas.Enabled = true;
            BtnContabilidad.Enabled = true;
            BtnFinanzas.Enabled = true;

            VentasContext.Insert(OpenFile.FileName);
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            OpenView<Stadistics>();
        }

        private void BtnEconomia_Click(object sender, EventArgs e)
        {
            OpenView<EconomicFilter>();
        }

        private void BtnFinanzas_Click(object sender, EventArgs e)
        {
            OpenView<Finances>();
        }

        private void OpenView<T>() where T : Form
        {
            Hide();
            var view = provider.GetRequiredService<T>();
            view.ShowDialog(this);
            Show();
        }
    }
}
