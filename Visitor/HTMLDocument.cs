using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class HTMLDocument
    {
        private readonly List<IHTMLNode> _nodes = [];


        public void AddNode(IHTMLNode node)
        {
            _nodes.Add(node);
        }

        //extensibility point
        public void Execute(IOperation operation)
        {
            foreach (IHTMLNode node in _nodes) 
            {
                node.Execute(operation);
            }
        }

    }
}
