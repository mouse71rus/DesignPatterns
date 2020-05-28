using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2.Bad
{
    public interface IDisplay
    {
        void Update(int temperature, int humidity, int pressure);
    }
}
