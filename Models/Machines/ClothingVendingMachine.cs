using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class ClothingVendingMachine : IVendingMachine<Clothing>
    {
        public List<Clothing> products { get; set; } = new List<Clothing> ();

        public void AddProduct (Clothing clothing)
        {
            products.Add(clothing);
        }
        public void SellProduct (Clothing clothing)
        {
            products.Add(clothing);
        }
    }
}