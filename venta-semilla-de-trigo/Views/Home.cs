namespace venta_semilla_de_trigo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog(this) != DialogResult.OK)
                return;

            BtnEstadisticas.Enabled = true;
        }
    }
}
