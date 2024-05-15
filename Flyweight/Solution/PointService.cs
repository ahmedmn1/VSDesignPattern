using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Solution
{
    public class PointService(PointIconFactory iconFactory)
    {
        private PointIconFactory _iconFactory = iconFactory;

        public List<Point> GetPoints()
        {
            List<Point> points = new();
            
            var point = new Point(2, 2, _iconFactory.GetPointIcon(PointType.Restaurant)); //IconFactory will create a new PointIcon object and add it to its dictionary
            points.Add(point);
            var point2 = new Point(1, 3, _iconFactory.GetPointIcon(PointType.Restaurant)); //IconFactory returns existed PointIcon object from its dictionary
            points.Add(point2);
            
            return points;
        }
    }
}
