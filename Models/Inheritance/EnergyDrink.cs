using System;

namespace Vendigo
{
    public class EnergyDrink : IProduct<EnergyDrink>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}