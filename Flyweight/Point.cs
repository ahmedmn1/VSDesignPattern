using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    //instead of creating a new point object each time we want to share its type and icon props across all points on he memory
    //the proposed flyWeight objet
    public class Point(int x, int y, PointType type, byte[] icon)
    {
        private int x = x, y = y;       //byte
        private PointType type = type;  //4byte
        private byte[] icon = icon;     //20 KB >> if we have thousand points we have 20MB which will hang the devices

        public void Draw()
        {
            Console.WriteLine($"{type} at {(x,y)}");
        }
    }
}
