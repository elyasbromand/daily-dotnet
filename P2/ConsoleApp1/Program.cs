// needs to be either "true" or "false"
string myBoolString = "TRUE";

bool myBool = Convert.ToBoolean(myBoolString);

Console.Write(myBool);

int num1 = 5;

int num2 = int.Parse(Console.ReadLine() ?? "0");

System.Console.WriteLine("Addition num1 and num2 is " + num1 * num2);

if (true && true)
{
    System.Console.WriteLine("And is working");
}

//XOR is true if one of the values is true but not both
if (true ^ false)
{
    System.Console.WriteLine("Xor Working");
}