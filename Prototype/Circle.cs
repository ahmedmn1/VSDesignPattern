using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : IComponent
    {
        public double Raduis { get; set; }
        public void Render()
        {
            Console.WriteLine("Circle Rendering..."); ;
        }
    }
}
