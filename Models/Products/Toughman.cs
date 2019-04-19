using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class Toughman : EnergyDrink , IJapanese<EnergyDrink>
    {
        public string Colors { get; set; }

        public string RfIdFrequency { get; set; }

        public void RfIdBroadcast() {
            Console.WriteLine($"The chip is broadcasting at {RfIdFrequency}");
        }

    }
}