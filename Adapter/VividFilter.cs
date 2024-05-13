using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying vivid filter"); ;
        }
    }
}
