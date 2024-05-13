using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Solution
{
    public class Circle : IComponent
    {
        public double Raduis { get; set; }

        public IComponent Clone()
        {
            Circle clonedCircle = new ();
            clonedCircle.Raduis = Raduis;
            Console.WriteLine("Cloned circle with raduis: " + Raduis);
            return clonedCircle;
        }

        public void Render()
        {
            Console.WriteLine("Circle Rendering..."); ;
        }
    }
}
