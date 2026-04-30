using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance;

public class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.Sound();
    }
}

public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void Sound()
    {
        base.Sound();
    }
}
