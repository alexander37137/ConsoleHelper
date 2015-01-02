using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTools.Commands
{
    public interface IConsoleCommand
    {
        void Execute(CommandArgs args);
    }
}
