using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comosite
{
    public class Group:IComponent
    {
        private readonly IList<IComponent> _components = [];

        public void Add(IComponent _component)
        {
            _components.Add(_component);
        }

        public void Render()
        {
            //this is ugly as if we have another method for resize we have to repeat the same if decsions code
            //foreach (object obj in _components)
            //{
            //    if (obj is Group)
            //    {
            //        ((Group) obj).Render();
            //    }
            //    else if (obj is Shape)
            //    {
            //        ((Shape)obj).Render();
            //    }
            //}

            //this is more beutiful using the composite pattern, nested loop is going to executed
            foreach (IComponent component in _components)
            {
                component.Render();
            }
        }

        public void Resize()
        {
            foreach (IComponent component in _components)
            {
                component.Resize();
            }
        }
    }
}
