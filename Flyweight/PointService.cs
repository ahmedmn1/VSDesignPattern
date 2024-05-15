using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class PointService
    {
        //if this method renders alot of points it will hault the memory due each point will contains a picture icon
        //if this GetPoints returns alot of points this will hault the memory. 
        //how can we imporve it? how we can reduce the amount of memory the app uses?
        public List<Point> GetPoints()
        {
            List<Point> points = new();
            var point = new Point(2, 2, PointType.Restaurant, null);
            points.Add(point);
            var point2 = new Point(2, 2, PointType.Hospital, null);
            points.Add(point2);
            var point3 = new Point(2, 2, PointType.Restaurant, null);
            points.Add(point3);


            return points;
        }
    }
}
