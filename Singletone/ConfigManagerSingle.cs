using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class ConfigManagerSingle
    {
        readonly Dictionary<string, string> _settings = [];
        private static readonly ConfigManagerSingle _instance = new(); //because we are inside this class we can use the new keyword. must be static

        //we added just these three line of codes to convert the class to be singletone
        private ConfigManagerSingle() {} //to disable any consumer from creating new insance from this class we made it private
        public static ConfigManagerSingle GetInstance { get => _instance; } // static to call it without creating new instance, and it reurn the same instance everytime

        public void Set(string key, string value)
        {
            _settings.Add(key, value);
        }

        public object Get(string key)
        {
            if (_settings.TryGetValue(key, out string value))
            {
                return value;
            }
            else
                return null;
        }

        
    }
}
