using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Chapter10 - State");
            Console.WriteLine();

            Bad.GumballMachine gumballMachine = new Bad.GumballMachine(5);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter(); 
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter(); 
            gumballMachine.EjectQuarter(); 
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
            
            gumballMachine.InsertQuarter(); 
            gumballMachine.TurnCrank(); 
            gumballMachine.InsertQuarter(); 
            gumballMachine.TurnCrank(); 
            gumballMachine.EjectQuarter();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter(); 
            gumballMachine.InsertQuarter(); 
            gumballMachine.TurnCrank(); 
            gumballMachine.InsertQuarter(); 
            gumballMachine.TurnCrank(); 
            gumballMachine.InsertQuarter(); 
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            Console.ReadKey();
        }
    }
}
