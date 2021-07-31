using System;

namespace BasketApp
{
    public class Product
    {
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
