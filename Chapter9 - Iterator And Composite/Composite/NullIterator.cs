using System.Collections;
using System.Collections.Generic;

namespace Chapter9.Composite
{
    public class NullIterator : IIterator<MenuComponent>
    {
        public bool HasNext()
        {
            return false;
        }

        public MenuComponent Next()
        {
            return null;
        }
    }
}