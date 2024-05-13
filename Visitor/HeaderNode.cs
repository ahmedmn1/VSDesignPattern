using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class HeaderNode : IHTMLNode
    {
        //extensibility point
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
