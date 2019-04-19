using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class EnergyDrinkVendingMachine : IVendingMachine<EnergyDrink>
    {
        public List<EnergyDrink> currentStock { get; set; } = new List<EnergyDrink> ();
        public List<EnergyDrink> soldItems { get; set; } = new List<EnergyDrink> ();

        public void AddProduct (EnergyDrink energyDrink)
        {
            currentStock.Add(energyDrink);
        }
        public void SellProduct (EnergyDrink energyDrink)
        {
            currentStock.Remove(energyDrink);
        }
    }
}