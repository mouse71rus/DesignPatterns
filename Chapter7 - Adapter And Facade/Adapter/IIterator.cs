using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7.Adapter
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
        void remove(object el);
    }
}
