using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Solution
{
    public class PointIcon(PointType type, byte[] icon)
    {
        private readonly PointType _type = type;  //4byte
        private readonly byte[] _icon = icon;     //20 KB >> if we have thousand points we have 20MB which will hang the devices

        public PointType Type => _type;
    }
}
