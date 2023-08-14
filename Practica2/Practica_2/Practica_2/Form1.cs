namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            double montoInicial, porcentaje, interesCompuesto;

            montoInicial = Convert.ToDouble(textboxMonto.Text);

            porcentaje = Convert.ToDouble(textboxPorcentaje.Text);

            interesCompuesto = montoInicial + (montoInicial * (porcentaje / 100));

            mostrarResultado.Text = "El interes compuesto es de: " + interesCompuesto.ToString();
        }
    }
}