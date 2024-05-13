using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Solution
{
    public class PointService
    {
        private PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            List<Point> points = new();
            var point = new Point(2, 2, _iconFactory.GetPointIcon(PointType.Restaurant));
            points.Add(point);
            return points;
        }
    }
}
