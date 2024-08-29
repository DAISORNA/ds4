internal class Program

{
    private static void Main(string[] args)
    {
        Client client = new Client();
        client.FirstName = "Su nombre";
        client.LastName = "Su apellido";
        client.Age = 15;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());
    }

}