namespace PRACTICE.Inheritance
{
    public class Program
    {
        public static void Main()
        {
            Employee joe = new("Joe", 21, 1, "Employee");

            Console.WriteLine("Name: " + joe.Name);
        }
    }

    public class Person
    {
        public string? Name { get; private set; }
        public int Age { get; private set; }

        public Person(string? name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; private set; }

        public string Position { get; private set; }

        public Employee(string? name, int age, int employeeId, string position)
            : base($"EMP-{name}", age)
        {
            EmployeeId = employeeId;
            Position = position;
        }
    }
}
