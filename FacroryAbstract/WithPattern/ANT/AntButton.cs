﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacroryAbstract.WithPattern.ANT
{
    public class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Material Button");
        }
    }
}
