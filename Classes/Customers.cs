namespace Classes
{
    internal class Customers
    {
        public string? Name { get; set; }
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
        }
    }
}
