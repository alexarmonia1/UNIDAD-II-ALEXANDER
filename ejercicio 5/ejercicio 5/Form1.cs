namespace ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (rbOpcion1.Checked)
            {
                lblresultado.Text = "Has Seleccionado la opcion 1";
            }
            else if (rbOpcion2.Checked)
            {
                lblresultado.Text = "Has Seleccionado la opcion 2";
            }
            else if (rbOpcion3.Checked)
            {
                lblresultado.Text = "Has Seleccionado la opcion 3";
            }
            else
            {
                MessageBox.Show("tienes que seleccionar una opcion", "aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    
            }
        }
    }
}

