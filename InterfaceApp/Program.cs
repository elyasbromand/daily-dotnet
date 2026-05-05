namespace InterfaceApp;

public interface IAnimal
{
    public int MyProperty { get; set; }
    void MakeSound()
    {
        Console.WriteLine(
            "In modern C# interfaces, you can have method implementations, but you can also have abstract methods that must be implemented by the class that implements the interface."
        );
    }

    // you can also have static members in interfaces, but the must have an implementation
    static int version = 1;
}

public class Dog : IAnimal
{
    public static int DogVersion => 222;
    public int MyProperty
    {
        get;
        set => throw new NotImplementedException();
    }

    public void MakeSound()
    {
        throw new WhyAreYouNotImplementingException("Stupid bitch, implement the method");
    }
}

public class Program
{
    public static void Main()
    {
        Dog d = new();
        try
        {
            Console.WriteLine(IAnimal.version);
            Console.WriteLine(Dog.DogVersion);
            d.MakeSound();
        }
        catch (WhyAreYouNotImplementingException)
        {
            Console.WriteLine(
                "gonna catch it, not letting the user see our humorous exception message"
            );
        }
    }
}
