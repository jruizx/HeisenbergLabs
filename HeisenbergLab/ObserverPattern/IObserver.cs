namespace HeisenbergLab.ObserverPattern
{
    public interface IObserver
    {
        void SendOffer(float quantity, float price);
        bool OfferReceived { get; }
    }
}