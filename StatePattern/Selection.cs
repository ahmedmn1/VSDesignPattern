using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Selection : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show Selection Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw Selection Rectangle");
        }
    }
}
