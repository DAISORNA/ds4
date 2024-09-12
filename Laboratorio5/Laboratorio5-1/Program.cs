using System;

internal class Program
{
    private int[] sueldos; // Declaramos un vector

    public void Cargar()
    {
        sueldos = new int[6]; // Inicializamos el vector en 5
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operario "+f+": ");
            string linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); // Asignamos los 5 sueldos al vector
        }
    }

    // Muestra los sueldos de los operarios en el vector sueldos[f]
    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios:");
        for (int f = 1; f <= 5; f++) 
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.ReadKey();
    }

    // Main principal
    static void Main(string[] args)
    {
        Program pv = new Program(); // Cambié el nombre de la clase a Program
        pv.Cargar();
        pv.Imprimir();
    }
}
