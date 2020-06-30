using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Builder.Good
{
    public class User
    {
        public string Name { get; set; }        // имя
        public string Company { get; set; }     // компания
        public int Age { get; set; }            // возраст
        public bool IsMarried { get; set; }      // женат/замужем

        public static UserBuilder CreateBuilder()
        {
            return new UserBuilder();
        }
    }
}
