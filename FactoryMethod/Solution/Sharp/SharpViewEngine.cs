using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Solution.Sharp
{
    public class SharpViewEngine : IMatchaViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View rendered by sharp engine";
        }
    }
}
