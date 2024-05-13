using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Brush : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show Brush Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw Brush");
        }
    }
}
