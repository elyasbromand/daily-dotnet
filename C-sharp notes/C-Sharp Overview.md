
1. [[#C-sharp Code with no Main method?]]
2. [[#Building and running C programs]]
3. 


#### C-sharp Code with no Main method?

will run but - compiler will create a program class and a main method itself for it.

## Building and running C# programs

C# is a _compiled_ language. In most C# programs, you use the [`dotnet build`](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-build) command to compile a group of source files into a binary package. Then, you use the [`dotnet run`](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-run) command to run the program. (You can simplify this process because `dotnet run` compiles the program before running it if necessary.) These tools support a rich language of configuration options and command-line switches. The `dotnet` command line interface (CLI), which is included in the .NET SDK, provides many [tools](https://learn.microsoft.com/en-us/dotnet/core/tools/) to generate and modify C# files.

Beginning with C# 14 and .NET 10, you can create _file-based apps_, which simplifies building and running C# programs. You use the `dotnet run` command to run a program contained in a single `*.cs` file. For example, if the following snippet is stored in a file named `hello-world.cs`, you can run it by typing `dotnet run hello-world.cs`:

C#

```
#!/usr/bin/env dotnet
Console.WriteLine("Hello, World!");
```

The first line of the program contains the `#!` sequence for Unix shells. The location of the `dotnet` CLI can vary on different distributions. On any Unix system, if you set the _execute_ (`+x`) permission on a C# file, you can run the C# file from the command line:

Bash

```
./hello-world.cs
```

The source for these programs must be a single file, but otherwise all C# syntax is valid. You can use file-based apps for small command-line utilities, prototypes, or other experiments. file-based apps allow [preprocessor directives](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives#file-based-apps) that configure the build system.

