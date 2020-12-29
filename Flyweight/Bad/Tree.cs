using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Bad
{
    public class Tree
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Data { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public void Draw()
        {
            Console.WriteLine($"{Color} {Name} ({X}, {Y})");
        }
    }
}
