using venta_semilla_de_trigo.Services;

namespace venta_semilla_de_trigo
{
    public partial class Home : Form
    {
        public readonly DataService service;

        public Home(DataService dataService)
        {
            InitializeComponent();
            service = dataService;
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog(this) != DialogResult.OK)
                return;

            BtnEstadisticas.Enabled = true;

            service.Insertar(OpenFile.FileName);
        }
    }
}
