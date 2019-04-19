using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class Shoes : Clothing , ISpanish<Clothing>
    {
        public int LvlSpicy { get; set; }

        public bool Organic { get; set; }

    }
}