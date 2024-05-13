using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Solution
{
    public interface IComponent //this is the prototype required to implemwnt the prototype pattern
    {
        void Render();
        IComponent Clone();
    }
}
