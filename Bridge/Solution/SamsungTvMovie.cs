using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Solution
{
    public class SamsungTvMovie:SamsungTV
    {
        public void Pause()
        {
            Console.WriteLine("SamsungTV Pause the Movie");
        }

        public void Play()
        {
            Console.WriteLine("SamsungTV Play the Movie");
        }

        public void Rewind()
        {
            Console.WriteLine("SamsungTV Rewind the Movie");
        }
    }
}
