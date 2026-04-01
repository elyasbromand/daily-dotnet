namespace Classes
{
    internal class Customers
    {
        // You cam make a property static as well if you want it to be at class level not at object level
        public static string? Name { get; set; } = "Taher";
        public string? Email { get; set; }
        public string? Phone { get; set; }

        // Custom constructor
        public Customers(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        // We can have multiple constructors in a class by using method overloading
        public Customers(string name)
        {
            Name = name;
        }

        // Default constructor
        public Customers()
        {
            Name = "Unknown";
            Email = "Unknown";
            Phone = "Unknown";
            // this is equavilent to this.ShowME(); thus it works, eventhough I havent' called the ShowME method with an object in program.cs file
            ShowME();
        }

        public static void DisplayName()
        {
            Console.WriteLine($"Name is {Name}");
        }

        //finalizer
        ~Customers()
        {
            Console.WriteLine("Destructor called");
        }

        // non-static methods have access to this keyword
        public void DisplayME()
        {
            Console.WriteLine("Display ME HEHE");
            // Same here it is also equavilent to this.ShowME(). and this keyword refers to the current instance of the class
            ShowME();
        }

        public void ShowME()
        {
            Console.Write("Show Me HEHE");
        }
    }
}
