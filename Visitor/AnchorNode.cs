using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class AnchorNode : IHTMLNode
    {
        //Extensibility point becasue you can extend the list of operations and this execute method will not change(you program against an interface
        //IOperation)
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
