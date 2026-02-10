namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) ||
                string.IsNullOrWhiteSpace(txtNumero2.Text))

            {
                MessageBox.Show("los campos no pueden estar vacios", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);

            double resultado = num1 + num2;
            lblresultado.Text = resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            lblresultado.Text = "Resultado";
        }
    }
}
