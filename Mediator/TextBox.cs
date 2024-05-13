using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class TextBox (DialogBox _dialogBox) :UIControl(_dialogBox)
    {
        private string _content;        

        public string Content
        {
            get =>  _content;
            set 
            {
                _content = value; 
                base._dialogBox.Changed(this);
            }
        }

    }
}
