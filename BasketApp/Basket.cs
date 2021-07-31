using System;
using System.Collections.Generic;
using System.Text;

namespace BasketApp
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

    public interface IBasket
    {
        List<LineItem> LineItems { get; set; }
        int ItemCount();
    }

    public class LineItem
    {
        public LineItem(Product productName, int unit)
        {
            this.Item = productName;
            //assumes no negative items
            this.Unit = unit >= 0 ? unit : 0;
        }
        public Product Item { get; set; }
        public int Unit { get; set; }
    }

} 