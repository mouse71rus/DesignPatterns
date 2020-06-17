namespace Chapter10.Good
{
    internal class SoldState : IState
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall(); 
            if (gumballMachine.GetCount() > 0) 
            { 
                gumballMachine.SetState(gumballMachine.GetNoQuarterState()); 
            } 
            else 
            {
                System.Console.WriteLine("Oops, out of gumballs!"); 
                gumballMachine.SetState(gumballMachine.GetSoldOutState()); 
            }
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("Please wait, we’re already giving you a gumball");
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }
    }
}