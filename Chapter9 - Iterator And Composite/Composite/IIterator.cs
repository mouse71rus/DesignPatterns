using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Composite
{
    public interface IIterator<out T>
    {
        bool HasNext();
        T Next();
    }
}