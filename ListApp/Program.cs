namespace ListApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> productsList = [];

            productsList.Add(new Product { Name = "Laptop", Price = 1000 });
            productsList.Add(new Product { Name = "Desktop", Price = 2000 });

            foreach (var product in productsList)
            {
                Console.WriteLine(product);
            }
        }
    }
}
