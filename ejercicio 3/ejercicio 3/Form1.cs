namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxdetalles.Text))
            {
                MessageBox.Show("escribe un texto primero", "aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            lblresultado.Text = tbxdetalles.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
