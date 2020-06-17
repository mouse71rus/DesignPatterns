using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Composite
{
    public abstract class MenuComponent
    {
        public virtual string GetName()
        {
            throw new NotSupportedException();
        }
        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }
        public virtual double GetPrice()
        {
            throw new NotSupportedException();
        }
        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual void Add(MenuComponent component)
        {
            throw new NotSupportedException();
        }
        public virtual void Remove(MenuComponent component)
        {
            throw new NotSupportedException();
        }
        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        public abstract IIterator<MenuComponent> CreateIterator();
    }
}
