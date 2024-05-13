using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IHTMLNode
    {
        //public void HighLight ();
        ////public void PlainText();
        ///
        void Execute(IOperation operation);
    }
}
