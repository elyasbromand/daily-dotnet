Program myProgram = new();

// The following line will cause a compile-time error because the Run method is inside Main method, not in the Program class.
// myProgram.Run();

int Run()
{
    System.Console.WriteLine("asdf");
    return 0;
}
