using System;

namespace Laboratorio21
{
    public class Program
    {
        public static void Main()
        {
            // Asignando valor a variable estática
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);

            // Declaramos variables con un valor de 28
            var valor1 = 28;
            var valor2 = valor1; // Asignamos el valor de 'valor1' a 'valor2'
            valor2 = 30;

            // Imprimiendo en consola variables
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            MyClass object1 = new MyClass(); // Creando nueva instancia
            object1.Nombre = "Yeison";
            object1.Edad = 28;
            MyClass object2 = object1; // Asignando una variable a otra

            // Este cambio en la propiedad afecta tanto a object1 como a object2.
            object2.Nombre = "Jose";

            // Al imprimir en consola vemos que ambas referencias imprimen el mismo valor 'Jose'
            Console.WriteLine(object2.Nombre);
            Console.WriteLine(object1.Nombre);

            char caracter = 'A';
            string cadena = "Cadena de caracteres";
        }
    }

    public class MyClass
    {
        // Declarando variable estática
        public static int Valor;

        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}

