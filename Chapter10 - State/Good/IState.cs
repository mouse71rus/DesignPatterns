namespace Chapter10.Good
{
    public interface IState
    {
        void EjectQuarter();
        void InsertQuarter();
        void TurnCrank();
        void Dispense();
    }
}