double x = 21.43; //Natural type
float y = 12.12; //This needs conversion, since it cannot convert float to double implicitly
long z = checked(x + y);
Console.Write(z);