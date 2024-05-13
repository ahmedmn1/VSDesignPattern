using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Button(DialogBox _dialogBox) : UIControl(_dialogBox)
    {
        private bool _isEnables;

        public bool IsEnabled
        {
            get { return _isEnables; }
            set 
            { 
                _isEnables = value;
                base._dialogBox.Changed(this);   
            }
        }

    }
}
