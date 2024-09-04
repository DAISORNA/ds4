internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero;

        Console.Write("Introduce el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

      
        CalculosMatematicos calculos = new CalculosMatematicos();

        int resultado = calculos.Calcular(primerNumero, segundoNumero);

        Console.WriteLine("El resultado de la operacion (a+b)*(a-b) es {0}", resultado);
    }

 
    class CalculosMatematicos
    {
        public int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }


}
