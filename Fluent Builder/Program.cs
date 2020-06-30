using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Bad.User Sergey = new Bad.User("Sergey", "BNG", 21, false);
            var Serg = Good.User.CreateBuilder().SetName("Sergey").SetCompany("BNG").SetAge(21).IsMarried.Build();
            var Sasha = new Good.UserBuilder().SetName("Sasha").SetCompany("BNG").SetAge(20).Build();

            var Dima = Good.User.CreateBuilder().SetName("Dima").SetCompany("BNG").SetAge(31).IsMarried;
        }
    }
}
