using System;

namespace Laboratorio21
{
    public class Program
    {
        public static void main()
        {
            //Asignando valor a variable estatica
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }

    }
    public class MyClass
    {
        //Declarando variable estatica
        public static int Valor;
    }

}


int nombreVariable = 1000;

int valor1 = 28; //Declaramos variables con un valor de 28

valor2 = valor1; //Asignamos el valor de variable1 a valor2
valor2 = 30;
//Imprimiendo en consola variables
Console.WriteLine(valor1);
Console.WriteLine(valor2);

Console.WriteLine(valor1);
Console.WriteLine(valor2);

