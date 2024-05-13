using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Solution.Sharp
{
    public class SharpController : Controller
    {
        //return another viewEngine
        protected override IMatchaViewEngine CreateViewEngine() => new SharpViewEngine();
    }
}
