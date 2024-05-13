using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class PointService
    {
        //if this method render alot of point hat hault the memory how can we imporve it?
        public List<Point> GetPoints()
        {
            List<Point> points = new();
            var point = new Point(2, 2, PointType.Restaurant, null);
            points.Add(point);
            return points;
        }
    }
}
