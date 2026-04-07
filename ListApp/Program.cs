namespace ListApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> productsList =
            [
                new Product { Name = "A", Price = 1000 },
                new Product { Name = "B", Price = 2000 },
                new Product { Name = "C", Price = 3000 },
            ];

            // the Where method will return a IEnumerable which we then cast it to a list since we are storing it in a list of type Product

            List<Product> cheapProduct = productsList
                .Where(product => product.Price <= 2000)
                .ToList();

            // You can also do it the modern way:
            /*
            List<Product> cheapProduct = [..productsList
                .Where(product => product.Price <= 2000)
                .ToList(); ]
            */
            int? x = 1234;

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
                foreach (Product product in productsList)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("X is not specified");
            }
        }
    }
}
