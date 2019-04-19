using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class SpanishCoffee : Coffee , ISpanish<Coffee>
    {
        public int LvlSpicy { get; set; }

        public bool Organic { get; set; }

    }
}