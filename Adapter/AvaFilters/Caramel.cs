using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.AvaFilters
{
    public class Caramel
    {
        //suppose it is required call before using this class
        public void Init()
        {

        }

        public void Render(Image image) => Console.WriteLine("Applying Caramel Filter");
    }
}
