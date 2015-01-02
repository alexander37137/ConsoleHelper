using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTools.Commands;
using ConsoleTools.Ioc;

namespace ConsoleTools
{
    public class ConsoleHelper
    {
        public static void RegisterCommand<T>() where T : IConsoleCommand
        {
            OF.Register<IConsoleCommand, T>();
        }

        public static void ProcessCommand(string[] args)
        {
             CommandProcessor.ProcessStartArguments(args);
        }
    }
}
