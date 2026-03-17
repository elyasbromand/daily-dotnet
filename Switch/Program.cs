string monthName;

int month = int.Parse(Console.ReadLine());

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
};