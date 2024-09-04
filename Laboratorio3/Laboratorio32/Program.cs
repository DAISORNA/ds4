internal class Program
{
    private static void Main(string[] args)
    {
        double radio, area;

        Console.Write("Introduce el radio del círculo: ");
        radio = Convert.ToDouble(Console.ReadLine());

      
        CalculosMatematicos calculos = new CalculosMatematicos();

      
        area = calculos.CalculoArea(radio);

      
        Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);
    }

    class CalculosMatematicos
    {
        public double CalculoArea(double radio)
        {
            return Math.PI * radio * radio;
        }
    }
}
