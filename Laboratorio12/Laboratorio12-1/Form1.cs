namespace Laboratorio12_1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }


    private void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            // Obtener velocidad y tiempo desde los TextBox
            double velocidad = double.Parse(numvelocidad.Text);
            double tiempo = double.Parse(numtiempo.Text);

            // Crear una instancia de la clase CalculosMovil y calcular la distancia
           
            double distancia = calculardistancia.CalcularDistancia(velocidad, tiempo);

            // Mostrar el resultado en textBox3
            textBoxresultado.Text = distancia.ToString();
        }
        catch (FormatException)
        {
            MessageBox.Show("Por favor, introduce valores numéricos válidos.");
        }

    }

    private void Button2_Click(object sender, EventArgs e)
    {
        numvelocidad.Clear();
        numtiempo.Clear();
        textBoxresultado.Clear();
    }

    private void Button3_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    double velocidad;
    double tiempo;
    private void TextBox3_TextChanged(object sender, EventArgs e)
    {

        // Verificar si los valores de velocidad y tiempo son válidos
        bool esVelocidadValida = double.TryParse(numvelocidad.Text, out velocidad);
        bool esTiempoValido = double.TryParse(numtiempo.Text, out tiempo);

        if (esVelocidadValida && esTiempoValido)
        {
            // Calcular la distancia utilizando el método estático CalcularDistancia
            double distancia = calculardistancia.CalcularDistancia(velocidad, tiempo);

            // Mostrar el resultado en textBox3
            textBoxresultado.Text = distancia.ToString();
        }
        else
        {
            // Mostrar un mensaje de error si la entrada no es válida
            MessageBox.Show("Por favor, introduce valores válidos para la velocidad y el tiempo.");
        }
    }

    private void TextBox3_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
