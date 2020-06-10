using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Iterator
{
    public class Waitress
    {
        private PancakeHouseMenu pancakeHouseMenu;
        private DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("--------------");
            Console.WriteLine("BREAKFAST");
            Console.WriteLine();


            IIterator menu = pancakeHouseMenu.CreateIterator();
            PrintMenu(menu);

            Console.WriteLine();
            Console.WriteLine("LUNCH");
            Console.WriteLine();

            IIterator menu2 = dinerMenu.CreateIterator();
            PrintMenu(menu2);            
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
