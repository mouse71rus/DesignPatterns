using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11.Example
{
    public class BookStore : IBook
    {
        private PageContext db;

        public BookStore()
        {
            this.db = new PageContext();
        }

        public Page GetPage(int number)
        {
           return db.Pages.FirstOrDefault((p) => p.Number == number);
        }
    }
}
