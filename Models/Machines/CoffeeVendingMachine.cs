using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class CoffeeVendingMachine : IVendingMachine<Coffee>
    {
        public List<Coffee> currentStock { get; set; } = new List<Coffee> ();
        public List<Coffee> soldItems { get; set; } = new List<Coffee> ();

        public void AddProduct (Coffee coffee)
        {
            currentStock.Add(coffee);
        }
        public void SellProduct (Coffee coffee)
        {
            currentStock.Remove(coffee);
        }
    }
}