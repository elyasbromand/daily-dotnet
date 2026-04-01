namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new();
            Customers customer2 = new();
            Customers customer3 = new();

            Console.WriteLine($"Customer 1 Id is {customer1.Id}");
            Console.WriteLine($"Customer 2 Id is {customer2.Id}");
            Console.WriteLine($"Customer 3 Id is {customer3.Id}");

        }
    }
}
