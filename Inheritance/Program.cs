namespace PRACTICE.Inheritance
{
    public class Program { }

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
        public Employee(string? name, int age)
            : base(name, age) { }
    }
}
