using System.Collections.Generic;

namespace BasketApp.Models
{

    public class Basket : IBasket
    {
        public Basket(List<LineItem> items)
        {
            this.LineItems = items; 
        }
        public List<LineItem> LineItems { get; set; }

        public int ItemCount()
        {
            return this.LineItems.Count;
        }
    }
} 