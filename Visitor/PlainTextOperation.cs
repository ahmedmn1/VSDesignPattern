using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeaderNode header)
        {
            Console.WriteLine("Header Plain Text"); ;
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Anchor Plain Text"); ;
        }
    }
}
