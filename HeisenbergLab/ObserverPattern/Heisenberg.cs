using System.Collections.Generic;

namespace HeisenbergLab.ObserverPattern
{
    public class Heisenberg : ISubject
    {
        private readonly IList<IObserver> buyers;
        private float quantity;
        private float price;

        public Heisenberg()
        {
            buyers = new List<IObserver>();
            quantity = 0;
            price = 0;
        }

        public void Cook()
        {
            quantity = 100;
            price = 1000;

            CookCompleted();
        }

        private void CookCompleted()
        {
            Notify();
        }

        public void Attach(IObserver buyer)
        {
            buyers.Add(buyer);
        }

        public void Detach(IObserver buyer)
        {
            if(buyers.Contains(buyer))
            {
                buyers.Remove(buyer);
            }
        }

        public void Notify()
        {
            foreach(var buyer in buyers)
            {
                buyer.SendOffer(quantity, price);
            }
        }
    }
}
