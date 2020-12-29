namespace Flyweight.Good
{
    public class Tree
    {
        public Tree(double x, double y, string name, Color color, string data)
        {
            X = x;
            Y = y;
            Type = TreeFactory.GetTreeType(name, color, data);
        }

        public double X { get; set; }
        public double Y { get; set; }
        public TreeType Type { get; set; }

        public void Draw()
        {
            Type.Draw(X, Y);
        }
    }
}
