Console.WriteLine("Hello, OOP!");
// new way of creating class and object
var p1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));

Console.WriteLine($"Name: {p1.First} {p1.Last}, Birth Date: {p1.Bd}");

Cat catie = new Cat("Catie");
Console.WriteLine($"{catie.First} says {catie.MakeSound()}");

public class Person (string firstName, string lastName, DateOnly birthDate)
{
    public string First { get; } = firstName;
    public string Last { get;  } = lastName;
    public DateOnly Bd { get; } = birthDate;
}


public abstract class Pet (string firstname)
{
    public string First { get; } = firstname;

    public abstract string MakeSound();

}


public class Cat(string f) : Pet (f)
{
    public override string MakeSound() => "Meow";
}


