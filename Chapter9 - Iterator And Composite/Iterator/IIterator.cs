﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
