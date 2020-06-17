namespace Chapter12.Observer
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}