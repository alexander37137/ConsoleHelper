using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTools;
using TestProject.Commands;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.RegisterCommand<HelloCommand>();

            ConsoleHelper.ProcessCommand(args);
        }
    }
}
