

namespace Laboratorio9_4
{
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

}
