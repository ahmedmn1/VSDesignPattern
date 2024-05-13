using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ImageView(Image image)
    {
        private readonly Image _image = image;

        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}
