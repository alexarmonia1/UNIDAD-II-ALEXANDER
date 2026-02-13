namespace ejercicio_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcelsius.Text))
            {
                MessageBox.Show("debe ingresar una temperatura", "aviso");
                return;
                
            }
            double celcius;
            if(!double.TryParse(txtcelsius.Text, out celcius))
            {
                MessageBox.Show("ingrese un numero valido", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtcelsius.Clear();
                txtcelsius.Focus();
                return;
            }
            double farenheit = (celcius * 9 / 5) + 32;
            lblresultado.Text = "resultado: " + farenheit.ToString("0.00") + " °F";
        }
    }
}
