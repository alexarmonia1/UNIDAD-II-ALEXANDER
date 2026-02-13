namespace ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Value = 0;
            timer1.Start();
            
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Proceso completado.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
