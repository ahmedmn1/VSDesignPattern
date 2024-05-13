using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Observer
{
    public class ListBox: UIControl
    {
        private string _selection;        

        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                NotifyEventHandlers();    
            }
        }        
    }
}
