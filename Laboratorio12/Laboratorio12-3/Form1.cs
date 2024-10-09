namespace Laboratorio12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA = Convert.ToDouble(textBox1.Text);
            double ladoB = Convert.ToDouble(textBox2.Text);
            double ladoC = Convert.ToDouble(textBox3.Text);

            double semiperimetro = (ladoA + ladoB + ladoC) / 2;
            textBox4.Text = semiperimetro.ToString();
        }

        private void button2_Click(object sender, EventArgs e) // Calcular Área
        {
            double ladoA = Convert.ToDouble(textBox1.Text);
            double ladoB = Convert.ToDouble(textBox2.Text);
            double ladoC = Convert.ToDouble(textBox3.Text);

            double semiperimetro = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
            textBox5.Text = area.ToString();
        }

        private void button3_Click(object sender, EventArgs e) // Reset
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e) // Salir
        {
            Application.Exit();
        }

      
    }
}
