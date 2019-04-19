using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class Coke : Soda , IAmerican<Soda>
    {
        public string Ingredients { get; set; }

        public bool Recyclable { get; set; }

    }
}