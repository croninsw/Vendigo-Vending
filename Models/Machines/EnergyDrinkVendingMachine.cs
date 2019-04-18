using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class EnergyDrinkVendingMachine : IVendingMachine<EnergyDrink>
    {
        public List<EnergyDrink> products { get; set; } = new List<EnergyDrink> ();

        public void AddProduct (EnergyDrink energyDrink)
        {
            products.Add(energyDrink);
        }
        public void SellProduct (EnergyDrink energyDrink)
        {
            products.Add(energyDrink);
        }
    }
}