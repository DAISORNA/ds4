using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Verificar si es un triángulo válido
        if (EsTrianguloValido(lado1, lado2, lado3))
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo equilátero.");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("Es un triángulo isósceles.");
            }
            else
            {
                Console.WriteLine("Es un triángulo escaleno.");
            }
        }
        else
        {
            Console.WriteLine("No es un triángulo válido.");
        }
    }

    static bool EsTrianguloValido(double lado1, double lado2, double lado3)
    {
        return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
    }
}
