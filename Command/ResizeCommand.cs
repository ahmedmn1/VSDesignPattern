using Command.FX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resizeing the image");
        }
    }
}
