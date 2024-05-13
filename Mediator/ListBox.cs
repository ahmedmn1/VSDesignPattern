using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ListBox(DialogBox _dialogBox): UIControl (_dialogBox)
    {
        private string _selection;        

        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                base._dialogBox.Changed(this);
            }
        }
    }
}
