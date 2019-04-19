using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class SundryVendingMachine : IVendingMachine<Sundry>
    {
        public List<Sundry> currentStock { get; set; } = new List<Sundry>();
        public List<Sundry> soldItems { get; set; } = new List<Sundry>();


        public void AddProduct(Sundry sundry)
        {
            currentStock.Add(sundry);
        }
        public void SellProduct(Sundry sundry)
        {
            currentStock.Remove(sundry);
        }
    }
}