using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public interface IFilter
    {
        void Apply(string fileName);
    }
}