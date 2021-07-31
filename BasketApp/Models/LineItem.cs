using System;
using System.Collections.Generic;
using System.Text;

namespace BasketApp.Models
{
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
