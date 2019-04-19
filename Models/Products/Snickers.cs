using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class Snickers : Candy , IAmerican<Candy>
    {
        public string Ingredients { get; set; }

        public bool Recyclable { get; set; }

    }
}