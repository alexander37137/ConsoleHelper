using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTools.Attributes;
using ConsoleTools.Ioc;

namespace ConsoleTools.Commands
{
    static class CommandProcessor
    {
        public static void ProcessStartArguments(string[] args)
        {
            var arguments = new CommandArgs(args);
            var commandName = arguments[0];

            var commands = OF.GetAll<IConsoleCommand>();
            foreach (var consoleCommand in commands)
            {
                var attr = (CommandAttribute)Attribute.GetCustomAttribute(consoleCommand.GetType(), typeof(CommandAttribute));
                if (attr.Command.Equals(commandName, StringComparison.InvariantCultureIgnoreCase))
                {
                    consoleCommand.Execute(arguments);
                    return;
                }
            }
            Console.WriteLine("Command not found");
        }
    }
}
