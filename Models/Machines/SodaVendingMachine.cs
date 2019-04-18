using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class SodaVendingMachine : IVendingMachine<Soda>
    {
        public List<Soda> products { get; set; } = new List<Soda> ();

        public void AddProduct (Soda soda)
        {
            products.Add(soda);
        }
        public void SellProduct (Soda soda)
        {
            products.Add(soda);
        }
    }
}