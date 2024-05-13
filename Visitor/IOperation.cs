using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IOperation
    {
        void Apply(HeaderNode header);
        void Apply(AnchorNode anchor);
    }
}
