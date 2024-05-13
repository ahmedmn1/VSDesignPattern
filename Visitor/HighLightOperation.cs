using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{

    //Note all the logic is on a single place
    public class HighLightOperation : IOperation
    {
        public void Apply(HeaderNode header)
        {
            Console.WriteLine("Header Highlight"); ;
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Anchor Highlight"); ;
        }
    }
}
