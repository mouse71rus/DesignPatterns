using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7.Adapter
{
    public interface IEnumeration
    {
        bool HasMoreElements();
        object NextElements();
    }
}
