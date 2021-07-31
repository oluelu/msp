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
    }

    public interface IBasket
    {
        List<LineItem> LineItems { get; set; }
    }

    public class LineItem
    {
        public LineItem(Product productName, int unit)
        {
            this.ProductName = productName;
            this.Unit = unit;
        }
        public Product ProductName { get; set; }
        public int Unit { get; set; }
    }

} 