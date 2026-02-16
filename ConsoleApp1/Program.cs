Console.WriteLine("Hello, OOP!");
// old way of creating a class and object
var p1 = new Person()
{
    firstName = "John",
    lastName = "Doe",
    birthDate = new DateOnly(1990, 1, 1)
};

public class Person
{
    public string firstName;

    public string lastName;
    
    public DateOnly birthDate;
}