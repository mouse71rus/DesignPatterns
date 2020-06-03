﻿using System;
using System.Collections.Generic;

namespace Chapter4.Good
{
    public abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;

        protected List<string> Toppings = new List<string>();

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (var item in Toppings)
            {
                Console.WriteLine("\t" + item);
            }
        }

        public string GetName()
        {
            return Name;
        }
    }
}