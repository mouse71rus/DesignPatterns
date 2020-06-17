using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter10.Bad
{
    public class GumballMachine
    {
        private enum State
        {
            SOLD_OUT,
            NO_QUARTER,
            HAS_QUARTER,
            SOLD
        }

        private State state = State.SOLD_OUT;

        public int Count;

        public GumballMachine(int count)
        {
            this.Count = count;
            if (this.Count > 0)
            {
                state = State.NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            if (state == State.HAS_QUARTER)
            {
                Console.WriteLine("You can't insert another quarter");
            }
            else if (state == State.NO_QUARTER)
            {
                state = State.HAS_QUARTER;
                Console.WriteLine("You inserted a quarter");
            }
            else if (state == State.SOLD_OUT) 
            {
                Console.WriteLine("You can’t insert a quarter, the machine is sold out");
            } 
            else if (state == State.SOLD) 
            {
                Console.WriteLine("Please wait, we’re already giving you a gumball"); 
            }
        }

        public void EjectQuarter() 
        { 
            if (state == State.HAS_QUARTER) 
            {
                Console.WriteLine("Quarter returned"); 
                state = State.NO_QUARTER; 
            } 
            else if (state == State.NO_QUARTER) 
            {
                Console.WriteLine("You haven’t inserted a quarter"); 
            } 
            else if (state == State.SOLD) 
            {
                Console.WriteLine("Sorry, you already turned the crank"); 
            } 
            else if (state == State.SOLD_OUT) 
            {
                Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet"); 
            } 
        }


        public void TurnCrank() 
        { 
            if (state == State.SOLD) 
            {
                Console.WriteLine("Turning twice doesn’t get you another gumball!"); 
            } 
            else if (state == State.NO_QUARTER) 
            {
                Console.WriteLine("You turned but there’s no quarter"); 
            } 
            else if (state == State.SOLD_OUT) 
            {
                Console.WriteLine("You turned, but there are no gumballs"); 
            } 
            else if (state == State.HAS_QUARTER) 
            {
                Console.WriteLine("You turned..."); 
                state = State.SOLD; 
                Dispense(); 
            } 
        }

        private void Dispense()
        {
            if (state == State.SOLD) 
            {
                Console.WriteLine("A gumball comes rolling out the slot"); 
                Count--; 
                if (Count == 0) 
                {
                    Console.WriteLine("Oops, out of gumballs!"); 
                    state = State.SOLD_OUT; 
                } 
                else 
                { 
                    state = State.NO_QUARTER;
                } 
            } 
            else if (state == State.NO_QUARTER) 
            {
                Console.WriteLine("You need to pay first"); 
            } 
            else if (state == State.SOLD_OUT) 
            {
                Console.WriteLine("No gumball dispensed"); 
            } 
            else if (state == State.HAS_QUARTER) 
            {
                Console.WriteLine("No gumball dispensed"); 
            }
        }

        public override string ToString()
        {
            return "State: " + state.ToString();
        }
    }
}
