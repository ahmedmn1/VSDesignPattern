using Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CompositeCommand
    {
        private readonly List<ICommand> _commands = [];

        public void Push(ICommand command)
        {
            _commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }



    }
}
