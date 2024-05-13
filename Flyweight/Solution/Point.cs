using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Solution
{
    //instead of creating a new point object each time we want to share its type and icon props across all points on he memory
    public class Point(int x, int y, PointIcon pointIcon)
    {
        private int x = x, y = y;             
        private PointIcon icon = pointIcon; //with this structure we can store each icon in a single place and refrenced in multiple points   

        public void Draw()
        {
            Console.WriteLine($"{icon.Type} at {(x,y)}");
        }
    }
}
