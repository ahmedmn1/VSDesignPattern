using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Solution
{
    
    public class Controller
    {
        
        public string Render(string viewName, Dictionary<string, object> context)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, context);
            return html;
        }

        //This is the Factory method, if we made it abstract so the creation of the engine defer to the subclass which is sharp as and example
        //dont want to call it outside this class also enable other class to override it
        protected virtual IMatchaViewEngine CreateViewEngine()
        {
            return new FactoryMethod.Solution.MatchaViewEngine(); //provide default implemtation
        }


        //or you can make it abstract to foce other derived class to overide it, either way you defer the creation of the object to the subclass
        //protected abstract IMatchaViewEngine CreateViewEngine();



    }
}
