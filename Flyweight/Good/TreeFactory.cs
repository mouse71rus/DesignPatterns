using System.Collections.Generic;
using System.Linq;

namespace Flyweight.Good
{
    public class TreeFactory
    {
        private static List<TreeType> TreeTypes = new List<TreeType>();

        public static TreeType GetTreeType(string name, Color color, string data)
        {
            var treeType = TreeTypes.FirstOrDefault(t => t.Name.Equals(name) && t.Color == color);
            if (treeType == default)
            {
                treeType = new TreeType(name, color, data);
                TreeTypes.Add(treeType);
            }
            return treeType;
        }
    }
}
