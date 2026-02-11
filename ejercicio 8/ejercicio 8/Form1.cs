namespace ejercicio_8
{
    public partial class Form1 : Form
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            lblresultado.Text = "veces presionado " + contador;

        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
