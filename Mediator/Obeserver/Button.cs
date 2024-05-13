using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer
{
    public class Button: UIControl
    {
        private bool _isEnables;

        public bool IsEnabled
        {
            get { return _isEnables; }
            set 
            { 
                _isEnables = value;
                NotifyEventHandlers();
            }
        }

    }
}
