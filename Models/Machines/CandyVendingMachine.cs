using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class CandyVendingMachine : IVendingMachine<Candy>
    {
        public List<Candy> currentStock { get; set; } = new List<Candy> ();
        public List<Candy> soldItems { get; set; } = new List<Candy> ();

        public void AddProduct (Candy candy)
        {
            currentStock.Add(candy);
        }
        public void SellProduct (Candy candy)
        {
            currentStock.Remove(candy);
        }
    }
}