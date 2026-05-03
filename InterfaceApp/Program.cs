namespace InterfaceApp;

public interface IAnimal
{
    public int MyProperty { get; set; }
    void MakeSound();
}

public class Dog : IAnimal
{
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
