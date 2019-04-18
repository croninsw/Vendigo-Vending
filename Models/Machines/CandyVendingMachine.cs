using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class CandyVendingMachine : IVendingMachine<Candy>
    {
        public List<Candy> products { get; set; } = new List<Candy> ();

        public void AddProduct (Candy candy)
        {
            products.Add(candy);
        }
        public void SellProduct (Candy candy)
        {
            products.Add(candy);
        }
    }
}