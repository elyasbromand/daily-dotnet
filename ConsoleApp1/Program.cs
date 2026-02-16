// Specify the data source.
List<int> scores = [97, 92, 81, 60, 100, 99, 95, 88];

// you can use string interpolation inside LINQ and have a type string from a list of int.
IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score ascending
    select $"Score is {score}";

// Execute the query. Now the LINQ is executed. 
foreach (var i in scoreQuery)
{
    Console.WriteLine(i);
}

// Output: 97 92 81