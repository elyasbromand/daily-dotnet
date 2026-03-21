System.Console.WriteLine("Rocket Launcher project");

string rocket = "/\\\n||\n||\n||\n/\\";

for (int i = 0; i < 5; i++)
{
    Console.Clear();
    Console.WriteLine(rocket);
    rocket = "\n" + rocket;
    Thread.Sleep(1000);
}

System.Console.WriteLine("-----------------------------\n rocket landed successfully!");
