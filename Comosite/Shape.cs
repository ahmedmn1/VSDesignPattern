using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comosite
{
    public class Shape:IComponent
    {
        public void Render() => Console.WriteLine("Render Shape");
        public void Resize() => Console.WriteLine("Resize Shape");
        
    }
}
