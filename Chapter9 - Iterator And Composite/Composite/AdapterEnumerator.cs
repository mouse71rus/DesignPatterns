using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Composite
{
    public class AdapterEnumerator : IIterator<MenuComponent>
    {
        private List<MenuComponent>.Enumerator iterator;

        public AdapterEnumerator(List<MenuComponent>.Enumerator iterator)
        {
            this.iterator = iterator;
        }

        public bool HasNext()
        {
            return iterator.MoveNext();
        }
        
        public MenuComponent Next()
        {
            return iterator.Current;
        }
    }
}