class Program
{
    static void Main()
    {
     
        Console.Write("Ingrese un valor par para N: ");
        int N = int.Parse(Console.ReadLine());


        if (N % 2 != 0)
        {
            Console.WriteLine("El valor ingresado no es par. Por favor, reinicie la aplicación e ingrese un valor par.");
            return;
        }

        int[,] matriz = new int[N, N];

      
        Random random = new Random();
        for (int i = 1; i < N - 1; i++) 
        {
            matriz[i, i] = random.Next(101, 201); 
        }

    
        Console.WriteLine("Matriz sub-diagonal:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }

       
        int sumaDiagonal = 0;
        for (int i = 1; i < N - 1; i++) 
        {
            sumaDiagonal += matriz[i, i];
        }

       
        Console.WriteLine($"Suma de los valores de la diagonal: {sumaDiagonal}");
    }
}
