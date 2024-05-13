using Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class BlackAndWhiteCommnad : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Converting Image to Black and White"); 
        }
    }
}
