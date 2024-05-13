using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comosite
{
    //select common behaviour betwen the objects(group and shape) in the hirarechy (render and resize)  
    public interface IComponent
    {
        void Render();
        void Resize();

    }
}
