﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface IIterator<T>
    {
        void Next();
        T Current();
        bool HasNext();
    }
}
