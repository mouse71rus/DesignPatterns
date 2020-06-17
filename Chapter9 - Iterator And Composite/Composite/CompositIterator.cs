using System.Collections;
using System.Collections.Generic;

namespace Chapter9.Composite
{
    internal class CompositIterator : IIterator<MenuComponent>
    {
        private Stack<IIterator<MenuComponent>> stack;

        public CompositIterator(IIterator<MenuComponent> iterator)
        {
            stack = new Stack<IIterator<MenuComponent>>();
            stack.Push(iterator);
        }

        public bool HasNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                IIterator<MenuComponent> iterator = stack.Peek();
                if (!iterator.HasNext())
                {
                    stack.Pop();
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public MenuComponent Next()
        {
            if (HasNext())
            {
                IIterator<MenuComponent> iterator = stack.Peek();
                MenuComponent component = iterator.Next();

                stack.Push(component.CreateIterator());

                return component;
            }
            else
            {
                return null;
            }
        }
    }
}