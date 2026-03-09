Console.WriteLine("Hello, OOP!");
// new way of creating class and object
var p1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));

p1.Pets.Add(new Cat("Fluffy"));

Console.WriteLine($"Name: {p1.First} {p1.Last}, Birth Date: {p1.Bd}, Pets: {p1.Pets[0].First}");


public class Person (string firstName, string lastName, DateOnly birthDate)
{
    public string First { get; } = firstName;
    public string Last { get;  } = lastName;
    public DateOnly Bd { get; } = birthDate;

    public List<Pet> Pets { get; } = [];
}


public abstract class Pet (string firstname)
{
    public string First { get; } = firstname;

    public abstract string MakeSound();

}

// send the f to the base class constructor to become as First in the pet class.
public class Cat(string f) : Pet (f)
{
    public override string MakeSound() => "Meow";

}

public class Dog(string f) : Pet(f)
{
    public override string MakeSound() => "Woof";

}
