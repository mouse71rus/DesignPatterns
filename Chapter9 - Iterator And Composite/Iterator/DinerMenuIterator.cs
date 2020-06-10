using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Iterator
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
                return false;
            else
            {
                return true;
            }
        }

        //public MenuItem Next()
        public object Next()
        {
            MenuItem item = items[position];
            position++;
            return item;
        }
    }
}
