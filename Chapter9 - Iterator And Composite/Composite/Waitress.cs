using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Composite
{
    public class Waitress
    {
        private MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            Composite.IIterator<Composite.MenuComponent> iterator = allMenus.CreateIterator();

            Console.WriteLine("VEGETARIAN MENU");
            Console.WriteLine();

            while (iterator.HasNext())
            {
                MenuComponent component = iterator.Next();
                try
                {
                    if (component.IsVegetarian())
                    {
                        component.Print();
                    }
                }
                catch (System.NotSupportedException) { }
            }
        }
    }
}
