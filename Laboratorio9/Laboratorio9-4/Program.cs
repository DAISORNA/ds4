using Laboratorio9_4;
using System;

class Program
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();

        // Generar un número entre 10 y 20
        int numero = aleatorios.GenerarNumeroEntre(10, 20);
        Console.WriteLine("Número aleatorio entre 10 y 20: " + numero);

        // Generar un arreglo de 5 números aleatorios entre 1 y 50
        int[] arreglo = aleatorios.GenerarArreglo(5, 1, 50);
        Console.WriteLine("Arreglo de números aleatorios:");
        foreach (int num in arreglo)
        {
            Console.WriteLine(num);
        }

        // Generar un arreglo de 5 números no repetidos entre 1 y 50
        int[] arregloNoRepetidos = aleatorios.GenerarArregloNoRepetidos(5, 1, 50);
        Console.WriteLine("Arreglo de números aleatorios no repetidos:");
        foreach (int num in arregloNoRepetidos)
        {
            Console.WriteLine(num);
        }
    }
}
