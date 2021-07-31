using BasketApp.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketApp
{
   public class Services : IService
    {
        private Basket _basket;

        public Services(Basket basket)
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
