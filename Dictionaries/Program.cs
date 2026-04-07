using System.Data;

namespace Dictionaries
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = [];

            employees.Add(100, new Employee(name: "Ahmad", age: 18, salary: 12000));

            foreach (KeyValuePair<int, Employee> employee in employees)
            {
                Console.WriteLine(employee.Value.Name);
            }
        }
    }

    internal class Employee
    {
        public string? Name { get; set; }
        public int Age { get; private set; }
        public int Salary { get; set; }

        // if you throw an exception mid object creation, object is not being created, thus it is good practice to check before assigning values.
        public Employee(string name, int age, int salary)
        {
            if (age < 18)
                throw new ArgumentException("You are underage!");
            Name = name;
            Salary = salary;
        }
    }
}
