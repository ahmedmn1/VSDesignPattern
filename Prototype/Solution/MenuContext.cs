using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Solution
{
    //applying OCP in action, is that beuitiful!!!    
    public class MenuContext
    {
        public void Duplicate (IComponent component)
        {
            IComponent clonedComponent = component.Clone ();
            //add to our slide        
        }
    }
}
