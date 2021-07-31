

using System;
using System.Collections.Generic;

namespace BasketApp.Extensions
{
    public static class Deals
    { 
        // Returns cost of Bread & Butter
        public static decimal ApplyButterDiscount(this IBasket basket)
        { 
            if(basket.ItemCount() == 0) return 0.00M;

            int butterCount = 0;
            int breadCount= 0;
            int dealCount = 0;

            decimal pucButter = 0;
            decimal pucBread = 0; 

            basket.LineItems.ForEach(product => {
                if (product.Item.Name == config.BUTTER)
                {
                    butterCount += product.Unit;
                }

                if (product.Item.Name == config.BREAD)
                {
                    breadCount += product.Unit;
                }
            });

            pucButter = butterCount * config.PRICE_PER_UNIT_BUTTER;

            dealCount = butterCount / 2;
            if (dealCount > 0)
            {
                if (breadCount >= dealCount)
                {
                    pucBread = (dealCount * 0.5M * config.PRICE_PER_UNIT_BREAD) + ((breadCount - dealCount) * config.PRICE_PER_UNIT_BREAD);
                }
                else
                {
                    pucBread = dealCount * 0.5M * config.PRICE_PER_UNIT_BREAD;
                }
            }
            else
            {
                pucBread = breadCount * config.PRICE_PER_UNIT_BREAD; 
            }
            return pucBread + pucButter;
        }

        public static decimal ApplyMilkOffer(this IBasket basket)
        {
            if (basket.ItemCount() == 0) return 0.00M;

            int milkCount = 0;

            basket.LineItems.ForEach(product => {
                if (product.Item.Name == config.MILK)
                {
                    milkCount += product.Unit;
                } 
            });
            var totalPrice =  (milkCount / 3) * 2* config.PRICE_PER_UNIT_MILK + Math.Floor((decimal)(milkCount % 3)) * config.PRICE_PER_UNIT_MILK;
            return totalPrice;
        }

        public static decimal GetSumTotal(this IBasket basket)
        {
            if (basket.ItemCount() == 0) return 0.00M;

            return basket.ApplyButterDiscount() + basket.ApplyMilkOffer();
        }
    }
}
