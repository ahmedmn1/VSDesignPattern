// real example, we need to store out application config in a class and use it on all places
// we need just one single copy of this class


using Singletone;


//without pattern
ConfigManager configManager = new ();
configManager.Set("name", "Mohmed Nabil");
Console.WriteLine(configManager.Get("name"));

ConfigManager configManager2 = new();
Console.WriteLine(configManager2.Get("name")); //RETURN NULL, we need it to rerurn Mohamed Nabil too!

Console.WriteLine("*********** With Pattern ************");
ConfigManagerSingle configManagerSingle = ConfigManagerSingle.GetInstance;
configManagerSingle.Set("name", "Mohmed Nabil");
Console.WriteLine(configManagerSingle.Get("name"));

ConfigManagerSingle configManagerSingle2 = ConfigManagerSingle.GetInstance;
Console.WriteLine(configManagerSingle2.Get("name")); //return the same result as it refere to the same instnace



