using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter7.Adapter
{
    public class EnumerationIterator : IIterator
    {
        private IEnumeration enumeration;

        public EnumerationIterator(IEnumeration enumeration)
        {
            this.enumeration = enumeration;
        }

        public bool HasNext()
        {
            return enumeration.HasMoreElements();
        }

        public object Next()
        {
            return enumeration.NextElements();
        }

        public void remove(object el)
        {
            throw new NotSupportedException();
        }
    }
}
