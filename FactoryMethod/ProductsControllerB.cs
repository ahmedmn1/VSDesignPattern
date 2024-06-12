using FactoryMethod.Matcha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //suppose that a dev will use our framework to build a product page
    public class ProductsControllerB:FactoryMethod.Solution.Controller
    {
        public void ListProducts()
        {
            //get products from a DB
            //create a context object for passing the products to  our view 
            Dictionary<string, object> context = [];
            //imagine that we filled these dic by product context.add 
            //call render method from the base to return the html using matcha framework
            var htmlResult = Render(viewName:"products.html",context:context);
            Console.WriteLine(htmlResult);
           

        }

    }
}
