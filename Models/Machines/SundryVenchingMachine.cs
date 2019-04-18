using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class SundryVendingMachine : IVendingMachine<Sundry>
    {
        public List<Sundry> products { get; set; } = new List<Sundry> ();

        public void AddProduct (Sundry sundry)
        {
            products.Add(sundry);
        }
        public void SellProduct (Sundry sundry)
        {
            products.Add(sundry);
        }
    }
}