using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Solution
{
    //This class to enure that there is an icon for a given type in memory and return it if there is not it will add create a new one and adds it to
    //the dictionary.
    //it is some kind of cache, this is how to prepare cache or pool of object to reuse
    public class PointIconFactory //resposible of purely creating a pointIcon object, we rely on this factory to not create multible instance of the
                                  //same object in memory
    {
        private Dictionary<PointType, PointIcon> icons = [];

        public PointIcon GetPointIcon (PointType type)
        {
            // key       -> value
            // PointType -> PointIcon
            if(!icons.ContainsKey(type)) //no icon in memory for the given type
            { 
                var icon = new PointIcon(type,null);
                icons.Add(type, icon);
            }
            return icons[type];
        }
    }
}
