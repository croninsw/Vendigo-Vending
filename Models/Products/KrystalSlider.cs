using System;
using System.Collections.Generic;

namespace Vendigo
{
    public class KrystalSlider : PreparedFood , IAmerican<PreparedFood>
    {
        public string Ingredients { get; set; }

        public bool Recyclable { get; set; }

    }
}