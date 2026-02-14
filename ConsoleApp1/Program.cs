//List<T> being prounouced as list of T, where T is the type of elements in the list. It is a generic collection that can hold any type of data. The list provides various methods to manipulate the data, such as adding, removing, and searching for elements. It is a dynamic array that can grow or shrink in size as needed. The list is part of the System.Collections.Generic namespace in C#.



List<string> names = ["Ahmad", "Jourdan"];

names.Add("Walid");
names.Remove("Ahmad");
names.Add("Ali");

foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.Write(names[0]);