using System;

class Program
{
    static void Main()
    {
        double precio;
        string formaPago;

        // Pedir precio del producto
        do
        {
            Console.Write("Ingrese el precio del producto (valor positivo): ");
            precio = Convert.ToDouble(Console.ReadLine());
        } while (precio <= 0);

        // Pedir la forma de pago
        do
        {
            Console.Write("Ingrese la forma de pago (efectivo/tarjeta): ");
            formaPago = Console.ReadLine().ToLower();
        } while (formaPago != "efectivo" && formaPago != "tarjeta");

        // Si el pago es con tarjeta, pedir el número de cuenta
        if (formaPago == "tarjeta")
        {
            string numeroCuenta;
            do
            {
                Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                numeroCuenta = Console.ReadLine();
            } while (numeroCuenta.Length != 16 || !long.TryParse(numeroCuenta, out _));  // Valida que sean 16 dígitos numéricos
        }

        Console.WriteLine("Pago registrado correctamente.");
    }
}
