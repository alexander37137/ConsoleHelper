ConsoleHelper
=============

This is a simple library for handling execution arguments in console applications.

To start using it install package from nuget

```
Install-Package Console.Helper 
```

Then define some commands and register them

Command class should implement interface IConsoleCommand and have Command attribute with command key word 

```csharp
    [Command("hello")]
    class HelloCommand : IConsoleCommand
    {
        public void Execute(CommandArgs args)
        {
            Console.WriteLine("Hello World!");
        }
    }
```

After you register your commands you can ask ConsoleHelper to process input arguments

```csharp
class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.RegisterCommand<HelloCommand>();

            ConsoleHelper.ProcessCommand(args);
        }
    }
```

Library will find required command and execute it. 

```
C:\ConsoleHelper\TestProject\bin\Debug>TestProject.exe Hello
Hello World!
```

