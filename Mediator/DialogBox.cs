using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    //this class is abstract and not an interfac as it might provide common behaviors for dailog boxes
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }
}
