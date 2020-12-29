using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Good
{
    public class TreeType
    {
        public TreeType(string name, Color color, string data)
        {
            Name = name;
            Color = color;
            Data = data;
        }

        public string Name { get; set; }
        public string Data { get; set; }
        public Color Color { get; set; }
        public void Draw(double x, double y)
        {
            Console.WriteLine($"{Color} {Name} ({x}, {y})");
        }
    }
}
