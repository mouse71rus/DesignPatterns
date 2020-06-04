using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5.Good
{
    public class ChocolateBoiler
    {
        private bool Empty;
        private bool Boiled;

        private static ChocolateBoiler Instance;

        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            return Instance ?? new ChocolateBoiler();
        }

        public void Fiil()
        {
            if (IsEmpty())
            {
                // Заполнение нагревателя молочно-шоколадной смесью
                Empty = false;
                Boiled = false;
            }
        }

        public bool IsEmpty()
        {
            return Empty;
        }

        public bool IsBoiled()
        {
            return Boiled;
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // Слить нагретое молоко и шоколад
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // Слить нагретое молоко и шоколад
                Boiled = true;
            }
        }
    }
}
