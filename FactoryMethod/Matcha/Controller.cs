using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Matcha
{
    //base class for all of our controllers
    // this class takes the actions of the user like click, and return a view
    // problem 1, this controller is tightly coupled to matchaview engine.suppose we need it to support other view engine.
    // we can solve it by make an interface but produces problem2
    public class Controller
    {
        // problem 1, this controller is tightly coupled to matchaview engine.suppose we need it to support other view engine.
        // we can solve it by make an interface
        //public string Render(string viewName, Dictionary<string, object> context)
        //{
        //    var engine = new MatchaViewEngine();
        //    var html = matchaViewEngine.Render(viewName, context);
        //    return "html";
        //}

        //problem2 it makes it harder to the users of our framework as they need to add the viewEngine param on every controller when we call render
        //methdod we have to pass the view engine.. how to solve this probelm using the factory pattern
        public string Render(string viewName, Dictionary<string, object> context, IMatchaViewEngine matchaViewEngine)
        {
            var html = matchaViewEngine.Render(viewName, context);
            return html;
        }

    }
}
