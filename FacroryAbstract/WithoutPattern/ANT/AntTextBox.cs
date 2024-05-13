using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacroryAbstract.WithoutPattern.ANT
{
    public class AntTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render Material Text Box");
        }
    }
}
