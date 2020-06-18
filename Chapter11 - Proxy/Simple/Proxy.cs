namespace Chapter11.Simple
{
    public class Proxy : ISubject
    {
        private RealSubject realSubject;
        public void Request()
        {
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}