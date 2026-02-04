
using System;
using System.Windows.Forms;



namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            lblmostrar.Text = "texto cambiado";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
