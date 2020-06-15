using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Iterator
{
    public class Waitress
    {
        private List<IMenu> menus;

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("--------------");
            Console.WriteLine();
            foreach (var item in menus)
            {
                Console.WriteLine("^^^^^^^^^^^");
                Console.WriteLine(item.GetTitle());
                Console.WriteLine("***********");
                Console.WriteLine();
                IIterator menu = item.CreateIterator();
                PrintMenu(menu);
                Console.WriteLine();
            }         
        }

        private void PrintMenu(IIterator iterator)
        {
            while(iterator.HasNext())
            {
                MenuItem item = (MenuItem)iterator.Next();
                Console.WriteLine(item.GetName());
                Console.WriteLine("\t\t" + item.GetPrice());
                Console.WriteLine("\t" + item.GetDescription());
            }
        }
    }
}
