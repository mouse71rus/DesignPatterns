namespace Chapter2.Good
{
    public interface IObserver
    {
        void Update(int temperature, int humidity, int pressure);
    }
}