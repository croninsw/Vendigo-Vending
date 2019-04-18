using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class CoffeeVendingMachine : IVendingMachine<Coffee>
    {
        public List<Coffee> products { get; set; } = new List<Coffee> ();

        public void AddProduct (Coffee coffee)
        {
            products.Add(coffee);
        }
        public void SellProduct (Coffee coffee)
        {
            products.Add(coffee);
        }
    }
}