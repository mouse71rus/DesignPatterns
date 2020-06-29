using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chapter5.Good
{
    public class ChocolateBoiler
    {
        private bool Empty;
        private bool Boiled;

        private static volatile ChocolateBoiler Instance;
        private static object syncRoot = new Object();
        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (Instance == null)
            {
                lock (syncRoot)
                {
                    if (Instance == null)
                    {
                        Instance = new ChocolateBoiler();
                        Console.WriteLine($"Thread {Thread.CurrentThread.Name} was created Instance this class");
                        return Instance;
                    }
                }
            }
            
            Console.WriteLine($"Thread {Thread.CurrentThread.Name} got Instance this class");
            return Instance;
            
            //return Instance ?? (Instance = new ChocolateBoiler());
        }

        public void GetStatus()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.Name}: Empty: {Empty}, Boiled: { Boiled}");
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
