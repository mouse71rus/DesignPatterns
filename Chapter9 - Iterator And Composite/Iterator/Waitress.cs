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
            List<MenuItem> menu = pancakeHouseMenu.GetMenuItems();
            MenuItem[] menu2 = dinerMenu.GetMenuItems();

            for (int i = 0; i < menu.Count(); i++)
            {
                Console.WriteLine(menu[i].GetName());
                Console.WriteLine("\t\t" + menu[i].GetPrice());
                Console.WriteLine("\t" + menu[i].GetDescription());
            }

            for (int i = 0; i < menu2.Length; i++)
            {
                Console.WriteLine(menu2[i].GetName());
                Console.WriteLine("\t\t" + menu2[i].GetPrice());
                Console.WriteLine("\t" + menu2[i].GetDescription());
            }
        }
    }
}
