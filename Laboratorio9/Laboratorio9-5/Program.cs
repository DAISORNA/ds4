using System;

class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    // Generar un número aleatorio entre dos valores
    public int GenerarNumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1);  // max es exclusivo, por eso sumamos 1
    }

    // Generar un arreglo de números aleatorios entre dos valores
    public int[] GenerarArreglo(int cantidad, int min, int max)
    {
        int[] arreglo = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = GenerarNumeroEntre(min, max);
        }
        return arreglo;
    }

    // Generar un arreglo de números no repetidos entre dos valores
    public int[] GenerarArregloNoRepetidos(int cantidad, int min, int max)
    {
        if (max - min + 1 < cantidad)
        {
            throw new ArgumentException("No hay suficientes números para generar el arreglo sin repeticiones.");
        }

        int[] arreglo = new int[cantidad];
        int index = 0;

        while (index < cantidad)
        {
            int numAleatorio = GenerarNumeroEntre(min, max);
            if (Array.IndexOf(arreglo, numAleatorio) == -1)
            {
                arreglo[index] = numAleatorio;
                index++;
            }
        }

        return arreglo;
    }
}

class Programa
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
