string firstFriend = "   Scott";
string secondFriend = "Chris   ";

string Friend = $"My friends are {firstFriend.Trim()} and {secondFriend.Trim()}.";
//it changes all of the occurrences of friends to Buddies
Console.WriteLine(Friend.Replace("friends", "Buddies"));
// The original variable is not changed
Console.Write(Friend);

