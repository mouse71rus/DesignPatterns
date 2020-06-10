using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Iterator
{
    public class MenuItem
    {
        private string Name;
        private string Description;
        private bool Vegetarian;
        private double Price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }
        public double GetPrice()
        {
            return Price;
        }
        public bool IsVegetarian()
        {
            return Vegetarian;
        }
    }
}
