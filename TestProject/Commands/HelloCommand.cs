using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTools.Attributes;
using ConsoleTools.Commands;

namespace TestProject.Commands
{
    [Command("hello")]
    class HelloCommand : IConsoleCommand
    {
        public void Execute(CommandArgs args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
