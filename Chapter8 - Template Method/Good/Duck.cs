using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8.Good
{
    public class Duck : IComparable
    {
        public string Name;
        public int Weight;

        public Duck(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public int CompareTo(object obj)
        {
            Duck duck = obj as Duck;
            if(this.Weight > duck.Weight)
            {
                return 1;
            }
            else if (this.Weight < duck.Weight)
            {
                return -1;
            }
            else
            { // this.Weight == duck.Weight
                return 0;
            }
        }
    }
}
