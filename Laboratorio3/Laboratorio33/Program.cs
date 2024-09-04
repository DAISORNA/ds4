internal class Program
{
    private static void Main(string[] args)
    {
        int largo, ancho, perimetro;

        Console.Write("Introduce el largo del rectángulo: ");
        largo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el ancho del rectángulo: ");
        ancho = Convert.ToInt32(Console.ReadLine());

       
        CalculosMatematicos calculos = new CalculosMatematicos();

       
        perimetro = calculos.CalculoPerimetroRectangulo(largo, ancho);

    
        Console.WriteLine("El perímetro del rectángulo es: {0}", perimetro);
    }

    class CalculosMatematicos
    {
        public int CalculoPerimetroRectangulo(int largo, int ancho)
        {
            return 2 * (largo + ancho);
        }
    }
}
