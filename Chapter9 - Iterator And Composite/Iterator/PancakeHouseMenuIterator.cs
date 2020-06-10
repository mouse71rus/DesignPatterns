using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Iterator
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private List<MenuItem> items;
        private int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            if (position >= items.Count())
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
