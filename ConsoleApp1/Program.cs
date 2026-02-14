// Arrays. 
var names = new string[] {"Scott", "John", "Jane"};

//names.Add("Marry"); // this is how we add to a list, but not to an array.

names = [..names, "Marry"]; //this is how you add to an array. We create a new array with the existing elements and add the new element at the end. and we assign the reference of the new array to the original variable.


foreach( var name in names)
{
    Console.WriteLine(name);
}