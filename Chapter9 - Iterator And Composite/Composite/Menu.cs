using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter9.Composite
{
    public class Menu : MenuComponent
    {
        private string Name;
        private string Description;
        private List<MenuComponent> menuComponents;

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;

            menuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent component)
        {
            menuComponents.Add(component);
        }
        public override void Remove(MenuComponent component)
        {
            menuComponents.Remove(component);
        }
        public override MenuComponent GetChild(int index)
        {
            return menuComponents[index];
        }


        public override string GetDescription()
        {
            return Description;
        }

        public override string GetName()
        {
            return Name;
        }

        

        public override void Print()
        {
            Console.WriteLine();
            Console.Write(Name);
            Console.WriteLine(", " + Description);
            Console.WriteLine("---------------");

            var enumerator = menuComponents.GetEnumerator();
            while(enumerator.MoveNext())
            {
                MenuComponent component = enumerator.Current;
                component.Print();
            }
        }
    }
}
