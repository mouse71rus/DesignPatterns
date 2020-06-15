namespace Chapter10.Good
{
    internal class HasQuarterState : IState
    {
        private GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
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
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }
    }
}