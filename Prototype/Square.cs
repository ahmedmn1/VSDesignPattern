using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Square : IComponent
    {
        public double Side { get; set; }
        public void Render()
        {
            Console.WriteLine("Square Rendering..."); ;
        }
    }
}
