using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class ClothingVendingMachine : IVendingMachine<Clothing>
    {
        public List<Clothing> currentStock { get; set; } = new List<Clothing> ();
        public List<Clothing> soldItems { get; set; } = new List<Clothing> ();

        public void AddProduct (Clothing clothing)
        {
            currentStock.Add(clothing);
        }
        public void SellProduct (Clothing clothing)
        {
            currentStock.Remove(clothing);
        }
    }
}