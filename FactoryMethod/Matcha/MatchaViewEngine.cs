using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Matcha
{
    public class MatchaViewEngine : IMatchaViewEngine
    {
        //takes view name and the data that we are gonna pass to the view (products in this case)
        public string Render(string viewName, Dictionary<string, object> context)
        {
            //implmetation of parsing the view or the template
            return "View rendered by Matcha";
        }
    }
}
