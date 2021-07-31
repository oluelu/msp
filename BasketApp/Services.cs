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

        void ApplyDeals()
        {
            _basket.ApplyButterDiscount();
            _basket.ApplyMilkOffer();
        }

        public decimal GetBasketTotal()
        {
            return 0.00M;
        } 

    }
}
