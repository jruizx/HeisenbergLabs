namespace HeisenbergLab.NoObserverPattern
{
    public class Heisenberg
    {
        private readonly TucoSalamanca buyer;
        private float quantity;
        private float price;

        public Heisenberg(TucoSalamanca buyer)
        {
            this.buyer = buyer;
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
            if(buyer != null)
                buyer.SendOffer(quantity, price);
        }
    }
}
