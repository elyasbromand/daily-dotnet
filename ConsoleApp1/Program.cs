Console.WriteLine("Hello, OOP!");
// new way of creating class and object
var p1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));

Console.WriteLine($"Name: {p1.First} {p1.Last}, Birth Date: {p1.Bd}");

public class Person (string firstName, string lastName, DateOnly birthDate)
{
    public string First { get; } = firstName;
    public string Last { get;  } = lastName;
    public DateOnly Bd { get; } = birthDate;
}