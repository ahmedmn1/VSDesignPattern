using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class ConfigManager
    {
        Dictionary<string, string> settings = new();

        public void Set(string key, string value)
        {
            settings.Add(key, value);
        }

        public object Get(string key)
        {
            if (settings.ContainsKey(key))
            {
                return settings[key];
            }
            else
                return null;
        }

        
    }
}
