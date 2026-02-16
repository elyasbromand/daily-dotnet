// Specify the data source.
List<int> scores = [97, 92, 81, 60];

// Define the query expression. it is deffered execution, it is not executed until the foreach statement is executed.
// LINQ returns an IEnumerable<T> and it is foreachable.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

scores.Add(99); // this will also be included in the query because the query is not executed until the foreach statement is executed.

// Execute the query. Now the LINQ is executed. 
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81