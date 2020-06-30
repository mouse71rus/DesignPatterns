using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Builder.Bad
{
    public class User
    {
        public string Name { get; set; }        // имя
        public string Company { get; set; }     // компания
        public int Age { get; set; }            // возраст
        public bool IsMarried { get; set; }      // женат/замужем

        public User(string name, string company, int age, bool isMarried) // Params are many. Very many.
        {
            Name = name;
            Company = company;
            Age = (age > 0) ? age : 18;
            IsMarried = isMarried;
        }
    }
}