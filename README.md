ConsoleHelper
=============

This is a simple library for handling arguments in console applications.

To start using it you can install package from nuget

```
Install-Package Console.Helper 
```

Then you should define some commands and register it 

Command class should implement interface IConsoleCommand and have Command attribute which contains key word for command

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

After you register commands you can ask ConsoleHelper to process input args

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
