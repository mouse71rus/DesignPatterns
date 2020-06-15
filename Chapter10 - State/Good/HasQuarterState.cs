using System;

namespace Chapter10.Good
{
    internal class HasQuarterState : IState
    {
        private GumballMachine gumballMachine;
        private Random randomWinner;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
            randomWinner = new Random();
        }

        public void Dispense()
        {
            System.Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("You can’t insert another quarter");
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if (winner == 0 && gumballMachine.GetCount() > 1)
            {
                gumballMachine.SetState(gumballMachine.GetWinnerState());
            }
            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }
        }
    }
}