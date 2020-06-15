namespace Chapter10.Good
{
    internal class NoQuarterState : IState
    {
        private GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            System.Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("You haven’t inserted a quarter");
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("You inserted a quarter");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("You turned, but there’s no quarter");
        }
    }
}