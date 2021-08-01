using BasketApp.Models;
using System;

namespace BasketApp.Extensions
{
    public static class Deals
    { 
        // Returns cost of Bread & Butter
        public static decimal ApplyButterDiscount(this IBasket basket)
        {
            decimal discount = 0.5M;
            if (basket.ItemCount() == 0) return 0.00M;

            int butterCount = 0;
            int breadCount= 0;
            int dealCount = 0;

            decimal subTotal_Butter = 0;
            decimal subTotal_Bread = 0; 

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

            subTotal_Butter = butterCount * config.PRICE_PER_UNIT_BUTTER;

            dealCount = butterCount / 2;
            if (dealCount > 0)
            {
                if (breadCount >= dealCount)
                {
                    subTotal_Bread = (dealCount * discount * config.PRICE_PER_UNIT_BREAD) + ((breadCount - dealCount) * config.PRICE_PER_UNIT_BREAD);
                }
                else
                {
                    subTotal_Bread = dealCount * discount * config.PRICE_PER_UNIT_BREAD;
                }
            }
            else
            {
                subTotal_Bread = breadCount * config.PRICE_PER_UNIT_BREAD; 
            }
            return subTotal_Bread + subTotal_Butter;
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
            var totalPrice = Math.Floor((decimal)(milkCount / 4)) * 3* config.PRICE_PER_UNIT_MILK + Math.Floor((decimal)(milkCount % 4)) * config.PRICE_PER_UNIT_MILK;
            return totalPrice;
        }

        public static decimal GetSumTotal(this IBasket basket)
        {
            if (basket.ItemCount() == 0) return 0.00M;

            return basket.ApplyButterDiscount() + basket.ApplyMilkOffer();
        }
    }
}
