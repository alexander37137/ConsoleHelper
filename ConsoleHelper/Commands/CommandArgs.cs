using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTools.Commands
{
    public class CommandArgs
    {
        private readonly string[] _args;

        public CommandArgs(string[] args)
        {
            _args = args;
        }

        public string this[int i]
        {
            get
            {
                return _args.Length < i + 1 ? null : _args[i];
            }
        }
    }
}
