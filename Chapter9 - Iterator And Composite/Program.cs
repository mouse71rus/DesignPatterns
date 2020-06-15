using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter9 - Iterator And Composite");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Iterator");
            Console.WriteLine();

            var menus = new List<Iterator.IMenu>();
            menus.Add(new Iterator.PancakeHouseMenu());
            menus.Add(new Iterator.DinerMenu());

            Iterator.Waitress waitress = new Iterator.Waitress(menus);
            waitress.PrintMenu();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Composite");
            Console.WriteLine();

            Composite.MenuComponent allMenus = new Composite.Menu("ALL MENU", "All menus combined");

            Composite.MenuComponent pancakeHouseMenu = new Composite.Menu("PANCAKE HOUSE MENU", "Breakfast");
            Composite.MenuComponent DinerMenu = new Composite.Menu("DINER MENU", "Lunch");
            Composite.MenuComponent DessertMenu = new Composite.Menu("DESSERT MENU", "Dessert of course");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(DinerMenu);

            DinerMenu.Add(new Composite.MenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));
            DinerMenu.Add(new Composite.MenuItem("BLT",
                "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            DinerMenu.Add(new Composite.MenuItem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 3.29));
            DinerMenu.Add(new Composite.MenuItem("Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false, 3.05));


            pancakeHouseMenu.Add(new Composite.MenuItem("K&B's Pancake Breakfast", "Pancake with scrambled eggs, and toast", true, 2.99));
            pancakeHouseMenu.Add(new Composite.MenuItem("Regular Pancake Breakfast", "Pancake with fried eggs, sausage", false, 2.99));
            pancakeHouseMenu.Add(new Composite.MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            pancakeHouseMenu.Add(new Composite.MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59));

            DinerMenu.Add(DessertMenu);

            DessertMenu.Add(new Composite.MenuItem("Apple pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59));

            Composite.Waitress waitress_new = new Composite.Waitress(allMenus);

            waitress_new.PrintMenu();

            Console.ReadKey();
        }
    }
}
