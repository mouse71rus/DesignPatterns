using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private List<MenuItem> menuItems;
        private string title;

        public PancakeHouseMenu()
        {
            title = "PancakeHouse Menu";
            menuItems = new List<MenuItem>();

            AddItem("K&B's Pancake Breakfast", "Pancake with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancake with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        

        public void AddItem(string Name, string Description, bool Vegetarian, double Price)
        {
            menuItems.Add(new MenuItem(Name, Description, Vegetarian, Price));
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
