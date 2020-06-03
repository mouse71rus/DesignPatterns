using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4.Bad
{
    public interface IPizza
    {
        void prepare();
        void bake();
        void cut();
        void box();
    }
}
