using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    //note all methods in the interface should be public when you implement it.
    public interface ITool
    {
        void MouseUp();
        void MouseDown();
    }
}
