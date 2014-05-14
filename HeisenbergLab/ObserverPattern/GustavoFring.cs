namespace HeisenbergLab.ObserverPattern
{
    public class GustavoFring : IObserver
    {
        private readonly float money;

        public GustavoFring()
        {
            money = 10000000;
        }

        public bool OfferReceived { get; private set; }

        public void SendOffer(float quantity, float price)
        {
            OfferReceived = true;

            AssessOffer(quantity, price);
        }

        private void AssessOffer(float quantity, float price)
        {
            if (quantity * price <= money)
            {
                // Buy
            }
        }
    }
}
