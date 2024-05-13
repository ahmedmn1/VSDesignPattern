using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying B&W Filter");
        }
    }
}