using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class PreparedFoodVendingMachine : IVendingMachine<PreparedFood>
    {
        public List<PreparedFood> products { get; set; } = new List<PreparedFood> ();

        public void AddProduct (PreparedFood preparedFood)
        {
            products.Add(preparedFood);
        }
        public void SellProduct (PreparedFood preparedFood)
        {
            products.Add(preparedFood);
        }
    }
}