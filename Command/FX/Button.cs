using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.FX
{
    public class Button
    {
        private readonly ICommand _command;

        public Button(ICommand _command) 
        {
            this._command = _command;
        }

        public string Label { get; set; }

        public void Click()
        {
            // the code should be excuted here depend on where we will use this button
            _command.Execute();
        }
    }
}
