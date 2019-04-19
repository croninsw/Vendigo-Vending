using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class PreparedFoodVendingMachine : IVendingMachine<PreparedFood>
    {
        public List<PreparedFood> currentStock { get; set; } = new List<PreparedFood> ();
        public List<PreparedFood> soldItems { get; set; } = new List<PreparedFood> ();

        public void AddProduct (PreparedFood preparedFood)
        {
            currentStock.Add(preparedFood);
        }
        public void SellProduct (PreparedFood preparedFood)
        {
            currentStock.Remove(preparedFood);
        }
    }
}