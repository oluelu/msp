

using System;
using System.Collections.Generic;

namespace BasketApp.Extensions
{
    public static class Deals
    {
        public static decimal PRICE_PER_UNIT_BUTTER = 0.80M;
        public static decimal PRICE_PER_UNIT_BREAD = 1.00M;

        public static decimal ApplyButterDiscount(this IBasket basket)
        { 
            if(basket.ItemCount() == 0) return 0.00M;

            int butterCount = 0;
            int breadCount= 0;
            int dealCount = 0;

            decimal pucButter = 0;
            decimal pucBread = 0; 

            basket.LineItems.ForEach(product => {
                if (product.Item.Name == "Butter")
                {
                    butterCount += product.Unit;
                }

                if (product.Item.Name == "Bread")
                {
                    breadCount += product.Unit;
                }
            });

            pucButter = butterCount * PRICE_PER_UNIT_BUTTER;

            //pair of butter
            dealCount = butterCount / 2;
            if (dealCount > 0)
            {
                if (breadCount >= dealCount)
                {
                    pucBread = (dealCount * 0.5M * PRICE_PER_UNIT_BREAD) + ((breadCount - dealCount) * PRICE_PER_UNIT_BREAD);
                }
                else
                {
                    pucBread = dealCount * 0.5M * PRICE_PER_UNIT_BREAD;
                }
            }
            else
            {
                pucBread = breadCount * PRICE_PER_UNIT_BREAD; 
            }
            return pucBread + pucButter;

            ////how many butter
            //List<LineItem> butter = basket.LineItems.FindAll(x => x.Item.Name == "Butter");
            //if (butter.Count > 0)
            //{
            //    butter.ForEach(item => {
            //        butterCount += item.Unit;
            //    });

            //    dealCount = butterCount / 2;
            //}

            //var breadCount = basket.LineItems.FindAll(x => x.Item.Name == "Bread").Count;
        }
        public static decimal ApplyMilkOffer(this IBasket basket)
        {
            if (basket.ItemCount() == 0) return 0.00M;

            return 0.00M;
        }

        public static decimal ApplySumTotal(this IBasket basket)
        {
            if (basket.ItemCount() == 0) return 0.00M;

            return 0.00M;
        }
    }
}
