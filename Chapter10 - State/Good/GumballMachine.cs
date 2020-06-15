using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter10.Good
{
    public class GumballMachine
    {
        private IState SOLD_OUT; // Шариков нет
        private IState NO_QUARTER; // Нет монетки
        private IState HAS_QUARTER; // Есть монетка
        private IState SOLD; // Шарик продан
        private IState WINNER; // Выиграл дополнительный шарик



        private IState state;
        private int Count;

        public int GetCount()
        {
            return Count;
        }

        public void Refiil(int count)
        {
            this.Count += count;
            state = NO_QUARTER;
        }

        public GumballMachine(int count)
        {
            SOLD_OUT = new SoldOutState(this);
            NO_QUARTER = new NoQuarterState(this);
            HAS_QUARTER = new HasQuarterState(this);
            SOLD = new SoldState(this);
            WINNER = new WinnerState(this);

            this.Count = count;
            if (this.Count > 0)
            {
                state = NO_QUARTER;
            }
            else
            {
                state = SOLD_OUT;
            }
        }
        public IState GetWinnerState()
        {
            return WINNER;
        }
        public IState GetSoldOutState()
        {
            return SOLD_OUT;
        }

        public IState GetNoQuarterState()
        {
            return NO_QUARTER;
        }

        public IState GetSoldState()
        {
            return SOLD;
        }

        public IState GetHasQuarterState()
        {
            return HAS_QUARTER;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }
        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }
        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void ReleaseBall() 
        {
            Console.WriteLine("A gumball comes rolling out the slot..."); 
            if (state == SOLD && Count != 0) 
            {
                Count--; 
            } 
        }
    }
}
