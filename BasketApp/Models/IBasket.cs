using System;
using System.Collections.Generic;
using System.Text;

namespace BasketApp.Models
{
    public interface IBasket
    {
        List<LineItem> LineItems { get; set; }
        int ItemCount();
    }
}
