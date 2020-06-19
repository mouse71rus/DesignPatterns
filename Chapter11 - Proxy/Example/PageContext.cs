using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11.Example
{
    public class PageContext
    {
        public List<Page> Pages;

        public PageContext()
        {
            Pages = new List<Page>();

            Pages.Add(new Page { Number = 1, Text = "Page 1" });
            Pages.Add(new Page { Number = 2, Text = "Page 2" });
            Pages.Add(new Page { Number = 3, Text = "Page 3" });
            Pages.Add(new Page { Number = 4, Text = "Page 4" });
            Pages.Add(new Page { Number = 5, Text = "Page 5" });
        }
    }
}
