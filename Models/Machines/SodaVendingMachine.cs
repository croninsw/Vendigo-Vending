using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class SodaVendingMachine : IVendingMachine<Soda>
    {
        public List<Soda> currentStock { get; set; } = new List<Soda> ();

        public List<Soda> soldItems { get; set; } = new List<Soda> ();

        public void AddProduct (Soda soda)
        {
            currentStock.Add(soda);
        }
        public void SellProduct (Soda soda)
        {
            currentStock.Remove(soda);
        }
    }
}