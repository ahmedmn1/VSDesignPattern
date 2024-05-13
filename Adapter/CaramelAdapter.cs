using Adapter.AvaFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    


    public class CaramelAdapter(Caramel caramel) : IFilter
    {
        private readonly Caramel _caramel = caramel;

        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }

    //we can also use inheritance instead of composition
    //public class CaramelAdapter(Caramel caramel) : Caramel, IFilter
    //{
    //    public void Apply(Image image)
    //    {
    //        Init();
    //        Render(image);
    //    }
    //}
}
