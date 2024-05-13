using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.HTMLEditor
{
    public class History
    {
        private readonly IList<IUndoableCommand> _commands = new List<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            _commands.Add(command);
        }

        public IUndoableCommand Pop()
        {
            var lastIndex = _commands.Count - 1;
            var lastCommand = _commands[lastIndex];
            _commands.RemoveAt(lastIndex);
            return lastCommand;
        }

        public int Size()
        {
            return _commands.Count;
        }

    }
}
