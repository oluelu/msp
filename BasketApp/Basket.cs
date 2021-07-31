using System;
using System.Collections.Generic;
using System.Text;

namespace BasketApp
{

    public class Basket : IBasket
    {
        public List<LineItems> Line { get; set; }
    }

    public interface IBasket
    {
        List<LineItems> Line { get; set; }
    }

    public class LineItems
    {
        public int Id { get; set; }
        public Product Name { get; set; }
        public int Units { get; set; }
    }

} 