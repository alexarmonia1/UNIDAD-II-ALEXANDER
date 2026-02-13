namespace ejercicio_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpfecha.Value;
            lblfecha.Text = "Fecha seleccionada: " + fechaSeleccionada.ToShortDateString();
        }
    }
}
