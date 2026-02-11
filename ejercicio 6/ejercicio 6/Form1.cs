using System.Drawing;


namespace ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbcolors_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbcolors.SelectedIndex)
            {
                case 0:
                    this.BackColor = Color.Red;
                    break;
                case 1:
                    this.BackColor = Color.Green;
                    break;
                case 2:
                    this.BackColor = Color.Blue;
                    break;
            }
        }
    }
}
