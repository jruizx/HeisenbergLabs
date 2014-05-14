namespace HeisenbergLab.ObserverPattern
{
    public interface ISubject
    {
        void Attach(IObserver buyer);
        void Detach(IObserver buyer);
        void Notify();
    }
}
