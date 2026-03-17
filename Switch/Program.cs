string monthName;

// The exclamation mark is used to indicate that the value will not be null, so it tells the compiler to ignore any potential null reference warnings.
int month = int.Parse(Console.ReadLine()!);

//New switch expression syntax
monthName = month switch
{
    1 => "January",
    2 => "February",
    _ => "Invalid month",
};

//Old switch statement syntax
switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    default:
        monthName = "Invalid month";
        break;
}
;




Console.WriteLine(monthName);

System.Console.WriteLine("Hello, decimals");

System.Console.WriteLine(10.0f % 3.0f);