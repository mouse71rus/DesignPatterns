namespace Chapter10.Good
{
    public class SoldOutState : IState
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            System.Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            System.Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet");
        }

        public void InsertQuarter()
        {
            System.Console.WriteLine("You can’t insert a quarter, the machine is sold out");
        }

        public void TurnCrank()
        {
            System.Console.WriteLine("You turned, but there are no gumballs");
        }
    }
}