using BasketApp.Extensions;
using BasketApp.Models;

namespace BasketApp
{
    public class BasketServices : IBasketService
    {
        private Basket _basket;

        public BasketServices(Basket basket)
        {
            _basket = basket;
        }

        public decimal GetBasketTotal()
        {
            decimal outcome = 0.0M;
            if (_basket != null)
            {
                outcome = _basket.ApplyButterDiscount() + _basket.ApplyMilkOffer();
            }

            return outcome;
        } 

    }
}
